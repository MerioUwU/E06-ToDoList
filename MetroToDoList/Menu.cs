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

    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        DetailTask det = new DetailTask();
        AddTask agr = new AddTask();
        Task task = new Task();
        List<Task> tasks = new List<Task>();
        int TaskID = 1;
        public Menu()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MLTaskCount.Text = "Numero de tareas asignadas: " + tasks.Count;
        }


        private void MBAddTask_Click(object sender, EventArgs e)
        {
            CleanAdd();
            agr.ShowDialog();
            Agregar();
        }
        public void Agregar()
        {
            task.ID = TaskID;
            task.User = agr.MTxtCatchUser.Text;
            task.TaskName = agr.MTxtCatchName.Text;
            task.Description = agr.MTxtCatchDetails.Text;
            task.Hour = agr.MTxtCatchHour.Text;
            task.Status = agr.CBoxStatus.Text;
            tasks.Add(task);
            MGridTasks.Rows.Add(TaskID,task.TaskName);
            agr.Hide();
            TaskID++;
        }
        public void CleanAdd() 
        {
            agr.MTxtCatchUser.Clear();
            agr.MTxtCatchName.Clear();
            agr.MTxtCatchDetails.Clear();
            agr.MTxtCatchHour.Clear();
        }

        private void MGridTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MBDetailTask_Click(object sender, EventArgs e)
        {
            CleanDet();
            det.taskies = tasks;
            det.ShowDialog();
        }
        private void CleanDet() 
        {
            det.MTxtSearch.Text = null;
            det.MTxtShowDetails.Text = null;
            det.MTxtShowHour.Text = null;
            det.MCboxNewStatus.Text = null;
            det.MTxtShowUser.Text = null;
            det.MTxtShowTask.Text = null;

        }
    }
}
