namespace GyumolcsokGyak
{
    partial class GyumcsokGUI
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
            this.GyumolcsokList = new System.Windows.Forms.ListBox();
            this.GyumolcsokBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.GyumolcsNevText = new System.Windows.Forms.TextBox();
            this.MennyisegNumUp = new System.Windows.Forms.NumericUpDown();
            this.EgysegArNumUp = new System.Windows.Forms.NumericUpDown();
            this.KivalasztButton = new System.Windows.Forms.Button();
            this.LetrehozButton = new System.Windows.Forms.Button();
            this.ModositButton = new System.Windows.Forms.Button();
            this.TorolButton = new System.Windows.Forms.Button();
            this.GyumolcsokBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MennyisegNumUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EgysegArNumUp)).BeginInit();
            this.SuspendLayout();
            // 
            // GyumolcsokList
            // 
            this.GyumolcsokList.Dock = System.Windows.Forms.DockStyle.Right;
            this.GyumolcsokList.FormattingEnabled = true;
            this.GyumolcsokList.Location = new System.Drawing.Point(619, 0);
            this.GyumolcsokList.Name = "GyumolcsokList";
            this.GyumolcsokList.Size = new System.Drawing.Size(181, 450);
            this.GyumolcsokList.TabIndex = 0;
            // 
            // GyumolcsokBox
            // 
            this.GyumolcsokBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GyumolcsokBox.Controls.Add(this.TorolButton);
            this.GyumolcsokBox.Controls.Add(this.ModositButton);
            this.GyumolcsokBox.Controls.Add(this.LetrehozButton);
            this.GyumolcsokBox.Controls.Add(this.KivalasztButton);
            this.GyumolcsokBox.Controls.Add(this.EgysegArNumUp);
            this.GyumolcsokBox.Controls.Add(this.MennyisegNumUp);
            this.GyumolcsokBox.Controls.Add(this.GyumolcsNevText);
            this.GyumolcsokBox.Controls.Add(this.IDText);
            this.GyumolcsokBox.Controls.Add(this.label4);
            this.GyumolcsokBox.Controls.Add(this.label3);
            this.GyumolcsokBox.Controls.Add(this.label2);
            this.GyumolcsokBox.Controls.Add(this.label1);
            this.GyumolcsokBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GyumolcsokBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GyumolcsokBox.Location = new System.Drawing.Point(0, 0);
            this.GyumolcsokBox.Name = "GyumolcsokBox";
            this.GyumolcsokBox.Size = new System.Drawing.Size(619, 450);
            this.GyumolcsokBox.TabIndex = 1;
            this.GyumolcsokBox.TabStop = false;
            this.GyumolcsokBox.Text = "Gyümölcsök Adatai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gyümölcs neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mennyiség:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Egységár:";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(134, 46);
            this.IDText.Name = "IDText";
            this.IDText.ReadOnly = true;
            this.IDText.Size = new System.Drawing.Size(100, 26);
            this.IDText.TabIndex = 4;
            // 
            // GyumolcsNevText
            // 
            this.GyumolcsNevText.Location = new System.Drawing.Point(134, 86);
            this.GyumolcsNevText.Name = "GyumolcsNevText";
            this.GyumolcsNevText.Size = new System.Drawing.Size(100, 26);
            this.GyumolcsNevText.TabIndex = 5;
            // 
            // MennyisegNumUp
            // 
            this.MennyisegNumUp.DecimalPlaces = 2;
            this.MennyisegNumUp.Location = new System.Drawing.Point(134, 132);
            this.MennyisegNumUp.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.MennyisegNumUp.Name = "MennyisegNumUp";
            this.MennyisegNumUp.Size = new System.Drawing.Size(120, 26);
            this.MennyisegNumUp.TabIndex = 6;
            this.MennyisegNumUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EgysegArNumUp
            // 
            this.EgysegArNumUp.DecimalPlaces = 2;
            this.EgysegArNumUp.Location = new System.Drawing.Point(134, 176);
            this.EgysegArNumUp.Name = "EgysegArNumUp";
            this.EgysegArNumUp.Size = new System.Drawing.Size(120, 26);
            this.EgysegArNumUp.TabIndex = 7;
            this.EgysegArNumUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KivalasztButton
            // 
            this.KivalasztButton.Location = new System.Drawing.Point(12, 394);
            this.KivalasztButton.Name = "KivalasztButton";
            this.KivalasztButton.Size = new System.Drawing.Size(106, 44);
            this.KivalasztButton.TabIndex = 2;
            this.KivalasztButton.Text = "Kiválaszt";
            this.KivalasztButton.UseVisualStyleBackColor = true;
            this.KivalasztButton.Click += new System.EventHandler(this.KivalasztButton_Click);
            // 
            // LetrehozButton
            // 
            this.LetrehozButton.Location = new System.Drawing.Point(16, 249);
            this.LetrehozButton.Name = "LetrehozButton";
            this.LetrehozButton.Size = new System.Drawing.Size(120, 40);
            this.LetrehozButton.TabIndex = 8;
            this.LetrehozButton.Text = "Létrehozás";
            this.LetrehozButton.UseVisualStyleBackColor = true;
            this.LetrehozButton.Click += new System.EventHandler(this.LetrehozButton_Click);
            // 
            // ModositButton
            // 
            this.ModositButton.Location = new System.Drawing.Point(167, 249);
            this.ModositButton.Name = "ModositButton";
            this.ModositButton.Size = new System.Drawing.Size(121, 37);
            this.ModositButton.TabIndex = 9;
            this.ModositButton.Text = "Módosítás";
            this.ModositButton.UseVisualStyleBackColor = true;
            this.ModositButton.Click += new System.EventHandler(this.ModositButton_Click);
            // 
            // TorolButton
            // 
            this.TorolButton.Location = new System.Drawing.Point(340, 249);
            this.TorolButton.Name = "TorolButton";
            this.TorolButton.Size = new System.Drawing.Size(119, 40);
            this.TorolButton.TabIndex = 10;
            this.TorolButton.Text = "Törlés";
            this.TorolButton.UseVisualStyleBackColor = true;
            this.TorolButton.Click += new System.EventHandler(this.TorolButton_Click);
            // 
            // GyumcsokGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GyumolcsokBox);
            this.Controls.Add(this.GyumolcsokList);
            this.Name = "GyumcsokGUI";
            this.Text = "Gyümölcsök";
            this.Load += new System.EventHandler(this.GyumcsokGUI_Load);
            this.GyumolcsokBox.ResumeLayout(false);
            this.GyumolcsokBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MennyisegNumUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EgysegArNumUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GyumolcsokList;
        private System.Windows.Forms.GroupBox GyumolcsokBox;
        private System.Windows.Forms.NumericUpDown MennyisegNumUp;
        private System.Windows.Forms.TextBox GyumolcsNevText;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EgysegArNumUp;
        private System.Windows.Forms.Button KivalasztButton;
        private System.Windows.Forms.Button TorolButton;
        private System.Windows.Forms.Button ModositButton;
        private System.Windows.Forms.Button LetrehozButton;
    }
}

