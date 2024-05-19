namespace PROYECTO_U3
{
    partial class frmAEVenta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPIva = new System.Windows.Forms.Label();
            this.lblPSub = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblPTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1084, 183);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvOrden
            // 
            this.dgvOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrden.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Location = new System.Drawing.Point(60, 194);
            this.dgvOrden.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.RowHeadersWidth = 51;
            this.dgvOrden.Size = new System.Drawing.Size(951, 230);
            this.dgvOrden.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(352, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Extra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(336, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(573, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Comentarios:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Todas",
            "Jugo",
            "Licuado",
            "Galletas",
            "Pan",
            "Fruta",
            "Postre",
            "Bebida Caliente"});
            this.cbxCategoria.Location = new System.Drawing.Point(47, 42);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(213, 29);
            this.cbxCategoria.TabIndex = 7;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged_1);
            // 
            // cbxProducto
            // 
            this.cbxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(47, 117);
            this.cbxProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(213, 29);
            this.cbxProducto.TabIndex = 8;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(316, 119);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 29);
            this.txtCantidad.TabIndex = 9;
            // 
            // txtCom
            // 
            this.txtCom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCom.Location = new System.Drawing.Point(476, 42);
            this.txtCom.Margin = new System.Windows.Forms.Padding(4);
            this.txtCom.Multiline = true;
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(360, 107);
            this.txtCom.TabIndex = 10;
            // 
            // txtExtra
            // 
            this.txtExtra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtra.Location = new System.Drawing.Point(316, 42);
            this.txtExtra.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(132, 29);
            this.txtExtra.TabIndex = 11;
            this.txtExtra.TextChanged += new System.EventHandler(this.txtExtra_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(444, 491);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(115, 44);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(595, 491);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 44);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(745, 491);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 44);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(896, 491);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(115, 44);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(199)))), ((int)(((byte)(162)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(896, 66);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 44);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPIva
            // 
            this.lblPIva.AutoSize = true;
            this.lblPIva.BackColor = System.Drawing.Color.Transparent;
            this.lblPIva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIva.ForeColor = System.Drawing.Color.White;
            this.lblPIva.Location = new System.Drawing.Point(180, 471);
            this.lblPIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPIva.Name = "lblPIva";
            this.lblPIva.Size = new System.Drawing.Size(34, 28);
            this.lblPIva.TabIndex = 27;
            this.lblPIva.Text = "$0";
            // 
            // lblPSub
            // 
            this.lblPSub.AutoSize = true;
            this.lblPSub.BackColor = System.Drawing.Color.Transparent;
            this.lblPSub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSub.ForeColor = System.Drawing.Color.White;
            this.lblPSub.Location = new System.Drawing.Point(180, 442);
            this.lblPSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPSub.Name = "lblPSub";
            this.lblPSub.Size = new System.Drawing.Size(34, 28);
            this.lblPSub.TabIndex = 26;
            this.lblPSub.Text = "$0";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.Color.White;
            this.lblIVA.Location = new System.Drawing.Point(117, 471);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(50, 28);
            this.lblIVA.TabIndex = 25;
            this.lblIVA.Text = "IVA:";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.White;
            this.lblSub.Location = new System.Drawing.Point(69, 442);
            this.lblSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(98, 28);
            this.lblSub.TabIndex = 24;
            this.lblSub.Text = "Subtotal:";
            // 
            // lblPTotal
            // 
            this.lblPTotal.AutoSize = true;
            this.lblPTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTotal.ForeColor = System.Drawing.Color.White;
            this.lblPTotal.Location = new System.Drawing.Point(180, 517);
            this.lblPTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPTotal.Name = "lblPTotal";
            this.lblPTotal.Size = new System.Drawing.Size(34, 28);
            this.lblPTotal.TabIndex = 29;
            this.lblPTotal.Text = "$0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(103, 517);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 28);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total:";
            // 
            // frmAEVenta
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_U3.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 581);
            this.Controls.Add(this.lblPTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPIva);
            this.Controls.Add(this.lblPSub);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrden);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAEVenta";
            this.Text = "frmAEVenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAEVenta_FormClosed);
            this.Load += new System.EventHandler(this.frmAEVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPIva;
        private System.Windows.Forms.Label lblPSub;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblPTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}