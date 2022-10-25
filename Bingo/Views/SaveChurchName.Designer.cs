namespace Bingo.Views
{
    partial class SaveChurchName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_NameChurch = new System.Windows.Forms.Label();
            this.txb_NameChurch = new System.Windows.Forms.TextBox();
            this.btn_SaveNameChurch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_NameChurch
            // 
            this.lbl_NameChurch.AutoSize = true;
            this.lbl_NameChurch.Location = new System.Drawing.Point(90, 71);
            this.lbl_NameChurch.Name = "lbl_NameChurch";
            this.lbl_NameChurch.Size = new System.Drawing.Size(92, 20);
            this.lbl_NameChurch.TabIndex = 0;
            this.lbl_NameChurch.Text = "Nome Igreja";
            // 
            // txb_NameChurch
            // 
            this.txb_NameChurch.Location = new System.Drawing.Point(56, 106);
            this.txb_NameChurch.Name = "txb_NameChurch";
            this.txb_NameChurch.Size = new System.Drawing.Size(125, 27);
            this.txb_NameChurch.TabIndex = 1;
            // 
            // btn_SaveNameChurch
            // 
            this.btn_SaveNameChurch.Location = new System.Drawing.Point(71, 155);
            this.btn_SaveNameChurch.Name = "btn_SaveNameChurch";
            this.btn_SaveNameChurch.Size = new System.Drawing.Size(111, 29);
            this.btn_SaveNameChurch.TabIndex = 2;
            this.btn_SaveNameChurch.Text = "Salvar Nome";
            this.btn_SaveNameChurch.UseVisualStyleBackColor = true;
            this.btn_SaveNameChurch.Click += new System.EventHandler(this.Btn_SaveNameChurch_Click);
            // 
            // SaveChurchName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 272);
            this.Controls.Add(this.btn_SaveNameChurch);
            this.Controls.Add(this.txb_NameChurch);
            this.Controls.Add(this.lbl_NameChurch);
            this.Name = "SaveChurchName";
            this.Text = "Nome Igreja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_NameChurch;
        private TextBox txb_NameChurch;
        private Button btn_SaveNameChurch;
    }
}