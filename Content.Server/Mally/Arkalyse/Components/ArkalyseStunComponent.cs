using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;
using Robust.Shared.Audio;

namespace Content.Server.Mally.Arkalyse.Components;

[RegisterComponent]
public sealed partial class ArkalyseStunComponent : Component
{
    [DataField]
    public float ParalyzeTime = 1.5f;

    [DataField]
    public EntityUid? ActionStunArkalyseAttackEntity;

    [DataField("actionStunArkalyseAttack", customTypeSerializer: typeof(PrototypeIdSerializer<EntityPrototype>))]
    public string ActionStunArkalyseAttack = "ActionStunArkalyseAttack";

    [DataField]
    public bool IsStunedAttack = false;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField, AutoNetworkedField]
    public SoundSpecifier HitSound = new SoundPathSpecifier("/Audio/Mally/sound_effects_hit_punch.ogg");
}
