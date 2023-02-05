using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Imp;
            int Ventas, InventarioInicial, DevolucionSobreVenta, GastosdeCompra, RentasdeOficinas, SueldoGerenteAditivo, Publicidad, OtrosProductos, Impuestos, Compras, InventarioFinal, DevolucionsobreCompras, Rentasdetiendas, ComisionVendedores, Serviciostelefonicosventas, Empaquesdeproductos, OtrosGastos, rebajasobreventa;
            Ventas = int.Parse(textventas.Text);
            InventarioInicial = int.Parse(textinventarioinicial.Text);
            DevolucionSobreVenta = int.Parse(textdevolucionessobreventas.Text);
            GastosdeCompra = int.Parse(textgastosdecompra.Text);
            RentasdeOficinas = int.Parse(textrentadeoficinas.Text);
            SueldoGerenteAditivo = int.Parse(textsueldogerente.Text);
            Publicidad = int.Parse(textpublicidad.Text);
            OtrosProductos = int.Parse(textotrosproductos.Text);
            Impuestos = int.Parse(textimpuestos.Text);
            Compras= int.Parse(textcompras.Text);
            InventarioFinal= int.Parse(textinventariofinal.Text);
            DevolucionsobreCompras= int.Parse(textdevolucionesobrecompra.Text);
            Rentasdetiendas= int.Parse(textrentadetienda.Text);
            ComisionVendedores = int.Parse(textcomisionesvendedores.Text);
            Serviciostelefonicosventas= int.Parse(textserviciostelefonicosventas.Text);
            Empaquesdeproductos = int.Parse(textempaquedeproductos.Text);
            OtrosGastos = int.Parse(textotrosgastos.Text);


            int n = Tabla.Rows.Add();
            Tabla.Rows[n].Cells[0].Value = Ventas;
            Tabla.Rows[n].Cells[1].Value = InventarioInicial;
            Tabla.Rows[n].Cells[2].Value = DevolucionesSobreVentas;
            Tabla.Rows[n].Cells[3].Value = GastosdeCompra;
            Tabla.Rows[n].Cells[4].Value = RentasdeOficinas;
            Tabla.Rows[n].Cells[5].Value = SueldoGerenteAditivo;
            Tabla.Rows[n].Cells[6].Value = Publicidad;
            Tabla.Rows[n].Cells[7].Value = OtrosProductos;
            Tabla.Rows[n].Cells[8].Value = Impuestos;
            Tabla.Rows[n].Cells[9].Value = Compras;
            Tabla.Rows[n].Cells[10].Value = InventarioFinal;
            Tabla.Rows[n].Cells[11].Value = DevolucionsobreCompras;
            Tabla.Rows[n].Cells[12].Value = Rentasdetiendas;
            Tabla.Rows[n].Cells[13].Value = ComisionVendedores;
            Tabla.Rows[n].Cells[14].Value = Serviciostelefonicosventas;
            Tabla.Rows[n].Cells[15].Value = Empaquesdeproductos;
            Tabla.Rows[n].Cells[16].Value = OtrosGastos;










































            totaldedudcion = ventas - DevolucionSobreVenta;
            totaldedudcion = DevolucionSobreVenta + rebajasobreventa;
            ventasnetas = Ventas - totaldedudcion;
            comprastotales = Compras - gastosdecompra;
            totaldedudcion = DevolucionesSobreVentas;
            comprasnetas = comprastotales - totaldedudcion;
            MercadoDisponibleparaventa = InventarioInicial - comprasnetas;
            comprastotales = Compras + gastosdecompra;
            totaldeducionsobrecompra = devolucionessobrecompra + rebajarocompra;
            comprasnetas = comprastotales - totaldeducionsobrecompra;
            MercadoDisponibleparaventa = Inventarioincial + comprasnetas;
            costodeventa = MercadoDisponibleparaventa - inventariofinal;
            utilidadbruta = ventasnetas - comisionesvendedores;
            TotalGastosDeAdmon = Saldodegasto + Papeleria + rentadeoficinas;
            TotalGastosdeVenta = compravendida - Publicidad - rentadetienda - empaquedeproductos;
            utilidadbruta = ventasnetas - costodeventa;
            TotalGastosdeVenta = compravendida + Publicidad + rentadetienda + serviciostelefonicosventas + empaquedeproductos;
            totalgastosoperativos = TotalGastosdeVenta + TotalGastosDeAdmon;
            utilidadoperativa = utilidadbruta - totalgastosoperativos;
            totalotrosproductos = OtrosProductos;
            totalotrosgastos = otrosgastos;
            totalotrosproductos1 = totalotrosproductos - totalotrosgastos;
            UtilidadAimpuestos = utilidadoperativa + totalotroproduto1;
            impuestos = UtilidadAimpuestos * 0.3;
            utilidadneta = (int)(UtilidadAimpuestos - impuestos);

        }
    }
}
