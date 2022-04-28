namespace Tilia.SDK.OculusIntegration.Tracking.CameraRig
{
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Extension;
    using Zinnia.Tracking.CameraRig;

    public class OVRInputDetailsRecord : BaseDeviceDetailsRecord
    {
        [Tooltip("OVR Controller type.")]
        [SerializeField]
        private OVRInput.Controller controller;
        /// <summary>
        /// OVR Controller type.
        /// </summary>
        public OVRInput.Controller Controller
        {
            get
            {
                return controller;
            }
            set
            {
                controller = value;
            }
        }

        /// <inheritdoc/>
        public override XRNode XRNodeType { get => ConvertFromController(Controller); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override bool IsConnected { get => OVRInput.IsControllerConnected(Controller); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override int Priority { get => GetPriority(Controller); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override float BatteryLevel { get => OVRInput.GetControllerBatteryPercentRemaining(Controller) / 100f; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override BatteryStatus BatteryChargeStatus { get => BatteryStatus.Unknown; protected set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Sets the <see cref="Controller"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="OVRInput.Controller"/>.</param>
        public virtual void SetControllerType(int index)
        {
            Controller = EnumExtensions.GetByIndex<OVRInput.Controller>(index);
        }

        /// <summary>
        /// Converts an <see cref="OVRInput.Controller"/> type to a Unity <see cref="XRNode"/> type.
        /// </summary>
        /// <param name="controller">The controller type to convert.</param>
        /// <returns>The converted type.</returns>
        protected virtual XRNode ConvertFromController(OVRInput.Controller controller)
        {
            switch (controller)
            {
                case OVRInput.Controller.LHand:
                case OVRInput.Controller.LTouch:
                    return XRNode.LeftHand;
                case OVRInput.Controller.RHand:
                case OVRInput.Controller.RTouch:
                    return XRNode.RightHand;
                case OVRInput.Controller.Gamepad:
                    return XRNode.GameController;
                case OVRInput.Controller.Remote:
                    return OVRInput.GetDominantHand() == OVRInput.Handedness.LeftHanded ? XRNode.LeftHand : XRNode.RightHand;
            }

            return XRNode.TrackingReference;
        }

        /// <summary>
        /// Gets the priority of the current selected controller.
        /// </summary>
        /// <param name="controller">The controller to check.</param>
        /// <returns>The priority of the controller.</returns>
        protected virtual int GetPriority(OVRInput.Controller controller)
        {
            OVRInput.Handedness dominantHand = OVRInput.GetDominantHand();

            switch (controller)
            {
                case OVRInput.Controller.LHand:
                case OVRInput.Controller.LTouch:
                    return dominantHand == OVRInput.Handedness.LeftHanded ? 0 : 1;
                case OVRInput.Controller.RHand:
                case OVRInput.Controller.RTouch:
                    return dominantHand == OVRInput.Handedness.RightHanded ? 0 : 1;
            }

            return 2;
        }
    }
}