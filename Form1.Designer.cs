namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.labelNev = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.labelSzulD = new System.Windows.Forms.Label();
            this.dateTimePickerSzul = new System.Windows.Forms.DateTimePicker();
            this.labelNem = new System.Windows.Forms.Label();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonFerfi = new System.Windows.Forms.RadioButton();
            this.labelHobbi = new System.Windows.Forms.Label();
            this.listBoxHobbik = new System.Windows.Forms.ListBox();
            this.labelUjHobbi = new System.Windows.Forms.Label();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.textBoxUjHobbi = new System.Windows.Forms.TextBox();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBetoltes = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNev.Location = new System.Drawing.Point(119, 13);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(65, 32);
            this.labelNev.TabIndex = 0;
            this.labelNev.Text = "Név";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNev.Location = new System.Drawing.Point(208, 10);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(210, 38);
            this.textBoxNev.TabIndex = 1;
            // 
            // labelSzulD
            // 
            this.labelSzulD.AutoSize = true;
            this.labelSzulD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzulD.Location = new System.Drawing.Point(12, 72);
            this.labelSzulD.Name = "labelSzulD";
            this.labelSzulD.Size = new System.Drawing.Size(172, 32);
            this.labelSzulD.TabIndex = 2;
            this.labelSzulD.Text = " Szül. dátum";
            // 
            // dateTimePickerSzul
            // 
            this.dateTimePickerSzul.Location = new System.Drawing.Point(208, 81);
            this.dateTimePickerSzul.Name = "dateTimePickerSzul";
            this.dateTimePickerSzul.Size = new System.Drawing.Size(210, 22);
            this.dateTimePickerSzul.TabIndex = 3;
            // 
            // labelNem
            // 
            this.labelNem.AutoSize = true;
            this.labelNem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNem.Location = new System.Drawing.Point(110, 133);
            this.labelNem.Name = "labelNem";
            this.labelNem.Size = new System.Drawing.Size(74, 32);
            this.labelNem.TabIndex = 4;
            this.labelNem.Text = "Nem";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Checked = true;
            this.radioButtonNo.Location = new System.Drawing.Point(208, 143);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(47, 21);
            this.radioButtonNo.TabIndex = 5;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Nő";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonFerfi
            // 
            this.radioButtonFerfi.AutoSize = true;
            this.radioButtonFerfi.Location = new System.Drawing.Point(327, 143);
            this.radioButtonFerfi.Name = "radioButtonFerfi";
            this.radioButtonFerfi.Size = new System.Drawing.Size(57, 21);
            this.radioButtonFerfi.TabIndex = 6;
            this.radioButtonFerfi.TabStop = true;
            this.radioButtonFerfi.Text = "Férfi";
            this.radioButtonFerfi.UseVisualStyleBackColor = true;
            // 
            // labelHobbi
            // 
            this.labelHobbi.AutoSize = true;
            this.labelHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHobbi.Location = new System.Drawing.Point(562, 13);
            this.labelHobbi.Name = "labelHobbi";
            this.labelHobbi.Size = new System.Drawing.Size(204, 32);
            this.labelHobbi.TabIndex = 7;
            this.labelHobbi.Text = "Kedvenc hobbi";
            // 
            // listBoxHobbik
            // 
            this.listBoxHobbik.FormattingEnabled = true;
            this.listBoxHobbik.ItemHeight = 16;
            this.listBoxHobbik.Items.AddRange(new object[] {
            "GITÁROZÁS",
            "BICIKLIZÉS",
            "TÚRÁZÁS"});
            this.listBoxHobbik.Location = new System.Drawing.Point(568, 61);
            this.listBoxHobbik.Name = "listBoxHobbik";
            this.listBoxHobbik.Size = new System.Drawing.Size(198, 244);
            this.listBoxHobbik.TabIndex = 8;
            this.listBoxHobbik.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // labelUjHobbi
            // 
            this.labelUjHobbi.AutoSize = true;
            this.labelUjHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUjHobbi.Location = new System.Drawing.Point(485, 308);
            this.labelUjHobbi.Name = "labelUjHobbi";
            this.labelUjHobbi.Size = new System.Drawing.Size(120, 32);
            this.labelUjHobbi.TabIndex = 9;
            this.labelUjHobbi.Text = "Új hobbi";
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(649, 348);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(117, 34);
            this.buttonHozzaad.TabIndex = 10;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            this.buttonHozzaad.Click += new System.EventHandler(this.ButtonHozzaad_Click);
            // 
            // textBoxUjHobbi
            // 
            this.textBoxUjHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUjHobbi.Location = new System.Drawing.Point(611, 312);
            this.textBoxUjHobbi.Name = "textBoxUjHobbi";
            this.textBoxUjHobbi.Size = new System.Drawing.Size(155, 30);
            this.textBoxUjHobbi.TabIndex = 11;
            this.textBoxUjHobbi.TextChanged += new System.EventHandler(this.TextBoxUjHobbi_TextChanged);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(568, 400);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(90, 38);
            this.buttonMentes.TabIndex = 12;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.ButtonMentes_Click);
            // 
            // buttonBetoltes
            // 
            this.buttonBetoltes.Location = new System.Drawing.Point(676, 400);
            this.buttonBetoltes.Name = "buttonBetoltes";
            this.buttonBetoltes.Size = new System.Drawing.Size(90, 38);
            this.buttonBetoltes.TabIndex = 13;
            this.buttonBetoltes.Text = "Betöltés";
            this.buttonBetoltes.UseVisualStyleBackColor = true;
            this.buttonBetoltes.Click += new System.EventHandler(this.ButtonBetoltes_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBetoltes);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.textBoxUjHobbi);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.labelUjHobbi);
            this.Controls.Add(this.listBoxHobbik);
            this.Controls.Add(this.labelHobbi);
            this.Controls.Add(this.radioButtonFerfi);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.labelNem);
            this.Controls.Add(this.dateTimePickerSzul);
            this.Controls.Add(this.labelSzulD);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.labelNev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label labelSzulD;
        private System.Windows.Forms.DateTimePicker dateTimePickerSzul;
        private System.Windows.Forms.Label labelNem;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonFerfi;
        private System.Windows.Forms.Label labelHobbi;
        private System.Windows.Forms.ListBox listBoxHobbik;
        private System.Windows.Forms.Label labelUjHobbi;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.TextBox textBoxUjHobbi;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonBetoltes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

