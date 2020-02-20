using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXILED;

namespace SCPBHP
{
	public static class Configs
	{
		internal static Dictionary<RoleType, int> scpRoleTypes = new Dictionary<RoleType, int> {
			{  RoleType.Scp049, 0 },
			{  RoleType.Scp0492, 0 },
			{  RoleType.Scp079, 0 },
			{  RoleType.Scp096, 0 },
			{  RoleType.Scp106, 0 },
			{  RoleType.Scp173, 0 },
			{  RoleType.Scp93953, 0 },
			{  RoleType.Scp93989, 0 }
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
				Plugin.Info("how the fuck does this game even work wtf is this shit");
				return;
			}
			foreach(var role in ccm.Classes)
			{
				if(scpRoleTypes.ContainsKey(role.roleId))
				{
					string roleName = role.roleId.ToString();
					int hp = Plugin.Config.GetInt(roleName + "_hp");
					Plugin.Debug($"Read {roleName}_hp as: {hp}");
					if (hp > 0)
					{
						Plugin.Debug($"Changed {roleName}_hp from {role.maxHP} to: {hp}");
						role.maxHP = hp;
					}
					scpRoleTypes[role.roleId] = Plugin.Config.GetInt(roleName + "_heal");
					Plugin.Debug($"Read {roleName}_heal as: {scpRoleTypes[role.roleId]}");
				}
			}
			CharacterClassManager._staticClasses = ccm.Classes;
		}
	}
}
