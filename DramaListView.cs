using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DramaLister
{
    public partial class DramaListView : Form
    {
        private Drama_Lister_Start dls = new Drama_Lister_Start();
        //private DramaSheet dramaS;

        BindingSource DramaBind = new BindingSource();

        public DramaListView(DramaSheet dramaS)
        {
            InitializeComponent();

            DramaGridView.ColumnCount = 4;

            DramaGridView.Columns[0].Name = "Drama Name";
            DramaGridView.Columns[0].HeaderText = "Name";
            DramaGridView.Columns[0].DataPropertyName = "dramaName";
            DramaGridView.Columns[0].Width = 150;

            DramaGridView.Columns[1].Name = "Country";
            DramaGridView.Columns[1].HeaderText = "Country";
            DramaGridView.Columns[1].DataPropertyName = "Counrty";

            DramaGridView.Columns[2].Name = "Ep Count";
            DramaGridView.Columns[2].HeaderText = "Ep Count";
            DramaGridView.Columns[2].DataPropertyName = "epCount";

            DramaGridView.Columns[3].Name = "Rating";
            DramaGridView.Columns[3].HeaderText = "Rating";
            DramaGridView.Columns[3].DataPropertyName = "rating";

            for (int i = 0; i < dramaS.dramas.Count; i++)
            {
                DramaGridView.Rows.Add(dramaS.dramas[i].dramaName, dramaS.dramas[i].CountryOrigin, dramaS.dramas[i].epCount, dramaS.dramas[i].rating);
                Console.WriteLine(dramaS.dramas[i].dramaName);
            }

            //DramaGridView.Rows.Add(dramaS);
        }


        #region TEST BUTTONS
        private void dramasAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are " + /*dramaS.dramas.Count()*/ " Dramas", "Dramas Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
