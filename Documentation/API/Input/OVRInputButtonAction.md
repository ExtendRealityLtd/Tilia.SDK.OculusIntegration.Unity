# Class OVRInputButtonAction

Listens for the specified button state and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Button]
  * [Controller]
* [Methods]
  * [Process()]
* [Implements]

## Details

##### Inheritance

* System.Object
* OVRInputButtonAction

##### Implements

IProcessable

[OVRInputControllable]

##### Namespace

* [Tilia.SDK.OculusIntegration.Input]

##### Syntax

```
public class OVRInputButtonAction : BooleanAction, IProcessable, OVRInputControllable
```

### Properties

#### Button

The button to listen for state changes on.

##### Declaration

```
public OVRInput.Button Button { get; set; }
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
[Button]: #Button
[Controller]: #Controller
[Methods]: #Methods
[Process()]: #Process
[Implements]: #Implements
