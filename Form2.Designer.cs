namespace Intento1
{
    partial class Form2
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
            this.btnIniciarPartido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGanador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnGolB1 = new System.Windows.Forms.Button();
            this.btnDescanso = new System.Windows.Forms.Button();
            this.btnGolA1 = new System.Windows.Forms.Button();
            this.txtEquipoB = new System.Windows.Forms.TextBox();
            this.txtEquipoA = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarPartido
            // 
            this.btnIniciarPartido.Location = new System.Drawing.Point(525, 51);
            this.btnIniciarPartido.Name = "btnIniciarPartido";
            this.btnIniciarPartido.Size = new System.Drawing.Size(139, 34);
            this.btnIniciarPartido.TabIndex = 0;
            this.btnIniciarPartido.Text = "INICIAR PARTIDO";
            this.btnIniciarPartido.UseVisualStyleBackColor = true;
            this.btnIniciarPartido.Click += new System.EventHandler(this.btnIniciarPartido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partido Futbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "EQUIPO A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "EQUIPO B";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(191, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "/ VS /";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGanador);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.btnGolB1);
            this.groupBox1.Controls.Add(this.btnDescanso);
            this.groupBox1.Controls.Add(this.btnGolA1);
            this.groupBox1.Controls.Add(this.txtEquipoB);
            this.groupBox1.Controls.Add(this.txtEquipoA);
            this.groupBox1.Controls.Add(this.btnIniciarPartido);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 299);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENCUENTRO";
            // 
            // txtGanador
            // 
            this.txtGanador.Location = new System.Drawing.Point(146, 232);
            this.txtGanador.Name = "txtGanador";
            this.txtGanador.ReadOnly = true;
            this.txtGanador.Size = new System.Drawing.Size(146, 22);
            this.txtGanador.TabIndex = 36;
            this.txtGanador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "GANADOR";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(525, 226);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(139, 34);
            this.btnFinalizar.TabIndex = 34;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnGolB1
            // 
            this.btnGolB1.Enabled = false;
            this.btnGolB1.Location = new System.Drawing.Point(304, 138);
            this.btnGolB1.Name = "btnGolB1";
            this.btnGolB1.Size = new System.Drawing.Size(100, 34);
            this.btnGolB1.TabIndex = 31;
            this.btnGolB1.Text = "GOL \"B\"";
            this.btnGolB1.UseVisualStyleBackColor = true;
            this.btnGolB1.Click += new System.EventHandler(this.btnGolB1_Click);
            // 
            // btnDescanso
            // 
            this.btnDescanso.Enabled = false;
            this.btnDescanso.Location = new System.Drawing.Point(525, 138);
            this.btnDescanso.Name = "btnDescanso";
            this.btnDescanso.Size = new System.Drawing.Size(139, 34);
            this.btnDescanso.TabIndex = 30;
            this.btnDescanso.Text = "DESCANSO";
            this.btnDescanso.UseVisualStyleBackColor = true;
            this.btnDescanso.Click += new System.EventHandler(this.btnDescanso_Click);
            // 
            // btnGolA1
            // 
            this.btnGolA1.Enabled = false;
            this.btnGolA1.Location = new System.Drawing.Point(48, 138);
            this.btnGolA1.Name = "btnGolA1";
            this.btnGolA1.Size = new System.Drawing.Size(100, 34);
            this.btnGolA1.TabIndex = 32;
            this.btnGolA1.Text = "GOL \"A\"";
            this.btnGolA1.UseVisualStyleBackColor = true;
            this.btnGolA1.Click += new System.EventHandler(this.btnGolA1_Click);
            // 
            // txtEquipoB
            // 
            this.txtEquipoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipoB.Location = new System.Drawing.Point(293, 63);
            this.txtEquipoB.Name = "txtEquipoB";
            this.txtEquipoB.ReadOnly = true;
            this.txtEquipoB.Size = new System.Drawing.Size(120, 38);
            this.txtEquipoB.TabIndex = 30;
            this.txtEquipoB.Text = "0";
            this.txtEquipoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipoA
            // 
            this.txtEquipoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipoA.Location = new System.Drawing.Point(38, 63);
            this.txtEquipoA.Name = "txtEquipoA";
            this.txtEquipoA.ReadOnly = true;
            this.txtEquipoA.Size = new System.Drawing.Size(120, 38);
            this.txtEquipoA.TabIndex = 29;
            this.txtEquipoA.Text = "0";
            this.txtEquipoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMensaje
            // 
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(29, 380);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(694, 42);
            this.lblMensaje.TabIndex = 30;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarPartido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGolB1;
        private System.Windows.Forms.Button btnGolA1;
        private System.Windows.Forms.TextBox txtEquipoB;
        private System.Windows.Forms.TextBox txtEquipoA;
        private System.Windows.Forms.Button btnDescanso;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtGanador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMensaje;
    }
}