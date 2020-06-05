namespace KalkulatorBMIgraficzny
{
    partial class KalkulatorBMI
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.waga = new System.Windows.Forms.TextBox();
            this.wynikBMI = new System.Windows.Forms.TextBox();
            this.wzrost = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // waga
            // 
            this.waga.Location = new System.Drawing.Point(0, 12);
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(100, 20);
            this.waga.TabIndex = 0;
            // 
            // wynikBMI
            // 
            this.wynikBMI.Location = new System.Drawing.Point(0, 64);
            this.wynikBMI.Name = "wynikBMI";
            this.wynikBMI.Size = new System.Drawing.Size(230, 20);
            this.wynikBMI.TabIndex = 1;
            this.wynikBMI.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // wzrost
            // 
            this.wzrost.Location = new System.Drawing.Point(0, 38);
            this.wzrost.Name = "wzrost";
            this.wzrost.Size = new System.Drawing.Size(100, 20);
            this.wzrost.TabIndex = 2;
            this.wzrost.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(72, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 71);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // KalkulatorBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 238);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.wzrost);
            this.Controls.Add(this.wynikBMI);
            this.Controls.Add(this.waga);
            this.Name = "KalkulatorBMI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox waga;
        private System.Windows.Forms.TextBox wynikBMI;
        private System.Windows.Forms.TextBox wzrost;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

