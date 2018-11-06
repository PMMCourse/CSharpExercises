namespace main
{
    partial class cars_list
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_done1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(26, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(358, 484);
            this.listBox1.TabIndex = 0;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(main.Car);
            // 
            // button_done1
            // 
            this.button_done1.Location = new System.Drawing.Point(378, 549);
            this.button_done1.Name = "button_done1";
            this.button_done1.Size = new System.Drawing.Size(75, 23);
            this.button_done1.TabIndex = 1;
            this.button_done1.Text = "done";
            this.button_done1.UseVisualStyleBackColor = true;
            this.button_done1.Click += new System.EventHandler(this.button_done1_Click);
            // 
            // cars_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 605);
            this.Controls.Add(this.button_done1);
            this.Controls.Add(this.listBox1);
            this.Name = "cars_list";
            this.Text = "cars_list";
            this.Load += new System.EventHandler(this.cars_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_done1;
        private System.Windows.Forms.BindingSource carBindingSource;
    }
}