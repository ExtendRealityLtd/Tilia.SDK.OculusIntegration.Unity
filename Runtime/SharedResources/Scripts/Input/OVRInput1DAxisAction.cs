namespace Tilia.SDK.OculusIntegration.Input
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified axis and emits the appropriate action.
    /// </summary>
    public class OVRInput1DAxisAction : FloatAction, IProcessable, OVRInputControllable
    {
        /// <summary>
        /// The controller to listen for the state change on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public OVRInput.Controller Controller { get; set; } = OVRInput.Controller.Active;
        /// <summary>
        /// The axis to listen for state changes on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public OVRInput.Axis1D Axis { get; set; }

        /// <inheritdoc />
        public void Process()
        {
            Receive(OVRInput.Get(Axis, Controller));
        }
    }
}