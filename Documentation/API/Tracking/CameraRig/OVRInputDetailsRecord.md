# Class OVRInputDetailsRecord

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [BatteryChargeStatus]
  * [BatteryLevel]
  * [Controller]
  * [IsConnected]
  * [Priority]
  * [XRNodeType]
* [Methods]
  * [ConvertFromController(OVRInput.Controller)]
  * [GetPriority(OVRInput.Controller)]
  * [SetControllerType(Int32)]

## Details

##### Inheritance

* System.Object
* OVRInputDetailsRecord

##### Namespace

* [Tilia.SDK.OculusIntegration.Tracking.CameraRig]

##### Syntax

```
public class OVRInputDetailsRecord : BaseDeviceDetailsRecord
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

#### SetControllerType(Int32)

Sets the [Controller].

##### Declaration

```
public virtual void SetControllerType(int index)
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
[Properties]: #Properties
[BatteryChargeStatus]: #BatteryChargeStatus
[BatteryLevel]: #BatteryLevel
[Controller]: #Controller
[IsConnected]: #IsConnected
[Priority]: #Priority
[XRNodeType]: #XRNodeType
[Methods]: #Methods
[ConvertFromController(OVRInput.Controller)]: #ConvertFromControllerOVRInput.Controller
[GetPriority(OVRInput.Controller)]: #GetPriorityOVRInput.Controller
[SetControllerType(Int32)]: #SetControllerTypeInt32
