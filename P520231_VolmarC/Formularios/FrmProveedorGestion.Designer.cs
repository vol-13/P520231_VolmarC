namespace P520231_VolmarC.Formularios
{
    partial class FrmProveedorGestion
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
            this.DgvListaProveedor = new System.Windows.Forms.DataGridView();
            this.CProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorTipoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtProveedorID = new System.Windows.Forms.TextBox();
            this.TxtProveedorEmail = new System.Windows.Forms.TextBox();
            this.TxtProveedorCedula = new System.Windows.Forms.TextBox();
            this.TxtProveedorNotas = new System.Windows.Forms.TextBox();
            this.TxtProveedorNombre = new System.Windows.Forms.TextBox();
            this.TxtProveedorDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbTipoProveedor = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaProveedor
            // 
            this.DgvListaProveedor.AllowUserToAddRows = false;
            this.DgvListaProveedor.AllowUserToDeleteRows = false;
            this.DgvListaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProveedorID,
            this.CProveedorNombre,
            this.CProveedorTipoDescripcion,
            this.CProveedorCedula,
            this.CProveedorEmail});
            this.DgvListaProveedor.Location = new System.Drawing.Point(12, 51);
            this.DgvListaProveedor.MultiSelect = false;
            this.DgvListaProveedor.Name = "DgvListaProveedor";
            this.DgvListaProveedor.ReadOnly = true;
            this.DgvListaProveedor.RowHeadersVisible = false;
            this.DgvListaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaProveedor.Size = new System.Drawing.Size(805, 252);
            this.DgvListaProveedor.TabIndex = 0;
            this.DgvListaProveedor.VirtualMode = true;
            this.DgvListaProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaProveedor_CellClick);
            this.DgvListaProveedor.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaProveedor_DataBindingComplete);
            // 
            // CProveedorID
            // 
            this.CProveedorID.DataPropertyName = "ProveedorID";
            this.CProveedorID.HeaderText = "Código";
            this.CProveedorID.Name = "CProveedorID";
            this.CProveedorID.ReadOnly = true;
            // 
            // CProveedorNombre
            // 
            this.CProveedorNombre.DataPropertyName = "ProveedorNombre";
            this.CProveedorNombre.HeaderText = "Nombre";
            this.CProveedorNombre.Name = "CProveedorNombre";
            this.CProveedorNombre.ReadOnly = true;
            this.CProveedorNombre.Width = 225;
            // 
            // CProveedorTipoDescripcion
            // 
            this.CProveedorTipoDescripcion.DataPropertyName = "ProveedorTipoDescripcion";
            this.CProveedorTipoDescripcion.HeaderText = "Tipo";
            this.CProveedorTipoDescripcion.Name = "CProveedorTipoDescripcion";
            this.CProveedorTipoDescripcion.ReadOnly = true;
            // 
            // CProveedorCedula
            // 
            this.CProveedorCedula.DataPropertyName = "ProveedorCedula";
            this.CProveedorCedula.HeaderText = "Cédula";
            this.CProveedorCedula.Name = "CProveedorCedula";
            this.CProveedorCedula.ReadOnly = true;
            this.CProveedorCedula.Width = 200;
            // 
            // CProveedorEmail
            // 
            this.CProveedorEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProveedorEmail.DataPropertyName = "ProveedorEmail";
            this.CProveedorEmail.FillWeight = 250F;
            this.CProveedorEmail.HeaderText = "Email";
            this.CProveedorEmail.Name = "CProveedorEmail";
            this.CProveedorEmail.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Notas";
            // 
            // TxtProveedorID
            // 
            this.TxtProveedorID.Location = new System.Drawing.Point(113, 324);
            this.TxtProveedorID.Name = "TxtProveedorID";
            this.TxtProveedorID.ReadOnly = true;
            this.TxtProveedorID.Size = new System.Drawing.Size(268, 26);
            this.TxtProveedorID.TabIndex = 3;
            // 
            // TxtProveedorEmail
            // 
            this.TxtProveedorEmail.Location = new System.Drawing.Point(549, 317);
            this.TxtProveedorEmail.Name = "TxtProveedorEmail";
            this.TxtProveedorEmail.Size = new System.Drawing.Size(268, 26);
            this.TxtProveedorEmail.TabIndex = 3;
            this.TxtProveedorEmail.Enter += new System.EventHandler(this.TxtProveedorEmail_Enter);
            this.TxtProveedorEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProveedorEmail_KeyPress);
            this.TxtProveedorEmail.Leave += new System.EventHandler(this.TxtProveedorEmail_Leave);
            // 
            // TxtProveedorCedula
            // 
            this.TxtProveedorCedula.Location = new System.Drawing.Point(113, 419);
            this.TxtProveedorCedula.Name = "TxtProveedorCedula";
            this.TxtProveedorCedula.Size = new System.Drawing.Size(268, 26);
            this.TxtProveedorCedula.TabIndex = 3;
            this.TxtProveedorCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProveedorCedula_KeyPress);
            // 
            // TxtProveedorNotas
            // 
            this.TxtProveedorNotas.Location = new System.Drawing.Point(549, 421);
            this.TxtProveedorNotas.Multiline = true;
            this.TxtProveedorNotas.Name = "TxtProveedorNotas";
            this.TxtProveedorNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProveedorNotas.Size = new System.Drawing.Size(268, 66);
            this.TxtProveedorNotas.TabIndex = 4;
            this.TxtProveedorNotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProveedorNotas_KeyPress);
            // 
            // TxtProveedorNombre
            // 
            this.TxtProveedorNombre.Location = new System.Drawing.Point(113, 366);
            this.TxtProveedorNombre.Name = "TxtProveedorNombre";
            this.TxtProveedorNombre.Size = new System.Drawing.Size(268, 26);
            this.TxtProveedorNombre.TabIndex = 3;
            this.TxtProveedorNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProveedorNombre_KeyPress);
            // 
            // TxtProveedorDireccion
            // 
            this.TxtProveedorDireccion.Location = new System.Drawing.Point(549, 349);
            this.TxtProveedorDireccion.Multiline = true;
            this.TxtProveedorDireccion.Name = "TxtProveedorDireccion";
            this.TxtProveedorDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProveedorDireccion.Size = new System.Drawing.Size(268, 66);
            this.TxtProveedorDireccion.TabIndex = 5;
            this.TxtProveedorDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProveedorDireccion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo";
            // 
            // CbTipoProveedor
            // 
            this.CbTipoProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoProveedor.FormattingEnabled = true;
            this.CbTipoProveedor.Location = new System.Drawing.Point(113, 466);
            this.CbTipoProveedor.Name = "CbTipoProveedor";
            this.CbTipoProveedor.Size = new System.Drawing.Size(121, 28);
            this.CbTipoProveedor.TabIndex = 7;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(417, 466);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(120, 39);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(272, 466);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 39);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmProveedorGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 508);
            this.Controls.Add(this.CbTipoProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtProveedorDireccion);
            this.Controls.Add(this.TxtProveedorNotas);
            this.Controls.Add(this.TxtProveedorCedula);
            this.Controls.Add(this.TxtProveedorEmail);
            this.Controls.Add(this.TxtProveedorNombre);
            this.Controls.Add(this.TxtProveedorID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvListaProveedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmProveedorGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Proveedor";
            this.Load += new System.EventHandler(this.FrmProveedorGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtProveedorID;
        private System.Windows.Forms.TextBox TxtProveedorEmail;
        private System.Windows.Forms.TextBox TxtProveedorCedula;
        private System.Windows.Forms.TextBox TxtProveedorNotas;
        private System.Windows.Forms.TextBox TxtProveedorNombre;
        private System.Windows.Forms.TextBox TxtProveedorDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbTipoProveedor;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorTipoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorEmail;
        private System.Windows.Forms.Button BtnAgregar;
    }
}