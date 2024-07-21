
namespace Interfaces
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
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.tablaDeDatos = new System.Windows.Forms.DataGridView();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.TextboxNombre = new System.Windows.Forms.TextBox();
            this.TextboxApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.TextboxIDBaja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextboxNombreModificacion = new System.Windows.Forms.TextBox();
            this.TextboxIDModificacion = new System.Windows.Forms.TextBox();
            this.TextboxApellidoModificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TextboxBusquedaNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextboxBusquedaID = new System.Windows.Forms.TextBox();
            this.TextboxBusquedaApellido = new System.Windows.Forms.TextBox();
            this.BotonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(96, 98);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(75, 23);
            this.BotonGuardar.TabIndex = 0;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // tablaDeDatos
            // 
            this.tablaDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeDatos.Location = new System.Drawing.Point(359, 12);
            this.tablaDeDatos.Name = "tablaDeDatos";
            this.tablaDeDatos.Size = new System.Drawing.Size(342, 426);
            this.tablaDeDatos.TabIndex = 1;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(12, 49);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(44, 13);
            this.LabelNombre.TabIndex = 2;
            this.LabelNombre.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(12, 75);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 3;
            this.Apellido.Text = "Apellido";
            // 
            // TextboxNombre
            // 
            this.TextboxNombre.Location = new System.Drawing.Point(96, 46);
            this.TextboxNombre.Name = "TextboxNombre";
            this.TextboxNombre.Size = new System.Drawing.Size(196, 20);
            this.TextboxNombre.TabIndex = 4;
            // 
            // TextboxApellido
            // 
            this.TextboxApellido.Location = new System.Drawing.Point(96, 72);
            this.TextboxApellido.Name = "TextboxApellido";
            this.TextboxApellido.Size = new System.Drawing.Size(196, 20);
            this.TextboxApellido.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(128, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Agregar Usuario";
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(96, 224);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(75, 23);
            this.BotonEliminar.TabIndex = 7;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // TextboxIDBaja
            // 
            this.TextboxIDBaja.Location = new System.Drawing.Point(96, 186);
            this.TextboxIDBaja.Name = "TextboxIDBaja";
            this.TextboxIDBaja.Size = new System.Drawing.Size(196, 20);
            this.TextboxIDBaja.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(128, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Eliminar Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(128, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modificar Usuario";
            // 
            // TextboxNombreModificacion
            // 
            this.TextboxNombreModificacion.Location = new System.Drawing.Point(102, 327);
            this.TextboxNombreModificacion.Name = "TextboxNombreModificacion";
            this.TextboxNombreModificacion.Size = new System.Drawing.Size(196, 20);
            this.TextboxNombreModificacion.TabIndex = 12;
            // 
            // TextboxIDModificacion
            // 
            this.TextboxIDModificacion.Location = new System.Drawing.Point(102, 379);
            this.TextboxIDModificacion.Name = "TextboxIDModificacion";
            this.TextboxIDModificacion.Size = new System.Drawing.Size(196, 20);
            this.TextboxIDModificacion.TabIndex = 14;
            // 
            // TextboxApellidoModificacion
            // 
            this.TextboxApellidoModificacion.Location = new System.Drawing.Point(102, 353);
            this.TextboxApellidoModificacion.Name = "TextboxApellidoModificacion";
            this.TextboxApellidoModificacion.Size = new System.Drawing.Size(196, 20);
            this.TextboxApellidoModificacion.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID";
            // 
            // BotonModificar
            // 
            this.BotonModificar.Location = new System.Drawing.Point(102, 415);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(75, 23);
            this.BotonModificar.TabIndex = 18;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.UseVisualStyleBackColor = true;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkRed;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(843, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Buscar usuario";
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(807, 124);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscar.TabIndex = 26;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(723, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nombre";
            // 
            // TextboxBusquedaNombre
            // 
            this.TextboxBusquedaNombre.Location = new System.Drawing.Point(807, 42);
            this.TextboxBusquedaNombre.Name = "TextboxBusquedaNombre";
            this.TextboxBusquedaNombre.Size = new System.Drawing.Size(196, 20);
            this.TextboxBusquedaNombre.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(723, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(723, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Apellido";
            // 
            // TextboxBusquedaID
            // 
            this.TextboxBusquedaID.Location = new System.Drawing.Point(807, 98);
            this.TextboxBusquedaID.Name = "TextboxBusquedaID";
            this.TextboxBusquedaID.Size = new System.Drawing.Size(196, 20);
            this.TextboxBusquedaID.TabIndex = 28;
            // 
            // TextboxBusquedaApellido
            // 
            this.TextboxBusquedaApellido.Location = new System.Drawing.Point(807, 72);
            this.TextboxBusquedaApellido.Name = "TextboxBusquedaApellido";
            this.TextboxBusquedaApellido.Size = new System.Drawing.Size(196, 20);
            this.TextboxBusquedaApellido.TabIndex = 27;
            // 
            // BotonLimpiar
            // 
            this.BotonLimpiar.Location = new System.Drawing.Point(807, 155);
            this.BotonLimpiar.Name = "BotonLimpiar";
            this.BotonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BotonLimpiar.TabIndex = 31;
            this.BotonLimpiar.Text = "Limpiar";
            this.BotonLimpiar.UseVisualStyleBackColor = true;
            this.BotonLimpiar.Click += new System.EventHandler(this.BotonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.BotonLimpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextboxBusquedaID);
            this.Controls.Add(this.TextboxBusquedaApellido);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TextboxBusquedaNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextboxIDModificacion);
            this.Controls.Add(this.TextboxApellidoModificacion);
            this.Controls.Add(this.TextboxNombreModificacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextboxIDBaja);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxApellido);
            this.Controls.Add(this.TextboxNombre);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.tablaDeDatos);
            this.Controls.Add(this.BotonGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.DataGridView tablaDeDatos;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox TextboxNombre;
        private System.Windows.Forms.TextBox TextboxApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.TextBox TextboxIDBaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextboxNombreModificacion;
        private System.Windows.Forms.TextBox TextboxIDModificacion;
        private System.Windows.Forms.TextBox TextboxApellidoModificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BotonModificar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextboxBusquedaNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextboxBusquedaID;
        private System.Windows.Forms.TextBox TextboxBusquedaApellido;
        private System.Windows.Forms.Button BotonLimpiar;
    }
}

