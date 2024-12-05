namespace Convertidor_de_Unidades
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnArea = new System.Windows.Forms.Button();
            this.btnDistancia = new System.Windows.Forms.Button();
            this.btnTemepratura = new System.Windows.Forms.Button();
            this.btnVolumen = new System.Windows.Forms.Button();
            this.btnMasa = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnVelocidad = new System.Windows.Forms.Button();
            this.btnTiempo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArea
            // 
            this.btnArea.Font = new System.Drawing.Font("Didot", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(12, 12);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(88, 31);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Área";
            this.btnArea.UseVisualStyleBackColor = true;
            // 
            // btnDistancia
            // 
            this.btnDistancia.Font = new System.Drawing.Font("Didot", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistancia.Location = new System.Drawing.Point(12, 64);
            this.btnDistancia.Name = "btnDistancia";
            this.btnDistancia.Size = new System.Drawing.Size(98, 31);
            this.btnDistancia.TabIndex = 1;
            this.btnDistancia.Text = "Distancia";
            this.btnDistancia.UseVisualStyleBackColor = true;
            // 
            // btnTemepratura
            // 
            this.btnTemepratura.Font = new System.Drawing.Font("Didot", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemepratura.Location = new System.Drawing.Point(12, 118);
            this.btnTemepratura.Name = "btnTemepratura";
            this.btnTemepratura.Size = new System.Drawing.Size(131, 31);
            this.btnTemepratura.TabIndex = 2;
            this.btnTemepratura.Text = "Temperatura";
            this.btnTemepratura.UseVisualStyleBackColor = true;
            // 
            // btnVolumen
            // 
            this.btnVolumen.Font = new System.Drawing.Font("Didot", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolumen.Location = new System.Drawing.Point(12, 173);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(98, 31);
            this.btnVolumen.TabIndex = 3;
            this.btnVolumen.Text = "Volumen";
            this.btnVolumen.UseVisualStyleBackColor = true;
            // 
            // btnMasa
            // 
            this.btnMasa.Font = new System.Drawing.Font("Didot", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasa.Location = new System.Drawing.Point(12, 228);
            this.btnMasa.Name = "btnMasa";
            this.btnMasa.Size = new System.Drawing.Size(88, 31);
            this.btnMasa.TabIndex = 4;
            this.btnMasa.Text = "Masa";
            this.btnMasa.UseVisualStyleBackColor = true;
            // 
            // btnData
            // 
            this.btnData.Font = new System.Drawing.Font("Didot", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.Location = new System.Drawing.Point(12, 283);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(88, 31);
            this.btnData.TabIndex = 5;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = true;
            // 
            // btnVelocidad
            // 
            this.btnVelocidad.Font = new System.Drawing.Font("Didot", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVelocidad.Location = new System.Drawing.Point(12, 336);
            this.btnVelocidad.Name = "btnVelocidad";
            this.btnVelocidad.Size = new System.Drawing.Size(109, 31);
            this.btnVelocidad.TabIndex = 6;
            this.btnVelocidad.Text = "Velocidad";
            this.btnVelocidad.UseVisualStyleBackColor = true;
            // 
            // btnTiempo
            // 
            this.btnTiempo.Font = new System.Drawing.Font("Didot", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiempo.Location = new System.Drawing.Point(12, 391);
            this.btnTiempo.Name = "btnTiempo";
            this.btnTiempo.Size = new System.Drawing.Size(88, 31);
            this.btnTiempo.TabIndex = 7;
            this.btnTiempo.Text = "Tiempo";
            this.btnTiempo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTiempo);
            this.Controls.Add(this.btnVelocidad);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnMasa);
            this.Controls.Add(this.btnVolumen);
            this.Controls.Add(this.btnTemepratura);
            this.Controls.Add(this.btnDistancia);
            this.Controls.Add(this.btnArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de Unidades";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnDistancia;
        private System.Windows.Forms.Button btnTemepratura;
        private System.Windows.Forms.Button btnVolumen;
        private System.Windows.Forms.Button btnMasa;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnVelocidad;
        private System.Windows.Forms.Button btnTiempo;
    }
}

