using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared.DeadSpace.ReviveImplant;

[Serializable, NetSerializable]
public sealed partial class ReviveImplantActivateEvent : SimpleDoAfterEvent
{

}
