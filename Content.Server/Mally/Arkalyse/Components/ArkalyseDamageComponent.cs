using Content.Shared.Damage;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;
using Robust.Shared.Audio;

namespace Content.Server.Mally.Arkalyse.Components;

[RegisterComponent]

public sealed partial class ArkalyseDamageComponent : Component
{
    [DataField]
    public EntityUid? ActionDamageArkalyseAttackEntity;

    [DataField("actionDamageArkalyseAttack", customTypeSerializer: typeof(PrototypeIdSerializer<EntityPrototype>))]
    public string ActionDamageArkalyseAttack = "ActionDamageArkalyseAttack";

    [DataField]
    public bool IsDamageAttack = false;

    [DataField]
    public DamageSpecifier Damage = new()
    {
        DamageDict = new()
        {
            { "Piercing", 20 }
        }
    };

    [DataField]
    public float PushStrength = 100f;

    [DataField]
    public float MaxPushDistance = 2f;

    [DataField]
    public bool UseDistanceScaling = true;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField, AutoNetworkedField]
    public SoundSpecifier HitSound = new SoundPathSpecifier("/Audio/Mally/sound_effects_hit_kick.ogg");
}
