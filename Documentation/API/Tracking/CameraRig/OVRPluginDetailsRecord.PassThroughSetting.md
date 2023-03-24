## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [PassthroughLayer]
  * [PassthroughLayerHiddenOnEnable]

## Details

# Struct OVRPluginDetailsRecord.PassThroughSetting

A setting for each Passthrough layer.

##### Inherited Members

System.ValueType.Equals(System.Object)

System.ValueType.GetHashCode()

System.ValueType.ToString()

System.Object.Equals(System.Object, System.Object)

System.Object.ReferenceEquals(System.Object, System.Object)

System.Object.GetType()

##### Namespace

* [Tilia.SDK.OculusIntegration.Tracking.CameraRig]

##### Syntax

```
[Serializable]
public struct PassThroughSetting
```

### Properties

#### PassthroughLayer

The OVRPassthroughLayer component for controlling camera passthrough.

##### Declaration

```
public OVRPassthroughLayer PassthroughLayer { get; set; }
```

#### PassthroughLayerHiddenOnEnable

Whether the OVRPassthroughLayer component is hidden on enable. Does not raise events.

##### Declaration

```
public bool PassthroughLayerHiddenOnEnable { get; set; }
```

[Tilia.SDK.OculusIntegration.Tracking.CameraRig]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[PassthroughLayer]: #PassthroughLayer
[PassthroughLayerHiddenOnEnable]: #PassthroughLayerHiddenOnEnable
