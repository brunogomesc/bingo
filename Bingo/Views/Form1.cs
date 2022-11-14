
using Bingo.Utils;
using System.Configuration;
using System.Windows;
using System.Windows.Forms;
using System.Collections.Generic;
using Bingo.Session;
using System.ComponentModel;

namespace Bingo.Views
{
    public partial class Form1 : Form
    {
        #region Componention Declaration
        private Label newComponent;
        private int[] BallsDrawn = new int[75];
        private int count = 0;
        private Control[] labels = new Control[75];
        #endregion

        public Form1()
        {

            InitializeComponent();

            this.newComponent = new();

            //Seta os valores da Session
            GetPosition.SetValuesInitialSession();
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {

            try
            {

                int number = Convert.ToInt32(txb_NumberInserted.Text);

                if (number > 0 && number < 76)
                {

                    if (InsertDrawnNumber(number))
                    {

                        ViewInsertedNumber viewInsertedNumber = new(ConvertNumber.ConvertToView(number));

                        viewInsertedNumber.ShowDialog();

                        GenerateNewNumberComponent(number);

                        UpdateNextPositions(ConvertNumber.ConvertToView(number), number);

                        ClearBallField();

                    }

                }
                else
                {
                    FormatMessageBox.FormatMessage("Número fora do padrão exigido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (FormatException)
            {

                FormatMessageBox.FormatMessage("Por favor insira algum número antes de enviar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void Txb_NumberInserted_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void Txb_NumberInserted_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) Btn_Insert_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResizeFormInitialStateLoadComponents();
        }

        private void ResizeFormInitialStateLoadComponents()
        {
            //Ajuste letra B
            lbl_B.Location = new Point(30, 30);

            //Ajuste Letra I
            lbl_I.Location = new Point(350, 30);

            //Ajuste Letra N
            lbl_N.Location = new Point(670, 30);

            //Ajuste Letra G
            lbl_G.Location = new Point(1040, 30);

            //Ajuste Letra O
            lbl_O.Location = new Point(1400, 30);



            //Reposiciona as divisórias
            ptb_Partition1.Location = new Point(255, 150);

            ptb_Partition2.Location = new Point(565, 150);

            ptb_Partition3.Location = new Point(910, 150);

            ptb_Partition4.Location = new Point(1260, 150);


            //Aumenta o tamanho das divisórias
            ptb_Partition1.Size = new Size(10, (Screen.PrimaryScreen.Bounds.Height - 100));

            ptb_Partition2.Size = new Size(10, (Screen.PrimaryScreen.Bounds.Height - 100));

            ptb_Partition3.Size = new Size(10, (Screen.PrimaryScreen.Bounds.Height - 100));

            ptb_Partition4.Size = new Size(10, (Screen.PrimaryScreen.Bounds.Height - 100));


            //Ajusta GroupBox
            grb_Functions.Size = new Size(250, Screen.PrimaryScreen.Bounds.Height - 50);
            grb_Functions.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 250, 34);
            grb_Functions.Padding = new Padding(3, 2, 3, 2);

            //Captura o nome da Igreja
            if (ValidateAppSettings.ValidateChurchName()) lbl_NameChurch.Text = ConfigurationManager.AppSettings.Get("nameChurch");

        }

        private void ClearBallField()
        {

            this.txb_NumberInserted.Text = "";
            this.txb_NumberInserted.Focus();

        }

        private bool InsertDrawnNumber(int number)
        {

            bool validEntry = true;

            for(int i = 0; i < count; i++)
            {
                if (BallsDrawn[i] == number && validEntry)
                {
                    FormatMessageBox.FormatMessage("Por favor insira um número que não foi sorteado ainda!",MessageBoxButtons.OK);
                    validEntry = false;
                    break;
                }
            }

            if(validEntry)
            {

                Session.Session.Instance.CurrentBall = number;
                this.BallsDrawn[count] = number;
                this.count++;

            }

            return validEntry;

        }

        private void GenerateNewNumberComponent(int number)
        {

            string nameComponent = "lbl_" + number.ToString();

            this.newComponent = new Label();
            SuspendLayout();
            this.newComponent.Font = new Font("Segoe UI", 56F, FontStyle.Bold, GraphicsUnit.Point);
            this.newComponent.Location = new Point(GetPosition.GetPositionX(number), GetPosition.GetPositionY(number));
            this.newComponent.Name = nameComponent;
            this.newComponent.Size = new Size(130, 100);
            this.newComponent.TabIndex = 0;
            this.newComponent.Text = number.ToString();
            this.Controls.Add(this.newComponent);
            this.ResumeLayout(false);

        } 

        private static void UpdateNextPositions(string drawnBall, int number) {

            if (Screen.PrimaryScreen.Bounds.Height < (GetPosition.GetPositionY(number) + 300)) CalculatePosition.CalculatePositionX(drawnBall);
            else CalculatePosition.CalculatePositionY(drawnBall);
        
        }

        private void Btn_Restart_Click(object sender, EventArgs e)
        {
            if (this.BallsDrawn[0] > 0)
            {
                DialogResult result = FormatMessageBox.FormatMessage("Deseja mesmo reiniciar o jogo?");
                if(result == DialogResult.Yes)
                {

                    DropComponents();
                    GetPosition.SetValuesInitialSession();
                    SetInitialValuesBalls();
                    this.txb_NumberInserted.Focus();

                }
            }
            else
            {
                FormatMessageBox.FormatMessage("Não é possivel reiniciar sem ter inserido nenhuma bola!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DropComponents()
        {
            int count = 0;

            foreach (Control control in this.Controls)
            {

                if (!control.Text.Contains('B') && !control.Text.Contains('I') && !control.Text.Contains('N') && !control.Text.Contains('G') && !control.Text.Contains('O') && control is Label)
                {
                    this.labels[count] = control;
                    count++;
                }

            }

            foreach(Control control in this.labels)
            {
                if(control == null) break;

                this.Controls.Remove(control);
                control.Dispose();
            }

        }

        private void SetInitialValuesBalls()
        {

            for(int i=0; i < count; i++)
            {
                this.BallsDrawn[i] = 0;
            }

            this.count = 0;

        }
    }
}