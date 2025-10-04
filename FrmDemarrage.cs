using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique;
using Btssio.Deezer;
using Btssio.Tools;
using System.Diagnostics;

namespace ZiKnCo_MoteurRechercheDeezer
{
    public partial class FrmDemarrage : Form
    {
        #region champs

        Artist selectedArtist = new Artist();
        Artist selectedArtistDetails = new Artist();
        Album selectedAlbum = new Album();
        Track selectedTrack = new Track();

        #region message

        private const string MESSAGE_ARTISTE_INCONNU = "Désolé, la discographie pour";

        private const string MESSAGE_RECHERCHE_ARTISTE = "Recherche en cours, veuillez patienter...";
        private const string MESSAGE_SAISIE_ARTISTE = "Veuillez saisir un artiste à rechercher";
        private const string MESSAGE_ARTISTE_INCONNU2 = "Désolé, l'artiste'#valeur#' est inconnu sur Deezer ...";
        private const string MESSAGE_DISCOGRAPHIE_INDISPONIBLE = "Désolé, la discographie pour '#valeur#' n'est pas disponible...";
        private string message;

        #endregion

        #endregion

        #region Constructeur

        #endregion

        #region btnRecherche
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (txtArtisteRecherche.Text == "")
            {
                lblMessage.Text = MESSAGE_SAISIE_ARTISTE;
                erp.SetError(txtArtisteRecherche, MESSAGE_SAISIE_ARTISTE);
                erp.SetError(txtArtisteRecherche, string.Empty);
            }

            else
            {
                Cursor.Current = Cursors.WaitCursor;
                lblMessage.Text = MESSAGE_RECHERCHE_ARTISTE;
                lblMessage.Refresh();


                RechercherArtistes();

                clear1();
            }

        }



        #endregion

        #region frmDemarrage2

        public FrmDemarrage()
        {
            InitializeComponent();
        }

        private async void FrmDemarrage_Load(object sender, EventArgs e)
        {
            if (!NetManager.isConnected())
            {
                MessageBox.Show("Attention, la connexion Internet est inactive !");
                Application.Exit();
            }

            await wbRadio.EnsureCoreWebView2Async(null);  //pour les webwiew radio
            await wbDisco.EnsureCoreWebView2Async(null); //pour les webwiew discographie
        }
        #endregion

