using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPO.Logic;

namespace TPO.DesktopClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateTaskListBox()
        {
            taskListBox.Items.Clear();

            for (int i = 0; i < _taskMgr.Count(); i++)
            {
                taskListBox.Items.Add(_taskMgr.Get(i).Name);
            }

            taskListBox.SelectedIndex = -1;
            taskListBox_SelectedIndexChanged(taskListBox, null);
        }

        private readonly TaskManager _taskMgr = new TaskManager();
        private readonly char[] taskNameFilter = new char[]
        {
            ' ', '\t', '\v', '\r', '\n', '\a'
        };

        private void addButton_Click(object sender, EventArgs e)
        {
            string taskName = taskNameTextBox.Text;
            string taskDescr = taskDescrTextBox.Text;

            if (string.IsNullOrEmpty(taskName) || string.IsNullOrWhiteSpace(taskName) ||
                string.IsNullOrEmpty(taskDescr) || string.IsNullOrWhiteSpace(taskDescr))
            {
                MessageBox.Show("Заполните все поля", "Предупреждение");
            }
            else
            {
                _taskMgr.Add(new UserTask { Name = taskName, Description = taskDescr });
                // update ui
                UpdateTaskListBox();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _taskMgr.Delete(taskListBox.SelectedIndex);
            UpdateTaskListBox();
        }

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox taskList = (ListBox)sender;

            int taskIndex = taskList.SelectedIndex;

            if (taskIndex > -1)
            {
                detailTaskDescrTextBox.Text = _taskMgr.Get(taskIndex).Description;
                deleteButton.Enabled = true;
            }
            else
            {
                detailTaskDescrTextBox.Text = string.Empty;
                deleteButton.Enabled = false;
            }
        }

        private void taskNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (taskNameFilter.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
