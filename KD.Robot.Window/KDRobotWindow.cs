using KD.Robot.Commands;
using System.Drawing;
using System.Windows.Forms;

namespace KD.Robot.Window
{
    /// <summary>
    /// Class which holds methods connected with Windows Forms and KD.Robot
    /// </summary>
    public class KDRobotWindow
    {
        private KDRobotWindow()
        {
        }

        /// <summary>
        /// Change key word color.
        /// </summary>
        /// <param name="rtb"></param>
        public static void TextChanged(ref RichTextBox rtb, Color keyWordColor, Color originalTextColor)
        {
            rtb.SelectionColor = originalTextColor;

            foreach (ICommand command in CommandRegistry.Commands)
                ChangeKeyWord(command.GetCommandKeyWord(), keyWordColor, 0, ref rtb);
        }

        private static void ChangeKeyWord(string keyWord, Color keyWordColor, int startIndex, ref RichTextBox rtb)
        {
            if (rtb.Text.Contains(keyWord))
            {
                int index = -1;
                int selectStart = rtb.SelectionStart;

                while ((index = rtb.Text.IndexOf(keyWord, (index + 1))) != -1)
                {
                    var originalColor = rtb.SelectionColor;
                    rtb.Select((index + startIndex), keyWord.Length);
                    rtb.SelectionColor = keyWordColor;
                    rtb.Select(selectStart, 0);
                    rtb.SelectionColor = originalColor;
                }
            }
        }
    }
}