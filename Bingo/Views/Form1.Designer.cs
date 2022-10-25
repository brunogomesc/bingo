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
            this.btn_Adjust = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txb_NumberInserted = new System.Windows.Forms.TextBox();
            this.grb_Functions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NameChurch
            // 
            this.lbl_NameChurch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NameChurch.AutoSize = true;
            this.lbl_NameChurch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NameChurch.Location = new System.Drawing.Point(657, 514);
            this.lbl_NameChurch.Name = "lbl_NameChurch";
            this.lbl_NameChurch.Size = new System.Drawing.Size(79, 20);
            this.lbl_NameChurch.TabIndex = 0;
            this.lbl_NameChurch.Text = "Paróquia: " + ConfigurationManager.AppSettings.Get("nameChurch");
            // 
            // lnl_Creator
            // 
            this.lnl_Creator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnl_Creator.AutoSize = true;
            this.lnl_Creator.Location = new System.Drawing.Point(849, 562);
            this.lnl_Creator.Name = "lnl_Creator";
            this.lnl_Creator.Size = new System.Drawing.Size(43, 20);
            this.lnl_Creator.TabIndex = 1;
            this.lnl_Creator.TabStop = true;
            this.lnl_Creator.Text = "4Dev";
            // 
            // grb_Functions
            // 
            this.grb_Functions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_Functions.Controls.Add(this.btn_Adjust);
            this.grb_Functions.Controls.Add(this.btn_Restart);
            this.grb_Functions.Controls.Add(this.btn_Insert);
            this.grb_Functions.Controls.Add(this.txb_NumberInserted);
            this.grb_Functions.Location = new System.Drawing.Point(747, 12);
            this.grb_Functions.Name = "grb_Functions";
            this.grb_Functions.Size = new System.Drawing.Size(167, 441);
            this.grb_Functions.TabIndex = 2;
            this.grb_Functions.TabStop = false;
            this.grb_Functions.Text = "Digite a bola na caixa abaixo:";
            // 
            // btn_Adjust
            // 
            this.btn_Adjust.Location = new System.Drawing.Point(20, 259);
            this.btn_Adjust.Name = "btn_Adjust";
            this.btn_Adjust.Size = new System.Drawing.Size(94, 29);
            this.btn_Adjust.TabIndex = 3;
            this.btn_Adjust.Text = "Ajustar";
            this.btn_Adjust.UseVisualStyleBackColor = true;
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(20, 200);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(94, 29);
            this.btn_Restart.TabIndex = 2;
            this.btn_Restart.Text = "Reiniciar";
            this.btn_Restart.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(20, 140);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(94, 29);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "Inserir";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // txb_NumberInserted
            // 
            this.txb_NumberInserted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_NumberInserted.Location = new System.Drawing.Point(38, 82);
            this.txb_NumberInserted.MaxLength = 2;
            this.txb_NumberInserted.Name = "txb_NumberInserted";
            this.txb_NumberInserted.Size = new System.Drawing.Size(55, 34);
            this.txb_NumberInserted.TabIndex = 0;
            this.txb_NumberInserted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_NumberInserted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txb_NumberInserted_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.grb_Functions);
            this.Controls.Add(this.lnl_Creator);
            this.Controls.Add(this.lbl_NameChurch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bingo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grb_Functions.ResumeLayout(false);
            this.grb_Functions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_NameChurch;
        private LinkLabel lnl_Creator;
        private GroupBox grb_Functions;
        private Button btn_Adjust;
        private Button btn_Restart;
        private Button btn_Insert;
        private TextBox txb_NumberInserted;
    }
}