using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MetroToDoList
{
    public partial class AddTask : MetroFramework.Forms.MetroForm
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void AddTask_Load(object sender, EventArgs e)
        {

        }

        private void CBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void MBAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informacion almacenada");
            this.Hide();
        }
       
    }
}
