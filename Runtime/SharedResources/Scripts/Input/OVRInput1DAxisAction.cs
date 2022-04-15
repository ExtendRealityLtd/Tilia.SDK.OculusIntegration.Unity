namespace Tilia.SDK.OculusIntegration.Input
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified axis and emits the appropriate action.
    /// </summary>
    public class OVRInput1DAxisAction : FloatAction, IProcessable, OVRInputControllable
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
        [Tooltip("The axis to listen for state changes on.")]
        [SerializeField]
        private OVRInput.Axis1D axis;
        /// <summary>
        /// The axis to listen for state changes on.
        /// </summary>
        public OVRInput.Axis1D Axis
        {
            get
            {
                return axis;
            }
            set
            {
                axis = value;
            }
        }

        /// <inheritdoc />
        public void Process()
        {
            Receive(OVRInput.Get(Axis, Controller));
        }
    }
}