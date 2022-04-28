namespace Tilia.SDK.OculusIntegration.Association
{
    using UnityEngine;
    using Zinnia.Association;

    /// <summary>
    /// Holds <see cref="GameObject"/>s to (de)activate based on a <see cref="OVRInput.Controller"/>.
    /// </summary>
    public class OVRInputControllerAssociation : GameObjectsAssociation
    {
        [Tooltip("The OVRInput.Controller that needs to be connected.")]
        [SerializeField]
        private OVRInput.Controller controller = OVRInput.Controller.None;
        /// <summary>
        /// The <see cref="OVRInput.Controller"/> that needs to be connected.
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

        [Tooltip("Whether the controller needs to be active.")]
        [SerializeField]
        private bool needsToBeActive;
        /// <summary>
        /// Whether the <see cref="controller"/> needs to be active.
        /// </summary>
        public bool NeedsToBeActive
        {
            get
            {
                return needsToBeActive;
            }
            set
            {
                needsToBeActive = value;
            }
        }

        /// <inheritdoc />
        public override bool ShouldBeActive()
        {
            return OVRInput.IsControllerConnected(Controller) && (!NeedsToBeActive || (OVRInput.GetActiveController() == Controller));
        }
    }
}