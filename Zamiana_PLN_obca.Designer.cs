namespace Kantor
{
    partial class Zamiana_PLN_obca
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
            this.bt_zamien = new System.Windows.Forms.Button();
            this.tB_kwota = new System.Windows.Forms.TextBox();
            this.cB_waluty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_zamien
            // 
            this.bt_zamien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_zamien.Location = new System.Drawing.Point(575, 337);
            this.bt_zamien.Name = "bt_zamien";
            this.bt_zamien.Size = new System.Drawing.Size(170, 72);
            this.bt_zamien.TabIndex = 0;
            this.bt_zamien.Text = "Zamień";
            this.bt_zamien.UseVisualStyleBackColor = true;
            this.bt_zamien.Click += new System.EventHandler(this.bt_zamien_Click);
            // 
            // tB_kwota
            // 
            this.tB_kwota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB_kwota.Location = new System.Drawing.Point(85, 77);
            this.tB_kwota.Name = "tB_kwota";
            this.tB_kwota.Size = new System.Drawing.Size(191, 30);
            this.tB_kwota.TabIndex = 1;
            // 
            // cB_waluty
            // 
            this.cB_waluty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cB_waluty.FormattingEnabled = true;
            this.cB_waluty.Location = new System.Drawing.Point(300, 77);
            this.cB_waluty.Name = "cB_waluty";
            this.cB_waluty.Size = new System.Drawing.Size(172, 33);
            this.cB_waluty.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kwota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(295, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Waluta docelowa";
            // 
            // Zamiana_PLN_obca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_waluty);
            this.Controls.Add(this.tB_kwota);
            this.Controls.Add(this.bt_zamien);
            this.Name = "Zamiana_PLN_obca";
            this.Text = "Zamiana_PLN_obca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Zamiana_PLN_obca_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_zamien;
        private System.Windows.Forms.TextBox tB_kwota;
        private System.Windows.Forms.ComboBox cB_waluty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}