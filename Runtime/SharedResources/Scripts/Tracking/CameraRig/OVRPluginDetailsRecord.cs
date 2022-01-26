namespace Tilia.SDK.OculusIntegration.Tracking.CameraRig
{
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Tracking.CameraRig;
    using Zinnia.Utility;

    public class OVRPluginDetailsRecord : DeviceDetailsRecord
    {
        /// <inheritdoc/>
        public override XRNode XRNodeType { get => XRNode.Head; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override bool IsConnected { get => XRDeviceProperties.IsTracked(XRNodeType); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override int Priority { get => 0; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override string Manufacturer { get => XRDeviceProperties.Manufacturer(XRNodeType); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override string Model { get => OVRPlugin.productName; protected set => throw new System.NotImplementedException(); }
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
        public override float BatteryLevel { get => SystemInfo.batteryLevel; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override BatteryStatus BatteryChargeStatus { get => SystemInfo.batteryStatus; protected set => throw new System.NotImplementedException(); }

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