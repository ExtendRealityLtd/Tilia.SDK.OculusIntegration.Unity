namespace Tilia.SDK.OculusIntegration.Input
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified button state and emits the appropriate action.
    /// </summary>
    public class OVRInputNearTouchAction : BooleanAction, IProcessable, OVRInputControllable
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
        [Tooltip("The near touch to listen for state changes on.")]
        [SerializeField]
        private OVRInput.NearTouch nearTouch;
        /// <summary>
        /// The near touch to listen for state changes on.
        /// </summary>
        public OVRInput.NearTouch NearTouch
        {
            get
            {
                return nearTouch;
            }
            set
            {
                nearTouch = value;
            }
        }

        /// <inheritdoc />
        public void Process()
        {
            Receive(OVRInput.Get(NearTouch, Controller));
        }
    }
}