using EXILED;
using System;

namespace SCPBHP
{
	public class BetterHPPlugin : Plugin
	{
		BetterHP evs;
		public override void OnDisable()
		{
			Events.WaitingForPlayersEvent -= evs.WaitingForPlayers;
			Events.PlayerDeathEvent -= evs.PlayerKill;
		}

		public override void OnEnable()
		{
			evs = new BetterHP();
			BetterHP.hpLoaded = false;
			Events.WaitingForPlayersEvent += evs.WaitingForPlayers;
			Events.PlayerDeathEvent += evs.PlayerKill;
		}

		public const string Version = "1.0.0";

		public override string getName => $"BetterHP{Version}";

		public override void OnReload(){}
	}
}