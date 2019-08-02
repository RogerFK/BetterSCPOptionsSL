# Better SCP Options
Better SCP Options for SCP:SL. Looks weird from spectator tho and will probably work weird when doing events.

# Configs and usage
Basically **every single max HP** for SCPs (except SCP-106) are turnt into **multipliers to their damage** instead of just raising his HP over the 100% bar in the client. This means that SCP-173's speed and SCP-049's revive speed are "correctly" synced between the client and the server. This fixes SCP-173 getting kicked or SCP-049 not reviving zombies which not only is frustrating, but it's complete bullshit.

This also means that in the client, your 100% value is the same as theirs. Say goodbye to SCP-173 getting kicked by anticheat, and goodbye to getting shot and seeing your health doesn't go below 100% for a few shots. That looks like absolute dogshit.

### The configs you use to change their max HP are the same as Smod2 wiki uses. "scp049_hp", "scp049-2_hp", "scp079_hp", "scp096_hp", "scp173_hp", "scp939_53_hp", "scp939_89_hp". This is to be consistent with other plugins that change the configs, let's say a gamemode. That means that it may or may not conflict with other plugins, for better or for worse.

| Config Option | Value Type | Default Value | Description |
|:-----------------------------:|:--------------:|:--------------------------------------------------------------------------------------------------:|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------:|
| bscpo_healing_amount | int Dictionary | 3:6-4-8, 0:170-200, 5:120-150, 9:100-120-150, 10:100-150, 16:100-150, 17:150-200-220 | Grants them HP after every kill. Better than fucking sitting on a fucking corner for 15 minutes, making the game even more boring for literally everyone including them.  Works as follow: ROLEID:HealingAmount1-HealingAmount2... To disable it, just set this config to -1 |
| bscpo_multiply_healing_amount | bool | false | If the healing amount should also be multiplied as if it was the damage. A.k.a. if you tell the plugin SCP-173 has double it's health, he will cure half of your config input |


I still ask myself why nobody did anything remotely close to this, I know this is the easiest way to do so I was expecting this, at least.
