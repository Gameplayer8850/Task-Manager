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
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa programu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa projektu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data zlecenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data terminu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data rozpoczęcia pracy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data zakończenia pracy";
            // 
            // textBoxProgram
            // 
            this.textBoxProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProgram.Location = new System.Drawing.Point(173, 27);
            this.textBoxProgram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProgram.Name = "textBoxProgram";
            this.textBoxProgram.Size = new System.Drawing.Size(187, 20);
            this.textBoxProgram.TabIndex = 8;
            // 
            // textBoxProject
            // 
            this.textBoxProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProject.Location = new System.Drawing.Point(173, 50);
            this.textBoxProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(187, 20);
            this.textBoxProject.TabIndex = 9;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(173, 72);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(187, 38);
            this.richTextBoxDescription.TabIndex = 10;
            this.richTextBoxDescription.Text = "";
            // 
            // dateComissioned
            // 
            this.dateComissioned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateComissioned.Enabled = false;
            this.dateComissioned.Location = new System.Drawing.Point(173, 115);
            this.dateComissioned.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateComissioned.Name = "dateComissioned";
            this.dateComissioned.Size = new System.Drawing.Size(187, 20);
            this.dateComissioned.TabIndex = 11;
            this.dateComissioned.Value = new System.DateTime(2020, 7, 26, 14, 3, 14, 0);
            // 
            // dateDeadline
            // 
            this.dateDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDeadline.Enabled = false;
            this.dateDeadline.Location = new System.Drawing.Point(173, 137);
            this.dateDeadline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new System.Drawing.Size(187, 20);
            this.dateDeadline.TabIndex = 12;
            // 
            // dateStart
            // 
            this.dateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateStart.Enabled = false;
            this.dateStart.Location = new System.Drawing.Point(173, 160);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(187, 20);
            this.dateStart.TabIndex = 13;
            // 
            // dateEnd
            // 
            this.dateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEnd.Enabled = false;
            this.dateEnd.Location = new System.Drawing.Point(173, 183);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(187, 20);
            this.dateEnd.TabIndex = 14;
            // 
            // checkBoxAccept
            // 
            this.checkBoxAccept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAccept.AutoSize = true;
            this.checkBoxAccept.Location = new System.Drawing.Point(111, 206);
            this.checkBoxAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxAccept.Name = "checkBoxAccept";
            this.checkBoxAccept.Size = new System.Drawing.Size(130, 17);
            this.checkBoxAccept.TabIndex = 15;
            this.checkBoxAccept.Text = "Zadanie zatwierdzone";
            this.checkBoxAccept.UseVisualStyleBackColor = true;
            // 
            // checkBoxComissioned_date
            // 
            this.checkBoxComissioned_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxComissioned_date.AutoSize = true;
            this.checkBoxComissioned_date.Location = new System.Drawing.Point(155, 115);
            this.checkBoxComissioned_date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxComissioned_date.Name = "checkBoxComissioned_date";
            this.checkBoxComissioned_date.Size = new System.Drawing.Size(15, 14);
            this.checkBoxComissioned_date.TabIndex = 16;
            this.checkBoxComissioned_date.UseVisualStyleBackColor = true;
            this.checkBoxComissioned_date.CheckedChanged += new System.EventHandler(this.checkBoxComissioned_date_CheckedChanged);
            // 
            // checkBoxDeadline
            // 
            this.checkBoxDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDeadline.AutoSize = true;
            this.checkBoxDeadline.Location = new System.Drawing.Point(155, 137);
            this.checkBoxDeadline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxDeadline.Name = "checkBoxDeadline";
            this.checkBoxDeadline.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDeadline.TabIndex = 17;
            this.checkBoxDeadline.UseVisualStyleBackColor = true;
            this.checkBoxDeadline.CheckedChanged += new System.EventHandler(this.checkBoxDeadline_CheckedChanged);
            // 
            // checkBoxStart
            // 
            this.checkBoxStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxStart.AutoSize = true;
            this.checkBoxStart.Location = new System.Drawing.Point(155, 160);
            this.checkBoxStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxStart.Name = "checkBoxStart";
            this.checkBoxStart.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStart.TabIndex = 18;
            this.checkBoxStart.UseVisualStyleBackColor = true;
            this.checkBoxStart.CheckedChanged += new System.EventHandler(this.checkBoxStart_CheckedChanged);
            // 
            // checkBoxEnd
            // 
            this.checkBoxEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEnd.AutoSize = true;
            this.checkBoxEnd.Location = new System.Drawing.Point(155, 183);
            this.checkBoxEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxEnd.Name = "checkBoxEnd";
            this.checkBoxEnd.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEnd.TabIndex = 19;
            this.checkBoxEnd.UseVisualStyleBackColor = true;
            this.checkBoxEnd.CheckedChanged += new System.EventHandler(this.checkBoxEnd_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(155, 232);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Add_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 266);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Add_Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Task";
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