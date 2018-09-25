namespace Moneda1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProcId = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboVentanas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblCompare = new System.Windows.Forms.Label();
            this.btnOCR = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IsMyTurn = new System.Windows.Forms.Button();
            this.Jugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProcId
            // 
            this.lblProcId.AutoSize = true;
            this.lblProcId.Location = new System.Drawing.Point(85, 57);
            this.lblProcId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcId.Name = "lblProcId";
            this.lblProcId.Size = new System.Drawing.Size(0, 17);
            this.lblProcId.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Capture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Load Windows";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboVentanas
            // 
            this.comboVentanas.FormattingEnabled = true;
            this.comboVentanas.Location = new System.Drawing.Point(89, 18);
            this.comboVentanas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboVentanas.Name = "comboVentanas";
            this.comboVentanas.Size = new System.Drawing.Size(160, 24);
            this.comboVentanas.TabIndex = 7;
            this.comboVentanas.SelectedIndexChanged += new System.EventHandler(this.comboVentanas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Windows:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 121);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Compare Imgs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblCompare
            // 
            this.lblCompare.AutoSize = true;
            this.lblCompare.Location = new System.Drawing.Point(35, 174);
            this.lblCompare.Name = "lblCompare";
            this.lblCompare.Size = new System.Drawing.Size(46, 17);
            this.lblCompare.TabIndex = 12;
            this.lblCompare.Text = "label2";
            // 
            // btnOCR
            // 
            this.btnOCR.Location = new System.Drawing.Point(259, 162);
            this.btnOCR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOCR.Name = "btnOCR";
            this.btnOCR.Size = new System.Drawing.Size(161, 28);
            this.btnOCR.TabIndex = 13;
            this.btnOCR.Text = "Test";
            this.btnOCR.UseVisualStyleBackColor = true;
            this.btnOCR.Click += new System.EventHandler(this.btnOCR_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IsMyTurn
            // 
            this.IsMyTurn.Location = new System.Drawing.Point(260, 85);
            this.IsMyTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IsMyTurn.Name = "IsMyTurn";
            this.IsMyTurn.Size = new System.Drawing.Size(160, 33);
            this.IsMyTurn.TabIndex = 15;
            this.IsMyTurn.Text = "IsMyTurn";
            this.IsMyTurn.UseVisualStyleBackColor = true;
            this.IsMyTurn.Click += new System.EventHandler(this.IsMyTurn_Click);
            // 
            // Jugar
            // 
            this.Jugar.Location = new System.Drawing.Point(259, 126);
            this.Jugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(161, 28);
            this.Jugar.TabIndex = 16;
            this.Jugar.Text = "Jugar";
            this.Jugar.UseVisualStyleBackColor = true;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 217);
            this.Controls.Add(this.Jugar);
            this.Controls.Add(this.IsMyTurn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOCR);
            this.Controls.Add(this.lblCompare);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblProcId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboVentanas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "DALPI BOT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProcId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboVentanas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblCompare;
        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button IsMyTurn;
        private System.Windows.Forms.Button Jugar;
    }
}

