namespace Tilia.SDK.OculusIntegration.Input
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified button state and emits the appropriate action.
    /// </summary>
    public class OVRInputTouchAction : BooleanAction, IProcessable, OVRInputControllable
    {
        /// <summary>
        /// The controller to listen for the state change on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public OVRInput.Controller Controller { get; set; } = OVRInput.Controller.Active;
        /// <summary>
        /// The touch to listen for state changes on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public OVRInput.Touch Touch { get; set; }

        /// <inheritdoc />
        public void Process()
        {
            Receive(OVRInput.Get(Touch, Controller));
        }
    }
}