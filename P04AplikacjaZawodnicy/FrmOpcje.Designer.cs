
namespace P04AplikacjaZawodnicy
{
    partial class FrmOpcje
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
            this.cbKolumna = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKolumna
            // 
            this.cbKolumna.FormattingEnabled = true;
            this.cbKolumna.Items.AddRange(new object[] {
            "id_zawodnika",
            "id_trenera",
            "imie",
            "nazwisko",
            "kraj",
            "data_ur",
            "wzrost",
            "waga "});
            this.cbKolumna.Location = new System.Drawing.Point(12, 40);
            this.cbKolumna.Name = "cbKolumna";
            this.cbKolumna.Size = new System.Drawing.Size(201, 21);
            this.cbKolumna.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj kolumne po której chcesz sortować";
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.Location = new System.Drawing.Point(138, 67);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(75, 23);
            this.btnAkceptuj.TabIndex = 2;
            this.btnAkceptuj.Text = "Akceptuj";
            this.btnAkceptuj.UseVisualStyleBackColor = true;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // FrmOpcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 95);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKolumna);
            this.Name = "FrmOpcje";
            this.Text = "FrmOpcje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKolumna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAkceptuj;
    }
}