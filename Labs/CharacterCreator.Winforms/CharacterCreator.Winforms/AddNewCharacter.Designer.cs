namespace CharacterCreator.Winforms
{
    partial class AddNewCharacter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.NameError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.professionError = new System.Windows.Forms.Label();
            this.ProfessioncomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.raceError = new System.Windows.Forms.Label();
            this.RacecomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StrengthError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.intellogenceError = new System.Windows.Forms.Label();
            this.StrengthnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IntelligencenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Constitution = new System.Windows.Forms.Label();
            this.agilityError = new System.Windows.Forms.Label();
            this.constitutionError = new System.Windows.Forms.Label();
            this.AgilitynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ConstitutionnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.charsimaError = new System.Windows.Forms.Label();
            this.CharismanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.BiographytextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.biographyError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntelligencenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgilitynumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstitutionnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharismanumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(130, 51);
            this.NametextBox.MaxLength = 50;
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(164, 26);
            this.NametextBox.TabIndex = 0;
            this.NametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NametextBox_KeyPress);
            // 
            // NameError
            // 
            this.NameError.AutoSize = true;
            this.NameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameError.ForeColor = System.Drawing.Color.Red;
            this.NameError.Location = new System.Drawing.Point(300, 57);
            this.NameError.Name = "NameError";
            this.NameError.Size = new System.Drawing.Size(41, 13);
            this.NameError.TabIndex = 3;
            this.NameError.Text = "label3";
            this.NameError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Profession";
            // 
            // professionError
            // 
            this.professionError.AutoSize = true;
            this.professionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professionError.ForeColor = System.Drawing.Color.Red;
            this.professionError.Location = new System.Drawing.Point(300, 99);
            this.professionError.Name = "professionError";
            this.professionError.Size = new System.Drawing.Size(41, 13);
            this.professionError.TabIndex = 3;
            this.professionError.Text = "label3";
            this.professionError.Visible = false;
            // 
            // ProfessioncomboBox
            // 
            this.ProfessioncomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfessioncomboBox.FormattingEnabled = true;
            this.ProfessioncomboBox.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this.ProfessioncomboBox.Location = new System.Drawing.Point(130, 92);
            this.ProfessioncomboBox.Name = "ProfessioncomboBox";
            this.ProfessioncomboBox.Size = new System.Drawing.Size(164, 28);
            this.ProfessioncomboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Race";
            // 
            // raceError
            // 
            this.raceError.AutoSize = true;
            this.raceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceError.ForeColor = System.Drawing.Color.Red;
            this.raceError.Location = new System.Drawing.Point(300, 142);
            this.raceError.Name = "raceError";
            this.raceError.Size = new System.Drawing.Size(41, 13);
            this.raceError.TabIndex = 3;
            this.raceError.Text = "label3";
            this.raceError.Visible = false;
            // 
            // RacecomboBox
            // 
            this.RacecomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this.RacecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RacecomboBox.FormattingEnabled = true;
            this.RacecomboBox.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this.RacecomboBox.Location = new System.Drawing.Point(130, 135);
            this.RacecomboBox.Name = "RacecomboBox";
            this.RacecomboBox.Size = new System.Drawing.Size(164, 28);
            this.RacecomboBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Strength";
            // 
            // StrengthError
            // 
            this.StrengthError.AutoSize = true;
            this.StrengthError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthError.ForeColor = System.Drawing.Color.Red;
            this.StrengthError.Location = new System.Drawing.Point(300, 187);
            this.StrengthError.Name = "StrengthError";
            this.StrengthError.Size = new System.Drawing.Size(41, 13);
            this.StrengthError.TabIndex = 3;
            this.StrengthError.Text = "label3";
            this.StrengthError.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Intelligence";
            // 
            // intellogenceError
            // 
            this.intellogenceError.AutoSize = true;
            this.intellogenceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intellogenceError.ForeColor = System.Drawing.Color.Red;
            this.intellogenceError.Location = new System.Drawing.Point(300, 224);
            this.intellogenceError.Name = "intellogenceError";
            this.intellogenceError.Size = new System.Drawing.Size(41, 13);
            this.intellogenceError.TabIndex = 3;
            this.intellogenceError.Text = "label3";
            this.intellogenceError.Visible = false;
            // 
            // StrengthnumericUpDown
            // 
            this.StrengthnumericUpDown.Location = new System.Drawing.Point(130, 180);
            this.StrengthnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StrengthnumericUpDown.Name = "StrengthnumericUpDown";
            this.StrengthnumericUpDown.Size = new System.Drawing.Size(164, 26);
            this.StrengthnumericUpDown.TabIndex = 3;
            this.StrengthnumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // IntelligencenumericUpDown
            // 
            this.IntelligencenumericUpDown.Location = new System.Drawing.Point(130, 217);
            this.IntelligencenumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntelligencenumericUpDown.Name = "IntelligencenumericUpDown";
            this.IntelligencenumericUpDown.Size = new System.Drawing.Size(164, 26);
            this.IntelligencenumericUpDown.TabIndex = 4;
            this.IntelligencenumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Agility";
            // 
            // Constitution
            // 
            this.Constitution.AutoSize = true;
            this.Constitution.Location = new System.Drawing.Point(12, 291);
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(94, 20);
            this.Constitution.TabIndex = 1;
            this.Constitution.Text = "Constitution";
            // 
            // agilityError
            // 
            this.agilityError.AutoSize = true;
            this.agilityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agilityError.ForeColor = System.Drawing.Color.Red;
            this.agilityError.Location = new System.Drawing.Point(300, 260);
            this.agilityError.Name = "agilityError";
            this.agilityError.Size = new System.Drawing.Size(41, 13);
            this.agilityError.TabIndex = 3;
            this.agilityError.Text = "label3";
            this.agilityError.Visible = false;
            // 
            // constitutionError
            // 
            this.constitutionError.AutoSize = true;
            this.constitutionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constitutionError.ForeColor = System.Drawing.Color.Red;
            this.constitutionError.Location = new System.Drawing.Point(300, 297);
            this.constitutionError.Name = "constitutionError";
            this.constitutionError.Size = new System.Drawing.Size(41, 13);
            this.constitutionError.TabIndex = 3;
            this.constitutionError.Text = "label3";
            this.constitutionError.Visible = false;
            // 
            // AgilitynumericUpDown
            // 
            this.AgilitynumericUpDown.Location = new System.Drawing.Point(130, 253);
            this.AgilitynumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgilitynumericUpDown.Name = "AgilitynumericUpDown";
            this.AgilitynumericUpDown.Size = new System.Drawing.Size(164, 26);
            this.AgilitynumericUpDown.TabIndex = 5;
            this.AgilitynumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ConstitutionnumericUpDown
            // 
            this.ConstitutionnumericUpDown.Location = new System.Drawing.Point(130, 290);
            this.ConstitutionnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ConstitutionnumericUpDown.Name = "ConstitutionnumericUpDown";
            this.ConstitutionnumericUpDown.Size = new System.Drawing.Size(164, 26);
            this.ConstitutionnumericUpDown.TabIndex = 6;
            this.ConstitutionnumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Charsima";
            // 
            // charsimaError
            // 
            this.charsimaError.AutoSize = true;
            this.charsimaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charsimaError.ForeColor = System.Drawing.Color.Red;
            this.charsimaError.Location = new System.Drawing.Point(300, 329);
            this.charsimaError.Name = "charsimaError";
            this.charsimaError.Size = new System.Drawing.Size(41, 13);
            this.charsimaError.TabIndex = 3;
            this.charsimaError.Text = "label3";
            this.charsimaError.Visible = false;
            // 
            // CharismanumericUpDown
            // 
            this.CharismanumericUpDown.Location = new System.Drawing.Point(130, 322);
            this.CharismanumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CharismanumericUpDown.Name = "CharismanumericUpDown";
            this.CharismanumericUpDown.Size = new System.Drawing.Size(164, 26);
            this.CharismanumericUpDown.TabIndex = 7;
            this.CharismanumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Biography";
            // 
            // BiographytextBox
            // 
            this.BiographytextBox.Location = new System.Drawing.Point(130, 355);
            this.BiographytextBox.Multiline = true;
            this.BiographytextBox.Name = "BiographytextBox";
            this.BiographytextBox.Size = new System.Drawing.Size(164, 102);
            this.BiographytextBox.TabIndex = 8;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(374, 461);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 34);
            this.Savebutton.TabIndex = 9;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseMnemonic = false;
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(8, 461);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 34);
            this.Cancelbutton.TabIndex = 10;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // biographyError
            // 
            this.biographyError.AutoSize = true;
            this.biographyError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biographyError.ForeColor = System.Drawing.Color.Red;
            this.biographyError.Location = new System.Drawing.Point(300, 389);
            this.biographyError.Name = "biographyError";
            this.biographyError.Size = new System.Drawing.Size(41, 13);
            this.biographyError.TabIndex = 3;
            this.biographyError.Text = "label3";
            this.biographyError.Visible = false;
            // 
            // AddNewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 507);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.BiographytextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CharismanumericUpDown);
            this.Controls.Add(this.ConstitutionnumericUpDown);
            this.Controls.Add(this.AgilitynumericUpDown);
            this.Controls.Add(this.biographyError);
            this.Controls.Add(this.charsimaError);
            this.Controls.Add(this.IntelligencenumericUpDown);
            this.Controls.Add(this.constitutionError);
            this.Controls.Add(this.StrengthnumericUpDown);
            this.Controls.Add(this.intellogenceError);
            this.Controls.Add(this.agilityError);
            this.Controls.Add(this.RacecomboBox);
            this.Controls.Add(this.StrengthError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.raceError);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this.ProfessioncomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.professionError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNewCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewCharacter";
            this.Load += new System.EventHandler(this.AddNewCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StrengthnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntelligencenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgilitynumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstitutionnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharismanumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label NameError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label professionError;
        private System.Windows.Forms.ComboBox ProfessioncomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label raceError;
        private System.Windows.Forms.ComboBox RacecomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StrengthError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label intellogenceError;
        private System.Windows.Forms.NumericUpDown StrengthnumericUpDown;
        private System.Windows.Forms.NumericUpDown IntelligencenumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Constitution;
        private System.Windows.Forms.Label agilityError;
        private System.Windows.Forms.Label constitutionError;
        private System.Windows.Forms.NumericUpDown AgilitynumericUpDown;
        private System.Windows.Forms.NumericUpDown ConstitutionnumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label charsimaError;
        private System.Windows.Forms.NumericUpDown CharismanumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BiographytextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Label biographyError;
    }
}