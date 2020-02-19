using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXILED;

namespace BetterSCPOptions
{
	public static class Configs
	{
		public static uint scp173heal;
		public static uint scp106heal;
		public static uint scp049heal;
		public static uint scp079heal;
		public static uint scp096heal;
		public static uint scp0492heal;
		public static uint scp93953heal;
		public static uint scp93989heal;

		public static HashSet<RoleType> scpRoleTypes = new HashSet<RoleType> {
			RoleType.Scp049,
			RoleType.Scp0492,
			RoleType.Scp079,
			RoleType.Scp096,
			RoleType.Scp106,
			RoleType.Scp173,
			RoleType.Scp93953,
			RoleType.Scp93989
		};
		public static void ReloadConfigs()
		{
			// 0 will not switch the HP btw
			var ccm = PlayerManager.localPlayer.GetComponent<CharacterClassManager>();
			if (ccm.Classes == null && CharacterClassManager._staticClasses != null)
			{
				ccm.Classes = CharacterClassManager._staticClasses;
			}
			else if (CharacterClassManager._staticClasses == null)
			{
				Plugin.Info("Where does this game get the info from????");
				return;
			}
			else if(ccm.Classes.Length == 0 && CharacterClassManager._staticClasses.Length > 0) 
			{
				ccm.Classes = CharacterClassManager._staticClasses;
			}
			else 
			{
				Plugin.Info("how the fuck does this game even work wtf fuck this shit");
				return;
			}
			foreach(var role in ccm.Classes)
			{
				if(scpRoleTypes.Contains(role.roleId))
				{
					int hp = Plugin.Config.GetInt(role.roleId.ToString() + "_hp");
					if (hp > 0)
					{
						role.maxHP = hp;
					}
					switch(role.roleId)
					{
							RoleType.Scp049,
			RoleType.Scp0492,
			RoleType.Scp079,
			RoleType.Scp096,
			RoleType.Scp106,
			RoleType.Scp173,
			RoleType.Scp93953,
			RoleType.Scp93989
					}
				}
			}
			CharacterClassManager._staticClasses = ccm.Classes;
		}
	}
}
