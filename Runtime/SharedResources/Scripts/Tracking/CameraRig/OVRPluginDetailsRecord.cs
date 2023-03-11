namespace Tilia.SDK.OculusIntegration.Tracking.CameraRig
{
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Tracking.CameraRig;

    public class OVRPluginDetailsRecord : BaseDeviceDetailsRecord
    {
        [Tooltip("The OVRPassthroughLayer component for controlling camera passthrough.")]
        [SerializeField]
        private OVRPassthroughLayer passthroughLayer;
        /// <summary>
        /// The <see cref="OVRPassthroughLayer"/> component for controlling camera passthrough.
        /// </summary>
        public OVRPassthroughLayer PassthroughLayer
        {
            get
            {
                return passthroughLayer;
            }
            set
            {
                passthroughLayer = value;
            }
        }
        [Tooltip("Whether The OVRPassthroughLayer component is hidden on enable. Does not raise events.")]
        [SerializeField]
        private bool passthroughLayerHiddenOnEnable;
        /// <summary>
        /// Whether the <see cref="OVRPassthroughLayer"/> component is hidden on enable. Does not raise events.
        /// </summary>
        public bool PassthroughLayerHiddenOnEnable
        {
            get
            {
                return passthroughLayerHiddenOnEnable;
            }
            set
            {
                passthroughLayerHiddenOnEnable = value;
            }
        }
        /// <inheritdoc/>
        public override XRNode XRNodeType { get => XRNode.Head; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override int Priority { get => 0; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override string Model { get => OVRPlugin.productName; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override float BatteryLevel { get => SystemInfo.batteryLevel; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override BatteryStatus BatteryChargeStatus { get => SystemInfo.batteryStatus; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override bool HasPassThroughCamera { get => passthroughLayer != null; protected set => throw new System.NotImplementedException(); }

        protected override void OnEnable()
        {
            passthroughLayer.hidden = PassthroughLayerHiddenOnEnable;
            base.OnEnable();
        }

        /// <inheritdoc/>
        protected override void EnablePassThrough()
        {
            passthroughLayer.hidden = false;
            base.EnablePassThrough();
        }

        /// <inheritdoc/>
        protected override void DisablePassThrough()
        {
            passthroughLayer.hidden = true;
            base.DisablePassThrough();
        }
    }
}