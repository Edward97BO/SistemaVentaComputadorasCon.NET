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
    public partial class FrmCategoria : Form
    {
        bool esNuevo = false;
        public FrmCategoria()
        {
            InitializeComponent();  
        }

        private void listar()
        {
            var categorias = CategoriaCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = categorias;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Categoría";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            btnEditar.Enabled = categorias.Count > 0;
            btnEliminar.Enabled = categorias.Count > 0;
            if (categorias.Count > 0) dgvLista.Rows[0].Cells["nombre"].Selected = true;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            listar();
            
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
            var categoria = CategoriaCln.get(id);
            txtNombre.Text = categoria.nombre;
            txtDescripcion.Text = categoria.descripcion;
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
            erpNombre.SetError(txtNombre, "");
            erpDescripcion.SetError(txtDescripcion, "");
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo Nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                esValido = false;
                erpDescripcion.SetError(txtDescripcion, "El campo Descripción es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar()) {
            var categoria = new Categoria();
            categoria.nombre = txtNombre.Text.Trim();
            categoria.descripcion = txtDescripcion.Text.Trim();
            categoria.usuarioRegistro = "Edward";

            if (esNuevo)
            {
                categoria.fechaRegistro = DateTime.Now;
                categoria.estado = 1;
                CategoriaCln.insertar(categoria);
            }
            else
            {
                int index = dgvLista.CurrentCell.RowIndex;
                categoria.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                CategoriaCln.actualizar(categoria);
            }
            listar();
            btnCancelar.PerformClick();
            MessageBox.Show("Categoría guardada correctamente", "::: It Pro - Mensaje:::", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);

            string nombre = dgvLista.Rows[index].Cells["nombre"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar la Categorría {nombre}?",
                "::: IT Pro - Mrnsaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                CategoriaCln.eliminar(id, "Edward");
                listar();
                MessageBox.Show("Categoría eliminada correctamente", "::: It Pro - Mensaje:::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
