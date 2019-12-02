namespace Tilia.SDK.OculusIntegration.Input
{
    /// <summary>
    /// Denotes containing a <see cref="OVRInput.Controller"/> Type.
    /// </summary>
    public interface OVRInputControllable
    {
        OVRInput.Controller Controller { get; set; }
    }
}