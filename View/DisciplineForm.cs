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
using NHibernate;
using Repository;

namespace View
{
    public partial class DisciplineForm : MetroForm
    {
        private Discipline handle;
        private DisciplineItem item;
        public DisciplineForm()
        {
            InitializeComponent();
            
        }


        void Discipline_Click(Object sender, EventArgs e)
        {
            item = (DisciplineItem)sender;
            handle = item.getDiscipline();

            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {

            }
            if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                metroContextMenu1.Show(System.Windows.Forms.Cursor.Position);
            }         
        }
        private void getData()
        {
            var repository = new DisciplineRepository(); //po odkomentowaniu nastepnej linijki sie wysypuje
            var disciplines = repository.GetAll();
            foreach (Discipline discipline in disciplines)
            {
                DisciplineItem tmp = new DisciplineItem(discipline);
                tmp.MouseUp += new MouseEventHandler(Discipline_Click);
                this.disciplinesPanel.Controls.Add(tmp);
            }
        }

        private object DisciplineClicked()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
             getData();
           
        }

        public void addDisciplineItem(Discipline newDiscipline)
        {
            DisciplineItem tmp = new DisciplineItem(newDiscipline);
            tmp.MouseUp += new MouseEventHandler(Discipline_Click);
            this.disciplinesPanel.Controls.Add(tmp);
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
            DisciplineCreate createForm = new DisciplineCreate(this);
            createForm.Show();
        }

        private void DisciplineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void removeMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Are you sure you want to remove element?","Remove",MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var repo = new DisciplineRepository();
                repo.Delete(handle);
                disciplinesPanel.Controls.Remove(item);
               
            }
    
        }

        private void informationMenuItem_Click(object sender, EventArgs e)
        {
            var view = new DisciplineShow(handle);
            view.Show();
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {
            var view = new DisciplineUpdate(handle);
            view.Show();
        }
    }
}
