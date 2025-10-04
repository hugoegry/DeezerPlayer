using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiKnCo_MoteurRechercheDeezer
{
    public partial class FrmPlaylist : Form
    {
        public FrmPlaylist()
        {
            InitializeComponent();
        }

        public void lstGauche1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //le premier en haut(bleux)
        private void btnUnD_Click(object sender, EventArgs e)
        {
            //lstDroite.Items.Add(lstGauche1.SelectedItem); //add
            //lstGauche1.Items.Remove(lstGauche1.SelectedItem);//remove
            transfererUn(lstDroite, lstGauche1);
        }

        //tous (bleux)
        private void btnTousD_Click(object sender, EventArgs e)
        {
            transfererTous(lstGauche1, lstDroite);
        }


        //le deuxieme en bas (noir)
        private void btnUnG_Click(object sender, EventArgs e)
        {
            //lstGauche1.Items.Add(lstDroite.SelectedItem); //add
            //lstDroite.Items.Remove(lstDroite.SelectedItem); //remove
            transfererUn(lstGauche1, lstDroite);
        }

        //tous (Noir)
        private void btnTousNoir_Click(object sender, EventArgs e)
        {
            transfererTous(lstDroite, lstGauche1);
        }

        //Factorisation
        private void transfererUn(ListBox lstDestination, ListBox lstSource)
        {
            lstDestination.Items.Add(lstSource.SelectedItem); //add
            lstSource.Items.Remove(lstSource.SelectedItem);//remove
        }

        private void transfererTous(ListBox lstSource, ListBox lstDestination)
        {
            foreach (object element in lstSource.Items)
                lstDestination.Items.Add(element);
                lstSource.Items.Clear();
        }
    }
}
