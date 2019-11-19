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
            Agregar();
        }
        public void Agregar()
        {
            CleanAdd();
            agr.Show();
            task.ID = TaskID;
            task.User = agr.MTxtCatchUser.Text;
            task.TaskName = agr.MTxtCatchUser.Text;
            task.Description = agr.MTxtCatchDetails.Text;
            task.Hour = agr.MTxtCatchHour.Text;
            task.Status = agr.CBoxStatus.Text;
            tasks.Add(task);
            int print = MGridTasks.Rows.Add();
            MGridTasks.Rows[print].Cells[0].Value = TaskID;
            MGridTasks.Rows[print].Cells[1].Value = task.TaskName;
            TaskID++;
        }
        public void CleanAdd() 
        {
            agr.MTxtCatchUser.Clear();
            agr.MTxtCatchUser.Clear();
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
    }
}
