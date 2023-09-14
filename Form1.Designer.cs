namespace TreeParser
{
    partial class Form1
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
            this.PlainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlainText
            // 
            this.PlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainText.Location = new System.Drawing.Point(27, 67);
            this.PlainText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(317, 400);
            this.PlainText.TabIndex = 1;
            this.PlainText.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese valores raiz, padre \r\ne hijo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Execute
            // 
            this.Execute.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.Location = new System.Drawing.Point(195, 484);
            this.Execute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(117, 36);
            this.Execute.TabIndex = 3;
            this.Execute.Text = "Ejecutar";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.Location = new System.Drawing.Point(68, 484);
            this.Open.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(100, 36);
            this.Open.TabIndex = 4;
            this.Open.Text = "Abrir";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // TreeView1
            // 
            this.TreeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeView1.Location = new System.Drawing.Point(432, 59);
            this.TreeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Size = new System.Drawing.Size(617, 408);
            this.TreeView1.TabIndex = 5;
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(600, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "V i s u a l i z a d o r";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(747, 484);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 36);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Salir";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(617, 484);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 36);
            this.clear.TabIndex = 8;
            this.clear.Text = "Limpiar";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TreeView1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlainText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "TreeParser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PlainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TreeView TreeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button clear;
    }
}

