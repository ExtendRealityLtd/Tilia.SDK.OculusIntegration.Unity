namespace Tilia.SDK.OculusIntegration.Input
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified button state and emits the appropriate action.
    /// </summary>
    public class OVRInputButtonAction : BooleanAction, IProcessable, OVRInputControllable
    {
        [Tooltip("The controller to listen for the state change on.")]
        [SerializeField]
        private OVRInput.Controller controller = OVRInput.Controller.Active;
        /// <summary>
        /// The controller to listen for the state change on.
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
        [Tooltip("The button to listen for state changes on.")]
        [SerializeField]
        private OVRInput.Button button;
        /// <summary>
        /// The button to listen for state changes on.
        /// </summary>
        public OVRInput.Button Button
        {
            get
            {
                return button;
            }
            set
            {
                button = value;
            }
        }

        /// <inheritdoc />
        public void Process()
        {
            Receive(OVRInput.Get(Button, Controller));
        }
    }
}