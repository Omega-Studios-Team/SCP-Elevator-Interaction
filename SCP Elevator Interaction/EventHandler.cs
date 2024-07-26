using Exiled.API.Enums;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace SCPElevatorInteraction
{
    public class EventHandler
    {
        private readonly Config config;

        public EventHandler(Config config)
        {
            this.config = config;
        }

        public void OnInteractingElevator(InteractingElevatorEventArgs ev)
        {
            if (ev.Lift.Type == ElevatorType.GateA || ev.Lift.Type == ElevatorType.GateB)
            {
                RoleTypeId scpRole = ev.Player.Role;

                bool is096InRage = scpRole == RoleTypeId.Scp096 && ev.Player.GetScp096().IsEnraged;

                if (is096InRage ||
                    (ev.Lift.Type == ElevatorType.GateA && config.ScpAllowedGateA.Contains(scpRole)) ||
                    (ev.Lift.Type == ElevatorType.GateB && config.ScpAllowedGateB.Contains(scpRole)))
                {
                    if (is096InRage)
                    {
                        ev.Player.ShowHint(config.HintMessage096Rage);
                    }
                    return;
                }

                ev.IsAllowed = false;
                ev.Player.ShowHint(config.HintMessage);
            }
        }
    }
}
