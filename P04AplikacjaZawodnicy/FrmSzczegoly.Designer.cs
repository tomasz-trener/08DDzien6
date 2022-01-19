
namespace P04AplikacjaZawodnicy
{
    partial class FrmSzczegoly
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
            this.nunWzrost = new System.Windows.Forms.NumericUpDown();
            this.numWaga = new System.Windows.Forms.NumericUpDown();
            this.dtpDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nunWzrost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).BeginInit();
            this.SuspendLayout();
            // 
            // nunWzrost
            // 
            this.nunWzrost.Location = new System.Drawing.Point(15, 227);
            this.nunWzrost.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nunWzrost.Name = "nunWzrost";
            this.nunWzrost.Size = new System.Drawing.Size(151, 20);
            this.nunWzrost.TabIndex = 28;
            // 
            // numWaga
            // 
            this.numWaga.Location = new System.Drawing.Point(15, 185);
            this.numWaga.Name = "numWaga";
            this.numWaga.Size = new System.Drawing.Size(151, 20);
            this.numWaga.TabIndex = 27;
            // 
            // dtpDataUrodzenia
            // 
            this.dtpDataUrodzenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUrodzenia.Location = new System.Drawing.Point(15, 145);
            this.dtpDataUrodzenia.Name = "dtpDataUrodzenia";
            this.dtpDataUrodzenia.Size = new System.Drawing.Size(151, 20);
            this.dtpDataUrodzenia.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Wzrost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Waga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data urodzenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kraj";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(15, 106);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(151, 20);
            this.txtKraj.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(15, 66);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(151, 20);
            this.txtNazwisko.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Imie";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(15, 25);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(151, 20);
            this.txtImie.TabIndex = 17;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(91, 263);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 29;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 296);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.nunWzrost);
            this.Controls.Add(this.numWaga);
            this.Controls.Add(this.dtpDataUrodzenia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImie);
            this.Name = "FrmSzczegoly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Szczegoly";
            this.Load += new System.EventHandler(this.FrmSzczegoly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nunWzrost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nunWzrost;
        private System.Windows.Forms.NumericUpDown numWaga;
        private System.Windows.Forms.DateTimePicker dtpDataUrodzenia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Button btnZapisz;
    }
}