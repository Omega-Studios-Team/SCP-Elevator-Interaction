using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace SCPElevatorInteraction
{
    public class EventHandler
    {
        private readonly Config _config;

        public EventHandler(Config config) => _config = config;

        public void OnInteractingElevator(InteractingElevatorEventArgs ev)
        {
            bool isBlacklisted = false;

            switch (ev.Lift.Type)
            {
                case ElevatorType.GateA:
                    isBlacklisted = _config.ScpBlacklistGateA.Contains(ev.Player.Role);
                    break;
                case ElevatorType.GateB:
                    isBlacklisted = _config.ScpBlacklistGateB.Contains(ev.Player.Role);
                    break;
                case ElevatorType.LczA:
                    isBlacklisted = _config.ScpBlacklistElevatorSystemA.Contains(ev.Player.Role);
                    break;
                case ElevatorType.LczB:
                    isBlacklisted = _config.ScpBlacklistElevatorSystemB.Contains(ev.Player.Role);
                    break;
                case ElevatorType.Scp049:
                    isBlacklisted = _config.ScpBlacklistScp049.Contains(ev.Player.Role);
                    break;
                case ElevatorType.Nuke:
                    isBlacklisted = _config.ScpBlacklistAlphaWarhead.Contains(ev.Player.Role);
                    break;
                default:
                    break;
            }

            if (isBlacklisted)
            {
                ev.IsAllowed = false; // Disallow interaction
                ev.Player.ShowHint(_config.HintMessage); // Show hint message
            }
        }
    }
}
