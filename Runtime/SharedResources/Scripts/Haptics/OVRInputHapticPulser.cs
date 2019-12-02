namespace Tilia.SDK.OculusIntegration.Haptics
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Haptics;

    /// <summary>
    /// Creates a single haptic pulse on a <see cref="OVRInput.Controller"/> supported haptic device.
    /// </summary>
    public class OVRInputHapticPulser : HapticPulser
    {
        /// <summary>
        /// The frequency between each pulse.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Range(0f, 1f)]
        public float Frequency { get; set; } = 0.1f;
        /// <summary>
        /// The controller to pulse.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public OVRInput.Controller Controller { get; set; } = OVRInput.Controller.All;
        /// <summary>
        /// The duration to pulse <see cref="Controller"/> for.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float Duration { get; set; } = 0.1f;

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