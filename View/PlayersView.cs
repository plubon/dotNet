using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Model.Enitites;
using Repository;

namespace View
{
    public partial class PlayersView : MetroForm
    {
        private BindingSource bindingSource1 = new BindingSource();
        private PlayerRepository repo = new PlayerRepository();
        public PlayersView()
        {
            InitializeComponent();
            bindingSource1.DataSource = repo.GetAll();
            playersGrid.DataSource = bindingSource1;
            playersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            playersGrid.MultiSelect = false;
            playersGrid.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }
        public void update()
        {
            playersGrid.DataSource = null;
            bindingSource1 = new BindingSource();
            bindingSource1.DataSource = repo.GetAll();
            playersGrid.DataSource = bindingSource1;
        }

        private void PlayersView_Load(object sender, EventArgs e)
        {

        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            var view = new PlayerCreate();
            view.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            int row = playersGrid.CurrentCell.RowIndex;
            var ID = Int32.Parse(playersGrid[playersGrid.ColumnCount - 1, row].Value.ToString());
            Player handler = repo.GetById(ID);
            var view = new PlayerCreate(handler);
            view.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
             DialogResult res = MetroMessageBox.Show(this, "Do you really want to remove this player?", "Remove player.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                int row = playersGrid.CurrentCell.RowIndex;
                var ID = Int32.Parse(playersGrid[playersGrid.ColumnCount - 1, row].Value.ToString());
                Player handler = repo.GetById(ID);
                repo.Delete(handler);
                update();
             }
          

        }

        private void playersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showSelectedPlayer(object sender, DataGridViewCellEventArgs e)
        {
            int row = playersGrid.CurrentCell.RowIndex;
            var ID = Int32.Parse(playersGrid[playersGrid.ColumnCount - 1, row].Value.ToString());
            Player handler = repo.GetById(ID);
            var view = new PlayerShow(handler);
            view.Show();
        }
    }
}
