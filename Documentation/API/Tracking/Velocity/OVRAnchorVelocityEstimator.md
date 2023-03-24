# Class OVRAnchorVelocityEstimator

Retrieves the velocity and angular velocity from the specific named OVRCameraRig tracked anchor (CenterEyeAnchor, LeftHandAnchor, RightHandAnchor).

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [AngularRotationSource]
  * [RelativeRotation]
  * [RelativeTo]
  * [TrackedGameObject]
* [Methods]
  * [DoGetAngularVelocity()]
  * [DoGetVelocity()]
  * [IsActive()]
  * [SetAngularRotationSource(Int32)]

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

#### AngularRotationSource

The source of the Angular Velocity rotation multiplier.

##### Declaration

```
public OVRAnchorVelocityEstimator.AngularRotation AngularRotationSource { get; set; }
```

#### RelativeRotation

The rotation of [RelativeTo] if it is set, otherwise Quaternion.identity.

##### Declaration

```
protected virtual Quaternion RelativeRotation { get; }
```

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

#### SetAngularRotationSource(Int32)

Sets the [AngularRotationSource].

##### Declaration

```
public virtual void SetAngularRotationSource(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index of the [OVRAnchorVelocityEstimator.AngularRotation]. |

[Tilia.SDK.OculusIntegration.Tracking.Velocity]: README.md
[RelativeTo]: OVRAnchorVelocityEstimator.md#RelativeTo
[AngularRotationSource]: OVRAnchorVelocityEstimator.md#AngularRotationSource
[OVRAnchorVelocityEstimator.AngularRotation]: OVRAnchorVelocityEstimator.AngularRotation.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[AngularRotationSource]: #AngularRotationSource
[RelativeRotation]: #RelativeRotation
[RelativeTo]: #RelativeTo
[TrackedGameObject]: #TrackedGameObject
[Methods]: #Methods
[DoGetAngularVelocity()]: #DoGetAngularVelocity
[DoGetVelocity()]: #DoGetVelocity
[IsActive()]: #IsActive
[SetAngularRotationSource(Int32)]: #SetAngularRotationSourceInt32
