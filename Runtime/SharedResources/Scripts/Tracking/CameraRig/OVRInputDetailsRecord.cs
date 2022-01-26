namespace Tilia.SDK.OculusIntegration.Tracking.CameraRig
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Extension;
    using Zinnia.Tracking.CameraRig;
    using Zinnia.Utility;

    public class OVRInputDetailsRecord : DeviceDetailsRecord
    {
        /// <summary>
        /// OVR Controller type.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public OVRInput.Controller Controller { get; set; }

        /// <inheritdoc/>
        public override XRNode XRNodeType { get => ConvertFromController(Controller); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override bool IsConnected { get => OVRInput.IsControllerConnected(Controller); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override int Priority { get => GetPriority(Controller); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override string Manufacturer { get => XRDeviceProperties.Manufacturer(XRNodeType); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override string Model { get => XRDeviceProperties.Model(XRNodeType); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override SpatialTrackingType TrackingType
        {
            get
            {
                if (XRDeviceProperties.HasPositionalTracking(XRNodeType) && XRDeviceProperties.HasRotationalTracking(XRNodeType))
                {
                    return SpatialTrackingType.RotationAndPosition;
                }
                else if (XRDeviceProperties.HasRotationalTracking(XRNodeType))
                {
                    return SpatialTrackingType.RotationOnly;
                }
                else
                {
                    return SpatialTrackingType.None;
                }
            }
            protected set => throw new System.NotImplementedException();
        }
        /// <inheritdoc/>
        public override float BatteryLevel { get => OVRInput.GetControllerBatteryPercentRemaining(Controller) / 100f; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override BatteryStatus BatteryChargeStatus { get => BatteryStatus.Unknown; protected set => throw new System.NotImplementedException(); }

        /// <summary>
        /// The last known battery charge status.
        /// </summary>
        protected BatteryStatus lastKnownBatteryStatus;
        /// <summary>
        /// The last known is connected status.
        /// </summary>
        protected bool lastKnownIsConnected;
        /// <summary>
        /// The last known tracking type.
        /// </summary>
        protected SpatialTrackingType lastKnownTrackingType;

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

        /// <inheritdoc/>
        protected override bool HasBatteryChargeStatusChanged()
        {
            bool hasChanged = BatteryChargeStatus != lastKnownBatteryStatus;
            if (hasChanged)
            {
                BatteryChargeStatusChanged?.Invoke(BatteryChargeStatus);
            }
            lastKnownBatteryStatus = BatteryChargeStatus;
            return hasChanged;
        }

        /// <inheritdoc/>
        protected override bool HasIsConnectedChanged()
        {
            bool hasChanged = IsConnected != lastKnownIsConnected;
            if (hasChanged)
            {
                ConnectionStatusChanged?.Invoke(IsConnected);
            }
            lastKnownIsConnected = IsConnected;
            return hasChanged;
        }

        /// <inheritdoc/>
        protected override bool HasTrackingTypeChanged()
        {
            bool hasChanged = TrackingType != lastKnownTrackingType;
            if (hasChanged)
            {
                TrackingTypeChanged?.Invoke(TrackingType);
            }
            lastKnownTrackingType = TrackingType;
            return hasChanged;
        }
    }
}