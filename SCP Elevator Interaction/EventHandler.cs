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
            if ((ev.Lift.Type == ElevatorType.GateA && _config.ScpAllowedGateA.Contains(ev.Player.Role)) ||
                (ev.Lift.Type == ElevatorType.GateB && _config.ScpAllowedGateB.Contains(ev.Player.Role)))
            {
                return; // Allow interaction if SCP is authorized
            }

            ev.IsAllowed = false; // Disallow interaction
            ev.Player.ShowHint(_config.HintMessage); // Show hint message
        }
    }
}
