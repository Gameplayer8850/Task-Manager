namespace TM.Forms
{
    partial class Add_Task
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxProgram = new System.Windows.Forms.TextBox();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.dateComissioned = new System.Windows.Forms.DateTimePicker();
            this.dateDeadline = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.checkBoxAccept = new System.Windows.Forms.CheckBox();
            this.checkBoxComissioned_date = new System.Windows.Forms.CheckBox();
            this.checkBoxDeadline = new System.Windows.Forms.CheckBox();
            this.checkBoxStart = new System.Windows.Forms.CheckBox();
            this.checkBoxEnd = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa programu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa projektu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data zlecenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data terminu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data rozpoczęcia pracy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data zakończenia pracy";
            // 
            // textBoxProgram
            // 
            this.textBoxProgram.Location = new System.Drawing.Point(231, 33);
            this.textBoxProgram.Name = "textBoxProgram";
            this.textBoxProgram.Size = new System.Drawing.Size(248, 22);
            this.textBoxProgram.TabIndex = 8;
            // 
            // textBoxProject
            // 
            this.textBoxProject.Location = new System.Drawing.Point(231, 61);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(248, 22);
            this.textBoxProject.TabIndex = 9;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(231, 89);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(248, 46);
            this.richTextBoxDescription.TabIndex = 10;
            this.richTextBoxDescription.Text = "";
            // 
            // dateComissioned
            // 
            this.dateComissioned.Enabled = false;
            this.dateComissioned.Location = new System.Drawing.Point(231, 141);
            this.dateComissioned.Name = "dateComissioned";
            this.dateComissioned.Size = new System.Drawing.Size(248, 22);
            this.dateComissioned.TabIndex = 11;
            this.dateComissioned.Value = new System.DateTime(2020, 7, 26, 14, 3, 14, 0);
            // 
            // dateDeadline
            // 
            this.dateDeadline.Enabled = false;
            this.dateDeadline.Location = new System.Drawing.Point(231, 169);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new System.Drawing.Size(248, 22);
            this.dateDeadline.TabIndex = 12;
            // 
            // dateStart
            // 
            this.dateStart.Enabled = false;
            this.dateStart.Location = new System.Drawing.Point(231, 197);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(248, 22);
            this.dateStart.TabIndex = 13;
            // 
            // dateEnd
            // 
            this.dateEnd.Enabled = false;
            this.dateEnd.Location = new System.Drawing.Point(231, 225);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(248, 22);
            this.dateEnd.TabIndex = 14;
            // 
            // checkBoxAccept
            // 
            this.checkBoxAccept.AutoSize = true;
            this.checkBoxAccept.Location = new System.Drawing.Point(148, 253);
            this.checkBoxAccept.Name = "checkBoxAccept";
            this.checkBoxAccept.Size = new System.Drawing.Size(169, 21);
            this.checkBoxAccept.TabIndex = 15;
            this.checkBoxAccept.Text = "Zadanie zatwierdzone";
            this.checkBoxAccept.UseVisualStyleBackColor = true;
            // 
            // checkBoxComissioned_date
            // 
            this.checkBoxComissioned_date.AutoSize = true;
            this.checkBoxComissioned_date.Location = new System.Drawing.Point(207, 141);
            this.checkBoxComissioned_date.Name = "checkBoxComissioned_date";
            this.checkBoxComissioned_date.Size = new System.Drawing.Size(18, 17);
            this.checkBoxComissioned_date.TabIndex = 16;
            this.checkBoxComissioned_date.UseVisualStyleBackColor = true;
            this.checkBoxComissioned_date.CheckedChanged += new System.EventHandler(this.checkBoxComissioned_date_CheckedChanged);
            // 
            // checkBoxDeadline
            // 
            this.checkBoxDeadline.AutoSize = true;
            this.checkBoxDeadline.Location = new System.Drawing.Point(207, 169);
            this.checkBoxDeadline.Name = "checkBoxDeadline";
            this.checkBoxDeadline.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDeadline.TabIndex = 17;
            this.checkBoxDeadline.UseVisualStyleBackColor = true;
            this.checkBoxDeadline.CheckedChanged += new System.EventHandler(this.checkBoxDeadline_CheckedChanged);
            // 
            // checkBoxStart
            // 
            this.checkBoxStart.AutoSize = true;
            this.checkBoxStart.Location = new System.Drawing.Point(207, 197);
            this.checkBoxStart.Name = "checkBoxStart";
            this.checkBoxStart.Size = new System.Drawing.Size(18, 17);
            this.checkBoxStart.TabIndex = 18;
            this.checkBoxStart.UseVisualStyleBackColor = true;
            this.checkBoxStart.CheckedChanged += new System.EventHandler(this.checkBoxStart_CheckedChanged);
            // 
            // checkBoxEnd
            // 
            this.checkBoxEnd.AutoSize = true;
            this.checkBoxEnd.Location = new System.Drawing.Point(207, 225);
            this.checkBoxEnd.Name = "checkBoxEnd";
            this.checkBoxEnd.Size = new System.Drawing.Size(18, 17);
            this.checkBoxEnd.TabIndex = 19;
            this.checkBoxEnd.UseVisualStyleBackColor = true;
            this.checkBoxEnd.CheckedChanged += new System.EventHandler(this.checkBoxEnd_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(193, 293);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Add_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 328);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxEnd);
            this.Controls.Add(this.checkBoxStart);
            this.Controls.Add(this.checkBoxDeadline);
            this.Controls.Add(this.checkBoxComissioned_date);
            this.Controls.Add(this.checkBoxAccept);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.dateDeadline);
            this.Controls.Add(this.dateComissioned);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxProject);
            this.Controls.Add(this.textBoxProgram);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Task";
            this.Text = "Add_Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxProgram;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.DateTimePicker dateComissioned;
        private System.Windows.Forms.DateTimePicker dateDeadline;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.CheckBox checkBoxAccept;
        private System.Windows.Forms.CheckBox checkBoxComissioned_date;
        private System.Windows.Forms.CheckBox checkBoxDeadline;
        private System.Windows.Forms.CheckBox checkBoxStart;
        private System.Windows.Forms.CheckBox checkBoxEnd;
        private System.Windows.Forms.Button buttonSave;
    }
}