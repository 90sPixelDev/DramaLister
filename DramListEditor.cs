using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DramaLister
{
    [Serializable]
    public partial class Drama_Lister_Start : Form
    {
        DramaSheet dramaSheet = new DramaSheet();
        SaveSystem saveSys = new SaveSystem();
        BindingSource dramaBindingSource = new BindingSource();

        string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Drama_Lister_Start()
        {
            InitializeComponent();
            dramaBindingSource.DataSource = dramaSheet.dramas;

            dramaSheet.dramas.Add(new Drama("New Drama"));
            //drama_listbx.Items.Add("New Drama");

            drama_listbx.SelectedIndex = 0;

            country_cbbx.DataSource = Enum.GetValues(typeof(Drama.Country));
            StartupBindings();
        }

        private void Drama_Lister_Start_Load(object sender, EventArgs e)
        {

        }

        public int GetSelectedDramaIndex()
        {
            return drama_listbx.SelectedIndex;
        }

        private void adddrama_contxtmenubtn_Click(object sender, EventArgs e)
        {
            dramaSheet.dramas.Add(new Drama("New Drama " + (drama_listbx.Items.Count)));
            drama_listbx.Items.Add("New Drama " + (drama_listbx.Items.Count));
        }

        private void deleteDramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedDrama = drama_listbx.SelectedIndex;
            if (selectedDrama == -1)
            {
                MessageBox.Show("You do not have a Drama selected to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (drama_listbx.Items.Count == 1)
            {
                MessageBox.Show("You can't delete the last drama left", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                drama_listbx.Items.RemoveAt(selectedDrama);
                dramaSheet.dramas.RemoveAt(selectedDrama);
            }
        }

        #region REFRESHING DATA
        private void drama_listbx_MouseClick(object sender, MouseEventArgs e)
        {
            StartupBindings();
        }

        private void StartupBindings()
        {
            fave_chbx.DataBindings.Clear();
            popular_chbx.DataBindings.Clear();
            wellmade_chbx.DataBindings.Clear();
            tropes_listbx.Items.Clear();

            //Basic Info
            name_txtbx.Text = dramaSheet.dramas[GetSelectedDramaIndex()].dramaName;
            ep_count_txtbx.Text = dramaSheet.dramas[GetSelectedDramaIndex()].epCount.ToString();
            country_cbbx.SelectedItem = dramaSheet.dramas[GetSelectedDramaIndex()].CountryOrigin;

            //Checkboxes
            if (dramaSheet.dramas[GetSelectedDramaIndex()].fave == true)
                fave_chbx.Checked = true;
            else
                fave_chbx.Checked = false;

            if (dramaSheet.dramas[GetSelectedDramaIndex()].popular == true)
                popular_chbx.Checked = true;
            else
                popular_chbx.Checked = false;
            if (dramaSheet.dramas[GetSelectedDramaIndex()].wellMade == true)
                wellmade_chbx.Checked = true;
            else
                fave_chbx.Checked = false;

            //Genres
            //Showing the genre checked
            for (int i = 0; i < dramaSheet.dramas[GetSelectedDramaIndex()].genres.Count; i++)
            {
                //genre_chbxlist.Items.Add(i);
                if (dramaSheet.dramas[GetSelectedDramaIndex()].genres.ElementAt(i).Value == true)
                {
                    genre_chbxlist.SetItemChecked(i, true);
                }
                else
                {
                    genre_chbxlist.SetItemChecked(i, false);
                }
            }

            //Tropes
            foreach (var trope in dramaSheet.dramas[GetSelectedDramaIndex()].tropes)
            {
                tropes_listbx.Items.Add(trope);
            }

            //Ratings
            rating_lbl.Text = dramaSheet.dramas[GetSelectedDramaIndex()].rating.ToString();
            rating_trckbr.Value = dramaSheet.dramas[GetSelectedDramaIndex()].rating;

            //Comments
            thoughts_txtbx.Text = dramaSheet.dramas[GetSelectedDramaIndex()].comments;
        }
        #endregion

        #region STATISTICS
        private void basicStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Dramas Seen: " + TotalDramasSeen() + Environment.NewLine + "Average Drama Rating: " + AverageRating(),
            "Basic Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //To Do
            //Total dramas seen -
            //Average Rating -
            //Dramas ordered by rating
            //Top 5 genres seen
        }

        private int TotalDramasSeen()
        {
            int dramasSeen = dramaSheet.dramas.Count();
            return dramasSeen;
        }
        private int AverageRating()
        {
            int avgRating;
            int rating = 0;

            for (int i = 0; i < dramaSheet.dramas.Count(); i++)
            {
                rating += dramaSheet.dramas[i].rating;
            }
            avgRating = rating / dramaSheet.dramas.Count();

            return avgRating;
        }
        //private string TopDrama()
        //{
        //    List<int> ratings = new List<int>();

        //    for (int i = 0; i < dramaSheet.dramas.Count(); i++)
        //    {
        //        ratings.Add(dramaSheet.dramas[i].rating);
        //    }
        //    ratings.Max();
        //    string topDrama = dramaSheet.dramas[]
        //}
        #endregion

        #region SAVE AND LOAD
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDramaSheet(dramaSheet);
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDramaSheet();
        }

        private void SaveDramaSheet(DramaSheet dramaSheet)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "New Drama Sheet";
            // Default file extension
            sfd.DefaultExt = "txt";
            // Available file extensions
            sfd.Filter = "Text Files (*.txt)|*txt|All Files (*.*)|*.*";
            sfd.RestoreDirectory = true;
            sfd.Title = "Where would you like to save your Drama Sheet?";
            sfd.InitialDirectory = path;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveSystem ss = new SaveSystem();
                ss.Save(dramaSheet, sfd.FileName);
                Console.WriteLine(sfd.FileName);
            }
            sfd.Dispose();
        }
        public void LoadDramaSheet()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            dramaSheet = new DramaSheet();

            // Sets selection of multiple files 
            ofd.Multiselect = false;
            // Available file extensions
            ofd.Filter = "Text Files (*.txt)|*.txt";
            // Startup directory
            ofd.InitialDirectory = path;
            // Restores the selected directory, next time
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DramaSheet loadedDramaSheet = (DramaSheet)SaveSystem.Load(ofd.FileName);

                dramaSheet = loadedDramaSheet;
                drama_listbx.Items.Clear();
                foreach (var drama in dramaSheet.dramas)
                {
                    drama_listbx.Items.Add(drama.dramaName);
                }
                drama_listbx.SelectedIndex = 0;
                StartupBindings();
            }
        }
        #endregion

        #region TEST BUTTONS
        private void originalDramaNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetSelectedDramaIndex() == -1)
            {
                MessageBox.Show("You do not have a Drama selected to check for the info!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Original Drama Name: " + dramaSheet.dramas[GetSelectedDramaIndex()].dramaName, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void originalDramaCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amount of Dramas in the origin of list: " + dramaSheet.dramas.Count.ToString(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void originalDramaRatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetSelectedDramaIndex() == -1)
            {
                MessageBox.Show("You do not have a Drama selected to check for the info!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Original Drama Rating: " + dramaSheet.dramas[GetSelectedDramaIndex()].rating.ToString(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void originalDramaCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetSelectedDramaIndex() == -1)
            {
                MessageBox.Show("You do not have a Drama selected to check for the info!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Original Drama Country: " + dramaSheet.dramas[GetSelectedDramaIndex()].CountryOrigin, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void averageRatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Average Rating: " + AverageRating(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region FORMATTING
        private void ep_count_txtbx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ep_count_txtbx.Text, "  ^ [0-9]"))
            {
                ep_count_txtbx.Text = "";
            }
        }
        private void ep_count_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        //SET INFO IN DRAMA LIST
        private void name_txtbx_Leave(object sender, EventArgs e)
        {
            dramaSheet.dramas[GetSelectedDramaIndex()].dramaName = name_txtbx.Text;
            drama_listbx.Items[drama_listbx.SelectedIndex] = name_txtbx.Text;

        }
        private void rating_trckbr_ValueChanged(object sender, EventArgs e)
        {
            dramaSheet.dramas[GetSelectedDramaIndex()].rating = rating_trckbr.Value;
            rating_lbl.Text = rating_trckbr.Value.ToString();
        }
        private void ep_count_txtbx_Leave(object sender, EventArgs e)
        {
            dramaSheet.dramas[GetSelectedDramaIndex()].epCount = Int32.Parse(ep_count_txtbx.Text);
        }
        private void thoughts_txtbx_Leave(object sender, EventArgs e)
        {
            dramaSheet.dramas[GetSelectedDramaIndex()].comments = thoughts_txtbx.Text;
        }
        private void fave_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if (fave_chbx.Checked)
                dramaSheet.dramas[GetSelectedDramaIndex()].fave = true;
            else
                dramaSheet.dramas[GetSelectedDramaIndex()].fave = false;
        }
        private void country_cbbx_Leave(object sender, EventArgs e)
        {
            dramaSheet.dramas[GetSelectedDramaIndex()].CountryOrigin = (Drama.Country)country_cbbx.SelectedItem;
        }
        private void genre_chbxlist_MouseDown(object sender, MouseEventArgs e)
        {
            int genreSelection = genre_chbxlist.SelectedIndex;

            string genreKey = dramaSheet.dramas[GetSelectedDramaIndex()].genres.ElementAt(genreSelection).Key;

            dramaSheet.dramas[GetSelectedDramaIndex()].genres[genreKey] = true;
        }
        private void addtrope_btn_Click(object sender, EventArgs e)
        {
            tropes_listbx.Items.Add(trope_txtbx.Text);
            dramaSheet.dramas[GetSelectedDramaIndex()].tropes.Add(trope_txtbx.Text);
            trope_txtbx.Clear();
        }
        private void deletetrope_Btn_Click(object sender, EventArgs e)
        {
            int selectedTrope = tropes_listbx.SelectedIndex;
            if (GetSelectedDramaIndex() == -1 || tropes_listbx.SelectedIndex == -1)
            {
                MessageBox.Show("You do not have a Drama or Trope selected to delete a trope!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tropes_listbx.Items.RemoveAt(tropes_listbx.SelectedIndex);
                dramaSheet.dramas[GetSelectedDramaIndex()].tropes.RemoveAt(selectedTrope);
            }
        }

        private void advancedStatisticsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DramaListView dramaListV = new DramaListView(dramaSheet);
            dramaListV.Show();
        }


    }
}
