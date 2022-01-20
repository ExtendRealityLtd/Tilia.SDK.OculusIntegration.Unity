# Class OVRInputDetailsRecord

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [lastKnownBatteryStatus]
  * [lastKnownIsConnected]
  * [lastKnownTrackingType]
* [Properties]
  * [BatteryChargeStatus]
  * [BatteryLevel]
  * [Controller]
  * [IsConnected]
  * [Manufacturer]
  * [Model]
  * [Priority]
  * [TrackingType]
  * [XRNodeType]
* [Methods]
  * [ConvertFromController(OVRInput.Controller)]
  * [GetPriority(OVRInput.Controller)]
  * [HasBatteryChargeStatusChanged()]
  * [HasIsConnectedChanged()]
  * [HasTrackingTypeChanged()]
  * [SetNodeType(Int32)]

## Details

##### Inheritance

* System.Object
* OVRInputDetailsRecord

##### Namespace

* [Tilia.SDK.OculusIntegration.Tracking.CameraRig]

##### Syntax

```
public class OVRInputDetailsRecord : DeviceDetailsRecord
```

### Fields

#### lastKnownBatteryStatus

The last known battery charge status.

##### Declaration

```
protected BatteryStatus lastKnownBatteryStatus
```

#### lastKnownIsConnected

The last known is connected status.

##### Declaration

```
protected bool lastKnownIsConnected
```

#### lastKnownTrackingType

The last known tracking type.

##### Declaration

```
protected SpatialTrackingType lastKnownTrackingType
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

#### Controller

OVR Controller type.

##### Declaration

```
public OVRInput.Controller Controller { get; set; }
```

#### IsConnected

##### Declaration

```
public override bool IsConnected { get; protected set; }
```

#### Manufacturer

##### Declaration

```
public override string Manufacturer { get; protected set; }
```

#### Model

##### Declaration

```
public override string Model { get; protected set; }
```

#### Priority

##### Declaration

```
public override int Priority { get; protected set; }
```

#### TrackingType

##### Declaration

```
public override SpatialTrackingType TrackingType { get; protected set; }
```

#### XRNodeType

##### Declaration

```
public override XRNode XRNodeType { get; protected set; }
```

### Methods

#### ConvertFromController(OVRInput.Controller)

Converts an OVRInput.Controller type to a Unity XRNode type.

##### Declaration

```
protected virtual XRNode ConvertFromController(OVRInput.Controller controller)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| OVRInput.Controller | controller | The controller type to convert. |

##### Returns

| Type | Description |
| --- | --- |
| XRNode | The converted type. |

#### GetPriority(OVRInput.Controller)

Gets the priority of the current selected controller.

##### Declaration

```
protected virtual int GetPriority(OVRInput.Controller controller)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| OVRInput.Controller | controller | The controller to check. |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | The priority of the controller. |

#### HasBatteryChargeStatusChanged()

##### Declaration

```
protected override bool HasBatteryChargeStatusChanged()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

#### HasIsConnectedChanged()

##### Declaration

```
protected override bool HasIsConnectedChanged()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

#### HasTrackingTypeChanged()

##### Declaration

```
protected override bool HasTrackingTypeChanged()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

#### SetNodeType(Int32)

Sets the [Controller].

##### Declaration

```
public virtual void SetNodeType(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index of the OVRInput.Controller. |

[Tilia.SDK.OculusIntegration.Tracking.CameraRig]: README.md
[Controller]: OVRInputDetailsRecord.md#Controller
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[lastKnownBatteryStatus]: #lastKnownBatteryStatus
[lastKnownIsConnected]: #lastKnownIsConnected
[lastKnownTrackingType]: #lastKnownTrackingType
[Properties]: #Properties
[BatteryChargeStatus]: #BatteryChargeStatus
[BatteryLevel]: #BatteryLevel
[Controller]: #Controller
[IsConnected]: #IsConnected
[Manufacturer]: #Manufacturer
[Model]: #Model
[Priority]: #Priority
[TrackingType]: #TrackingType
[XRNodeType]: #XRNodeType
[Methods]: #Methods
[ConvertFromController(OVRInput.Controller)]: #ConvertFromControllerOVRInput.Controller
[GetPriority(OVRInput.Controller)]: #GetPriorityOVRInput.Controller
[HasBatteryChargeStatusChanged()]: #HasBatteryChargeStatusChanged
[HasIsConnectedChanged()]: #HasIsConnectedChanged
[HasTrackingTypeChanged()]: #HasTrackingTypeChanged
[SetNodeType(Int32)]: #SetNodeTypeInt32
