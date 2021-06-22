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
    public partial class frmClients : Form
    {
        private ClientRepository clientRepository;
        public frmClients()
        {
            InitializeComponent();
            
            this.MinimumSize = new Size(651, 298);
            clientRepository = new ClientRepository();

            setDataResource();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmClient frmClientAU = new frmClient();
            frmClientAU.ShowDialog();
            frmClientAU.update = false;

            setDataResource();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.Rows.Count == 0 || dgvClients.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Esta tabla esta vacia, o intente seleccionar otra fila pls");
                return;
            }
            Cliente c = (Cliente)dgvClients.CurrentRow.DataBoundItem;
            Console.WriteLine(c.Id);
            clientRepository.Delete(c);

            setDataResource();
        }

        private void setDataResource()
        {
            try
            {
                dgvClients.DataSource = clientRepository.GetAll();
            }
            catch (EndOfStreamException) { throw; }
        }

       
    }
    }

