# Class OVRInputTouchAction

Listens for the specified button state and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Controller]
  * [Touch]
* [Methods]
  * [Process()]
* [Implements]

## Details

##### Inheritance

* System.Object
* OVRInputTouchAction

##### Implements

IProcessable

[OVRInputControllable]

##### Namespace

* [Tilia.SDK.OculusIntegration.Input]

##### Syntax

```
public class OVRInputTouchAction : BooleanAction, IProcessable, OVRInputControllable
```

### Properties

#### Controller

The controller to listen for the state change on.

##### Declaration

```
public OVRInput.Controller Controller { get; set; }
```

#### Touch

The touch to listen for state changes on.

##### Declaration

```
public OVRInput.Touch Touch { get; set; }
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
[Controller]: #Controller
[Touch]: #Touch
[Methods]: #Methods
[Process()]: #Process
[Implements]: #Implements
