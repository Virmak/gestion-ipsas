using Gestion_Ipsas.Models;
using System;
using System.Windows.Forms;

namespace Gestion_Ipsas.Ui
{
    public partial class GestionIPSAS : Form
    {
        private User user;

        private Authentification authentification;

        public GestionIPSAS(User user, Authentification authentification)
        {
            InitializeComponent();
            this.user = user;
            this.authentification = authentification;
            userToolStrip.Text = user.FirstName + " " + user.LastName + " - " + user.Role;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            authentification.Show();
            this.Close();
        }

        private void enseignants_Click(object sender, EventArgs e)
        {
            if (hasPermission("enseignants"))
            {
                GestionEnseignant gestionEnseignant = new GestionEnseignant();
                gestionEnseignant.Show();
            }
        }

        private void etudiants_Click(object sender, EventArgs e)
        {
            if (hasPermission("etudiants"))
            {
                GestionEtudiant gestionEtudiant = new GestionEtudiant();
                gestionEtudiant.Show();
            }
        }

        private void cours_Click(object sender, EventArgs e)
        {
            if (hasPermission("cours"))
            {
                GestionCours gestionCours = new GestionCours();
                gestionCours.Show();
            }
        }

        private void users_Click(object sender, EventArgs e)
        {
            if (hasPermission("utilisateurs"))
            {
                GestionUtilisateurs gestionUtilisateurs = new GestionUtilisateurs();
                gestionUtilisateurs.Show();
            }
        }

        private bool hasPermission(string module)
        {
            if (user.Role == "Directeur")
            {
                return true;
            }
            else if (user.Role == "Responsable Formation")
            {
                if (module == "enseignants" || module == "cours" || module == "etudiants")
                {
                    return true;
                }
            }
            else if (user.Role == "Responsable Examens")
            {
                if (module == "examens" || module == "notes")
                {
                    return true;
                }
            } else if (user.Role == "Responsable Stages")
            {
                if (module == "stages")
                {
                    return true;
                }
            }

            MessageBox.Show("Vous n'avez pas le droit pour accéder a ce module", "Erreur de permission",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        private void GestionIPSAS_FormClosing(object sender, FormClosingEventArgs e)
        {
            authentification.Show();
        }
    }
}
