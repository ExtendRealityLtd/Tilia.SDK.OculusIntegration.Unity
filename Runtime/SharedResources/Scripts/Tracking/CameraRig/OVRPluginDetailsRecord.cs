namespace Tilia.SDK.OculusIntegration.Tracking.CameraRig
{
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Tracking.CameraRig;

    public class OVRPluginDetailsRecord : BaseDeviceDetailsRecord
    {
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
    }
}