KD.Robot
===

|Build|
|-----|
|[![Build status](https://ci.appveyor.com/api/projects/status/github/Sejoslaw/KD.Robot?svg=true)](https://ci.appveyor.com/api/projects/status/github/Sejoslaw/KD.Robot?svg=true)|

Robot which will perform some work for You. Robots can understand programmed commands. Single Robot should be able to simulate single User behaviour. Currently this project use some basic IDE written in Windows Forms with basic syntax highlighting. IDE as well as Robot behaviours should be platform-independent and should work in the same way on every platform.

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
process \*ProcessName\*; | Simulate User starting new process. | ![](https://raw.githubusercontent.com/Sejoslaw/KD.Robot/master/img/process.PNG)
tab \*WindowName\*; | Simulate User switching between windows. | ![](https://raw.githubusercontent.com/Sejoslaw/KD.Robot/master/img/tab.PNG)
mouseMove posX posY | Simulate User moving mouse. | ![](https://raw.githubusercontent.com/Sejoslaw/KD.Robot/master/img/mouseMove.PNG)
mouseClick \[L-Left\|M-Middle\|R-Right\] [number of clicks - optional] | Simulate User clicking button on mouse. (two times - optional. By default it will be single click.) | ![](https://raw.githubusercontent.com/Sejoslaw/KD.Robot/master/img/mouseClick.PNG)
type Some random text to type by Robot.; | Simulate User typing text. | ![](https://raw.githubusercontent.com/Sejoslaw/KD.Robot/master/img/type.PNG)


TODO:
---

- [ ] Save / Load written script.
- [x] Add Plugin API and Plugin Loader for writing plugins with custom commands. (Add .dll file to "plugins" folder next to Robot IDE exe file).
- [ ] Compilers: Windows, Linux, FreeBSD, etc.
- [ ] Console version (with options: "-f" for file, ex: -f "C:\Dev\command.txt", "-c" for command, ex: -c "process \*notepad\*;").
