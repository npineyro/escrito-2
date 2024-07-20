
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
            this.TextboxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(128, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Agregar Usuario";
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(96, 212);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(75, 23);
            this.BotonEliminar.TabIndex = 7;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // TextboxID
            // 
            this.TextboxID.Location = new System.Drawing.Point(96, 174);
            this.TextboxID.Name = "TextboxID";
            this.TextboxID.Size = new System.Drawing.Size(196, 20);
            this.TextboxID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Eliminar Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextboxID);
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
        private System.Windows.Forms.TextBox TextboxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

