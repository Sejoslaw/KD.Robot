KD.Robot
===

Robot which will perform some work for You in background.

Projects:
---

Project Name | Description
-------------|-------------
**[KD.Robot](KD.Robot)** | Main project
**[KD.Robot.IDE.WindowForm](KD.Robot.IDE.WindowForm)** | IDE made in Windows Forms

Tasks:
---

1. Implement simple commands:
- [x] 	1.1. process - starts new process, ex: process *notepad*;
- [ ] 	1.2. text - represents Typing a text, ex: text "Hejo";
- [x] 	1.3. mouseClick - represents Mouse Click, ex: mouseClick L -> it will perform single Left Mouse Button Click. mouseClick L 2 -> it will perform double click (2 clicks) with Left Mouse Button.
- [ ] 	1.4. tab - switch between windows with Alt+Tab, ex: (tab 2) / (tab "Untitled - Notepad")
- [ ] 	1.5. shortcut - use custom shortcut, ex: shortcut "ctrl+c"

- [ ] 2. Save / Load script file

- [ ] 3. Add Plugin API and Plugin Loader for writing plugins with custom commands

4. Add compilers for:
- [ ] 	4.1. Windows (to exe)
- [ ] 	4.2. Linux
- [ ] 	4.3. etc.

5. Add Console version of the Robot with options:
- [ ] 	5.1. "-f" for file, ex: -f "C:\Dev\command.txt"
- [ ] 	5.2. "-c" for command, ex: -c "process *notepad*;"