        #region gestions interraction

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAPropos formulaire = new FrmAPropos();
            formulaire.ShowDialog();
        }

        private void txtArtisteRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnRechercher.PerformClick();
        }

        private void picDeezer_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.deezer.com/fr/");
        }

        private void FrmDemarrage_Activated(object sender, EventArgs e)
        {
            txtArtisteRecherche.Focus();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void FrmDemarrage_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "ZiK'nCo : question",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)

                    e.Cancel = true;
        }

        private void lklDeezerLien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Artist> lesArtistes = new List<Artist>();
            string recherche = txtArtisteRecherche.Text;

            //affectation de la collection
          
            Process.Start(selectedArtistDetails.link);
        }



        private void lstArtistes_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblMessage.Text = string.Empty;
            erp.SetError(txtArtisteRecherche, string.Empty);
            pnlDisco.Visible = false;
            btnEcouterExtraits.Enabled = false;
            
            selectedArtist = (Artist)lstArtistes.SelectedItem;

            //Affichage des informations dans les contrôles associés
            lblArtisteNom.Text = selectedArtist.name;
            lklDeezerLien.Text = selectedArtist.link;
            picArtiste.ImageLocation = selectedArtist.picture;


            //Recherche de l'URL de la radio et navigation vers celle-ci
            string urlWidget = DeezerPlugin.getUrlPluginRadio(selectedArtist.id, wbRadio.Size.Width,
            wbRadio.Size.Height);
            wbRadio.CoreWebView2.Navigate(urlWidget);

            //Traitement de la discographie
            TraitementDisco();

        }

        private void btnEcouterExtraits_Click(object sender, EventArgs e)
        {

            Artist selectedArtistDetails = new Artist();
            selectedArtistDetails = DeezerApi.getDetailsArtistById(selectedArtist.id);
            if (selectedArtistDetails.nbAlbums == 0)
            {
                lblMessage.Text = "Désolé, les extraits pour '" + selectedArtist.name + "' ne sont pas disponibles...";
            }
            else
            {
                FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();

                List<Album> lesAlbums = selectedArtistDetails.getLesAlbums();

                foreach (Album unAlbum in lesAlbums)
                {
                    List<Track> lesTracks = unAlbum.getLesTracks();

                    foreach (Track unTrack in lesTracks)
                    {
                        WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                        formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                    }
                }

                formulaire.Show();

                formulaire.wmpLecteur.Ctlcontrols.play();
            }
            
        }

        private void txtArtisteRecherche_TextChanged(object sender, EventArgs e)
        {
            /*if (txtArtisteRecherche.Text.Length > 0)
            {
                lblMessage.Text = "Veuillez saisir un artiste à rechercher";
                erp.SetError(txtArtisteRecherche, "Veuillez saisir un artiste à rechercher");

            }*/
        }
        

        private void tbc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lstbAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAlbum = (Album)lstbAlbums.SelectedItem;
            picDisco.ImageLocation = selectedAlbum.cover;
           

            List<Track> lesTracks = selectedAlbum.getLesTracks();
            
            lstbTitres.DataSource = lesTracks;
            lstbTitres.DisplayMember = "title";
           
           
        }

        private void lstbTitres_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Recherche de l'URL de la discographie et navigation vers celle-ci
            
            selectedTrack =(Track)lstbTitres.SelectedItem;
            wbDisco.CoreWebView2.Navigate(selectedTrack.link);
            

            //ou

            /*string urlPlugin = DeezerPlugin.getUrlPluginTrack(selectedTrack.id, wbDisco.Size.Width,
            wbDisco.Size.Height);
            wbDisco.CoreWebView2.Navigate(urlPlugin);
            */
        }

        #endregion

        #region méthodes
        private void RechercherArtistes()
        {
            //Artist monArtist = new Artist();
            //string recherche = txtArtisteRecherche.Text;
            //monArtist = DeezerApi.getFirstArtistByName(recherche);

            //Déclaration et instanciation de la collection (liste) d'artistes
            List<Artist> lesArtistes = new List<Artist>();
            string maRecherche = txtArtisteRecherche.Text;
            //affectation de la collection qui contiendra tous les « bob » trouvés, il devrait y en avoir…
            lesArtistes = DeezerApi.getAllArtistsByName(maRecherche);



            if (lesArtistes.Count == 0)
            {
                //MessageBox.Show("Désolé, artiste '" + maRecherche + "' inconnu sur Deezer ...", "Zik'nCo : avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblMessage.Text = MESSAGE_ARTISTE_INCONNU2.Replace("#valeur#",selectedArtist.name);
                //"Désolé, l'artiste '" + maRecherche + "' est inconnu sur Deezer ..."
                erp.SetError(txtArtisteRecherche, " n'existe pas");
            }
            else
            {
                grbArtisteInfos.Visible = true;
                //lblArtisteNom.Text = lesArtistes[0].name;
                //Console.WriteLine("ID : " + monArtist.id);
                //picArtiste.ImageLocation = lesArtistes[0].picture;
                //lklDeezerLien.Text = lesArtistes[0].link;
                //string urlWidget = DeezerPlugin.getUrlPluginRadio(lesArtistes[0].id);
                //urlWidget = urlWidget.Replace("http", "https");
                //wbRadio.CoreWebView2.Navigate(urlWidget);
                //Console.WriteLine("Lien du PLUGIN de RADIO de l'artiste : " +
                //DeezerPlugin.getUrlPluginRadio(monArtist.id));
                //Console.WriteLine("\nEt voilà le travail !");

                lstArtistes.DataSource = lesArtistes;
                lstArtistes.DisplayMember = "name";

            }
        }

        private void TraitementDisco()
        {
            selectedArtistDetails = DeezerApi.getDetailsArtistById(selectedArtist.id);

            List<Album> lesAlbums = selectedArtistDetails.getLesAlbums();

            if (lesAlbums.Count == 0)
            {
                erp.SetError(btnEcouterExtraits, MESSAGE_ARTISTE_INCONNU + selectedArtistDetails.name + " n'existe pas");
            }
            else
            {
                pnlDisco.Visible = true;
                btnEcouterExtraits.Enabled = true;

                //On remplit la liste d'Album (l'évènement n'est donc pas déclenché)
                lstbAlbums.DataSource = lesAlbums;
                lstbAlbums.DisplayMember = "title";
                picDisco.ImageLocation = selectedArtist.picture;


            }
        }

        private void clear1()
        {
            lblMessage.Text = string.Empty;
            erp.SetError(txtArtisteRecherche, string.Empty);
            txtArtisteRecherche.Text = string.Empty;
        }

        private void verifExtrait()
        {
            if (selectedArtistDetails.nbAlbums == 0)
            {
                btnEcouterExtraits.Enabled = false;////ici
            }
        }


        #endregion



        private void lstbAlbums_DoubleClick(object sender, EventArgs e)
        {
            FrmPlaylist formulaire = new FrmPlaylist();
            selectedAlbum = (Album)lstbAlbums.SelectedItem;
            List<Track> lesTracks = selectedAlbum.getLesTracks(); //Liste des titres de l'album sélectionné
            foreach (Track unTrack in lesTracks)
            { //Remplissage de la liste de gauche du formulaire FrmPlaylist (propriété Modifiers : Public)
                formulaire.lstGauche1.Items.Add(unTrack);
                formulaire.lstGauche1.DisplayMember = "title"; //Le nom du titre sera affiché
            }
            formulaire.Show(); //Affichage du formulaire
        }
    }
}
