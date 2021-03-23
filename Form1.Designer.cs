
namespace Cliente_Ej13
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
            this.Valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CF = new System.Windows.Forms.RadioButton();
            this.FC = new System.Windows.Forms.RadioButton();
            this.Enviar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Units = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(193, 102);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(95, 22);
            this.Valor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convertir valor de:";
            // 
            // CF
            // 
            this.CF.AutoSize = true;
            this.CF.Location = new System.Drawing.Point(193, 142);
            this.CF.Name = "CF";
            this.CF.Size = new System.Drawing.Size(89, 21);
            this.CF.TabIndex = 2;
            this.CF.TabStop = true;
            this.CF.Text = "Farenheit";
            this.CF.UseVisualStyleBackColor = true;
            this.CF.CheckedChanged += new System.EventHandler(this.CF_CheckedChanged);
            // 
            // FC
            // 
            this.FC.AutoSize = true;
            this.FC.Location = new System.Drawing.Point(193, 178);
            this.FC.Name = "FC";
            this.FC.Size = new System.Drawing.Size(74, 21);
            this.FC.TabIndex = 3;
            this.FC.TabStop = true;
            this.FC.Text = "Celsius";
            this.FC.UseVisualStyleBackColor = true;
            this.FC.CheckedChanged += new System.EventHandler(this.FC_CheckedChanged);
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(331, 102);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(96, 23);
            this.Enviar.TabIndex = 4;
            this.Enviar.Text = "Convertir";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(254, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "A";
            // 
            // Units
            // 
            this.Units.AutoSize = true;
            this.Units.Location = new System.Drawing.Point(294, 105);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(0, 17);
            this.Units.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.FC);
            this.Controls.Add(this.CF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Valor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CF;
        private System.Windows.Forms.RadioButton FC;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Units;
    }
}

