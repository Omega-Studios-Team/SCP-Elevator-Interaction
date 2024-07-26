<h1 align="center">SCPElevatorInteraction - S.E.I</h1>
S.E.I is an Exiled Reboot: 8.9.11 plugin. With this plugin you can manage wich SCP can interact with wich Elevator.
You can also manage the Hint display if a SCP can't interact with an elevator.

<h1 align="center">S.E.I - Installation</h1>

To get started, find the Exiled plugin folder. It is normally located here: ``C:\Users\%UserName%\AppData\Roaming\EXILED\Plugins`` then put the .dll into the plugin folder and run the ``restart`` command in the server's terminal. After this the plugin should be successfully installed.

<h1 align="center">S.E.I - Configuration</h1>

```yml
scpelevatorinteraction:
  is_enabled: true
  debug: false
  scp_blacklist_gate_a:
  - Scp049
  - Scp096
  scp_blacklist_gate_b:
  - Scp173
  - Scp106
  - Scp049
  scp_blacklist_elevator_system_a:
  - Scp939
  scp_blacklist_elevator_system_b: 
  - Scp3114
  scp_blacklist_scp049:
  - Scp049
  scp_blacklist_alpha_warhead:
  - Scp106
  hint_message: 'You can't use this elevator !'
```
