
using Bingo.Utils;

namespace Bingo.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            ValidateAppSettings.ValidateChurchName();

        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {

            int number = Convert.ToInt32(txb_NumberInserted.Text);

            if( number >= 1 && number <= 75)
            {

                ViewInsertedNumber viewInsertedNumber = new(ConvertNumber.ConvertToView(number));

                viewInsertedNumber.ShowDialog();

            }
            else
            {
                MessageBox.Show("Número fora do padrão exigido!", "Bingo", MessageBoxButtons.OK);
            }

        }

        private void Txb_NumberInserted_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }
    }
}