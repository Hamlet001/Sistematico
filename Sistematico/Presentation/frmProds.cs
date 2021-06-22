using Core.Poco;
using Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmProds : Form
    {
        private ProductRepository productRepository;
        public frmProds()   
        {
            InitializeComponent();
            
            this.MinimumSize = new Size(651, 298);
            productRepository = new ProductRepository();
            setDataSource();
        }

   
        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProd frmProductAU = new frmProd();
            frmProductAU.ShowDialog();
            frmProductAU.update = false;
            setDataSource();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           if (dgvProducts.Rows.Count == 0 || dgvProducts.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Error de Datos");
                return;
            }

            Product p = (Product)dgvProducts.CurrentRow.DataBoundItem;
            Console.WriteLine(p.Id);
            productRepository.Delete(p);

            setDataSource();
        }

        private void setDataSource()
        {
            try
            {
                dgvProducts.DataSource = productRepository.GetAll();
            }
            catch (EndOfStreamException)
            {

            }
        }

    }
}
