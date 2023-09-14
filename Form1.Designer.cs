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
            this.PlainText.Location = new System.Drawing.Point(12, 48);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(239, 332);
            this.PlainText.TabIndex = 1;
            this.PlainText.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text View";
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(176, 415);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(75, 23);
            this.Execute.TabIndex = 3;
            this.Execute.Text = "Ejecutar";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(12, 414);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 4;
            this.Open.Text = "Abrir";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // TreeView1
            // 
            this.TreeView1.Location = new System.Drawing.Point(324, 48);
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Size = new System.Drawing.Size(464, 332);
            this.TreeView1.TabIndex = 5;
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tree View";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(712, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Salir";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(324, 415);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 8;
            this.clear.Text = "Limpiar";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TreeView1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlainText);
            this.Name = "Form1";
            this.Text = "Form1";
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

