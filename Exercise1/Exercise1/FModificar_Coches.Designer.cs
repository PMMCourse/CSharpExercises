namespace Exercise1
{
    partial class FModificar_Coches
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
            this.lbCocheModificar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCocheModificar
            // 
            this.lbCocheModificar.FormattingEnabled = true;
            this.lbCocheModificar.Location = new System.Drawing.Point(12, 12);
            this.lbCocheModificar.Name = "lbCocheModificar";
            this.lbCocheModificar.Size = new System.Drawing.Size(228, 420);
            this.lbCocheModificar.TabIndex = 0;
            // 
            // FModificar_Coches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCocheModificar);
            this.Name = "FModificar_Coches";
            this.Text = "FModificar_Coches";
            this.Load += new System.EventHandler(this.FMWLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCocheModificar;
    }
}