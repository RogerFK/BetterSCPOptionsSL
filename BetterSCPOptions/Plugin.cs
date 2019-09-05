using Smod2;
using Smod2.Attributes;
using Smod2.Config;
using Smod2.EventHandlers;

namespace BSCPO
{
	[PluginDetails(
		author = "RogerFK",
		name = "Better SCP Options",
		description = "Better Stuff for SCPs",
		id = "rogerfk.betterscpoptions",
		version = "1.0",
		SmodMajor = 3,
		SmodMinor = 5,
		SmodRevision = 0,
		configPrefix = "bscpo"
		)]

	public class BetterSCPPlugin : Plugin
	{
		public override void OnDisable()
		{
			Info("Disabled Better SCP Options\nYou might even DM RogerFK about why you disabled the plugin!");
		}

		public override void OnEnable()
		{
			Info("Enhaced this game");
		}
		[ConfigOption] // bscpo_healing_amount
        public readonly string[] healingAmount = new string[] { "3:6-4-8", "0:170-200", "5:120-150", "9:100-120-150", "10:100-150", "16:100-150", "17:150-200-220" };
		[ConfigOption]
		public readonly bool multiplyHealingAmount = false;
		public override void Register()
		{
            var Instance = new BetterSCPEvents(this);
			AddEventHandler(typeof(IEventHandlerSetConfig), Instance, Smod2.Events.Priority.Low);
			AddEventHandler(typeof(IEventHandlerPlayerHurt), Instance);
			AddEventHandler(typeof(IEventHandlerPlayerDie), Instance);
			AddEventHandler(typeof(IEventHandlerWaitingForPlayers), Instance);
		}
	}
}