KD.Robot
===

Robot which will perform some work for You.

Projects:
---

Project Name | Description
-------------|-------------
**[KD.Robot](KD.Robot)** | Main project
**[KD.Robot.IDE.WindowForm](KD.Robot.IDE.WindowForm)** | IDE made in Windows Forms


Currently implemented commands:
---

Command | Description | Example
--------|-------------|---------
process | Simulate User opening new file. | process \*notepad\*;
tab | Simulate User switching between windows. | tab \*WindowName\*;
mouseMove | Simulate User moving mouse. | mouseMove 100 200
mouseClick | Simulate User clicking button on mouse. | mouseClick L 2
type | Simulate User typing text. | type Hello World.;


TODO:
---

- [ ] Save / Load written script.
- [ ] Add Plugin API and Plugin Loader for writing plugins with custom commands.
- [ ] Compilers: Windows, Linux, FreeBSD, etc.
- [ ] Console version (with options: "-f" for file, ex: -f "C:\Dev\command.txt", "-c" for command, ex: -c "process *notepad*;").
