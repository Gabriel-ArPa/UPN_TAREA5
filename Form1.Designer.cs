namespace Intento1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txttalla = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnVoley = new System.Windows.Forms.Button();
            this.btnFutbol = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxDeporte = new System.Windows.Forms.ComboBox();
            this.cbxEquipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TALLA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "PESO:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(153, 37);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(152, 22);
            this.txtnombre.TabIndex = 4;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(153, 154);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(152, 22);
            this.txtpeso.TabIndex = 5;
            // 
            // txttalla
            // 
            this.txttalla.Location = new System.Drawing.Point(153, 115);
            this.txttalla.Name = "txttalla";
            this.txttalla.Size = new System.Drawing.Size(152, 22);
            this.txttalla.TabIndex = 6;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(153, 74);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(152, 22);
            this.txtapellido.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 236);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Location = new System.Drawing.Point(59, 477);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(142, 44);
            this.btnAlumnos.TabIndex = 11;
            this.btnAlumnos.Text = "VER ALUMNOS";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnVoley
            // 
            this.btnVoley.Location = new System.Drawing.Point(582, 477);
            this.btnVoley.Name = "btnVoley";
            this.btnVoley.Size = new System.Drawing.Size(142, 44);
            this.btnVoley.TabIndex = 12;
            this.btnVoley.Text = "VOLEY";
            this.btnVoley.UseVisualStyleBackColor = true;
            this.btnVoley.Click += new System.EventHandler(this.btnVoley_Click);
            // 
            // btnFutbol
            // 
            this.btnFutbol.Location = new System.Drawing.Point(322, 477);
            this.btnFutbol.Name = "btnFutbol";
            this.btnFutbol.Size = new System.Drawing.Size(142, 44);
            this.btnFutbol.TabIndex = 13;
            this.btnFutbol.Text = "FUTBOL";
            this.btnFutbol.UseVisualStyleBackColor = true;
            this.btnFutbol.Click += new System.EventHandler(this.btnFutbol_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "EQUIPO:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "DEPORTE:";
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.FormattingEnabled = true;
            this.cbxDeporte.Items.AddRange(new object[] {
            "FUTBOL",
            "VOLEY"});
            this.cbxDeporte.Location = new System.Drawing.Point(448, 37);
            this.cbxDeporte.Name = "cbxDeporte";
            this.cbxDeporte.Size = new System.Drawing.Size(179, 24);
            this.cbxDeporte.TabIndex = 16;
            // 
            // cbxEquipo
            // 
            this.cbxEquipo.FormattingEnabled = true;
            this.cbxEquipo.Items.AddRange(new object[] {
            "EQUIPOA",
            "EQUIPOB"});
            this.cbxEquipo.Location = new System.Drawing.Point(448, 74);
            this.cbxEquipo.Name = "cbxEquipo";
            this.cbxEquipo.Size = new System.Drawing.Size(179, 24);
            this.cbxEquipo.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(672, 157);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 30);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "SEXO:";
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "HOMBRE",
            "MUJER"});
            this.cbxSexo.Location = new System.Drawing.Point(448, 115);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(179, 24);
            this.cbxSexo.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "ESTADO:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "TITULAR",
            "SUPLENTE"});
            this.cbxEstado.Location = new System.Drawing.Point(448, 154);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(179, 24);
            this.cbxEstado.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 556);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxEquipo);
            this.Controls.Add(this.cbxDeporte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFutbol);
            this.Controls.Add(this.btnVoley);
            this.Controls.Add(this.btnAlumnos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txttalla);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txttalla;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnVoley;
        private System.Windows.Forms.Button btnFutbol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxDeporte;
        private System.Windows.Forms.ComboBox cbxEquipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxEstado;
    }
}

