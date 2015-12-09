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
using Model.Enitites;

namespace View
{
    public partial class PlayerShow : MetroForm
    {
        private Player handle = null;
        public PlayerShow(Player _handle)
        {
            handle = _handle;
            InitializeComponent();
            Text = handle.Name;
            nameLabel.Text = handle.Name;
            nationalityLabel.Text = handle.Nationality;
            teamsLabel.Text += handle.Teams.Name+" ; ";
        }

        private void PlayerShow_Load(object sender, EventArgs e)
        {

        }
    }
}
