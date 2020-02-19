using EXILED;

namespace BSCPO
{

	public class BetterHPPlugin : Plugin
	{
		BetterHP events;
		public override void OnDisable()
		{
			Info("Disabled Better SCP Options\nYou might even DM RogerFK about why you disabled the plugin!");
		}

		public override void OnEnable()
		{
			events = new BetterHP();
			Info("Enhaced this game");
		}
		public const string Version = "1.0.0";

		public override string getName => $"BetterHP{Version}";

		public override void OnReload(){}
	}
}