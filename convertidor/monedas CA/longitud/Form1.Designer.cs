namespace longitud
{
    partial class longitud
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
            this.btnatras = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblr = new System.Windows.Forms.Label();
            this.lblum = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmdconvertir = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.cbxsalida = new System.Windows.Forms.ComboBox();
            this.cbxentrada = new System.Windows.Forms.ComboBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(46, 296);
            this.btnatras.Margin = new System.Windows.Forms.Padding(6);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(246, 44);
            this.btnatras.TabIndex = 28;
            this.btnatras.Text = "atras";
            this.btnatras.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblr);
            this.GroupBox1.Controls.Add(this.lblum);
            this.GroupBox1.Location = new System.Drawing.Point(46, 349);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(270, 66);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Resultado";
            // 
            // lblr
            // 
            this.lblr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblr.Location = new System.Drawing.Point(23, 25);
            this.lblr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblr.Name = "lblr";
            this.lblr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblr.Size = new System.Drawing.Size(189, 27);
            this.lblr.TabIndex = 4;
            // 
            // lblum
            // 
            this.lblum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblum.Location = new System.Drawing.Point(198, 16);
            this.lblum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblum.Name = "lblum";
            this.lblum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblum.Size = new System.Drawing.Size(51, 27);
            this.lblum.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(111, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(71, 13);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "Ingrese valor:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(43, 143);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(17, 13);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "A:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(43, 71);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(24, 13);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "De:";
            // 
            // cmdconvertir
            // 
            this.cmdconvertir.Location = new System.Drawing.Point(46, 240);
            this.cmdconvertir.Margin = new System.Windows.Forms.Padding(6);
            this.cmdconvertir.Name = "cmdconvertir";
            this.cmdconvertir.Size = new System.Drawing.Size(246, 44);
            this.cmdconvertir.TabIndex = 23;
            this.cmdconvertir.Text = "Convertir";
            this.cmdconvertir.UseVisualStyleBackColor = true;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(46, 39);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(6);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(246, 20);
            this.txtvalor.TabIndex = 22;
            this.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxsalida
            // 
            this.cbxsalida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxsalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsalida.FormattingEnabled = true;
            this.cbxsalida.Location = new System.Drawing.Point(46, 188);
            this.cbxsalida.Margin = new System.Windows.Forms.Padding(6);
            this.cbxsalida.Name = "cbxsalida";
            this.cbxsalida.Size = new System.Drawing.Size(242, 21);
            this.cbxsalida.TabIndex = 21;
            // 
            // cbxentrada
            // 
            this.cbxentrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxentrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxentrada.FormattingEnabled = true;
            this.cbxentrada.Location = new System.Drawing.Point(46, 117);
            this.cbxentrada.Margin = new System.Windows.Forms.Padding(6);
            this.cbxentrada.Name = "cbxentrada";
            this.cbxentrada.Size = new System.Drawing.Size(242, 21);
            this.cbxentrada.TabIndex = 20;
            // 
            // longitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(365, 432);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cmdconvertir);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.cbxsalida);
            this.Controls.Add(this.cbxentrada);
            this.Name = "longitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "longitud";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnatras;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblr;
        internal System.Windows.Forms.Label lblum;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button cmdconvertir;
        internal System.Windows.Forms.TextBox txtvalor;
        internal System.Windows.Forms.ComboBox cbxsalida;
        internal System.Windows.Forms.ComboBox cbxentrada;
    }
}

