using Core.Poco;
using Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmProd : Form
    {
        private ProductRepository productRepository;
        public bool update;
        private int onePoint = 0;
        public Product productToUpdate { get; set; }
        public frmProd()
        {
            InitializeComponent();
            productRepository = new ProductRepository();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() {Title = "Por favor, seleccione la ruta de la imagen", Multiselect = false, ValidateNames = true, Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImage.Text = ofd.FileName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string description = txtDescription.Text;
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int stock = int.Parse(txtStock.Text);
            string image = txtImage.Text;

            if (update == true)
            {
                productToUpdate.Name = name;
                productToUpdate.Description = description;
                productToUpdate.Brand = brand;
                productToUpdate.Model = model;
                productToUpdate.Price = price;
                productToUpdate.Stock = stock;
                productToUpdate.ImageURL = image;
                productRepository.Update(productToUpdate);
                this.Dispose();
                return;
            }

            Product p = new Product
            {
                Name = name,
                Description = description,
                Brand = brand,
                Model = model,
                Price = price,
                Stock = stock,
                ImageURL = image,
            };

            productRepository.Create(p);

            this.Dispose();
        }

        public void fillSpaces(Product p)
        {
            txtName.Text = p.Name;
            txtDescription.Text = p.Description;
            txtBrand.Text = p.Brand;
            txtModel.Text = p.Model;
            txtPrice.Text = p.Price.ToString();
            txtStock.Text = p.Stock.ToString();
            txtImage.Text = p.ImageURL;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmProductAU_Load(object sender, EventArgs e)
        {

        }

        private void TxtImage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
