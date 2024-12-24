using Robust.Shared.Audio;

namespace Content.Server.DeadSpace.Implants.Revive.Components;

[RegisterComponent]
public sealed partial class ReviveImplantComponent : Component
{
    [DataField]
    public float InjectTime = 4f;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField, AutoNetworkedField]
    public SoundSpecifier ImplantedSound = new SoundPathSpecifier("/Audio/DeadSpace/Autosurgeon/sound_weapons_circsawhit.ogg");
}
