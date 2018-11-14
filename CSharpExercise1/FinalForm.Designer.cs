namespace CSharpExercise1
{
    partial class FinalForm
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
            this.FinallistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FinallistBox
            // 
            this.FinallistBox.FormattingEnabled = true;
            this.FinallistBox.Location = new System.Drawing.Point(75, 32);
            this.FinallistBox.Name = "FinallistBox";
            this.FinallistBox.Size = new System.Drawing.Size(360, 342);
            this.FinallistBox.TabIndex = 0;
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinallistBox);
            this.Name = "FinalForm";
            this.Text = "FinalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FinallistBox;
    }
}