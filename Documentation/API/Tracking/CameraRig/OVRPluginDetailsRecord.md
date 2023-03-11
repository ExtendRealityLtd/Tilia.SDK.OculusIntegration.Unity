# Class OVRPluginDetailsRecord

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [BatteryChargeStatus]
  * [BatteryLevel]
  * [HasPassThroughCamera]
  * [Model]
  * [PassthroughLayer]
  * [PassthroughLayerHiddenOnEnable]
  * [Priority]
  * [XRNodeType]
* [Methods]
  * [DisablePassThrough()]
  * [EnablePassThrough()]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* OVRPluginDetailsRecord

##### Namespace

* [Tilia.SDK.OculusIntegration.Tracking.CameraRig]

##### Syntax

```
public class OVRPluginDetailsRecord : BaseDeviceDetailsRecord
```

### Properties

#### BatteryChargeStatus

##### Declaration

```
public override BatteryStatus BatteryChargeStatus { get; protected set; }
```

#### BatteryLevel

##### Declaration

```
public override float BatteryLevel { get; protected set; }
```

#### HasPassThroughCamera

##### Declaration

```
public override bool HasPassThroughCamera { get; protected set; }
```

#### Model

##### Declaration

```
public override string Model { get; protected set; }
```

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

#### Priority

##### Declaration

```
public override int Priority { get; protected set; }
```

#### XRNodeType

##### Declaration

```
public override XRNode XRNodeType { get; protected set; }
```

### Methods

#### DisablePassThrough()

##### Declaration

```
protected override void DisablePassThrough()
```

#### EnablePassThrough()

##### Declaration

```
protected override void EnablePassThrough()
```

#### OnEnable()

##### Declaration

```
protected override void OnEnable()
```

[Tilia.SDK.OculusIntegration.Tracking.CameraRig]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[BatteryChargeStatus]: #BatteryChargeStatus
[BatteryLevel]: #BatteryLevel
[HasPassThroughCamera]: #HasPassThroughCamera
[Model]: #Model
[PassthroughLayer]: #PassthroughLayer
[PassthroughLayerHiddenOnEnable]: #PassthroughLayerHiddenOnEnable
[Priority]: #Priority
[XRNodeType]: #XRNodeType
[Methods]: #Methods
[DisablePassThrough()]: #DisablePassThrough
[EnablePassThrough()]: #EnablePassThrough
[OnEnable()]: #OnEnable
