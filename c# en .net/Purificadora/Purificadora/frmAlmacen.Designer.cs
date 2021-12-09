namespace Purificadora
{
    partial class frmAlmacen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtANombre = new System.Windows.Forms.TextBox();
            this.txtADescripcion = new System.Windows.Forms.TextBox();
            this.txtACantidad = new System.Windows.Forms.TextBox();
            this.btnAGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // txtANombre
            // 
            this.txtANombre.Location = new System.Drawing.Point(159, 65);
            this.txtANombre.Name = "txtANombre";
            this.txtANombre.Size = new System.Drawing.Size(100, 20);
            this.txtANombre.TabIndex = 6;
            // 
            // txtADescripcion
            // 
            this.txtADescripcion.Location = new System.Drawing.Point(159, 116);
            this.txtADescripcion.Name = "txtADescripcion";
            this.txtADescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtADescripcion.TabIndex = 7;
            // 
            // txtACantidad
            // 
            this.txtACantidad.Location = new System.Drawing.Point(159, 164);
            this.txtACantidad.Name = "txtACantidad";
            this.txtACantidad.Size = new System.Drawing.Size(100, 20);
            this.txtACantidad.TabIndex = 8;
            // 
            // btnAGuardar
            // 
            this.btnAGuardar.Location = new System.Drawing.Point(41, 204);
            this.btnAGuardar.Name = "btnAGuardar";
            this.btnAGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnAGuardar.TabIndex = 9;
            this.btnAGuardar.Text = "Guardar";
            this.btnAGuardar.UseVisualStyleBackColor = true;
            this.btnAGuardar.Click += new System.EventHandler(this.btnAGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(280, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Location = new System.Drawing.Point(41, 247);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.Size = new System.Drawing.Size(606, 170);
            this.dgvAlmacen.TabIndex = 11;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(159, 204);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvAlmacen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAGuardar);
            this.Controls.Add(this.txtACantidad);
            this.Controls.Add(this.txtADescripcion);
            this.Controls.Add(this.txtANombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlmacen";
            this.Text = "frmAlmacen";
            this.Load += new System.EventHandler(this.frmAlmacen_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtANombre, 0);
            this.Controls.SetChildIndex(this.txtADescripcion, 0);
            this.Controls.SetChildIndex(this.txtACantidad, 0);
            this.Controls.SetChildIndex(this.btnAGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.dgvAlmacen, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtANombre;
        private System.Windows.Forms.TextBox txtADescripcion;
        private System.Windows.Forms.TextBox txtACantidad;
        private System.Windows.Forms.Button btnAGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvAlmacen;
        private System.Windows.Forms.Button btnEditar;
    }
}