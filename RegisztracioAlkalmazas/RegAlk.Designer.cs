namespace RegisztracioAlkalmazas
{
    partial class RegAlkForm
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
            this.NévLabel = new System.Windows.Forms.Label();
            this.SzülLabel = new System.Windows.Forms.Label();
            this.NemLabel = new System.Windows.Forms.Label();
            this.NőRádió = new System.Windows.Forms.RadioButton();
            this.FérfiRadio = new System.Windows.Forms.RadioButton();
            this.NévTB = new System.Windows.Forms.TextBox();
            this.KedvencLabel = new System.Windows.Forms.Label();
            this.HobbiLB = new System.Windows.Forms.ListBox();
            this.ÚjhobbiTB = new System.Windows.Forms.TextBox();
            this.ÚjhobbiL = new System.Windows.Forms.Label();
            this.HozzáadB = new System.Windows.Forms.Button();
            this.MentésB = new System.Windows.Forms.Button();
            this.BetöltésB = new System.Windows.Forms.Button();
            this.SzülDTP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // NévLabel
            // 
            this.NévLabel.AutoSize = true;
            this.NévLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NévLabel.Location = new System.Drawing.Point(12, 9);
            this.NévLabel.Name = "NévLabel";
            this.NévLabel.Size = new System.Drawing.Size(36, 16);
            this.NévLabel.TabIndex = 0;
            this.NévLabel.Text = "Név:";
            // 
            // SzülLabel
            // 
            this.SzülLabel.AutoSize = true;
            this.SzülLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SzülLabel.Location = new System.Drawing.Point(12, 36);
            this.SzülLabel.Name = "SzülLabel";
            this.SzülLabel.Size = new System.Drawing.Size(79, 16);
            this.SzülLabel.TabIndex = 1;
            this.SzülLabel.Text = "Szül. dátum:";
            // 
            // NemLabel
            // 
            this.NemLabel.AutoSize = true;
            this.NemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NemLabel.Location = new System.Drawing.Point(12, 68);
            this.NemLabel.Name = "NemLabel";
            this.NemLabel.Size = new System.Drawing.Size(40, 16);
            this.NemLabel.TabIndex = 2;
            this.NemLabel.Text = "Nem:";
            // 
            // NőRádió
            // 
            this.NőRádió.AutoSize = true;
            this.NőRádió.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NőRádió.Location = new System.Drawing.Point(136, 66);
            this.NőRádió.Name = "NőRádió";
            this.NőRádió.Size = new System.Drawing.Size(36, 20);
            this.NőRádió.TabIndex = 3;
            this.NőRádió.TabStop = true;
            this.NőRádió.Text = "N";
            this.NőRádió.UseVisualStyleBackColor = true;
            // 
            // FérfiRadio
            // 
            this.FérfiRadio.AutoSize = true;
            this.FérfiRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FérfiRadio.Location = new System.Drawing.Point(96, 66);
            this.FérfiRadio.Name = "FérfiRadio";
            this.FérfiRadio.Size = new System.Drawing.Size(34, 20);
            this.FérfiRadio.TabIndex = 4;
            this.FérfiRadio.TabStop = true;
            this.FérfiRadio.Text = "F";
            this.FérfiRadio.UseVisualStyleBackColor = true;
            // 
            // NévTB
            // 
            this.NévTB.Location = new System.Drawing.Point(96, 10);
            this.NévTB.Name = "NévTB";
            this.NévTB.Size = new System.Drawing.Size(100, 20);
            this.NévTB.TabIndex = 5;
            // 
            // KedvencLabel
            // 
            this.KedvencLabel.AutoSize = true;
            this.KedvencLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KedvencLabel.Location = new System.Drawing.Point(230, 10);
            this.KedvencLabel.Name = "KedvencLabel";
            this.KedvencLabel.Size = new System.Drawing.Size(101, 16);
            this.KedvencLabel.TabIndex = 7;
            this.KedvencLabel.Text = "Kedvenc hobbi:";
            // 
            // HobbiLB
            // 
            this.HobbiLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HobbiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HobbiLB.FormattingEnabled = true;
            this.HobbiLB.ItemHeight = 16;
            this.HobbiLB.Items.AddRange(new object[] {
            "Úszás",
            "Horgászat",
            "Futás"});
            this.HobbiLB.Location = new System.Drawing.Point(222, 29);
            this.HobbiLB.Name = "HobbiLB";
            this.HobbiLB.Size = new System.Drawing.Size(109, 66);
            this.HobbiLB.TabIndex = 8;
            // 
            // ÚjhobbiTB
            // 
            this.ÚjhobbiTB.Location = new System.Drawing.Point(222, 110);
            this.ÚjhobbiTB.Name = "ÚjhobbiTB";
            this.ÚjhobbiTB.Size = new System.Drawing.Size(109, 20);
            this.ÚjhobbiTB.TabIndex = 9;
            this.ÚjhobbiTB.TextChanged += new System.EventHandler(this.ÚjhobbiTB_TextChanged);
            // 
            // ÚjhobbiL
            // 
            this.ÚjhobbiL.AutoSize = true;
            this.ÚjhobbiL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ÚjhobbiL.Location = new System.Drawing.Point(155, 111);
            this.ÚjhobbiL.Name = "ÚjhobbiL";
            this.ÚjhobbiL.Size = new System.Drawing.Size(61, 16);
            this.ÚjhobbiL.TabIndex = 10;
            this.ÚjhobbiL.Text = "Új hobbi:";
            // 
            // HozzáadB
            // 
            this.HozzáadB.Location = new System.Drawing.Point(233, 137);
            this.HozzáadB.Name = "HozzáadB";
            this.HozzáadB.Size = new System.Drawing.Size(94, 29);
            this.HozzáadB.TabIndex = 11;
            this.HozzáadB.Text = "Hozzáad";
            this.HozzáadB.UseVisualStyleBackColor = true;
            this.HozzáadB.Click += new System.EventHandler(this.HozzáadB_Click);
            // 
            // MentésB
            // 
            this.MentésB.Location = new System.Drawing.Point(149, 205);
            this.MentésB.Name = "MentésB";
            this.MentésB.Size = new System.Drawing.Size(79, 29);
            this.MentésB.TabIndex = 12;
            this.MentésB.Text = "Mentés";
            this.MentésB.UseVisualStyleBackColor = true;
            this.MentésB.Click += new System.EventHandler(this.MentésB_Click);
            // 
            // BetöltésB
            // 
            this.BetöltésB.Location = new System.Drawing.Point(248, 205);
            this.BetöltésB.Name = "BetöltésB";
            this.BetöltésB.Size = new System.Drawing.Size(79, 29);
            this.BetöltésB.TabIndex = 13;
            this.BetöltésB.Text = "Betöltés";
            this.BetöltésB.UseVisualStyleBackColor = true;
            this.BetöltésB.Click += new System.EventHandler(this.BetöltésB_Click);
            // 
            // SzülDTP
            // 
            this.SzülDTP.Location = new System.Drawing.Point(96, 36);
            this.SzülDTP.Name = "SzülDTP";
            this.SzülDTP.Size = new System.Drawing.Size(120, 20);
            this.SzülDTP.TabIndex = 14;
            // 
            // RegAlkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 238);
            this.Controls.Add(this.SzülDTP);
            this.Controls.Add(this.BetöltésB);
            this.Controls.Add(this.MentésB);
            this.Controls.Add(this.HozzáadB);
            this.Controls.Add(this.ÚjhobbiL);
            this.Controls.Add(this.ÚjhobbiTB);
            this.Controls.Add(this.HobbiLB);
            this.Controls.Add(this.KedvencLabel);
            this.Controls.Add(this.NévTB);
            this.Controls.Add(this.FérfiRadio);
            this.Controls.Add(this.NőRádió);
            this.Controls.Add(this.NemLabel);
            this.Controls.Add(this.SzülLabel);
            this.Controls.Add(this.NévLabel);
            this.Name = "RegAlkForm";
            this.Text = "Regisztrációs Alkalmazás ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NévLabel;
        private System.Windows.Forms.Label SzülLabel;
        private System.Windows.Forms.Label NemLabel;
        private System.Windows.Forms.RadioButton NőRádió;
        private System.Windows.Forms.RadioButton FérfiRadio;
        private System.Windows.Forms.TextBox NévTB;
        private System.Windows.Forms.Label KedvencLabel;
        private System.Windows.Forms.ListBox HobbiLB;
        private System.Windows.Forms.TextBox ÚjhobbiTB;
        private System.Windows.Forms.Label ÚjhobbiL;
        private System.Windows.Forms.Button HozzáadB;
        private System.Windows.Forms.Button MentésB;
        private System.Windows.Forms.Button BetöltésB;
        private System.Windows.Forms.DateTimePicker SzülDTP;
    }
}

