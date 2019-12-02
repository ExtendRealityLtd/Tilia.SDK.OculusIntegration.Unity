namespace Tilia.SDK.OculusIntegration.Association
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Association;

    /// <summary>
    /// Holds <see cref="GameObject"/>s to (de)activate based on a <see cref="OVRInput.Controller"/>.
    /// </summary>
    public class OVRInputControllerAssociation : GameObjectsAssociation
    {
        /// <summary>
        /// The <see cref="OVRInput.Controller"/> that needs to be connected.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public OVRInput.Controller Controller { get; set; } = OVRInput.Controller.None;

        /// <summary>
        /// Whether the <see cref="controller"/> needs to be active.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool NeedsToBeActive { get; set; }

        /// <inheritdoc />
        public override bool ShouldBeActive()
        {
            return OVRInput.IsControllerConnected(Controller) &&
                (!NeedsToBeActive || (OVRInput.GetActiveController() == Controller));
        }
    }
}