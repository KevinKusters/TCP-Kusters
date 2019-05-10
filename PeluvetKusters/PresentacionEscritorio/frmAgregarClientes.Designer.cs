namespace PresentacionEscritorio
{
    partial class frmAgregarClientes
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
            this.dgbAgregarCliente = new System.Windows.Forms.DataGridView();
            this.lblOtro = new System.Windows.Forms.Label();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbOtro = new System.Windows.Forms.RadioButton();
            this.rbtGato = new System.Windows.Forms.RadioButton();
            this.rbtPerro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMasc = new System.Windows.Forms.Label();
            this.lblCli = new System.Windows.Forms.Label();
            this.lblApellidoMasc = new System.Windows.Forms.Label();
            this.lblNombreMasc = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblApellidoCli = new System.Windows.Forms.Label();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.txtNombreMasc = new System.Windows.Forms.TextBox();
            this.txtApellidoMasc = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtApellidoCli = new System.Windows.Forms.TextBox();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbAgregarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbAgregarCliente
            // 
            this.dgbAgregarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbAgregarCliente.Location = new System.Drawing.Point(331, 14);
            this.dgbAgregarCliente.Name = "dgbAgregarCliente";
            this.dgbAgregarCliente.Size = new System.Drawing.Size(382, 397);
            this.dgbAgregarCliente.TabIndex = 54;
            // 
            // lblOtro
            // 
            this.lblOtro.AutoSize = true;
            this.lblOtro.Location = new System.Drawing.Point(90, 225);
            this.lblOtro.Name = "lblOtro";
            this.lblOtro.Size = new System.Drawing.Size(33, 13);
            this.lblOtro.TabIndex = 53;
            this.lblOtro.Text = "Otro: ";
            // 
            // txtOtro
            // 
            this.txtOtro.Location = new System.Drawing.Point(152, 225);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(154, 20);
            this.txtOtro.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Especie: ";
            // 
            // rdbOtro
            // 
            this.rdbOtro.AutoSize = true;
            this.rdbOtro.Checked = true;
            this.rdbOtro.Location = new System.Drawing.Point(261, 195);
            this.rdbOtro.Name = "rdbOtro";
            this.rdbOtro.Size = new System.Drawing.Size(45, 17);
            this.rdbOtro.TabIndex = 50;
            this.rdbOtro.TabStop = true;
            this.rdbOtro.Text = "Otro";
            this.rdbOtro.UseVisualStyleBackColor = true;
            // 
            // rbtGato
            // 
            this.rbtGato.AutoSize = true;
            this.rbtGato.Location = new System.Drawing.Point(207, 195);
            this.rbtGato.Name = "rbtGato";
            this.rbtGato.Size = new System.Drawing.Size(48, 17);
            this.rbtGato.TabIndex = 49;
            this.rbtGato.Text = "Gato";
            this.rbtGato.UseVisualStyleBackColor = true;
            // 
            // rbtPerro
            // 
            this.rbtPerro.AutoSize = true;
            this.rbtPerro.Location = new System.Drawing.Point(151, 195);
            this.rbtPerro.Name = "rbtPerro";
            this.rbtPerro.Size = new System.Drawing.Size(50, 17);
            this.rbtPerro.TabIndex = 48;
            this.rbtPerro.Text = "Perro";
            this.rbtPerro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Raza: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(543, 417);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(170, 23);
            this.btnmodificar.TabIndex = 45;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(215, 417);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(90, 417);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 23);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Agregar Mascota";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblMasc
            // 
            this.lblMasc.AutoSize = true;
            this.lblMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasc.Location = new System.Drawing.Point(90, 154);
            this.lblMasc.Name = "lblMasc";
            this.lblMasc.Size = new System.Drawing.Size(94, 25);
            this.lblMasc.TabIndex = 41;
            this.lblMasc.Text = "Mascota";
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCli.Location = new System.Drawing.Point(90, 11);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(79, 25);
            this.lblCli.TabIndex = 40;
            this.lblCli.Text = "Cliente";
            // 
            // lblApellidoMasc
            // 
            this.lblApellidoMasc.AutoSize = true;
            this.lblApellidoMasc.Location = new System.Drawing.Point(90, 295);
            this.lblApellidoMasc.Name = "lblApellidoMasc";
            this.lblApellidoMasc.Size = new System.Drawing.Size(50, 13);
            this.lblApellidoMasc.TabIndex = 39;
            this.lblApellidoMasc.Text = "Apellido: ";
            // 
            // lblNombreMasc
            // 
            this.lblNombreMasc.AutoSize = true;
            this.lblNombreMasc.Location = new System.Drawing.Point(90, 269);
            this.lblNombreMasc.Name = "lblNombreMasc";
            this.lblNombreMasc.Size = new System.Drawing.Size(50, 13);
            this.lblNombreMasc.TabIndex = 38;
            this.lblNombreMasc.Text = "Nombre: ";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(90, 128);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(56, 13);
            this.lblContacto.TabIndex = 37;
            this.lblContacto.Text = "Contacto: ";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(90, 102);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(59, 13);
            this.lblLocalidad.TabIndex = 36;
            this.lblLocalidad.Text = "Localidad: ";
            // 
            // lblApellidoCli
            // 
            this.lblApellidoCli.AutoSize = true;
            this.lblApellidoCli.Location = new System.Drawing.Point(90, 76);
            this.lblApellidoCli.Name = "lblApellidoCli";
            this.lblApellidoCli.Size = new System.Drawing.Size(50, 13);
            this.lblApellidoCli.TabIndex = 35;
            this.lblApellidoCli.Text = "Apellido: ";
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Location = new System.Drawing.Point(90, 46);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(50, 13);
            this.lblNombreCli.TabIndex = 34;
            this.lblNombreCli.Text = "Nombre: ";
            // 
            // txtNombreMasc
            // 
            this.txtNombreMasc.Location = new System.Drawing.Point(150, 266);
            this.txtNombreMasc.Name = "txtNombreMasc";
            this.txtNombreMasc.Size = new System.Drawing.Size(156, 20);
            this.txtNombreMasc.TabIndex = 33;
            // 
            // txtApellidoMasc
            // 
            this.txtApellidoMasc.Location = new System.Drawing.Point(150, 292);
            this.txtApellidoMasc.Name = "txtApellidoMasc";
            this.txtApellidoMasc.Size = new System.Drawing.Size(156, 20);
            this.txtApellidoMasc.TabIndex = 32;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(150, 121);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(156, 20);
            this.txtContacto.TabIndex = 31;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(150, 95);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(156, 20);
            this.txtLocalidad.TabIndex = 30;
            // 
            // txtApellidoCli
            // 
            this.txtApellidoCli.Location = new System.Drawing.Point(150, 69);
            this.txtApellidoCli.Name = "txtApellidoCli";
            this.txtApellidoCli.Size = new System.Drawing.Size(156, 20);
            this.txtApellidoCli.TabIndex = 29;
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Location = new System.Drawing.Point(150, 43);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(156, 20);
            this.txtNombreCli.TabIndex = 28;
            // 
            // frmAgregarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgbAgregarCliente);
            this.Controls.Add(this.lblOtro);
            this.Controls.Add(this.txtOtro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbOtro);
            this.Controls.Add(this.rbtGato);
            this.Controls.Add(this.rbtPerro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMasc);
            this.Controls.Add(this.lblCli);
            this.Controls.Add(this.lblApellidoMasc);
            this.Controls.Add(this.lblNombreMasc);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblApellidoCli);
            this.Controls.Add(this.lblNombreCli);
            this.Controls.Add(this.txtNombreMasc);
            this.Controls.Add(this.txtApellidoMasc);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtApellidoCli);
            this.Controls.Add(this.txtNombreCli);
            this.Name = "frmAgregarClientes";
            this.Text = "frmAgregarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgbAgregarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbAgregarCliente;
        private System.Windows.Forms.Label lblOtro;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbOtro;
        private System.Windows.Forms.RadioButton rbtGato;
        private System.Windows.Forms.RadioButton rbtPerro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMasc;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.Label lblApellidoMasc;
        private System.Windows.Forms.Label lblNombreMasc;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblApellidoCli;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.TextBox txtNombreMasc;
        private System.Windows.Forms.TextBox txtApellidoMasc;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtApellidoCli;
        private System.Windows.Forms.TextBox txtNombreCli;
    }
}