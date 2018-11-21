namespace Exercise1
{
    partial class Menu_Principal
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
            this.btadd = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.btaceptar = new System.Windows.Forms.Button();
            this.lbWritteJason = new System.Windows.Forms.ListBox();
            this.lbReadJason = new System.Windows.Forms.ListBox();
            this.cbMarcaRead = new System.Windows.Forms.ComboBox();
            this.cbModeloRead = new System.Windows.Forms.ComboBox();
            this.cbColorRead = new System.Windows.Forms.ComboBox();
            this.cbMarcaWritter = new System.Windows.Forms.ComboBox();
            this.cbModeloWritter = new System.Windows.Forms.ComboBox();
            this.cbColorWritter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(332, 256);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 0;
            this.btadd.Text = ">";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btdel
            // 
            this.btdel.Location = new System.Drawing.Point(332, 322);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(75, 23);
            this.btdel.TabIndex = 1;
            this.btdel.Text = "X";
            this.btdel.UseVisualStyleBackColor = true;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(292, 472);
            this.btaceptar.Name = "btaceptar";
            this.btaceptar.Size = new System.Drawing.Size(155, 23);
            this.btaceptar.TabIndex = 2;
            this.btaceptar.Text = "Aceptar";
            this.btaceptar.UseVisualStyleBackColor = true;
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // lbWritteJason
            // 
            this.lbWritteJason.FormattingEnabled = true;
            this.lbWritteJason.Location = new System.Drawing.Point(453, 114);
            this.lbWritteJason.Name = "lbWritteJason";
            this.lbWritteJason.Size = new System.Drawing.Size(257, 381);
            this.lbWritteJason.TabIndex = 4;
            // 
            // lbReadJason
            // 
            this.lbReadJason.FormattingEnabled = true;
            this.lbReadJason.Location = new System.Drawing.Point(29, 114);
            this.lbReadJason.Name = "lbReadJason";
            this.lbReadJason.Size = new System.Drawing.Size(257, 381);
            this.lbReadJason.TabIndex = 5;
            // 
            // cbMarcaRead
            // 
            this.cbMarcaRead.FormattingEnabled = true;
            this.cbMarcaRead.Location = new System.Drawing.Point(29, 23);
            this.cbMarcaRead.Name = "cbMarcaRead";
            this.cbMarcaRead.Size = new System.Drawing.Size(257, 21);
            this.cbMarcaRead.TabIndex = 6;
            this.cbMarcaRead.SelectedIndexChanged += new System.EventHandler(this.cbMarcaRead_SelectedIndex);
            // 
            // cbModeloRead
            // 
            this.cbModeloRead.FormattingEnabled = true;
            this.cbModeloRead.Location = new System.Drawing.Point(29, 50);
            this.cbModeloRead.Name = "cbModeloRead";
            this.cbModeloRead.Size = new System.Drawing.Size(257, 21);
            this.cbModeloRead.TabIndex = 7;
            this.cbModeloRead.SelectedIndexChanged += new System.EventHandler(this.cbModeloRead_SelectedIndex);
            // 
            // cbColorRead
            // 
            this.cbColorRead.FormattingEnabled = true;
            this.cbColorRead.Location = new System.Drawing.Point(29, 77);
            this.cbColorRead.Name = "cbColorRead";
            this.cbColorRead.Size = new System.Drawing.Size(257, 21);
            this.cbColorRead.TabIndex = 8;
            this.cbColorRead.SelectedIndexChanged += new System.EventHandler(this.cbColorRead_SelectedIndex);
            // 
            // cbMarcaWritter
            // 
            this.cbMarcaWritter.FormattingEnabled = true;
            this.cbMarcaWritter.Location = new System.Drawing.Point(453, 23);
            this.cbMarcaWritter.Name = "cbMarcaWritter";
            this.cbMarcaWritter.Size = new System.Drawing.Size(257, 21);
            this.cbMarcaWritter.TabIndex = 9;
            this.cbMarcaWritter.SelectedIndexChanged += new System.EventHandler(this.cbMarcaWritter_SelectedIndex);
            // 
            // cbModeloWritter
            // 
            this.cbModeloWritter.FormattingEnabled = true;
            this.cbModeloWritter.Location = new System.Drawing.Point(453, 50);
            this.cbModeloWritter.Name = "cbModeloWritter";
            this.cbModeloWritter.Size = new System.Drawing.Size(257, 21);
            this.cbModeloWritter.TabIndex = 10;
            this.cbModeloWritter.SelectedIndexChanged += new System.EventHandler(this.cbModeloWritter_SelectedIndex);
            // 
            // cbColorWritter
            // 
            this.cbColorWritter.FormattingEnabled = true;
            this.cbColorWritter.Location = new System.Drawing.Point(453, 77);
            this.cbColorWritter.Name = "cbColorWritter";
            this.cbColorWritter.Size = new System.Drawing.Size(257, 21);
            this.cbColorWritter.TabIndex = 11;
            this.cbColorWritter.SelectedIndexChanged += new System.EventHandler(this.cbColorWritter_SelectedIndex);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 523);
            this.Controls.Add(this.cbColorWritter);
            this.Controls.Add(this.cbModeloWritter);
            this.Controls.Add(this.cbMarcaWritter);
            this.Controls.Add(this.cbColorRead);
            this.Controls.Add(this.cbModeloRead);
            this.Controls.Add(this.cbMarcaRead);
            this.Controls.Add(this.lbReadJason);
            this.Controls.Add(this.lbWritteJason);
            this.Controls.Add(this.btaceptar);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.btadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu_Principal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.Button btaceptar;
        private System.Windows.Forms.ListBox lbWritteJason;
        private System.Windows.Forms.ListBox lbReadJason;
        private System.Windows.Forms.ComboBox cbMarcaRead;
        private System.Windows.Forms.ComboBox cbModeloRead;
        private System.Windows.Forms.ComboBox cbColorRead;
        private System.Windows.Forms.ComboBox cbMarcaWritter;
        private System.Windows.Forms.ComboBox cbModeloWritter;
        private System.Windows.Forms.ComboBox cbColorWritter;
    }
}

