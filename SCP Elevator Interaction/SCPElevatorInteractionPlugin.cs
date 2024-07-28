using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;


namespace SCPElevatorInteraction
{
    public class SCPElevatorInteractionPlugin : Plugin<Config>
    {
        public override string Author => "Lanonymous";
        public override string Name => "SCPElevatorInteraction";
        public override string Prefix => "scpelevatorinteraction";
        public override Version RequiredExiledVersion => new Version(3, 0, 0);
        public override Version Version => new Version(1, 0, 2);

        private EventHandler eventHandler;

        public override void OnEnabled()
        {
            eventHandler = new EventHandler(Config);
            Player.InteractingElevator += eventHandler.OnInteractingElevator;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.InteractingElevator -= eventHandler.OnInteractingElevator;
            eventHandler = null;

            base.OnDisabled();
        }
    }
}
