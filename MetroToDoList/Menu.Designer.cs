namespace MetroToDoList
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MBAddTask = new MetroFramework.Controls.MetroButton();
            this.MBDetailTask = new MetroFramework.Controls.MetroButton();
            this.MLWelcome = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.MGridTasks = new MetroFramework.Controls.MetroGrid();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MLTaskCount = new MetroFramework.Controls.MetroLabel();
            this.MBtnSalir = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MGridTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // MBAddTask
            // 
            this.MBAddTask.Location = new System.Drawing.Point(23, 200);
            this.MBAddTask.Name = "MBAddTask";
            this.MBAddTask.Size = new System.Drawing.Size(200, 42);
            this.MBAddTask.TabIndex = 0;
            this.MBAddTask.Text = "Agregar Tarea";
            this.MBAddTask.UseSelectable = true;
            this.MBAddTask.Click += new System.EventHandler(this.MBAddTask_Click);
            // 
            // MBDetailTask
            // 
            this.MBDetailTask.Location = new System.Drawing.Point(23, 259);
            this.MBDetailTask.Name = "MBDetailTask";
            this.MBDetailTask.Size = new System.Drawing.Size(200, 42);
            this.MBDetailTask.TabIndex = 4;
            this.MBDetailTask.Text = "Detallar una tarea";
            this.MBDetailTask.UseSelectable = true;
            this.MBDetailTask.Click += new System.EventHandler(this.MBDetailTask_Click);
            // 
            // MLWelcome
            // 
            this.MLWelcome.AutoSize = true;
            this.MLWelcome.Location = new System.Drawing.Point(23, 73);
            this.MLWelcome.Name = "MLWelcome";
            this.MLWelcome.Size = new System.Drawing.Size(200, 80);
            this.MLWelcome.TabIndex = 6;
            this.MLWelcome.Text = "Bienvenido, seleccione con un\r\nbotón la acción a realizar. Las \r\ntareas se encuen" +
    "tran en la lista\r\nen la derecha .";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.MGridTasks);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(270, 73);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(347, 342);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // MGridTasks
            // 
            this.MGridTasks.AllowUserToResizeRows = false;
            this.MGridTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGridTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MGridTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MGridTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGridTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MGridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MGridTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MGridTasks.DefaultCellStyle = dataGridViewCellStyle5;
            this.MGridTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MGridTasks.EnableHeadersVisualStyles = false;
            this.MGridTasks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MGridTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGridTasks.Location = new System.Drawing.Point(0, 0);
            this.MGridTasks.Name = "MGridTasks";
            this.MGridTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGridTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MGridTasks.RowHeadersWidth = 51;
            this.MGridTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MGridTasks.RowTemplate.Height = 24;
            this.MGridTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MGridTasks.Size = new System.Drawing.Size(347, 342);
            this.MGridTasks.TabIndex = 2;
            this.MGridTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MGridTasks_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "#";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 25;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Tarea a Realizar";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 325;
            // 
            // MLTaskCount
            // 
            this.MLTaskCount.AutoSize = true;
            this.MLTaskCount.Location = new System.Drawing.Point(273, 50);
            this.MLTaskCount.Name = "MLTaskCount";
            this.MLTaskCount.Size = new System.Drawing.Size(66, 20);
            this.MLTaskCount.TabIndex = 8;
            this.MLTaskCount.Text = "Contador";
            // 
            // MBtnSalir
            // 
            this.MBtnSalir.Location = new System.Drawing.Point(23, 378);
            this.MBtnSalir.Name = "MBtnSalir";
            this.MBtnSalir.Size = new System.Drawing.Size(200, 42);
            this.MBtnSalir.TabIndex = 9;
            this.MBtnSalir.Text = "Salir";
            this.MBtnSalir.UseSelectable = true;
            this.MBtnSalir.Click += new System.EventHandler(this.MBtnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 443);
            this.Controls.Add(this.MBtnSalir);
            this.Controls.Add(this.MLTaskCount);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.MLWelcome);
            this.Controls.Add(this.MBDetailTask);
            this.Controls.Add(this.MBAddTask);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MGridTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroButton MBAddTask;
        public MetroFramework.Controls.MetroButton MBDetailTask;
        public MetroFramework.Controls.MetroLabel MLWelcome;
        public MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Controls.MetroLabel MLTaskCount;
        public MetroFramework.Controls.MetroGrid MGridTasks;
        public MetroFramework.Controls.MetroButton MBtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
    }
}

