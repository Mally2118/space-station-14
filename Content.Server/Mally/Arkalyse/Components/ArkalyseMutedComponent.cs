using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Mally.Arkalyse.Components;

[RegisterComponent]
public sealed partial class ArkalyseMutedComponent : Component
{
    [DataField]
    public float TimeMuted = 10.0f;

    [DataField]
    public float TimeSuffocation = 7.0f;

    [DataField]
    public EntityUid? ActionMutedArkalyseAttackEntity;

    [DataField("actionMutedArkalyseAttack", customTypeSerializer: typeof(PrototypeIdSerializer<EntityPrototype>))]
    public string ActionMutedArkalyseAttack = "ActionMutedArkalyseAttack";

    [DataField]
    public bool IsMutedAttack = false;
}
