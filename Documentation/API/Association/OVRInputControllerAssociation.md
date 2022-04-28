# Class OVRInputControllerAssociation

Holds GameObjects to (de)activate based on a OVRInput.Controller.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Controller]
  * [NeedsToBeActive]
* [Methods]
  * [ShouldBeActive()]

## Details

##### Inheritance

* System.Object
* OVRInputControllerAssociation

##### Namespace

* [Tilia.SDK.OculusIntegration.Association]

##### Syntax

```
public class OVRInputControllerAssociation : GameObjectsAssociation
```

### Properties

#### Controller

The OVRInput.Controller that needs to be connected.

##### Declaration

```
public OVRInput.Controller Controller { get; set; }
```

#### NeedsToBeActive

Whether the Tilia.SDK.OculusIntegration.Association.OVRInputControllerAssociation.controller needs to be active.

##### Declaration

```
public bool NeedsToBeActive { get; set; }
```

### Methods

#### ShouldBeActive()

##### Declaration

```
public override bool ShouldBeActive()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

[Tilia.SDK.OculusIntegration.Association]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Controller]: #Controller
[NeedsToBeActive]: #NeedsToBeActive
[Methods]: #Methods
[ShouldBeActive()]: #ShouldBeActive
