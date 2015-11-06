using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
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

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void playersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
