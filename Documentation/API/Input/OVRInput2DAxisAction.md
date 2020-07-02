# Class OVRInput2DAxisAction

Listens for the specified axis and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Axis]
  * [Controller]
* [Methods]
  * [Process()]
* [Implements]

## Details

##### Inheritance

* System.Object
* OVRInput2DAxisAction

##### Implements

IProcessable

[OVRInputControllable]

##### Namespace

* [Tilia.SDK.OculusIntegration.Input]

##### Syntax

```
public class OVRInput2DAxisAction : Vector2Action, IProcessable, OVRInputControllable
```

### Properties

#### Axis

The axis to listen for state changes on.

##### Declaration

```
public OVRInput.Axis2D Axis { get; set; }
```

#### Controller

The controller to listen for the state change on.

##### Declaration

```
public OVRInput.Controller Controller { get; set; }
```

### Methods

#### Process()

##### Declaration

```
public void Process()
```

### Implements

IProcessable

[OVRInputControllable]

[Tilia.SDK.OculusIntegration.Input]: README.md
[OVRInputControllable]: OVRInputControllable.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Axis]: #Axis
[Controller]: #Controller
[Methods]: #Methods
[Process()]: #Process
[Implements]: #Implements
