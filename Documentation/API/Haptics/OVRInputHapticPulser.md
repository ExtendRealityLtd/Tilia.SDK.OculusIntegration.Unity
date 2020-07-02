# Class OVRInputHapticPulser

Creates a single haptic pulse on a OVRInput.Controller supported haptic device.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Controller]
  * [Duration]
  * [Frequency]
* [Methods]
  * [DoBegin()]
  * [DoCancel()]

## Details

##### Inheritance

* System.Object
* OVRInputHapticPulser

##### Namespace

* [Tilia.SDK.OculusIntegration.Haptics]

##### Syntax

```
public class OVRInputHapticPulser : HapticPulser
```

### Properties

#### Controller

The controller to pulse.

##### Declaration

```
public OVRInput.Controller Controller { get; set; }
```

#### Duration

The duration to pulse [Controller] for.

##### Declaration

```
public float Duration { get; set; }
```

#### Frequency

The frequency between each pulse.

##### Declaration

```
public float Frequency { get; set; }
```

### Methods

#### DoBegin()

##### Declaration

```
protected override void DoBegin()
```

#### DoCancel()

##### Declaration

```
protected override void DoCancel()
```

[Tilia.SDK.OculusIntegration.Haptics]: README.md
[Controller]: OVRInputHapticPulser.md#Controller
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Controller]: #Controller
[Duration]: #Duration
[Frequency]: #Frequency
[Methods]: #Methods
[DoBegin()]: #DoBegin
[DoCancel()]: #DoCancel
