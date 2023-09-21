namespace NachoOpera
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lbN1 = new System.Windows.Forms.Label();
            this.lbN2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbSuma = new System.Windows.Forms.Label();
            this.lbResta = new System.Windows.Forms.Label();
            this.lbMult = new System.Windows.Forms.Label();
            this.lbDiv = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtResta = new System.Windows.Forms.TextBox();
            this.txtMult = new System.Windows.Forms.TextBox();
            this.txtDiv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(94, 158);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(119, 42);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(261, 158);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(119, 42);
            this.txtNum2.TabIndex = 1;
            // 
            // lbN1
            // 
            this.lbN1.AutoSize = true;
            this.lbN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN1.Location = new System.Drawing.Point(90, 119);
            this.lbN1.Name = "lbN1";
            this.lbN1.Size = new System.Drawing.Size(137, 32);
            this.lbN1.TabIndex = 2;
            this.lbN1.Text = "Número 1";
            // 
            // lbN2
            // 
            this.lbN2.AutoSize = true;
            this.lbN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN2.Location = new System.Drawing.Point(257, 119);
            this.lbN2.Name = "lbN2";
            this.lbN2.Size = new System.Drawing.Size(137, 32);
            this.lbN2.TabIndex = 3;
            this.lbN2.Text = "Número 2";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(146, 228);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(157, 53);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbSuma
            // 
            this.lbSuma.AutoSize = true;
            this.lbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuma.Location = new System.Drawing.Point(632, 108);
            this.lbSuma.Name = "lbSuma";
            this.lbSuma.Size = new System.Drawing.Size(88, 32);
            this.lbSuma.TabIndex = 5;
            this.lbSuma.Text = "Suma";
            // 
            // lbResta
            // 
            this.lbResta.AutoSize = true;
            this.lbResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResta.Location = new System.Drawing.Point(632, 168);
            this.lbResta.Name = "lbResta";
            this.lbResta.Size = new System.Drawing.Size(88, 32);
            this.lbResta.TabIndex = 6;
            this.lbResta.Text = "Resta";
            // 
            // lbMult
            // 
            this.lbMult.AutoSize = true;
            this.lbMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMult.Location = new System.Drawing.Point(532, 230);
            this.lbMult.Name = "lbMult";
            this.lbMult.Size = new System.Drawing.Size(188, 32);
            this.lbMult.TabIndex = 7;
            this.lbMult.Text = "Multiplicación";
            // 
            // lbDiv
            // 
            this.lbDiv.AutoSize = true;
            this.lbDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiv.Location = new System.Drawing.Point(605, 293);
            this.lbDiv.Name = "lbDiv";
            this.lbDiv.Size = new System.Drawing.Size(115, 32);
            this.lbDiv.TabIndex = 8;
            this.lbDiv.Text = "División";
            // 
            // txtSuma
            // 
            this.txtSuma.CausesValidation = false;
            this.txtSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuma.Location = new System.Drawing.Point(726, 98);
            this.txtSuma.Multiline = true;
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.ReadOnly = true;
            this.txtSuma.Size = new System.Drawing.Size(119, 42);
            this.txtSuma.TabIndex = 9;
            this.txtSuma.TabStop = false;
            // 
            // txtResta
            // 
            this.txtResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResta.Location = new System.Drawing.Point(726, 158);
            this.txtResta.Multiline = true;
            this.txtResta.Name = "txtResta";
            this.txtResta.Size = new System.Drawing.Size(119, 42);
            this.txtResta.TabIndex = 10;
            this.txtResta.TabStop = false;
            // 
            // txtMult
            // 
            this.txtMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMult.Location = new System.Drawing.Point(726, 220);
            this.txtMult.Multiline = true;
            this.txtMult.Name = "txtMult";
            this.txtMult.Size = new System.Drawing.Size(119, 42);
            this.txtMult.TabIndex = 11;
            this.txtMult.TabStop = false;
            // 
            // txtDiv
            // 
            this.txtDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiv.Location = new System.Drawing.Point(726, 283);
            this.txtDiv.Multiline = true;
            this.txtDiv.Name = "txtDiv";
            this.txtDiv.Size = new System.Drawing.Size(119, 42);
            this.txtDiv.TabIndex = 12;
            this.txtDiv.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 430);
            this.Controls.Add(this.txtDiv);
            this.Controls.Add(this.txtMult);
            this.Controls.Add(this.txtResta);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.lbDiv);
            this.Controls.Add(this.lbMult);
            this.Controls.Add(this.lbResta);
            this.Controls.Add(this.lbSuma);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbN2);
            this.Controls.Add(this.lbN1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lbN1;
        private System.Windows.Forms.Label lbN2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbSuma;
        private System.Windows.Forms.Label lbResta;
        private System.Windows.Forms.Label lbMult;
        private System.Windows.Forms.Label lbDiv;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox txtResta;
        private System.Windows.Forms.TextBox txtMult;
        private System.Windows.Forms.TextBox txtDiv;
    }
}

