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

namespace TM.Forms
{
    public partial class Add_Task : Form
    {
        private List<Data.Task> tasks;
        private Global_Data.FormType formType;
        private int id;
        public Add_Task(List <Data.Task> tasks, Global_Data.FormType formType, int id=0)
        {
            InitializeComponent();
            this.tasks = tasks;
            this.formType = formType;
            this.id = id;
        }

        private void checkBoxComissioned_date_CheckedChanged(object sender, EventArgs e)
        {
            dateComissioned.Enabled = !dateComissioned.Enabled;
        }

        private void checkBoxDeadline_CheckedChanged(object sender, EventArgs e)
        {
            dateDeadline.Enabled = !dateDeadline.Enabled;
        }

        private void checkBoxStart_CheckedChanged(object sender, EventArgs e)
        {
            dateStart.Enabled = !dateStart.Enabled;
        }

        private void checkBoxEnd_CheckedChanged(object sender, EventArgs e)
        {
            dateEnd.Enabled = !dateEnd.Enabled;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Data.Task task = new Data.Task();
            if (formType == Global_Data.FormType.New)
            {
                if (!tasks.Any()) task.id = 1;
                else task.id = tasks.Last().id + 1;
            }
            task.program_name = textBoxProgram.Text;
            task.project_name = textBoxProject.Text;
            task.description = richTextBoxDescription.Text;
            if (!checkBoxComissioned_date.Checked) task.commissioned_date = default(DateTime);
            else task.commissioned_date = dateComissioned.Value;
            if (!checkBoxDeadline.Checked) task.deadline_date = default(DateTime);
            else task.deadline_date = dateDeadline.Value;
            if (!checkBoxStart.Checked) task.start_date = default(DateTime);
            else task.start_date = dateStart.Value;
            if (!checkBoxEnd.Checked) task.end_date = default(DateTime);
            else task.end_date = dateEnd.Value;
            task.confirmed = checkBoxAccept.Checked;
            if (formType == Global_Data.FormType.New) tasks.Add(task);
            else tasks[tasks.FindIndex(x => x.id == id)]=task;
            Files_and_Data_Manager.Files_Manager fm = new Files_and_Data_Manager.Files_Manager();
            fm.File_Save(tasks);
            this.Close();
        }

        private void fill_data() {

        }
    }
}
