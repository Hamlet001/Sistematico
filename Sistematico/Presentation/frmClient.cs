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
    public partial class frmClient : Form
    {
        private ClientRepository clientRepository;
        public bool update;
        public Cliente clientToUpdate { get; set; }
        public frmClient()
        {
            InitializeComponent();
            clientRepository = new ClientRepository();
        }

        public void fillSpaces(Cliente c)
        {
            txtName.Text = c.Name;
            txtLastName.Text = c.LastName;
            txtEmail.Text = c.Email;
            txtPhone.Text = c.Phone;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;


                if (update == true)
            {
                clientToUpdate.Name = name;
                clientToUpdate.LastName = lastName;
                clientToUpdate.Email = email;
                clientToUpdate.Phone = phone;
                clientRepository.Update(clientToUpdate);
                this.Dispose();
                return;
            }

            Cliente c = new Cliente
            {
                Name = name,
                LastName = lastName,
                Email = email,
                Phone = phone
            };

            clientRepository.Create(c);
            this.Dispose();
        }

    }
}
