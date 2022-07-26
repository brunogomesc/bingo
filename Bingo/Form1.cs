

namespace Bingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            ValidateAppSettings validateAppSettings = new ValidateAppSettings();

            validateAppSettings.ValidateChurchName();

        }

    }
}