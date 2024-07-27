<h1 align="center">SCPElevatorInteraction - S.E.I</h1>

<br>

<div align="center">
<img alt="GitHub Tag" src="https://img.shields.io/github/v/tag/RLLanonymous/SCP-Elevator-Interaction?sort=date&style=for-the-badge&logo=GitBook&logoSize=auto&label=Release">
<img alt="GitHub Downloads (all assets, all releases)" src="https://img.shields.io/github/downloads/RLLanonymous/SCP-Elevator-Interaction/total?style=for-the-badge&logo=Github&logoSize=auto&color=%230a912e&link=https%3A%2F%2Fgithub.com%2FRLLanonymous%2FSCP-Elevator-Interaction%2Freleases">
<img alt="Static Badge" src="https://img.shields.io/badge/Exiled%20Version-Reboot%3A_8.9.11-blue?style=for-the-badge&logo=Framework&logoSize=auto">

</div>

<br>

S.E.I is an Exiled Reboot: 8.9.11 plugin. With this plugin you can manage wich SCP can interact with wich Elevator.
You can also manage the Hint display if a SCP can't interact with an elevator.

<h1 align="center">S.E.I - Installation</h1>

To get started, find the Exiled plugin folder. It is normally located here: ``C:\Users\%UserName%\AppData\Roaming\EXILED\Plugins`` then put the .dll into the plugin folder and run the ``restart`` command in the server's terminal. After this the plugin should be successfully installed.

<h1 align="center">S.E.I - Configuration</h1>

To modify the plugin config, start by locating your config folder. It should be found here: ``C:\Users\%UserName%\AppData\Roaming\EXILED\Configs`` then search the ``xxxx-config.yml`` **(xxxx stands for the port of the server)**.
Then run it with a text editor (Notepad should work but i recommend you VsCode or ~~Atom~~ :trollface:). 

### The Config : 
```yml
scpelevatorinteraction:
  is_enabled: true
  debug: false
  # List of SCPs that are blacklisted from using Gate A elevators.
  scp_blacklist_gate_a:
  - Scp0492
  - Scp173
  - Scp939
  - Scp096
  # List of SCPs that are blacklisted from using Gate B elevators.
  scp_blacklist_gate_b:
  - Scp0492
  - Scp173
  - Scp939
  - Scp096
  # List of SCPs that are blacklisted from using Elevator System A.
  scp_blacklist_elevator_system_a:
  - Scp0492
  - Scp173
  - Scp939
  - Scp096
  # List of SCPs that are blacklisted from using Elevator System B.
  scp_blacklist_elevator_system_b:
  - Scp0492
  - Scp096
  # List of SCPs that are blacklisted from using SCP-049's elevator.
  scp_blacklist_scp049: 
  - Scp096
  # List of SCPs that are blacklisted from using the Alpha Warhead elevator.
  scp_blacklist_alpha_warhead:
  - Scp0492
  # The duration of the hint message displayed to players.
  hint_duration: 5
  # The message displayed to players when they are not allowed to use an elevator.
  hint_message: 'Vous ne pouvez pas prendre cet ascenseur !'
  # Whether to use hint messages (true) or broadcast messages (false).
  use_hint: true
```

- The ``is_enabled`` tells to exiled if the plugin should be load or not.
- The ``Debug`` shouldn't be usefull for you.
- The ``scp_blacklist_gate_a:`` is a list, wich mean you can add or remove SCPs that must be blacklist from the GateA elevator.
- The ``scp_blacklist_gate_b:`` is a list, wich mean you can add or remove SCPs that must be blacklist from the GateB elevator.
- The ``scp_blacklist_elevator_system_a:`` is a list, wich mean you can add or remove SCPs that must be blacklist from the LczA elevator.
- The ``scp_blacklist_elevator_system_b:`` is a list, wich mean you can add or remove SCPs that must be blacklist from the LczB elevator.
- The ``scp_blacklist_scp049:`` is a list, wich mean you can add or remove SCPs that must be blacklist from the 049 elevator.
- The ``scp_blacklist_alpha_warhead:`` is a list, wich mean you can add or remove SCPs that must be blacklist from the Nuke elevator.
- The ``hint_message`` is the text display when a blacklist SCP try to interact with is blacklist elevator.
- The ``hint_duration`` is the duration of the text display when a blacklist SCP try to interact with is blacklist elevator (in seconds).
- The ``use_hint`` tells to use hint if its set on true or use broadcast if its set on false.

### List of Blacklistable SCPs : 

```yml
- Scp173
- Scp3114
- Scp049
- Scp0492
- Scp096
- Scp939
- Scp106
```
Now you are ready to bully SCPs :trollface:



