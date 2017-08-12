KD.Robot
===

Robot which will perform some work for You. Robots can understand programmed commands. Single Robot should be able to simulate single User behaviour.

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
process | Simulate User starting new process. | ![](https://raw.githubusercontent.com/Sejoslaw/KD.Robot/master/img/process.PNG)
tab | Simulate User switching between windows. | ![](https://raw.githubusercontent.com/Sejoslaw/KD.Robot/master/img/tab.PNG)
mouseMove | Simulate User moving mouse. | ![](https://raw.githubusercontent.com/Sejoslaw/KD.Robot/master/img/mouseMove.PNG)
mouseClick | Simulate User clicking button on mouse. (two times - optional. By default it will be single click.) | ![](https://raw.githubusercontent.com/Sejoslaw/KD.Robot/master/img/mouseClick.PNG)
type | Simulate User typing text. | ![](https://raw.githubusercontent.com/Sejoslaw/KD.Robot/master/img/type.PNG)


TODO:
---

- [ ] Save / Load written script.
- [ ] Add Plugin API and Plugin Loader for writing plugins with custom commands.
- [ ] Compilers: Windows, Linux, FreeBSD, etc.
- [ ] Console version (with options: "-f" for file, ex: -f "C:\Dev\command.txt", "-c" for command, ex: -c "process \*notepad\*;").
