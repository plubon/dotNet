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

namespace View
{
    public partial class CreateForm : MetroForm
    {
        private void InitializeDiscipline()
        {
            formTableLayout.RowCount = 2;
            formTableLayout.ColumnCount = 2;

            Label name = new Label();
            name.Text = "Name:";
            TextBox nameBox = new DataGridTextBox();
            Label description = new Label();
            description.Text = "Description:";
            RichTextBox descriptionBox = new RichTextBox();

            formTableLayout.Controls.Add(name,0,0);
            formTableLayout.Controls.Add(nameBox,1,0);
            formTableLayout.Controls.Add(description,0,1);
            formTableLayout.Controls.Add(descriptionBox,1,1);
        }

        public CreateForm(String type)
        {

            InitializeComponent();
            switch (type)
            {
                case "discipline":
                    InitializeDiscipline();
                    break;
            }
        }
    }
}
