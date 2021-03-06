﻿using Gestion_Ipsas.Models;
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
            else if (user.Role == "Responsable Examen")
            {
                if (module == "examens" || module == "notes")
                {
                    return true;
                }
            } else if (user.Role == "Responsable Stage")
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (hasPermission("examens"))
            {
                GestionExamen gestionUtilisateurs = new GestionExamen();
                gestionUtilisateurs.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (hasPermission("notes"))
            {
                GestionNotes gestionNotes = new GestionNotes();
                gestionNotes.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (hasPermission("stages"))
            {
                GestionStages gestionNotes = new GestionStages();
                gestionNotes.Show();
            }
        }
    }
}
