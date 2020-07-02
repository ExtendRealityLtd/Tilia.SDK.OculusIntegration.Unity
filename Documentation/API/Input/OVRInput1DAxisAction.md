# Class OVRInput1DAxisAction

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
* OVRInput1DAxisAction

##### Implements

IProcessable

[OVRInputControllable]

##### Namespace

* [Tilia.SDK.OculusIntegration.Input]

##### Syntax

```
public class OVRInput1DAxisAction : FloatAction, IProcessable, OVRInputControllable
```

### Properties

#### Axis

The axis to listen for state changes on.

##### Declaration

```
public OVRInput.Axis1D Axis { get; set; }
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
