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
    public partial class FrmVentas : Form
    {
        bool esNuevo = false;
        public FrmVentas()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var ventas = VentaCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = ventas;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idCliente"].Visible = false;
            dgvLista.Columns["idUsuario"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["tipoComprobante"].HeaderText = "Tipo de Comprobante";
            dgvLista.Columns["numComprobante"].HeaderText = "Número de Comprobante";
            dgvLista.Columns["total"].HeaderText = "Total";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            btnEditar.Enabled = ventas.Count > 0;
            btnEliminar.Enabled = ventas.Count > 0;
            if (ventas.Count > 0) dgvLista.Rows[0].Cells["numComprobante"].Selected = true;
        }


        private void FrmVentas_Load(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            pnlDatos.Visible = true;
            txtNumComprobante.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlDatos.Visible = true;
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var venta = VentaCln.get(id);
            txtTipoComprobante.Text = venta.tipoComprobante;
            txtNumComprobante.Text = venta.numComprobante;
            nudTotal.Value = venta.total;
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

       

        private bool validar()
        {
            bool esValido = true;
            erpNumComprobante.SetError(txtNumComprobante, "");
            erpTipoComprobante.SetError(txtTipoComprobante, "");
            erpTotal.SetError(nudTotal, "");
            if (string.IsNullOrEmpty(txtNumComprobante.Text))
            {
                esValido = false;
                erpNumComprobante.SetError(txtNumComprobante, "El campo Número de Comprobante es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTipoComprobante.Text))
            {
                esValido = false;
                erpTipoComprobante.SetError(txtTipoComprobante, "El campo Tipo de Comprobante  es obligatorio");
            }
            if (nudTotal.Value < 0)
            {
                esValido = false;
                erpTotal.SetError(nudTotal, "El campo Total es obligatorio y debe ser mayor o igual a 0");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var venta = new Venta();
                venta.numComprobante = txtNumComprobante.Text.Trim();
                venta.tipoComprobante = txtTipoComprobante.Text.Trim();
                venta.total = nudTotal.Value;
                venta.usuarioRegistro = "Edward";

                if (esNuevo)
                {
                    venta.fechaRegistro = DateTime.Now;
                    venta.estado = 1;
                    VentaCln.insertar(venta);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    venta.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    VentaCln.actualizar(venta);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Venta guardada correctamente", "::: It Pro - Mensaje:::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            txtNumComprobante.Text = string.Empty;
            txtTipoComprobante.Text= string.Empty;
            nudTotal.Value = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);

            string numComprobante = dgvLista.Rows[index].Cells["numComprobante"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar la Venta {numComprobante}?",
                "::: IT Pro - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                VentaCln.eliminar(id, "Edward");
                listar();
                MessageBox.Show("Venta eliminada correctamente", "::: It Pro - Mensaje:::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        
    }
}
