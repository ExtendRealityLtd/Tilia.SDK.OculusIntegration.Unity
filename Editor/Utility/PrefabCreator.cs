namespace Tilia.SDK.OculusIntegration.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation;

        private const string package = "io.extendreality.tilia.sdk.oculusintegration.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabCameraRigsOculusIntegration = "CameraRigs.OculusIntegration";
        private const string prefabInputOculusTouchLeftController = "Input.OculusIntegration.OculusTouchLeftController";
        private const string prefabInputOculusTouchRightController = "Input.OculusIntegration.OculusTouchRightController";

        private const string prefabInputOculusOVRInput1DAxisAction = "Input.OculusIntegration.OVRInput1DAxisAction";
        private const string prefabInputOculusOVRInput2DAxisAction = "Input.OculusIntegration.OVRInput2DAxisAction";
        private const string prefabInputOculusOVRInputButtonAction = "Input.OculusIntegration.OVRInputButtonAction";
        private const string prefabInputOculusOVRInputTouchAction = "Input.OculusIntegration.OVRInputTouchAction";
        private const string prefabInputOculusOVRInputNearTouchAction = "Input.OculusIntegration.OVRInputNearTouchAction";

        [MenuItem(menuItemRoot + "CameraRigs/" + prefabCameraRigsOculusIntegration, false, priority)]
        private static void AddCameraRigsOculusIntegration()
        {
            string prefab = prefabCameraRigsOculusIntegration + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + "Input/OculusIntegration/Actions/" + prefabInputOculusOVRInput1DAxisAction, false, priority)]
        private static void AddInputOculusOVRInput1DAxisAction()
        {
            string prefab = prefabInputOculusOVRInput1DAxisAction + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, "Input", "Actions", prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + "Input/OculusIntegration/Actions/" + prefabInputOculusOVRInput2DAxisAction, false, priority)]
        private static void AddInputOculusOVRInput2DAxisAction()
        {
            string prefab = prefabInputOculusOVRInput2DAxisAction + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, "Input", "Actions", prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + "Input/OculusIntegration/Actions/" + prefabInputOculusOVRInputButtonAction, false, priority)]
        private static void AddInputOculusOVRInputButtonAction()
        {
            string prefab = prefabInputOculusOVRInputButtonAction + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, "Input", "Actions", prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + "Input/OculusIntegration/Actions/" + prefabInputOculusOVRInputTouchAction, false, priority)]
        private static void AddInputOculusOVRInputTouchAction()
        {
            string prefab = prefabInputOculusOVRInputTouchAction + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, "Input", "Actions", prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + "Input/OculusIntegration/Actions/" + prefabInputOculusOVRInputNearTouchAction, false, priority)]
        private static void AddInputOculusOVRInputNearTouchAction()
        {
            string prefab = prefabInputOculusOVRInputNearTouchAction + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, "Input", "Actions", prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + "Input/OculusIntegration/ControllerMappings/" + prefabInputOculusTouchLeftController, false, priority)]
        private static void AddInputOculusTouchLeftController()
        {
            string prefab = prefabInputOculusTouchLeftController + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, "Input", "ControllerMappings", prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + "Input/OculusIntegration/ControllerMappings/" + prefabInputOculusTouchRightController, false, priority)]
        private static void AddInputOculusTouchRightController()
        {
            string prefab = prefabInputOculusTouchRightController + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, "Input", "ControllerMappings", prefab);
            CreatePrefab(packageLocation);
        }
    }
}