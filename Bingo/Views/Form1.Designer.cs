using System.Configuration;

namespace Bingo.Views
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_NameChurch = new System.Windows.Forms.Label();
            this.lnl_Creator = new System.Windows.Forms.LinkLabel();
            this.grb_Functions = new System.Windows.Forms.GroupBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txb_NumberInserted = new System.Windows.Forms.TextBox();
            this.lbl_B = new System.Windows.Forms.Label();
            this.lbl_I = new System.Windows.Forms.Label();
            this.lbl_N = new System.Windows.Forms.Label();
            this.lbl_G = new System.Windows.Forms.Label();
            this.lbl_O = new System.Windows.Forms.Label();
            this.ptb_Partition1 = new System.Windows.Forms.PictureBox();
            this.ptb_Partition2 = new System.Windows.Forms.PictureBox();
            this.ptb_Partition3 = new System.Windows.Forms.PictureBox();
            this.ptb_Partition4 = new System.Windows.Forms.PictureBox();
            this.grb_Functions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Partition1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Partition2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Partition3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Partition4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NameChurch
            // 
            this.lbl_NameChurch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NameChurch.AutoSize = true;
            this.lbl_NameChurch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NameChurch.Location = new System.Drawing.Point(17, 368);
            this.lbl_NameChurch.Name = "lbl_NameChurch";
            this.lbl_NameChurch.Size = new System.Drawing.Size(0, 20);
            this.lbl_NameChurch.TabIndex = 0;
            // 
            // lnl_Creator
            // 
            this.lnl_Creator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnl_Creator.AutoSize = true;
            this.lnl_Creator.Location = new System.Drawing.Point(90, 399);
            this.lnl_Creator.Name = "lnl_Creator";
            this.lnl_Creator.Size = new System.Drawing.Size(43, 20);
            this.lnl_Creator.TabIndex = 1;
            this.lnl_Creator.TabStop = true;
            this.lnl_Creator.Text = "4Dev";
            // 
            // grb_Functions
            // 
            this.grb_Functions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_Functions.Controls.Add(this.btn_Remove);
            this.grb_Functions.Controls.Add(this.lnl_Creator);
            this.grb_Functions.Controls.Add(this.btn_Restart);
            this.grb_Functions.Controls.Add(this.lbl_NameChurch);
            this.grb_Functions.Controls.Add(this.btn_Insert);
            this.grb_Functions.Controls.Add(this.txb_NumberInserted);
            this.grb_Functions.Location = new System.Drawing.Point(658, 45);
            this.grb_Functions.Name = "grb_Functions";
            this.grb_Functions.Size = new System.Drawing.Size(256, 511);
            this.grb_Functions.TabIndex = 2;
            this.grb_Functions.TabStop = false;
            this.grb_Functions.Text = "Digite a bola na caixa abaixo:";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(65, 273);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(94, 55);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Excluir";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(65, 205);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(94, 55);
            this.btn_Restart.TabIndex = 2;
            this.btn_Restart.Text = "Reiniciar";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.Btn_Restart_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(65, 147);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(94, 49);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "Inserir";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // txb_NumberInserted
            // 
            this.txb_NumberInserted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_NumberInserted.Location = new System.Drawing.Point(80, 64);
            this.txb_NumberInserted.MaxLength = 2;
            this.txb_NumberInserted.Name = "txb_NumberInserted";
            this.txb_NumberInserted.Size = new System.Drawing.Size(66, 34);
            this.txb_NumberInserted.TabIndex = 0;
            this.txb_NumberInserted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_NumberInserted.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txb_NumberInserted_KeyDown);
            this.txb_NumberInserted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txb_NumberInserted_KeyPress);
            // 
            // lbl_B
            // 
            this.lbl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_B.AutoSize = true;
            this.lbl_B.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_B.Location = new System.Drawing.Point(30, 23);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(144, 159);
            this.lbl_B.TabIndex = 3;
            this.lbl_B.Text = "B";
            // 
            // lbl_I
            // 
            this.lbl_I.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_I.AutoSize = true;
            this.lbl_I.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_I.Location = new System.Drawing.Point(165, 21);
            this.lbl_I.Name = "lbl_I";
            this.lbl_I.Size = new System.Drawing.Size(105, 159);
            this.lbl_I.TabIndex = 4;
            this.lbl_I.Text = "I";
            // 
            // lbl_N
            // 
            this.lbl_N.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_N.AutoSize = true;
            this.lbl_N.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_N.Location = new System.Drawing.Point(271, 21);
            this.lbl_N.Name = "lbl_N";
            this.lbl_N.Size = new System.Drawing.Size(162, 159);
            this.lbl_N.TabIndex = 5;
            this.lbl_N.Text = "N";
            // 
            // lbl_G
            // 
            this.lbl_G.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_G.AutoSize = true;
            this.lbl_G.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_G.Location = new System.Drawing.Point(394, 21);
            this.lbl_G.Name = "lbl_G";
            this.lbl_G.Size = new System.Drawing.Size(152, 159);
            this.lbl_G.TabIndex = 6;
            this.lbl_G.Text = "G";
            // 
            // lbl_O
            // 
            this.lbl_O.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_O.AutoSize = true;
            this.lbl_O.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_O.Location = new System.Drawing.Point(502, 21);
            this.lbl_O.Name = "lbl_O";
            this.lbl_O.Size = new System.Drawing.Size(158, 159);
            this.lbl_O.TabIndex = 7;
            this.lbl_O.Text = "O";
            // 
            // ptb_Partition1
            // 
            this.ptb_Partition1.Image = global::Bingo.Properties.Resources.Ipreto;
            this.ptb_Partition1.Location = new System.Drawing.Point(107, 159);
            this.ptb_Partition1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_Partition1.Name = "ptb_Partition1";
            this.ptb_Partition1.Size = new System.Drawing.Size(11, 425);
            this.ptb_Partition1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Partition1.TabIndex = 8;
            this.ptb_Partition1.TabStop = false;
            // 
            // ptb_Partition2
            // 
            this.ptb_Partition2.Image = global::Bingo.Properties.Resources.Ipreto;
            this.ptb_Partition2.Location = new System.Drawing.Point(413, 159);
            this.ptb_Partition2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_Partition2.Name = "ptb_Partition2";
            this.ptb_Partition2.Size = new System.Drawing.Size(11, 425);
            this.ptb_Partition2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Partition2.TabIndex = 9;
            this.ptb_Partition2.TabStop = false;
            // 
            // ptb_Partition3
            // 
            this.ptb_Partition3.Image = global::Bingo.Properties.Resources.Ipreto;
            this.ptb_Partition3.Location = new System.Drawing.Point(513, 159);
            this.ptb_Partition3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_Partition3.Name = "ptb_Partition3";
            this.ptb_Partition3.Size = new System.Drawing.Size(11, 425);
            this.ptb_Partition3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Partition3.TabIndex = 10;
            this.ptb_Partition3.TabStop = false;
            // 
            // ptb_Partition4
            // 
            this.ptb_Partition4.Image = global::Bingo.Properties.Resources.Ipreto;
            this.ptb_Partition4.Location = new System.Drawing.Point(394, 159);
            this.ptb_Partition4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_Partition4.Name = "ptb_Partition4";
            this.ptb_Partition4.Size = new System.Drawing.Size(11, 425);
            this.ptb_Partition4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Partition4.TabIndex = 11;
            this.ptb_Partition4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.grb_Functions);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.lbl_I);
            this.Controls.Add(this.lbl_N);
            this.Controls.Add(this.lbl_G);
            this.Controls.Add(this.lbl_O);
            this.Controls.Add(this.ptb_Partition1);
            this.Controls.Add(this.ptb_Partition4);
            this.Controls.Add(this.ptb_Partition2);
            this.Controls.Add(this.ptb_Partition3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bingo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb_Functions.ResumeLayout(false);
            this.grb_Functions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Partition1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Partition2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Partition3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Partition4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_NameChurch;
        private LinkLabel lnl_Creator;
        private GroupBox grb_Functions;
        private Button btn_Remove;
        private Button btn_Restart;
        private Button btn_Insert;
        private TextBox txb_NumberInserted;
        private Label lbl_B;
        private Label lbl_I;
        private Label lbl_N;
        private Label lbl_G;
        private Label lbl_O;
        private PictureBox ptb_Partition1;
        private PictureBox ptb_Partition2;
        private PictureBox ptb_Partition3;
        private PictureBox ptb_Partition4;
    }
}