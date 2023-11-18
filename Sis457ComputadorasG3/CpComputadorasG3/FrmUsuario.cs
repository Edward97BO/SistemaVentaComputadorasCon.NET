using CadComputadorasG3;
using ClnComputadorasG3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpComputadorasG3
{
    public partial class FrmUsuario : Form
    {
        bool esNuevo = false;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var usuarios = UsuarioCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = usuarios;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["idRol"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Usuario";
            dgvLista.Columns["tipoDocumento"].HeaderText = "Tipo de Documento";
            dgvLista.Columns["numDocumento"].HeaderText = "Número de Documento";
            dgvLista.Columns["direccion"].HeaderText = "Dirección";
            dgvLista.Columns["telefono"].HeaderText = "Teléfono";
            dgvLista.Columns["email"].HeaderText = "Email";
            dgvLista.Columns["clave"].HeaderText = "Contraseña";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            btnEditar.Enabled = usuarios.Count > 0;
            btnEliminar.Enabled = usuarios.Count > 0;
            if (usuarios.Count > 0) dgvLista.Rows[0].Cells["nombre"].Selected = true;
        }

        private void cargarRol()
        {
            cbxRol.DataSource = RolCln.listar();
            cbxRol.DisplayMember = "nombre";
            cbxRol.ValueMember = "id";
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            listar();
            cargarRol();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            pnlDatos.Visible = true;
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlDatos.Visible = true;
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var usuario = UsuarioCln.get(id);
            txtNombre.Text = usuario.nombre;
            cbxTipoDocumento.Text = usuario.tipoDocumento;
            txtNumeroDocumento.Text = usuario.numDocumento;
            txtDireccion.Text = usuario.direccion;
            txtTelefono.Text = usuario.telefono;
            txtEmail.Text = usuario.email;
            txtClave.Text = usuario.clave;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Visible =false;
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private bool validar()
        {
            bool esValido = true;
            erpNombre.SetError(txtNombre, "");
            erpTipoDocumento.SetError(cbxTipoDocumento, "");
            erpNumeroDocumento.SetError(txtNumeroDocumento, "");
            erpDireccion.SetError(txtDireccion, "");
            erpTelefono.SetError(txtTelefono, "");
            erpEmail.SetError(txtEmail, "");
            erpClave.SetError(txtClave, "");
            if  (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo Nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxTipoDocumento.Text))
            {
                esValido = false;
                erpTipoDocumento.SetError(cbxTipoDocumento, "El campo Tipo de Documento es obligatorio");
            }
            if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                esValido = false;
                erpNumeroDocumento.SetError(txtNumeroDocumento, "El campo Número de Documento es obligatorio");
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                esValido = false;
                erpDireccion.SetError(txtDireccion, "El campo Dirección es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                esValido = false;
                erpTelefono.SetError(txtTelefono, "El campo Teléfono es obligatorio");
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                esValido = false;
                erpEmail.SetError(txtEmail, "El campo Email es obligatorio");
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                esValido = false;
                erpClave.SetError(txtClave, "El campo Clave es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var usuario = new Usuario();
                usuario.nombre = txtNombre.Text.Trim();
                usuario.tipoDocumento = cbxTipoDocumento.Text.Trim();
                usuario.numDocumento = txtNumeroDocumento.Text.Trim();
                usuario.direccion = txtDireccion.Text.Trim();
                usuario.telefono = txtTelefono.Text.Trim();
                usuario.email = txtEmail.Text.Trim();
                usuario.clave = txtClave.Text.Trim();
                usuario.usuarioRegistro = "Admin IT Pro";
                if (esNuevo)
                {
                    usuario.fechaRegistro = DateTime.Now;
                    usuario.estado = 1;
                    usuario.idRol = Convert.ToInt32(cbxRol.SelectedValue);
                    UsuarioCln.insertar(usuario);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    usuario.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    UsuarioCln.actualizar(usuario);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Usuario guardado correctamente", "::: It Pro - Mensaje:::",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
            {
                txtNombre.Text = string.Empty;
                cbxTipoDocumento.Text = string.Empty;
                txtNumeroDocumento.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtClave.Text = string.Empty;
            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);

            string nombre = dgvLista.Rows[index].Cells["nombre"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar el Usuario {nombre}?",
                "::: IT Pro - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ArticuloCln.eliminar(id, "Edward");
                listar();
                MessageBox.Show("Usuario eliminado correctamente", "::: It Pro - Mensaje:::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
