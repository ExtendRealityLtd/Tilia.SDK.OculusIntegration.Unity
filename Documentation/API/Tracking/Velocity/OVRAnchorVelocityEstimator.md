# Class OVRAnchorVelocityEstimator

Retrieves the velocity and angular velocity from the specific named OVRCameraRig tracked anchor (CenterEyeAnchor, LeftHandAnchor, RightHandAnchor).

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [RelativeTo]
  * [TrackedGameObject]
* [Methods]
  * [DoGetAngularVelocity()]
  * [DoGetVelocity()]
  * [IsActive()]

## Details

##### Inheritance

* System.Object
* OVRAnchorVelocityEstimator

##### Namespace

* [Tilia.SDK.OculusIntegration.Tracking.Velocity]

##### Syntax

```
public class OVRAnchorVelocityEstimator : VelocityTracker
```

### Properties

#### RelativeTo

An optional GameObject to consider the source relative to when retrieving velocities.

##### Declaration

```
public GameObject RelativeTo { get; set; }
```

#### TrackedGameObject

The GameObject anchor from the OVRCameraRig to track velocity for.

##### Declaration

```
public GameObject TrackedGameObject { get; set; }
```

### Methods

#### DoGetAngularVelocity()

##### Declaration

```
protected override Vector3 DoGetAngularVelocity()
```

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | n/a |

#### DoGetVelocity()

##### Declaration

```
protected override Vector3 DoGetVelocity()
```

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | n/a |

#### IsActive()

##### Declaration

```
public override bool IsActive()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

[Tilia.SDK.OculusIntegration.Tracking.Velocity]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[RelativeTo]: #RelativeTo
[TrackedGameObject]: #TrackedGameObject
[Methods]: #Methods
[DoGetAngularVelocity()]: #DoGetAngularVelocity
[DoGetVelocity()]: #DoGetVelocity
[IsActive()]: #IsActive
