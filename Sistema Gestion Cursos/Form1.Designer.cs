namespace Sistema_Gestion_Cursos
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
            this.cmbModalidad = new System.Windows.Forms.ComboBox();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.txtbNombreCurso = new System.Windows.Forms.TextBox();
            this.lstbCursos = new System.Windows.Forms.ListBox();
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.txtbCantEstudiantes = new System.Windows.Forms.TextBox();
            this.txtbDocente = new System.Windows.Forms.TextBox();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lbNombreCurso = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblSisGesCursos = new System.Windows.Forms.Label();
            this.txtbPrecioUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbIntensidadHoraria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbModalidad
            // 
            this.cmbModalidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbModalidad.FormattingEnabled = true;
            this.cmbModalidad.Items.AddRange(new object[] {
            "(Seleccione)",
            "Presencial",
            "Virtual"});
            this.cmbModalidad.Location = new System.Drawing.Point(182, 228);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(207, 21);
            this.cmbModalidad.TabIndex = 39;
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidad.Location = new System.Drawing.Point(13, 228);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(98, 24);
            this.lblModalidad.TabIndex = 38;
            this.lblModalidad.Text = "Modalidad";
            // 
            // txtbNombreCurso
            // 
            this.txtbNombreCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbNombreCurso.Location = new System.Drawing.Point(182, 116);
            this.txtbNombreCurso.Name = "txtbNombreCurso";
            this.txtbNombreCurso.Size = new System.Drawing.Size(207, 20);
            this.txtbNombreCurso.TabIndex = 37;
            // 
            // lstbCursos
            // 
            this.lstbCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbCursos.FormattingEnabled = true;
            this.lstbCursos.Location = new System.Drawing.Point(395, 110);
            this.lstbCursos.MinimumSize = new System.Drawing.Size(454, 290);
            this.lstbCursos.Name = "lstbCursos";
            this.lstbCursos.Size = new System.Drawing.Size(751, 290);
            this.lstbCursos.TabIndex = 35;
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCurso.Location = new System.Drawing.Point(283, 446);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(588, 40);
            this.btnAgregarCurso.TabIndex = 34;
            this.btnAgregarCurso.Text = "Agregar Curso";
            this.btnAgregarCurso.UseVisualStyleBackColor = true;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            // 
            // txtbCantEstudiantes
            // 
            this.txtbCantEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbCantEstudiantes.Location = new System.Drawing.Point(182, 332);
            this.txtbCantEstudiantes.Name = "txtbCantEstudiantes";
            this.txtbCantEstudiantes.Size = new System.Drawing.Size(207, 20);
            this.txtbCantEstudiantes.TabIndex = 33;
            // 
            // txtbDocente
            // 
            this.txtbDocente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbDocente.Location = new System.Drawing.Point(182, 171);
            this.txtbDocente.Name = "txtbDocente";
            this.txtbDocente.Size = new System.Drawing.Size(207, 20);
            this.txtbDocente.TabIndex = 32;
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioBase.Location = new System.Drawing.Point(13, 332);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(153, 24);
            this.lblPrecioBase.TabIndex = 31;
            this.lblPrecioBase.Text = "Cant. estudiantes";
            // 
            // lblDocente
            // 
            this.lblDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocente.AutoSize = true;
            this.lblDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocente.Location = new System.Drawing.Point(13, 171);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(81, 24);
            this.lblDocente.TabIndex = 30;
            this.lblDocente.Text = "Docente";
            // 
            // lbNombreCurso
            // 
            this.lbNombreCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNombreCurso.AutoSize = true;
            this.lbNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCurso.Location = new System.Drawing.Point(13, 116);
            this.lbNombreCurso.Name = "lbNombreCurso";
            this.lbNombreCurso.Size = new System.Drawing.Size(134, 24);
            this.lbNombreCurso.TabIndex = 29;
            this.lbNombreCurso.Text = "Nombre Curso";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(13, 279);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(172, 24);
            this.lblFechaVencimiento.TabIndex = 28;
            this.lblFechaVencimiento.Text = "Intensiadad Horaria";
            // 
            // lblSisGesCursos
            // 
            this.lblSisGesCursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSisGesCursos.AutoSize = true;
            this.lblSisGesCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSisGesCursos.Location = new System.Drawing.Point(433, 41);
            this.lblSisGesCursos.Name = "lblSisGesCursos";
            this.lblSisGesCursos.Size = new System.Drawing.Size(263, 24);
            this.lblSisGesCursos.TabIndex = 27;
            this.lblSisGesCursos.Text = "Sistema de Gestión de Cursos";
            // 
            // txtbPrecioUnit
            // 
            this.txtbPrecioUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbPrecioUnit.Location = new System.Drawing.Point(182, 380);
            this.txtbPrecioUnit.Name = "txtbPrecioUnit";
            this.txtbPrecioUnit.Size = new System.Drawing.Size(207, 20);
            this.txtbPrecioUnit.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Precio unitario";
            // 
            // txtbIntensidadHoraria
            // 
            this.txtbIntensidadHoraria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbIntensidadHoraria.Location = new System.Drawing.Point(182, 283);
            this.txtbIntensidadHoraria.Name = "txtbIntensidadHoraria";
            this.txtbIntensidadHoraria.Size = new System.Drawing.Size(207, 20);
            this.txtbIntensidadHoraria.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 514);
            this.Controls.Add(this.txtbIntensidadHoraria);
            this.Controls.Add(this.txtbPrecioUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbModalidad);
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.txtbNombreCurso);
            this.Controls.Add(this.lstbCursos);
            this.Controls.Add(this.btnAgregarCurso);
            this.Controls.Add(this.txtbCantEstudiantes);
            this.Controls.Add(this.txtbDocente);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.lbNombreCurso);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblSisGesCursos);
            this.MinimumSize = new System.Drawing.Size(1174, 553);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModalidad;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.TextBox txtbNombreCurso;
        private System.Windows.Forms.ListBox lstbCursos;
        private System.Windows.Forms.Button btnAgregarCurso;
        private System.Windows.Forms.TextBox txtbCantEstudiantes;
        private System.Windows.Forms.TextBox txtbDocente;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lbNombreCurso;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblSisGesCursos;
        private System.Windows.Forms.TextBox txtbPrecioUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbIntensidadHoraria;
    }
}

