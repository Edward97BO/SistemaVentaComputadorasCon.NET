namespace CpComputadorasG3
{
    partial class FrmUsuario
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
            this.components = new System.ComponentModel.Container();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.erpNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTipoDocumento = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNumeroDocumento = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpClave = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDatos.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNumeroDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClave)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pnlDatos.Controls.Add(this.gbxDatos);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDatos.Location = new System.Drawing.Point(778, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(302, 615);
            this.pnlDatos.TabIndex = 9;
            this.pnlDatos.Visible = false;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtClave);
            this.gbxDatos.Controls.Add(this.lblClave);
            this.gbxDatos.Controls.Add(this.txtEmail);
            this.gbxDatos.Controls.Add(this.lblEmail);
            this.gbxDatos.Controls.Add(this.txtTelefono);
            this.gbxDatos.Controls.Add(this.lblTelefono);
            this.gbxDatos.Controls.Add(this.txtNumeroDocumento);
            this.gbxDatos.Controls.Add(this.cbxTipoDocumento);
            this.gbxDatos.Controls.Add(this.lblCategoria);
            this.gbxDatos.Controls.Add(this.cbxRol);
            this.gbxDatos.Controls.Add(this.txtDireccion);
            this.gbxDatos.Controls.Add(this.lblDireccion);
            this.gbxDatos.Controls.Add(this.lblNumeroDocumento);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(this.lblTipoDocumento);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxDatos.Location = new System.Drawing.Point(16, 12);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(274, 591);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos del Usuario:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(89, 449);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(164, 33);
            this.txtClave.TabIndex = 32;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(16, 452);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(67, 22);
            this.lblClave.TabIndex = 31;
            this.lblClave.Text = "Clave:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(20, 346);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 33);
            this.txtEmail.TabIndex = 30;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 321);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 22);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(20, 285);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(233, 33);
            this.txtTelefono.TabIndex = 28;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(16, 260);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(94, 22);
            this.lblTelefono.TabIndex = 27;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(20, 165);
            this.txtNumeroDocumento.MaxLength = 20;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(233, 29);
            this.txtNumeroDocumento.TabIndex = 26;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Items.AddRange(new object[] {
            "Carnet de Identidad",
            "Pasaporte",
            "Tarjeta de Residencia"});
            this.cbxTipoDocumento.Location = new System.Drawing.Point(20, 107);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(233, 30);
            this.cbxTipoDocumento.TabIndex = 25;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(22, 382);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(46, 22);
            this.lblCategoria.TabIndex = 24;
            this.lblCategoria.Text = "Rol:";
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(20, 407);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(233, 30);
            this.cbxRol.TabIndex = 23;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(20, 224);
            this.txtDireccion.MaxLength = 70;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(233, 33);
            this.txtDireccion.TabIndex = 22;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 197);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(103, 22);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(16, 140);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(219, 22);
            this.lblNumeroDocumento.TabIndex = 17;
            this.lblNumeroDocumento.Text = "Número de Documento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 50);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 29);
            this.txtNombre.TabIndex = 15;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(16, 82);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(187, 22);
            this.lblTipoDocumento.TabIndex = 14;
            this.lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 22);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Usuario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCancelar.Image = global::CpComputadorasG3.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(154, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 66);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardar.Image = global::CpComputadorasG3.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(61, 503);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 66);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(2, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(770, 47);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "USUARIOS";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBusqueda.Location = new System.Drawing.Point(30, 126);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(261, 19);
            this.lblBusqueda.TabIndex = 11;
            this.lblBusqueda.Text = "Buscar por nombre de usuario:";
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtParametro.Location = new System.Drawing.Point(34, 167);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(558, 20);
            this.txtParametro.TabIndex = 12;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.Image = global::CpComputadorasG3.Properties.Resources.Busca;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(617, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 66);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbxLista.Location = new System.Drawing.Point(34, 236);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(715, 229);
            this.gbxLista.TabIndex = 14;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Usuarios";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(16, 25);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(679, 181);
            this.dgvLista.TabIndex = 0;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(34, 481);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(715, 100);
            this.pnlAcciones.TabIndex = 15;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCerrar.Image = global::CpComputadorasG3.Properties.Resources.Cerrar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(560, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(135, 66);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.Image = global::CpComputadorasG3.Properties.Resources.Eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(369, 15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 66);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditar.Image = global::CpComputadorasG3.Properties.Resources.Editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(192, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(131, 66);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNuevo.Image = global::CpComputadorasG3.Properties.Resources.Nuevo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(16, 15);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(131, 66);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // erpNombre
            // 
            this.erpNombre.ContainerControl = this;
            // 
            // erpTipoDocumento
            // 
            this.erpTipoDocumento.ContainerControl = this;
            // 
            // erpNumeroDocumento
            // 
            this.erpNumeroDocumento.ContainerControl = this;
            // 
            // erpDireccion
            // 
            this.erpDireccion.ContainerControl = this;
            // 
            // erpTelefono
            // 
            this.erpTelefono.ContainerControl = this;
            // 
            // erpEmail
            // 
            this.erpEmail.ContainerControl = this;
            // 
            // erpClave
            // 
            this.erpClave.ContainerControl = this;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnlDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.pnlDatos.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNumeroDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.ErrorProvider erpNombre;
        private System.Windows.Forms.ErrorProvider erpTipoDocumento;
        private System.Windows.Forms.ErrorProvider erpNumeroDocumento;
        private System.Windows.Forms.ErrorProvider erpDireccion;
        private System.Windows.Forms.ErrorProvider erpTelefono;
        private System.Windows.Forms.ErrorProvider erpEmail;
        private System.Windows.Forms.ErrorProvider erpClave;
    }
}