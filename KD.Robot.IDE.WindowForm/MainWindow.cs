using KD.Robot.Window;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KD.Robot.IDE.WindowForm
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B_Execute_Click(object sender, EventArgs e)
        {
            // All lines from RichTextBox
            string commands = RTB_Commands.Text;

            // Execute commands on new KDRobot instance.
            // Calling new Robot should be as simple as possible.
            KDRobotManager.NewRobot().Execute(commands);
        }

        private void RTB_Commands_TextChanged(object sender, EventArgs e)
        {
            KDRobotWindow.TextChanged(ref RTB_Commands, Color.Blue);
        }
    }
}