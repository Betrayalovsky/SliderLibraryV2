namespace SliderTest
{
    partial class Form1
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
            this.bintoD1 = new bintod.bintoD();
            this.SuspendLayout();
            // 
            // bintoD1
            // 
            this.bintoD1.colorSLider = "blue";
            this.bintoD1.colorSuwak = "red";
            this.bintoD1.colorText = "magenta";
            this.bintoD1.Location = new System.Drawing.Point(43, 46);
            this.bintoD1.Margin = new System.Windows.Forms.Padding(4);
            this.bintoD1.maxValue = "80";
            this.bintoD1.minValue = "10";
            this.bintoD1.Name = "bintoD1";
            this.bintoD1.Size = new System.Drawing.Size(678, 140);
            this.bintoD1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bintoD1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private bintod.bintoD bintoD1;
    }
}

