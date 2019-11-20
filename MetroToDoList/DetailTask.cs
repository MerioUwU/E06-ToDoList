using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroToDoList
{
    public partial class DetailTask : MetroFramework.Forms.MetroForm
    {
        public List<Task> taskies = null;
        Task task;
        public DetailTask()
        {
            InitializeComponent();
        }

        private void MCboxPickTask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MBtnFinish_Click(object sender, EventArgs e)
        {
            task.Status = MCboxNewStatus.Text;
            this.Hide();
        }

        private void DetailTask_Load(object sender, EventArgs e)
        {

        }

        private void MBtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search() 
        {
            foreach (var item in taskies)
            {
                if (Convert.ToInt32(MTxtSearch.Text) == item.ID)  
                { 
                    task = item;
                    MTxtShowUser.Text = task.User;
                    MTxtShowTask.Text = task.TaskName;
                    MTxtShowDetails.Text = task.Description;
                    MTxtShowHour.Text = task.Description;
                    MCboxNewStatus.Text = task.Status;
                }
                else 
                {
                    MessageBox.Show("Tarea no encontrada, volviendo al Menu");
                    this.Hide();
                    MTxtSearch.Text = "";
                }
            }
        }
    }
}
