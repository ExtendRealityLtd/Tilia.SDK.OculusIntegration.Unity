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
  * [PassthroughLayerOptions]
  * [Priority]
  * [XRNodeType]
* [Methods]
  * [DisablePassThrough()]
  * [EnablePassThrough()]
  * [HasPassthroughLayer()]
  * [OnEnable()]
  * [SetPassthroughLayerState(Nullable<Boolean>)]

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

#### PassthroughLayerOptions

The collection of OVRPassthroughLayer components for controlling camera passthrough.

##### Declaration

```
public List<OVRPluginDetailsRecord.PassThroughSetting> PassthroughLayerOptions { get; set; }
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

#### HasPassthroughLayer()

Determines whether there are any set passthrough layers.

##### Declaration

```
protected virtual bool HasPassthroughLayer()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether a passthrough layer exists. |

#### OnEnable()

##### Declaration

```
protected override void OnEnable()
```

#### SetPassthroughLayerState(Nullable<Boolean>)

Sets the passthrough layer state.

##### Declaration

```
protected virtual bool SetPassthroughLayerState(bool? state)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Boolean\> | state | The state to set. If null is passed then it uses the setting's Tilia.SDK.OculusIntegration.Tracking.CameraRig.OVRPluginDetailsRecord.PassThroughSetting.passthroughLayerHiddenOnEnable value. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether any passthrough layer state was set. |

[Tilia.SDK.OculusIntegration.Tracking.CameraRig]: README.md
[OVRPluginDetailsRecord.PassThroughSetting]: OVRPluginDetailsRecord.PassThroughSetting.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[BatteryChargeStatus]: #BatteryChargeStatus
[BatteryLevel]: #BatteryLevel
[HasPassThroughCamera]: #HasPassThroughCamera
[Model]: #Model
[PassthroughLayerOptions]: #PassthroughLayerOptions
[Priority]: #Priority
[XRNodeType]: #XRNodeType
[Methods]: #Methods
[DisablePassThrough()]: #DisablePassThrough
[EnablePassThrough()]: #EnablePassThrough
[HasPassthroughLayer()]: #HasPassthroughLayer
[OnEnable()]: #OnEnable
[SetPassthroughLayerState(Nullable<Boolean>)]: #SetPassthroughLayerStateNullable<Boolean>
