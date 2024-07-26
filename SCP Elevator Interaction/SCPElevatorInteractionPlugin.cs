using Exiled.API.Features;
using System;

namespace SCPElevatorInteraction
{
    public class SCPElevatorInteractionPlugin : Plugin<Config>
    {
        public override string Name => "SCPElevatorInteraction";
        public override string Author => "Lanonymous";
        public override Version Version => new Version(1, 0, 0);
        public override string Prefix => "scpelevatorinteraction";

        public EventHandler EventHandler { get; private set; }

        public override void OnEnabled()
        {
            EventHandler = new EventHandler(Config);
            Exiled.Events.Handlers.Player.InteractingElevator += EventHandler.OnInteractingElevator;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.InteractingElevator -= EventHandler.OnInteractingElevator;
            EventHandler = null;
            base.OnDisabled();
        }
    }
}
