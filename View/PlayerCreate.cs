﻿using System;
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
    public partial class PlayerCreate : MetroForm
    {
        private PlayerRepository repo = new PlayerRepository();
        private TeamRepository teamRepository = new TeamRepository();

        private Boolean validate()
        {
            Boolean result = !(nameInput.Text == "" || nationalityInput.Text == "" || teamsCombo.SelectedItem == null);
            return result;
        }
        public PlayerCreate()
        {
            InitializeComponent();
            foreach (Team team in teamRepository.GetAll())
            {
                teamsCombo.Items.Add(team);
            }
        }

        private void PlayerCreate_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {

                
                Player newPlayer = new Player();
                newPlayer.Nationality = nationalityInput.Text;
                if (newPlayer.Teams == null) newPlayer.Teams = new List<Team>();
                
                newPlayer.Teams.Add((Team) teamsCombo.SelectedItem);
                
                
               
                newPlayer.Name = nameInput.Text;
                
                repo.SaveOrUpdate(newPlayer);
                DialogResult result = MetroMessageBox.Show(this, "Player created!", "Success!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {


                }


            }
            else
            {
                MetroMessageBox.Show(this, "Sorry, data is not valid.", "Validation error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
           
            }
        }

        private void dismissButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
