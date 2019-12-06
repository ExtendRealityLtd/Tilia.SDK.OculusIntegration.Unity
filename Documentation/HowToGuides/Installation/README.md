# Installing the package

> * Level: Beginner
>
> * Reading Time: 5 minutes
>
> * Checked with:
>   * Unity 2018.3.14f1
>   * Oculus Intergration 1.43

## Introduction

The [Oculus Integration] asset for the [Unity] software provides direct access to the Oculus hardware API and therefore offers a number of additional features outside of the default Unity software XR offering.

This package contains the following functionality:

* CameraRig wrapper so the `OVRCameraRig` prefab can be used with the [Tilia.CameraRigs.TrackedAlias.Unity].
* Default input action prefabs for `OVRInput` types such as press, touch, near touch and axis data.
* Controller input action mappings for the Oculus Touch controllers.
* Controller haptic feedback utilizing `OVRInput`.

## Let's Start

### Step 1

> You may skip this step if you already have a Unity project to import the package into.

* Create a new project in the Unity software version `2018.3.10f1` (or above) using `3D Template` or open an existing project.

### Step 2: Configuring the Unity project

* Ensure the project `Scripting Runtime Version` is set to `.NET 4.x Equivalent`:
  * In the Unity software select `Main Menu -> Edit -> Project Settings` to open the `Project Settings` inspector.
  * Select `Player` from the left hand menu in the `Project Settings` window.
  * In the `Player` settings panel expand `Other Settings`.
  * Ensure the `Scripting Runtime Version` is set to `.NET 4.x Equivalent`.

### Step 3: Adding the Oculus Integration asset to the Unity project.

* Visit the Unity Asset Store and download the free [Oculus Integration] asset into your Unity project.

### Step 4: Adding the package to the Unity project manifest

* Navigate to the `Packages` directory of your project.
* Adjust the [project manifest file][Project-Manifest] `manifest.json` in a text editor.
  * Ensure `https://registry.npmjs.org/` is part of `scopedRegistries`.
    * Ensure `io.extendreality` is part of `scopes`.
  * Add `io.extendreality.tilia.sdk.oculusintegration.unity` to `dependencies`, stating the latest version.

  A minimal example ends up looking like this. Please note that the version `X.Y.Z` stated here is to be replaced with [the latest released version][Latest-Release] which is currently [![Release][Version-Release]][Releases].
  ```json
  {
    "scopedRegistries": [
      {
        "name": "npmjs",
        "url": "https://registry.npmjs.org/",
        "scopes": [
          "io.extendreality"
        ]
      }
    ],
    "dependencies": {
      "io.extendreality.tilia.sdk.oculusintegration.unity": "X.Y.Z",
      ...
    }
  }
  ```
* Switch back to the Unity software and wait for it to finish importing the added package.

### Done

The Oculus Integration package will now be available in your Unity project `Packages` directory ready for use in your project.

The package will now also show up in the Unity Package Manager UI. From then on the package can be updated by selecting the package in the Unity Package Manager and clicking on the `Update` button or using the version selection UI.

[Oculus Integration]: https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022
[Unity]: https://unity3d.com/
[Tilia.CameraRigs.TrackedAlias.Unity]: https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity
[Unity Package Manager]: https://docs.unity3d.com/Manual/upm-ui.html
[Project-Manifest]: https://docs.unity3d.com/Manual/upm-manifestPrj.html
[Version-Release]: https://img.shields.io/github/release/ExtendRealityLtd/Tilia.SDK.OculusIntegration.Unity.svg
[Releases]: ../../releases
[Latest-Release]: ../../releases/latest