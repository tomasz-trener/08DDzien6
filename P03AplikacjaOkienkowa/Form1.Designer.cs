
namespace P03AplikacjaOkienkowa
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
            this.btnWyslij = new System.Windows.Forms.Button();
            this.txtPolecenieSQL = new System.Windows.Forms.TextBox();
            this.dgvDane = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(12, 12);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 23);
            this.btnWyslij.TabIndex = 0;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // txtPolecenieSQL
            // 
            this.txtPolecenieSQL.Location = new System.Drawing.Point(93, 15);
            this.txtPolecenieSQL.Name = "txtPolecenieSQL";
            this.txtPolecenieSQL.Size = new System.Drawing.Size(394, 20);
            this.txtPolecenieSQL.TabIndex = 1;
            // 
            // dgvDane
            // 
            this.dgvDane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDane.Location = new System.Drawing.Point(12, 41);
            this.dgvDane.Name = "dgvDane";
            this.dgvDane.Size = new System.Drawing.Size(475, 346);
            this.dgvDane.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 403);
            this.Controls.Add(this.dgvDane);
            this.Controls.Add(this.txtPolecenieSQL);
            this.Controls.Add(this.btnWyslij);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWyslij;
        private System.Windows.Forms.TextBox txtPolecenieSQL;
        private System.Windows.Forms.DataGridView dgvDane;
    }
}

