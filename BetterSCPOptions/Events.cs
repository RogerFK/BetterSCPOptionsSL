using EXILED;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCPBHP
{
	public class BetterHP
	{
		internal static bool hpLoaded;
		internal void WaitingForPlayers()
		{
			if (!hpLoaded)
			{
				Configs.ReloadConfigs();
				hpLoaded = true;
			}
		}

		internal void PlayerKill(ref PlayerDeathEvent ev)
		{
			if (!ev.Killer.characterClassManager.IsAnyScp()) return;
			try 
			{
				var FuckYourProperties = ev.Killer;
				FuckYourProperties.playerStats.HealHPAmount(Configs.scpRoleTypes[FuckYourProperties.characterClassManager.CurClass]);
			}
			catch {
				Plugin.Debug($"{ev.Killer.characterClassManager.CurClass} not implemented");
			}	
		}
	}
}

