namespace Atencion_de_procesos
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtCiclosVacios = new System.Windows.Forms.TextBox();
            this.txtProcesoComp = new System.Windows.Forms.TextBox();
            this.txtProcesoPen = new System.Windows.Forms.TextBox();
            this.txtCiclosPen = new System.Windows.Forms.TextBox();
            this.lblCiclosVacios = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(144, 64);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtCiclosVacios
            // 
            this.txtCiclosVacios.Location = new System.Drawing.Point(135, 109);
            this.txtCiclosVacios.Name = "txtCiclosVacios";
            this.txtCiclosVacios.Size = new System.Drawing.Size(100, 20);
            this.txtCiclosVacios.TabIndex = 1;
            // 
            // txtProcesoComp
            // 
            this.txtProcesoComp.Location = new System.Drawing.Point(135, 135);
            this.txtProcesoComp.Name = "txtProcesoComp";
            this.txtProcesoComp.Size = new System.Drawing.Size(100, 20);
            this.txtProcesoComp.TabIndex = 2;
            // 
            // txtProcesoPen
            // 
            this.txtProcesoPen.Location = new System.Drawing.Point(135, 163);
            this.txtProcesoPen.Name = "txtProcesoPen";
            this.txtProcesoPen.Size = new System.Drawing.Size(100, 20);
            this.txtProcesoPen.TabIndex = 3;
            // 
            // txtCiclosPen
            // 
            this.txtCiclosPen.Location = new System.Drawing.Point(135, 189);
            this.txtCiclosPen.Name = "txtCiclosPen";
            this.txtCiclosPen.Size = new System.Drawing.Size(100, 20);
            this.txtCiclosPen.TabIndex = 4;
            // 
            // lblCiclosVacios
            // 
            this.lblCiclosVacios.AutoSize = true;
            this.lblCiclosVacios.Location = new System.Drawing.Point(54, 112);
            this.lblCiclosVacios.Name = "lblCiclosVacios";
            this.lblCiclosVacios.Size = new System.Drawing.Size(75, 13);
            this.lblCiclosVacios.TabIndex = 5;
            this.lblCiclosVacios.Text = "Ciclos Vacíos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Procesos completados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Procesos pendientes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ciclos pendientes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 254);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCiclosVacios);
            this.Controls.Add(this.txtCiclosPen);
            this.Controls.Add(this.txtProcesoPen);
            this.Controls.Add(this.txtProcesoComp);
            this.Controls.Add(this.txtCiclosVacios);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtCiclosVacios;
        private System.Windows.Forms.TextBox txtProcesoComp;
        private System.Windows.Forms.TextBox txtProcesoPen;
        private System.Windows.Forms.TextBox txtCiclosPen;
        private System.Windows.Forms.Label lblCiclosVacios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

