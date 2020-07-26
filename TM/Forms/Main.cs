using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TM.Data;
using TM.Files_and_Data_Manager;
using TM.Forms;

namespace TM
{
    public partial class Main : Form
    {
        Files_Manager fm;
        List<Data.Task> tasks=new List<Data.Task>();
        List<Data.Task> active = new List<Data.Task>();
        List<Data.Task> finished = new List<Data.Task>();
        List<Data.Task> confirmed = new List<Data.Task>();
        Global_Data.Mode current_mode;
        public Main()
        {
            InitializeComponent();
            buttons_disable();
            fm = new Files_Manager();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            current_mode = Global_Data.Mode.Active;
            buttonNew.Enabled = true;
            if (!fm.File_Exist()) {
                fm.File_Save(null);
                MessageBox.Show("Utworzono pliki lokalne.", "Informacja");
                buttonNew.Enabled = true;
                return;
            }
            fill_with_data();
            if (tasks.Any()) {
                radioActive.Select();
                fill_grid(Global_Data.Mode.Active);
            }

        }
        private void buttons_disable() {
            radioActive.Enabled = false;
            radioFinished.Enabled = false;
            radioConfirmed.Enabled = false;
            radioAll.Enabled = false;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonStat.Enabled = false;
        }
        private void fill_with_data() {
            tasks = fm.File_Read();
            tasks=tasks.OrderBy(x=>x.id).ToList();
            active = tasks.FindAll(x=>x.end_date== default(DateTime));
            finished = tasks.FindAll(x=>x.end_date!= default(DateTime) && x.confirmed==false);
            confirmed = tasks.FindAll(x=>x.confirmed==true);

            radioAll.Enabled = tasks.Any();
            if (!radioAll.Enabled) {
                radioActive.Enabled = false;
                radioFinished.Enabled = false;
                radioConfirmed.Enabled = false;
                return;
            }
            radioActive.Enabled = active.Any();
            radioFinished.Enabled = finished.Any();
            radioConfirmed.Enabled = confirmed.Any();
        }

        private void fill_grid(Global_Data.Mode mode) {
            current_mode = mode;
            if (mode == Global_Data.Mode.Active)
            {
                var source = new BindingSource();
                source.DataSource = active;
                gridTask.DataSource = source;
            }
            else if (mode == Global_Data.Mode.Finished)
            {
                var source = new BindingSource();
                source.DataSource = finished;
                gridTask.DataSource = source;
            }
            else if (mode == Global_Data.Mode.Confirmed)
            {
                var source = new BindingSource();
                source.DataSource = confirmed;
                gridTask.DataSource = source;
            }
            else {
                var source = new BindingSource();
                source.DataSource = tasks;
                gridTask.DataSource = source;
            }
        }

        private void radioActive_CheckedChanged(object sender, EventArgs e)
        {
            fill_grid(Global_Data.Mode.Active);
        }

        private void radioFinished_CheckedChanged(object sender, EventArgs e)
        {
            fill_grid(Global_Data.Mode.Finished);
        }

        private void radioConfirmed_CheckedChanged(object sender, EventArgs e)
        {
            fill_grid(Global_Data.Mode.Confirmed);
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            fill_grid(Global_Data.Mode.All);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Add_Task at = new Add_Task(tasks, Global_Data.FormType.New);
            at.ShowDialog();
            at.Dispose();
            fill_with_data();
            fill_grid(current_mode);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //int id
        }
    }
}
