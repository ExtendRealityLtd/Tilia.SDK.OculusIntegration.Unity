namespace Tilia.SDK.OculusIntegration.Tracking.Velocity
{
    using UnityEngine;
    using Zinnia.Tracking.Velocity;

    /// <summary>
    /// Retrieves the velocity and angular velocity from the specific named OVRCameraRig tracked anchor (CenterEyeAnchor, LeftHandAnchor, RightHandAnchor).
    /// </summary>
    public class OVRAnchorVelocityEstimator : VelocityTracker
    {
        [Tooltip("The GameObject anchor from the OVRCameraRig to track velocity for.")]
        [SerializeField]
        private GameObject trackedGameObject;
        /// <summary>
        /// The <see cref="GameObject"/> anchor from the OVRCameraRig to track velocity for.
        /// </summary>
        public GameObject TrackedGameObject
        {
            get
            {
                return trackedGameObject;
            }
            set
            {
                trackedGameObject = value;
            }
        }
        [Tooltip("An optional GameObject to consider the source relative to when retrieving velocities.")]
        [SerializeField]
        private GameObject relativeTo;
        /// <summary>
        /// An optional <see cref="GameObject"/> to consider the source relative to when retrieving velocities.
        /// </summary>
        public GameObject RelativeTo
        {
            get
            {
                return relativeTo;
            }
            set
            {
                relativeTo = value;
            }
        }

        /// <inheritdoc />
        public override bool IsActive()
        {
            return TrackedGameObject != null && TrackedGameObject.activeInHierarchy && isActiveAndEnabled;
        }

        /// <inheritdoc />
        protected override Vector3 DoGetVelocity()
        {
            if (TrackedGameObject == null)
            {
                return default;
            }

            Quaternion relative = RelativeTo != null ? RelativeTo.transform.rotation : Quaternion.identity;
            switch (TrackedGameObject.name)
            {
                case "CenterEyeAnchor":
                    return relative * (OVRManager.isHmdPresent ? OVRPlugin.GetNodeVelocity(OVRPlugin.Node.EyeCenter, OVRPlugin.Step.Render).FromFlippedZVector3f() : Vector3.zero);
                case "LeftHandAnchor":
                    return relative * OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LTouch);
                case "RightHandAnchor":
                    return relative * OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch);
                default:
                    return default;
            }
        }

        /// <inheritdoc />
        protected override Vector3 DoGetAngularVelocity()
        {
            if (TrackedGameObject == null)
            {
                return default;
            }

            switch (TrackedGameObject.name)
            {
                case "CenterEyeAnchor":
                    return TrackedGameObject.transform.rotation * (OVRManager.isHmdPresent ? OVRPlugin.GetNodeAngularVelocity(OVRPlugin.Node.EyeCenter, OVRPlugin.Step.Render).FromFlippedZVector3f() : Vector3.zero);
                case "LeftHandAnchor":
                    return TrackedGameObject.transform.rotation * OVRInput.GetLocalControllerAngularVelocity(OVRInput.Controller.LTouch);
                case "RightHandAnchor":
                    return TrackedGameObject.transform.rotation * OVRInput.GetLocalControllerAngularVelocity(OVRInput.Controller.RTouch);
                default:
                    return default;
            }
        }
    }
}