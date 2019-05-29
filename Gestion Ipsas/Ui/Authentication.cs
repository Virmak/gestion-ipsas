using System;
using System.Windows.Forms;
using Gestion_Ipsas.Models;
using Gestion_Ipsas.Ui;

namespace Gestion_Ipsas
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
            roleComboBox.SelectedIndex = 1;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var user = User.Login(userIdTxt.Text, passwordTxt.Text, roleComboBox.SelectedItem.ToString());
            if (user != null)
            {
                GestionIPSAS gestionIPSAS = new GestionIPSAS(user, this);
                gestionIPSAS.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrecte");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Authentification_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
