
namespace BoeNewClients
{
    partial class BoeNewClients
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cargarClientes = new System.Windows.Forms.Button();
            this.calendarioCargarClientes = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridResultados = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboProvincias = new System.Windows.Forms.ComboBox();
            this.buscarClientes = new System.Windows.Forms.Button();
            this.calendarioBuscador = new System.Windows.Forms.DateTimePicker();
            this.diasMarcados = new System.Windows.Forms.GroupBox();
            this.calendarioMarcado = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.diasMarcados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cargarClientes);
            this.groupBox1.Controls.Add(this.calendarioCargarClientes);
            this.groupBox1.Location = new System.Drawing.Point(506, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar nuevos clientes";
            // 
            // cargarClientes
            // 
            this.cargarClientes.Location = new System.Drawing.Point(23, 63);
            this.cargarClientes.Name = "cargarClientes";
            this.cargarClientes.Size = new System.Drawing.Size(201, 21);
            this.cargarClientes.TabIndex = 1;
            this.cargarClientes.Text = "Cargar Clientes";
            this.cargarClientes.UseVisualStyleBackColor = true;
            this.cargarClientes.Click += new System.EventHandler(this.cargarClientes_Click);
            // 
            // calendarioCargarClientes
            // 
            this.calendarioCargarClientes.Location = new System.Drawing.Point(22, 28);
            this.calendarioCargarClientes.Name = "calendarioCargarClientes";
            this.calendarioCargarClientes.Size = new System.Drawing.Size(202, 20);
            this.calendarioCargarClientes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1094, 445);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar clientes";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridResultados);
            this.groupBox4.Location = new System.Drawing.Point(14, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1065, 315);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultados";
            // 
            // dataGridResultados
            // 
            this.dataGridResultados.AllowUserToAddRows = false;
            this.dataGridResultados.AllowUserToDeleteRows = false;
            this.dataGridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResultados.Location = new System.Drawing.Point(16, 19);
            this.dataGridResultados.Name = "dataGridResultados";
            this.dataGridResultados.Size = new System.Drawing.Size(1004, 282);
            this.dataGridResultados.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboProvincias);
            this.groupBox3.Controls.Add(this.buscarClientes);
            this.groupBox3.Controls.Add(this.calendarioBuscador);
            this.groupBox3.Location = new System.Drawing.Point(12, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1067, 76);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscador";
            // 
            // comboProvincias
            // 
            this.comboProvincias.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboProvincias.FormattingEnabled = true;
            this.comboProvincias.Location = new System.Drawing.Point(414, 29);
            this.comboProvincias.Name = "comboProvincias";
            this.comboProvincias.Size = new System.Drawing.Size(269, 21);
            this.comboProvincias.Sorted = true;
            this.comboProvincias.TabIndex = 2;
            this.comboProvincias.Text = "- Elige una provincia -";
            this.comboProvincias.SelectedIndexChanged += new System.EventHandler(this.comboProvincias_SelectedIndexChanged);
            // 
            // buscarClientes
            // 
            this.buscarClientes.Location = new System.Drawing.Point(739, 30);
            this.buscarClientes.Name = "buscarClientes";
            this.buscarClientes.Size = new System.Drawing.Size(195, 24);
            this.buscarClientes.TabIndex = 1;
            this.buscarClientes.Text = "Buscar";
            this.buscarClientes.UseVisualStyleBackColor = true;
            this.buscarClientes.Click += new System.EventHandler(this.buscarClientes_Click);
            // 
            // calendarioBuscador
            // 
            this.calendarioBuscador.Location = new System.Drawing.Point(18, 30);
            this.calendarioBuscador.Name = "calendarioBuscador";
            this.calendarioBuscador.Size = new System.Drawing.Size(345, 20);
            this.calendarioBuscador.TabIndex = 0;
            // 
            // diasMarcados
            // 
            this.diasMarcados.Controls.Add(this.calendarioMarcado);
            this.diasMarcados.Location = new System.Drawing.Point(13, 13);
            this.diasMarcados.Name = "diasMarcados";
            this.diasMarcados.Size = new System.Drawing.Size(474, 212);
            this.diasMarcados.TabIndex = 2;
            this.diasMarcados.TabStop = false;
            this.diasMarcados.Text = "Días cargados";
            // 
            // calendarioMarcado
            // 
            this.calendarioMarcado.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.calendarioMarcado.Location = new System.Drawing.Point(29, 25);
            this.calendarioMarcado.Name = "calendarioMarcado";
            this.calendarioMarcado.TabIndex = 0;
            this.calendarioMarcado.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarioMarcado_DateChanged);
            // 
            // BoeNewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 682);
            this.Controls.Add(this.diasMarcados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BoeNewClients";
            this.Text = "Boe new clients";
            this.Load += new System.EventHandler(this.BoeNewClients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.diasMarcados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cargarClientes;
        private System.Windows.Forms.DateTimePicker calendarioCargarClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridResultados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buscarClientes;
        private System.Windows.Forms.DateTimePicker calendarioBuscador;
        private System.Windows.Forms.GroupBox diasMarcados;
        private System.Windows.Forms.MonthCalendar calendarioMarcado;
        private System.Windows.Forms.ComboBox comboProvincias;
    }
}

