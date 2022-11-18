using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo.Views
{
    public partial class ViewInsertedNumber : Form
    {
        public ViewInsertedNumber(string number)
        {
            InitializeComponent();
            this.lbl_Number.Text = number;
        }

        private void ViewInsertedNumber_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue.Equals(27)) this.Close();

        }
    }
}
