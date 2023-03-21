namespace Tilia.SDK.OculusIntegration.Tracking.CameraRig
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Tracking.CameraRig;

    public class OVRPluginDetailsRecord : BaseDeviceDetailsRecord
    {
        /// <summary>
        /// A setting for each Passthrough layer.
        /// </summary>
        [Serializable]
        public struct PassThroughSetting
        {
            [Tooltip("The OVRPassthroughLayer component for controlling camera passthrough.")]
            [SerializeField]
            private OVRPassthroughLayer passthroughLayer;
            /// <summary>
            /// The <see cref="OVRPassthroughLayer"/> component for controlling camera passthrough.
            /// </summary>
            public OVRPassthroughLayer PassthroughLayer
            {
                get => passthroughLayer;
                set => passthroughLayer = value;
            }
            [Tooltip("Whether the OVRPassthroughLayer component is hidden on enable. Does not raise events.")]
            [SerializeField]
            private bool passthroughLayerHiddenOnEnable;
            /// <summary>
            /// Whether the <see cref="OVRPassthroughLayer"/> component is hidden on enable. Does not raise events.
            /// </summary>
            public bool PassthroughLayerHiddenOnEnable
            {
                get => passthroughLayerHiddenOnEnable;
                set => passthroughLayerHiddenOnEnable = value;
            }
        }

        [Tooltip("The collection of OVRPassthroughLayer components for controlling camera passthrough.")]
        [SerializeField]
        private List<PassThroughSetting> passthroughLayerOptions = new List<PassThroughSetting>();
        /// <summary>
        /// The collection of <see cref="OVRPassthroughLayer"/> components for controlling camera passthrough.
        /// </summary>
        public List<PassThroughSetting> PassthroughLayerOptions
        {
            get
            {
                return passthroughLayerOptions;
            }
            set
            {
                passthroughLayerOptions = value;
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
        public override bool HasPassThroughCamera { get => HasPassthroughLayer(); protected set => throw new System.NotImplementedException(); }

        protected override void OnEnable()
        {
            base.OnEnable();
            SetPassthroughLayerState(null);
        }

        /// <inheritdoc/>
        protected override void EnablePassThrough()
        {
            if (SetPassthroughLayerState(false))
            {
                base.EnablePassThrough();
            }
        }

        /// <inheritdoc/>
        protected override void DisablePassThrough()
        {
            if (SetPassthroughLayerState(true))
            {
                base.DisablePassThrough();
            }
        }

        /// <summary>
        /// Determines whether there are any set passthrough layers.
        /// </summary>
        /// <returns>Whether a passthrough layer exists.</returns>
        protected virtual bool HasPassthroughLayer()
        {
            foreach (PassThroughSetting setting in PassthroughLayerOptions)
            {
                if (setting.PassthroughLayer != null)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Sets the passthrough layer state.
        /// </summary>
        /// <param name="state">The state to set. If <see langword="null"/> is passed then it uses the setting's <see cref="PassThroughSetting.passthroughLayerHiddenOnEnable"/> value.</param>
        /// <returns>Whether any passthrough layer state was set.</returns>
        protected virtual bool SetPassthroughLayerState(bool? state)
        {
            bool stateSet = false;
            foreach (PassThroughSetting setting in PassthroughLayerOptions)
            {
                if (setting.PassthroughLayer == null)
                {
                    continue;
                }

                setting.PassthroughLayer.hidden = state == null ? setting.PassthroughLayerHiddenOnEnable : (bool)state;
                stateSet = true;
            }
            return stateSet;
        }
    }
}