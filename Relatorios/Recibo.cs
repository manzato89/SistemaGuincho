using SistemaGuincho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGuincho.Relatorios {
    public partial class Recibo : Form {

        private PrintDocument printDocument1 = new PrintDocument();
        Bitmap memoryImage;

        Faturamento faturamento;

        public Recibo(Faturamento faturamento) {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            this.faturamento = faturamento;

            fillFields();
        }

        private void fillFields() {
            lblNomeCliente.Text = faturamento.cliente.nome;
            lblEnderecoCliente.Text = faturamento.cliente.endereco.ToString();
            lblValorFaturamento.Text = Utilidades.Util.formatValor(faturamento.valorTotal());
            lblServicosCustosAdicionais.Text = faturamento.servicos_custosAdicionais();
            lblCidadeData.Text = String.Format("Garça, {0} de {1} de {2}", DateTime.Now.Day, Utilidades.Util.getMes(DateTime.Now.Month), DateTime.Now.Year);
        }

        private void CaptureScreen() {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Location.X + 15, Location.Y + 30, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void bntImprimir_click(object sender, EventArgs e) {
            btnImprimir.Visible = false;
            CaptureScreen();
            printDocument1.Print();
            btnImprimir.Visible = true;
        }
    }
}
