using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Utils
{
    public class FormatMessageBox
    {

        public static DialogResult FormatMessage(string message)
        {

            return MessageBox.Show(message, "Bingo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        public static void FormatMessage(string message, MessageBoxButtons typeButton)
        {

            MessageBox.Show(message,"Bingo", typeButton);

        }

        public static void FormatMessage(string message, MessageBoxButtons typeButton, MessageBoxIcon typeIcon)
        {

            MessageBox.Show(message, "Bingo", typeButton, typeIcon);

        }

        public static void FormatMessage(string message, MessageBoxButtons typeButton, MessageBoxIcon typeIcon, MessageBoxDefaultButton typeDefaultButton)
        {

            MessageBox.Show(message, "Bingo", typeButton, typeIcon, typeDefaultButton);

        }

        public static void FormatMessage(string message, MessageBoxButtons typeButton, MessageBoxIcon typeIcon, MessageBoxDefaultButton typeDefaultButton, MessageBoxOptions typeOptions)
        {

            MessageBox.Show(message, "Bingo", typeButton, typeIcon, typeDefaultButton, typeOptions);

        }

    }
}
