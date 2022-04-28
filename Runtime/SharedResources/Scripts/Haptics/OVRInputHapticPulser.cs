namespace Tilia.SDK.OculusIntegration.Haptics
{
    using UnityEngine;
    using Zinnia.Haptics;

    /// <summary>
    /// Creates a single haptic pulse on a <see cref="OVRInput.Controller"/> supported haptic device.
    /// </summary>
    public class OVRInputHapticPulser : HapticPulser
    {
        [Tooltip("The controller to pulse.")]
        [SerializeField]
        private OVRInput.Controller controller = OVRInput.Controller.All;
        /// <summary>
        /// The controller to pulse.
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
        [Tooltip("The duration to pulse Controller for.")]
        [SerializeField]
        private float duration = 0.1f;
        /// <summary>
        /// The duration to pulse <see cref="Controller"/> for.
        /// </summary>
        public float Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        [Tooltip("The frequency between each pulse.")]
        [SerializeField]
        [Range(0f, 1f)]
        private float frequency = 0.1f;
        /// <summary>
        /// The frequency between each pulse.
        /// </summary>
        public float Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                frequency = value;
            }
        }

        /// <inheritdoc />
        protected override void DoBegin()
        {
            OVRInput.SetControllerVibration(Frequency, Intensity, Controller);
            Invoke("DoCancel", Duration);
        }

        /// <inheritdoc />
        protected override void DoCancel()
        {
            CancelInvoke("DoCancel");
            OVRInput.SetControllerVibration(0f, 0f, Controller);
        }
    }
}