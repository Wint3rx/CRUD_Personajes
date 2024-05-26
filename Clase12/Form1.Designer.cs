namespace Clase12
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
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.Cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.numericUpDownNivelPoder = new System.Windows.Forms.NumericUpDown();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.textBoxHistoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(1541, 813);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(192, 56);
            this.buttonPrueba.TabIndex = 0;
            this.buttonPrueba.Text = "Boton Prueba";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            this.buttonPrueba.Click += new System.EventHandler(this.buttonPrueba_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(12, 467);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.RowHeadersWidth = 82;
            this.dataGridViewPersonajes.RowTemplate.Height = 33;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(1145, 402);
            this.dataGridViewPersonajes.TabIndex = 1;
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(1163, 467);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(156, 48);
            this.Cargar.TabIndex = 2;
            this.Cargar.Text = "Cargar Datos";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Power";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(211, 36);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(223, 31);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(211, 97);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(223, 31);
            this.textBoxNombre.TabIndex = 8;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(483, 97);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(124, 40);
            this.buttonCrear.TabIndex = 11;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // numericUpDownNivelPoder
            // 
            this.numericUpDownNivelPoder.Location = new System.Drawing.Point(211, 222);
            this.numericUpDownNivelPoder.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownNivelPoder.Name = "numericUpDownNivelPoder";
            this.numericUpDownNivelPoder.Size = new System.Drawing.Size(223, 31);
            this.numericUpDownNivelPoder.TabIndex = 12;
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(211, 161);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(223, 33);
            this.comboBoxRaza.TabIndex = 14;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(483, 31);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(124, 36);
            this.buttonBuscar.TabIndex = 15;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha de Creacion";
            // 
            // dateTimePickerFechaCreacion
            // 
            this.dateTimePickerFechaCreacion.Location = new System.Drawing.Point(299, 296);
            this.dateTimePickerFechaCreacion.Name = "dateTimePickerFechaCreacion";
            this.dateTimePickerFechaCreacion.Size = new System.Drawing.Size(397, 31);
            this.dateTimePickerFechaCreacion.TabIndex = 17;
            // 
            // textBoxHistoria
            // 
            this.textBoxHistoria.Location = new System.Drawing.Point(211, 353);
            this.textBoxHistoria.Name = "textBoxHistoria";
            this.textBoxHistoria.Size = new System.Drawing.Size(222, 31);
            this.textBoxHistoria.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Historia";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(483, 161);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(123, 48);
            this.buttonLimpiar.TabIndex = 20;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 912);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxHistoria);
            this.Controls.Add(this.dateTimePickerFechaCreacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.numericUpDownNivelPoder);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.buttonPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrueba;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.NumericUpDown numericUpDownNivelPoder;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCreacion;
        private System.Windows.Forms.TextBox textBoxHistoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

