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
    public partial class DisciplineForm : MetroForm
    {
        public DisciplineForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              var repository = new DisciplineRepository(); //po odkomentowaniu nastepnej linijki sie wysypuje
              var disciplines = repository.GetAll();     
//            foreach (Discipline discipline  in disciplines)
//            {
//                DisciplineItem tmp = new DisciplineItem(discipline);
//                this.disciplinesPanel.Controls.Add(tmp);
//            }
           
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void addDiscipline_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm("discipline");
            createForm.Show();
        }
    }
}
