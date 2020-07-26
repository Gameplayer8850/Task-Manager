namespace TM
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridTask = new System.Windows.Forms.DataGridView();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.radioActive = new System.Windows.Forms.RadioButton();
            this.radioFinished = new System.Windows.Forms.RadioButton();
            this.radioConfirmed = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.buttonStat = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTask)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTask
            // 
            this.gridTask.AllowUserToAddRows = false;
            this.gridTask.AllowUserToDeleteRows = false;
            this.gridTask.AllowUserToOrderColumns = true;
            this.gridTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTask.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTask.Location = new System.Drawing.Point(12, 46);
            this.gridTask.MultiSelect = false;
            this.gridTask.Name = "gridTask";
            this.gridTask.ReadOnly = true;
            this.gridTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTask.Size = new System.Drawing.Size(776, 363);
            this.gridTask.TabIndex = 1;
            this.gridTask.SelectionChanged += new System.EventHandler(this.gridTask_SelectionChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNew.Enabled = false;
            this.buttonNew.Location = new System.Drawing.Point(12, 415);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Nowy";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(93, 415);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // radioActive
            // 
            this.radioActive.AutoSize = true;
            this.radioActive.Enabled = false;
            this.radioActive.Location = new System.Drawing.Point(3, 3);
            this.radioActive.Name = "radioActive";
            this.radioActive.Size = new System.Drawing.Size(66, 17);
            this.radioActive.TabIndex = 4;
            this.radioActive.TabStop = true;
            this.radioActive.Text = "Aktywne";
            this.radioActive.UseVisualStyleBackColor = true;
            this.radioActive.CheckedChanged += new System.EventHandler(this.radioActive_CheckedChanged);
            // 
            // radioFinished
            // 
            this.radioFinished.AutoSize = true;
            this.radioFinished.Enabled = false;
            this.radioFinished.Location = new System.Drawing.Point(75, 3);
            this.radioFinished.Name = "radioFinished";
            this.radioFinished.Size = new System.Drawing.Size(80, 17);
            this.radioFinished.TabIndex = 5;
            this.radioFinished.TabStop = true;
            this.radioFinished.Text = "Ukończone";
            this.radioFinished.UseVisualStyleBackColor = true;
            this.radioFinished.CheckedChanged += new System.EventHandler(this.radioFinished_CheckedChanged);
            // 
            // radioConfirmed
            // 
            this.radioConfirmed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioConfirmed.AutoSize = true;
            this.radioConfirmed.Enabled = false;
            this.radioConfirmed.Location = new System.Drawing.Point(161, 3);
            this.radioConfirmed.Name = "radioConfirmed";
            this.radioConfirmed.Size = new System.Drawing.Size(89, 17);
            this.radioConfirmed.TabIndex = 6;
            this.radioConfirmed.TabStop = true;
            this.radioConfirmed.Text = "Zatwierdzone";
            this.radioConfirmed.UseVisualStyleBackColor = true;
            this.radioConfirmed.CheckedChanged += new System.EventHandler(this.radioConfirmed_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.radioAll);
            this.panel1.Controls.Add(this.radioActive);
            this.panel1.Controls.Add(this.radioConfirmed);
            this.panel1.Controls.Add(this.radioFinished);
            this.panel1.Location = new System.Drawing.Point(229, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 28);
            this.panel1.TabIndex = 7;
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Enabled = false;
            this.radioAll.Location = new System.Drawing.Point(256, 3);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(73, 17);
            this.radioAll.TabIndex = 7;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "Wszystkie";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radioAll_CheckedChanged);
            // 
            // buttonStat
            // 
            this.buttonStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStat.Enabled = false;
            this.buttonStat.Location = new System.Drawing.Point(713, 415);
            this.buttonStat.Name = "buttonStat";
            this.buttonStat.Size = new System.Drawing.Size(75, 23);
            this.buttonStat.TabIndex = 8;
            this.buttonStat.Text = "Statystyki";
            this.buttonStat.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(173, 415);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonStat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.gridTask);
            this.Name = "Main";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridTask)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTask;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.RadioButton radioActive;
        private System.Windows.Forms.RadioButton radioFinished;
        private System.Windows.Forms.RadioButton radioConfirmed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.Button buttonStat;
        private System.Windows.Forms.Button buttonDelete;
    }
}

