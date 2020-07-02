# Class OVRInputNearTouchAction

Listens for the specified button state and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Controller]
  * [NearTouch]
* [Methods]
  * [Process()]
* [Implements]

## Details

##### Inheritance

* System.Object
* OVRInputNearTouchAction

##### Implements

IProcessable

[OVRInputControllable]

##### Namespace

* [Tilia.SDK.OculusIntegration.Input]

##### Syntax

```
public class OVRInputNearTouchAction : BooleanAction, IProcessable, OVRInputControllable
```

### Properties

#### Controller

The controller to listen for the state change on.

##### Declaration

```
public OVRInput.Controller Controller { get; set; }
```

#### NearTouch

The near touch to listen for state changes on.

##### Declaration

```
public OVRInput.NearTouch NearTouch { get; set; }
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
[NearTouch]: #NearTouch
[Methods]: #Methods
[Process()]: #Process
[Implements]: #Implements
