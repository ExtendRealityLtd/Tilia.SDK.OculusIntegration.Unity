namespace Tilia.SDK.OculusIntegration.Tracking.Velocity
{
    using UnityEngine;
    using Zinnia.Extension;
    using Zinnia.Tracking.Velocity;

    /// <summary>
    /// Retrieves the velocity and angular velocity from the specific named OVRCameraRig tracked anchor (CenterEyeAnchor, LeftHandAnchor, RightHandAnchor).
    /// </summary>
    public class OVRAnchorVelocityEstimator : VelocityTracker
    {
        /// <summary>
        /// The source of the Angular Velocity rotation multiplier
        /// </summary>
        public enum AngularRotation
        {
            /// <summary>
            /// Uses <see cref="TrackedGameObject"/> as the rotation multiplier.
            /// </summary>
            TrackedGameObject,
            /// <summary>
            /// Uses <see cref="RelativeTo"/> as the rotation multiplier.
            /// </summary>
            RelativeTo
        }

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
        [Tooltip("The source of the Angular Velocity rotation multiplier.")]
        [SerializeField]
        private AngularRotation angularRotationSource = AngularRotation.RelativeTo;
        /// <summary>
        /// The source of the Angular Velocity rotation multiplier.
        /// </summary>
        public AngularRotation AngularRotationSource
        {
            get
            {
                return angularRotationSource;
            }
            set
            {
                angularRotationSource = value;
            }
        }

        /// <summary>
        /// The rotation of <see cref="RelativeTo"/> if it is set, otherwise <see cref="Quaternion.identity"/>.
        /// </summary>
        protected virtual Quaternion RelativeRotation => RelativeTo != null ? RelativeTo.transform.rotation : Quaternion.identity;

        /// <summary>
        /// Sets the <see cref="AngularRotationSource"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="AngularRotation"/>.</param>
        public virtual void SetAngularRotationSource(int index)
        {
            AngularRotationSource = EnumExtensions.GetByIndex<AngularRotation>(index);
        }

        /// <inheritdoc />
        public override bool IsActive()
        {
            return TrackedGameObject != null && TrackedGameObject.activeInHierarchy && this.CheckIsActiveAndEnabled();
        }

        /// <inheritdoc />
        protected override Vector3 DoGetVelocity()
        {
            if (TrackedGameObject == null)
            {
                return default;
            }

            switch (TrackedGameObject.name)
            {
                case "CenterEyeAnchor":
                    return RelativeRotation * (OVRManager.isHmdPresent ? OVRPlugin.GetNodeVelocity(OVRPlugin.Node.EyeCenter, OVRPlugin.Step.Render).FromFlippedZVector3f() : Vector3.zero);
                case "LeftHandAnchor":
                    return RelativeRotation * OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LTouch);
                case "RightHandAnchor":
                    return RelativeRotation * OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch);
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

            Quaternion rotationMultiplier = Quaternion.identity;
            switch (AngularRotationSource)
            {
                case AngularRotation.RelativeTo:
                    rotationMultiplier = RelativeRotation;
                    break;
                case AngularRotation.TrackedGameObject:
                    rotationMultiplier = TrackedGameObject.transform.rotation;
                    break;
            }


            switch (TrackedGameObject.name)
            {
                case "CenterEyeAnchor":
                    return rotationMultiplier * (OVRManager.isHmdPresent ? OVRPlugin.GetNodeAngularVelocity(OVRPlugin.Node.EyeCenter, OVRPlugin.Step.Render).FromFlippedZVector3f() : Vector3.zero);
                case "LeftHandAnchor":
                    return rotationMultiplier * -OVRInput.GetLocalControllerAngularVelocity(OVRInput.Controller.LTouch);
                case "RightHandAnchor":
                    return rotationMultiplier * -OVRInput.GetLocalControllerAngularVelocity(OVRInput.Controller.RTouch);
                default:
                    return default;
            }
        }
    }
}