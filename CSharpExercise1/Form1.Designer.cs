namespace CSharpExercise1
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MakercomboBox1 = new System.Windows.Forms.ComboBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModelcomboBox1 = new System.Windows.Forms.ComboBox();
            this.ColorcomboBox1 = new System.Windows.Forms.ComboBox();
            this.MakercomboBox2 = new System.Windows.Forms.ComboBox();
            this.ModelcomboBox2 = new System.Windows.Forms.ComboBox();
            this.ColorcomboBox2 = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MakercomboBox1
            // 
            this.MakercomboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Maker", true));
            this.MakercomboBox1.DisplayMember = "id";
            this.MakercomboBox1.FormattingEnabled = true;
            this.MakercomboBox1.Location = new System.Drawing.Point(65, 46);
            this.MakercomboBox1.Name = "MakercomboBox1";
            this.MakercomboBox1.Size = new System.Drawing.Size(121, 21);
            this.MakercomboBox1.TabIndex = 0;
            this.MakercomboBox1.ValueMember = "id";
            this.MakercomboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(CSharpExercise1.Car);
            // 
            // ModelcomboBox1
            // 
            this.ModelcomboBox1.FormattingEnabled = true;
            this.ModelcomboBox1.Location = new System.Drawing.Point(65, 73);
            this.ModelcomboBox1.Name = "ModelcomboBox1";
            this.ModelcomboBox1.Size = new System.Drawing.Size(121, 21);
            this.ModelcomboBox1.TabIndex = 1;
            this.ModelcomboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // ColorcomboBox1
            // 
            this.ColorcomboBox1.FormattingEnabled = true;
            this.ColorcomboBox1.Location = new System.Drawing.Point(65, 100);
            this.ColorcomboBox1.Name = "ColorcomboBox1";
            this.ColorcomboBox1.Size = new System.Drawing.Size(121, 21);
            this.ColorcomboBox1.TabIndex = 2;
            this.ColorcomboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // MakercomboBox2
            // 
            this.MakercomboBox2.FormattingEnabled = true;
            this.MakercomboBox2.Location = new System.Drawing.Point(347, 46);
            this.MakercomboBox2.Name = "MakercomboBox2";
            this.MakercomboBox2.Size = new System.Drawing.Size(121, 21);
            this.MakercomboBox2.TabIndex = 3;
            // 
            // ModelcomboBox2
            // 
            this.ModelcomboBox2.FormattingEnabled = true;
            this.ModelcomboBox2.Location = new System.Drawing.Point(347, 73);
            this.ModelcomboBox2.Name = "ModelcomboBox2";
            this.ModelcomboBox2.Size = new System.Drawing.Size(121, 21);
            this.ModelcomboBox2.TabIndex = 4;
            // 
            // ColorcomboBox2
            // 
            this.ColorcomboBox2.FormattingEnabled = true;
            this.ColorcomboBox2.Location = new System.Drawing.Point(347, 100);
            this.ColorcomboBox2.Name = "ColorcomboBox2";
            this.ColorcomboBox2.Size = new System.Drawing.Size(121, 21);
            this.ColorcomboBox2.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(234, 173);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = ">";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(234, 293);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "x";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.carBindingSource;
            this.listBox1.DisplayMember = "showInfo";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(65, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 238);
            this.listBox1.TabIndex = 8;
            this.listBox1.ValueMember = "id";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(347, 139);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 238);
            this.listBox2.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 421);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ColorcomboBox2);
            this.Controls.Add(this.ModelcomboBox2);
            this.Controls.Add(this.MakercomboBox2);
            this.Controls.Add(this.ColorcomboBox1);
            this.Controls.Add(this.ModelcomboBox1);
            this.Controls.Add(this.MakercomboBox1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox MakercomboBox1;
        private System.Windows.Forms.ComboBox ModelcomboBox1;
        private System.Windows.Forms.ComboBox ColorcomboBox1;
        private System.Windows.Forms.ComboBox MakercomboBox2;
        private System.Windows.Forms.ComboBox ModelcomboBox2;
        private System.Windows.Forms.ComboBox ColorcomboBox2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.BindingSource carBindingSource;
    }
}

