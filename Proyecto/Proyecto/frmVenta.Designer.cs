namespace PROYECTO_U3
{
    partial class frmVenta
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(149, 47);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(88, 37);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Inicio";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.BackColor = System.Drawing.Color.Transparent;
            this.lblFin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.ForeColor = System.Drawing.Color.White;
            this.lblFin.Location = new System.Drawing.Point(461, 47);
            this.lblFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(55, 37);
            this.lblFin.TabIndex = 1;
            this.lblFin.Text = "Fin";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(60, 91);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(272, 26);
            this.dtpInicio.TabIndex = 2;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(363, 91);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(265, 26);
            this.dtpFin.TabIndex = 3;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(60, 145);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.Size = new System.Drawing.Size(959, 288);
            this.dgvVentas.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(424, 465);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 41);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(583, 465);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 41);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(741, 465);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 41);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(900, 465);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 41);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(652, 78);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(125, 41);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodo.ForeColor = System.Drawing.Color.White;
            this.btnTodo.Location = new System.Drawing.Point(803, 78);
            this.btnTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(125, 41);
            this.btnTodo.TabIndex = 10;
            this.btnTodo.Text = "Ver todas";
            this.btnTodo.UseVisualStyleBackColor = false;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(60, 452);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(168, 28);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Ventas Realizadas:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.BackColor = System.Drawing.Color.Transparent;
            this.lblCant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.ForeColor = System.Drawing.Color.White;
            this.lblCant.Location = new System.Drawing.Point(248, 452);
            this.lblCant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(23, 28);
            this.lblCant.TabIndex = 12;
            this.lblCant.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(84, 500);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(149, 28);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total Generado:";
            // 
            // lblPTotal
            // 
            this.lblPTotal.AutoSize = true;
            this.lblPTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTotal.ForeColor = System.Drawing.Color.White;
            this.lblPTotal.Location = new System.Drawing.Point(236, 500);
            this.lblPTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPTotal.Name = "lblPTotal";
            this.lblPTotal.Size = new System.Drawing.Size(34, 28);
            this.lblPTotal.TabIndex = 14;
            this.lblPTotal.Text = "$0";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_U3.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblPTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVenta_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVenta_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPTotal;
    }
}