namespace PigeonholeSortJavierChavarria
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.Ordenamiento = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los numeros separado por comas";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 45);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(133, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(15, 86);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(82, 30);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Ordenar";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Ordenamiento
            // 
            this.Ordenamiento.FormattingEnabled = true;
            this.Ordenamiento.Location = new System.Drawing.Point(15, 184);
            this.Ordenamiento.Name = "Ordenamiento";
            this.Ordenamiento.Size = new System.Drawing.Size(213, 147);
            this.Ordenamiento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultados Ordenados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(264, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ordenamiento);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pigeonhole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox Ordenamiento;
        private System.Windows.Forms.Label label2;
    }
}

