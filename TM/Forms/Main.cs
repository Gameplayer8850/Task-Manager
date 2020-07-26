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
        Boolean new_file = false;
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
                new_file = true;
                buttonNew.Enabled = true;
                radioActive.Select();
                return;
            }
            fill_with_data();
            if (tasks.Any()) {
                radioActive.Select();
                fill_grid(Global_Data.Mode.Active);
            }

        } 
        private void Main_Shown(object sender, EventArgs e)
        {
            if (new_file)
            {
                MessageBox.Show("Utworzono pliki lokalne.", "Informacja");
                new_file = false;
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
                create_source(active);
            }
            else if (mode == Global_Data.Mode.Finished)
            {
                create_source(finished);
            }
            else if (mode == Global_Data.Mode.Confirmed)
            {
                create_source(confirmed);
            }
            else {
                create_source(tasks);
            }
        }

        private void create_source(List<Data.Task> list) {
            var source = new BindingSource();
            source.DataSource = list;
            gridTask.DataSource = source;
            gridTask.Columns[0].HeaderText = "Id";
            gridTask.Columns[1].HeaderText = "Program";
            gridTask.Columns[2].HeaderText = "Projekt";
            gridTask.Columns[3].HeaderText = "Opis";
            gridTask.Columns[4].HeaderText = "Data Rozpoczęcia";
            gridTask.Columns[5].HeaderText = "Data Zakończenia";
            gridTask.Columns[6].HeaderText = "Data Zlecenia";
            gridTask.Columns[7].HeaderText = "Data Ostateczna";
            gridTask.Columns[8].HeaderText = "Zatwierdzone";
        }

        private void radioSelection() {
            if (current_mode == Global_Data.Mode.Active)
            {
                if (!active.Any()) radioAll.Select();
                else radioActive.Checked = true;
            } 
            else if (current_mode == Global_Data.Mode.Finished)
            {
                if (!finished.Any()) radioAll.Select();
                else radioFinished.Checked = true;
            } 
            else if (current_mode == Global_Data.Mode.Confirmed)
            {
                if (!confirmed.Any()) radioAll.Select();
                else radioConfirmed.Checked = true;
            } 
            else radioAll.Checked = true;
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
            radioSelection();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = (int)gridTask.SelectedRows[0].Cells[0].Value;
            Add_Task at = new Add_Task(tasks, Global_Data.FormType.Edit, id);
            at.ShowDialog();
            at.Dispose();
            fill_with_data();
            fill_grid(current_mode);
            radioSelection();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = (int)gridTask.SelectedRows[0].Cells[0].Value;
            if(MessageBox.Show("Czy napewno chcesz usunąć zadanie o id: \""+id+"\"", "Ostrzeżenie", MessageBoxButtons.YesNo)==DialogResult.No) return;
            tasks.RemoveAt(tasks.FindIndex(x=>x.id==id));
            fm.File_Save(tasks);
            fill_with_data();
            fill_grid(current_mode);
            radioSelection();
        }

        private void gridTask_SelectionChanged(object sender, EventArgs e)
        {
            if (gridTask.SelectedRows.Count == 0||gridTask.SelectedRows[0].Index < 0) {
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }

       
    }
}
