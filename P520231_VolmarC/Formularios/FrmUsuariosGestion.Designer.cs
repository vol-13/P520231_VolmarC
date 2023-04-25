namespace P520231_VolmarC.Formularios
{
    partial class FrmUsuariosGestion
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.CboxVerActivos = new System.Windows.Forms.CheckBox();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.CUsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuarioNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuarioCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuarioCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuarioTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuarioRolDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbRolesUsuario = new System.Windows.Forms.ComboBox();
            this.TxtUsuarioDireccion = new System.Windows.Forms.TextBox();
            this.txtUsuarioContrasennia = new System.Windows.Forms.TextBox();
            this.TxtUsuarioCorreo = new System.Windows.Forms.TextBox();
            this.TxtUsuarioTelefono = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.TxtUsuarioID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtBuscar.Location = new System.Drawing.Point(188, 39);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(358, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // CboxVerActivos
            // 
            this.CboxVerActivos.AutoSize = true;
            this.CboxVerActivos.Checked = true;
            this.CboxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerActivos.Location = new System.Drawing.Point(591, 38);
            this.CboxVerActivos.Name = "CboxVerActivos";
            this.CboxVerActivos.Size = new System.Drawing.Size(175, 24);
            this.CboxVerActivos.TabIndex = 2;
            this.CboxVerActivos.Text = "Ver Usuarios Activos";
            this.CboxVerActivos.UseVisualStyleBackColor = true;
            this.CboxVerActivos.CheckedChanged += new System.EventHandler(this.CboxVerActivos_CheckedChanged);
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.AllowUserToOrderColumns = true;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUsuarioID,
            this.CUsuarioNombre,
            this.CUsuarioCedula,
            this.CUsuarioCorreo,
            this.CUsuarioTelefono,
            this.CUsuarioRolDescripcion});
            this.DgLista.Location = new System.Drawing.Point(12, 111);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(1148, 298);
            this.DgLista.TabIndex = 3;
            this.DgLista.VirtualMode = true;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete);
            // 
            // CUsuarioID
            // 
            this.CUsuarioID.DataPropertyName = "UsuarioID";
            this.CUsuarioID.HeaderText = "Cod. Usuario";
            this.CUsuarioID.Name = "CUsuarioID";
            this.CUsuarioID.ReadOnly = true;
            // 
            // CUsuarioNombre
            // 
            this.CUsuarioNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUsuarioNombre.DataPropertyName = "UsuarioNombre";
            this.CUsuarioNombre.HeaderText = "Nombre";
            this.CUsuarioNombre.Name = "CUsuarioNombre";
            this.CUsuarioNombre.ReadOnly = true;
            // 
            // CUsuarioCedula
            // 
            this.CUsuarioCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CUsuarioCedula.DataPropertyName = "UsuarioCedula";
            this.CUsuarioCedula.HeaderText = "Cédula";
            this.CUsuarioCedula.Name = "CUsuarioCedula";
            this.CUsuarioCedula.ReadOnly = true;
            this.CUsuarioCedula.Width = 120;
            // 
            // CUsuarioCorreo
            // 
            this.CUsuarioCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CUsuarioCorreo.DataPropertyName = "UsuarioCorreo";
            this.CUsuarioCorreo.HeaderText = "Correo";
            this.CUsuarioCorreo.Name = "CUsuarioCorreo";
            this.CUsuarioCorreo.ReadOnly = true;
            this.CUsuarioCorreo.Width = 150;
            // 
            // CUsuarioTelefono
            // 
            this.CUsuarioTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CUsuarioTelefono.DataPropertyName = "UsuarioTelefono";
            this.CUsuarioTelefono.HeaderText = "Teléfono";
            this.CUsuarioTelefono.Name = "CUsuarioTelefono";
            this.CUsuarioTelefono.ReadOnly = true;
            this.CUsuarioTelefono.Width = 120;
            // 
            // CUsuarioRolDescripcion
            // 
            this.CUsuarioRolDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CUsuarioRolDescripcion.DataPropertyName = "UsuarioRolDescripcion";
            this.CUsuarioRolDescripcion.HeaderText = "Rol";
            this.CUsuarioRolDescripcion.Name = "CUsuarioRolDescripcion";
            this.CUsuarioRolDescripcion.ReadOnly = true;
            this.CUsuarioRolDescripcion.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbRolesUsuario);
            this.groupBox1.Controls.Add(this.TxtUsuarioDireccion);
            this.groupBox1.Controls.Add(this.txtUsuarioContrasennia);
            this.groupBox1.Controls.Add(this.TxtUsuarioCorreo);
            this.groupBox1.Controls.Add(this.TxtUsuarioTelefono);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.TxtUsuarioNombre);
            this.groupBox1.Controls.Add(this.TxtUsuarioID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1148, 234);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Usuario";
            // 
            // CbRolesUsuario
            // 
            this.CbRolesUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRolesUsuario.FormattingEnabled = true;
            this.CbRolesUsuario.Location = new System.Drawing.Point(694, 132);
            this.CbRolesUsuario.Name = "CbRolesUsuario";
            this.CbRolesUsuario.Size = new System.Drawing.Size(233, 28);
            this.CbRolesUsuario.TabIndex = 16;
            // 
            // TxtUsuarioDireccion
            // 
            this.TxtUsuarioDireccion.Location = new System.Drawing.Point(694, 172);
            this.TxtUsuarioDireccion.Multiline = true;
            this.TxtUsuarioDireccion.Name = "TxtUsuarioDireccion";
            this.TxtUsuarioDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtUsuarioDireccion.Size = new System.Drawing.Size(233, 62);
            this.TxtUsuarioDireccion.TabIndex = 15;
            this.TxtUsuarioDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuarioDireccion_KeyPress);
            // 
            // txtUsuarioContrasennia
            // 
            this.txtUsuarioContrasennia.Location = new System.Drawing.Point(694, 84);
            this.txtUsuarioContrasennia.Name = "txtUsuarioContrasennia";
            this.txtUsuarioContrasennia.Size = new System.Drawing.Size(233, 26);
            this.txtUsuarioContrasennia.TabIndex = 13;
            this.txtUsuarioContrasennia.UseSystemPasswordChar = true;
            this.txtUsuarioContrasennia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioContrasennia_KeyPress);
            // 
            // TxtUsuarioCorreo
            // 
            this.TxtUsuarioCorreo.Location = new System.Drawing.Point(694, 33);
            this.TxtUsuarioCorreo.Name = "TxtUsuarioCorreo";
            this.TxtUsuarioCorreo.Size = new System.Drawing.Size(233, 26);
            this.TxtUsuarioCorreo.TabIndex = 12;
            this.TxtUsuarioCorreo.Enter += new System.EventHandler(this.TxtUsuarioCorreo_Enter);
            this.TxtUsuarioCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuarioCorreo_KeyPress);
            this.TxtUsuarioCorreo.Leave += new System.EventHandler(this.TxtUsuarioCorreo_Leave);
            // 
            // TxtUsuarioTelefono
            // 
            this.TxtUsuarioTelefono.Location = new System.Drawing.Point(202, 188);
            this.TxtUsuarioTelefono.Name = "TxtUsuarioTelefono";
            this.TxtUsuarioTelefono.Size = new System.Drawing.Size(200, 26);
            this.TxtUsuarioTelefono.TabIndex = 11;
            this.TxtUsuarioTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuarioTelefono_KeyPress);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(202, 140);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(200, 26);
            this.TxtCedula.TabIndex = 10;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // TxtUsuarioNombre
            // 
            this.TxtUsuarioNombre.Location = new System.Drawing.Point(202, 87);
            this.TxtUsuarioNombre.Name = "TxtUsuarioNombre";
            this.TxtUsuarioNombre.Size = new System.Drawing.Size(200, 26);
            this.TxtUsuarioNombre.TabIndex = 9;
            this.TxtUsuarioNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuarioNombre_KeyPress);
            // 
            // TxtUsuarioID
            // 
            this.TxtUsuarioID.Location = new System.Drawing.Point(202, 42);
            this.TxtUsuarioID.Name = "TxtUsuarioID";
            this.TxtUsuarioID.ReadOnly = true;
            this.TxtUsuarioID.Size = new System.Drawing.Size(200, 26);
            this.TxtUsuarioID.TabIndex = 8;
            this.TxtUsuarioID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Rol de Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Correo Electrónico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cédula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código usuario:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(52, 649);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(127, 38);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Location = new System.Drawing.Point(287, 649);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(127, 38);
            this.BtnModificar.TabIndex = 5;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(517, 649);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(127, 38);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(749, 649);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(127, 38);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(1011, 649);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(127, 38);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuariosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.CboxVerActivos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmUsuariosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuariosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckBox CboxVerActivos;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbRolesUsuario;
        private System.Windows.Forms.TextBox TxtUsuarioDireccion;
        private System.Windows.Forms.TextBox txtUsuarioContrasennia;
        private System.Windows.Forms.TextBox TxtUsuarioCorreo;
        private System.Windows.Forms.TextBox TxtUsuarioTelefono;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtUsuarioNombre;
        private System.Windows.Forms.TextBox TxtUsuarioID;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioRolDescripcion;
    }
}