using CadComputadorasG3;
using ClnComputadorasG3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpComputadorasG3
{
    public partial class FrmArticulo : Form
    {
        bool esNuevo = false;
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var articulos = ArticuloCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = articulos;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["idCategoria"].HeaderText = "Categoría";
            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["nombre"].HeaderText = "Nombre";
            dgvLista.Columns["precioVenta"].HeaderText = "Precio";
            dgvLista.Columns["stock"].HeaderText = "Stock";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            btnEditar.Enabled = articulos.Count > 0;
            btnEliminar.Enabled = articulos.Count > 0;
            if (articulos.Count > 0) dgvLista.Rows[0].Cells["codigo"].Selected = true;
        }

        private void cargarCategoria()
        {
            cbxCategoria.DataSource = CategoriaCln.listar();
            cbxCategoria.DisplayMember = "nombre";
            cbxCategoria.ValueMember = "id";
        }
        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            listar();
            cargarCategoria();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            pnlDatos.Visible = true;
            txtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlDatos.Visible = true;

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var articulo = ArticuloCln.get(id);
            txtCodigo.Text = articulo.codigo;
            txtNombre.Text = articulo.nombre;
            txtDescripcion.Text = articulo.descripcion;
            nudPrecioVenta.Value = articulo.precioVenta;
            nudStock.Value = (decimal)articulo.stock;
            txtDescripcion.Text =articulo.descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
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
            erpCodigo.SetError(txtCodigo, "");
            erpNombre.SetError(txtNombre, "");
            erpPrecioVenta.SetError(nudPrecioVenta, "");
            erpStock.SetError(nudStock, "");
            erpDescripcion.SetError(txtDescripcion, "");
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                esValido = false;
                erpCodigo.SetError(txtCodigo, "El campo Código es obligatorio");
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo Nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                esValido = false;
                erpDescripcion.SetError(txtDescripcion, "El campo Código es obligatorio");
            }
            if (string.IsNullOrEmpty(nudPrecioVenta.Text))
            {
                esValido = false;
                erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio es obligatorio");
            }
            if (nudPrecioVenta.Value < 0)
            {
                esValido = false;
                erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio debe ser mayor a cero");
            }
            if (nudStock.Value < 0)
            {
                esValido = false;
                erpStock.SetError(nudStock, "El campo Stock no puede ser cero");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var articulo = new Articulo();
                articulo.codigo = txtCodigo.Text.Trim();
                articulo.nombre = txtNombre.Text.Trim();
                articulo.precioVenta = nudPrecioVenta.Value;
                articulo.stock = (int)nudStock.Value;
                articulo.descripcion = txtDescripcion.Text.Trim();
                articulo.usuarioRegistro = "Edward";
                if (esNuevo)
                {
                    articulo.fechaRegistro = DateTime.Now;
                    articulo.estado = 1;
                    articulo.idCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                    ArticuloCln.insertar(articulo);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    articulo.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    ArticuloCln.actualizar(articulo);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Artículo guardado correctamente", "::: It Pro - Mensaje:::",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            nudPrecioVenta.Value = 0;
            nudStock.Value = 0;
            txtDescripcion.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);

            string codigo = dgvLista.Rows[index].Cells["codigo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar el Artículo {codigo}?",
                "::: IT Pro - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ArticuloCln.eliminar(id, "Edward");
                listar();
                MessageBox.Show("Artículo eliminado correctamente", "::: It Pro - Mensaje:::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
