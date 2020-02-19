# SCP Better HP
SCP Better HP for SCP:SL. Looks weird from spectator tho and will probably work weird when doing events.

# Read everything here before asking a question, or you'll be ignored
### I'm just not going to answer stuff that's here on Discord. **I'll literally ignore you**, not even tell you to read the GitHub.
### Also, don't ask about the camping mechanic to get HP. I will never add it, since it was the worst mechanic SMod2 ever introduced.

# Configs and usage
Basically **every single max HP** for SCPs **(except SCP-106)** are turnt into **multipliers to their damage instead of just raising his HP over the 100% bar in the client.** This means that SCP-173's speed and SCP-049's revive speed are "correctly" synced between the client and the server. This fixes SCP-173's speed when you don't have normal HP, SCP-049 not reviving zombies and others which not only is frustrating, but it's complete bullshit.

### But Roger, I don't understand basic math because I'm a 10 year old kid.
First, delete your server. Second:
this means that in the client, **your 100% value is the same as the server's**. Say goodbye to SCP-173 getting kicked by anticheat, and goodbye to getting shot and not seeing your health go below 100% for a few shots. That looks like absolute dogshit.

| Config Option | Format | Default Value | Description |
|:--:|:--:|:-:|:-----------:|
|`scp_XXX_hp`| Number | *depends* | The max HP for SCP-XXX HP. **It will overwrite the maxHP from the main game. Scroll down for more info.** |
|`scp_XXX_heal`| Min-Max | *depends*-*depends* | How much HP they'll get **after every kill.** |
