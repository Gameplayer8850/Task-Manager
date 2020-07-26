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
            this.gridTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTask.Location = new System.Drawing.Point(16, 57);
            this.gridTask.Margin = new System.Windows.Forms.Padding(4);
            this.gridTask.Name = "gridTask";
            this.gridTask.Size = new System.Drawing.Size(1035, 447);
            this.gridTask.TabIndex = 1;
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNew.Enabled = false;
            this.buttonNew.Location = new System.Drawing.Point(16, 511);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(100, 28);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Nowy";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(124, 511);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 28);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // radioActive
            // 
            this.radioActive.AutoSize = true;
            this.radioActive.Enabled = false;
            this.radioActive.Location = new System.Drawing.Point(4, 4);
            this.radioActive.Margin = new System.Windows.Forms.Padding(4);
            this.radioActive.Name = "radioActive";
            this.radioActive.Size = new System.Drawing.Size(81, 21);
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
            this.radioFinished.Location = new System.Drawing.Point(100, 4);
            this.radioFinished.Margin = new System.Windows.Forms.Padding(4);
            this.radioFinished.Name = "radioFinished";
            this.radioFinished.Size = new System.Drawing.Size(100, 21);
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
            this.radioConfirmed.Location = new System.Drawing.Point(215, 4);
            this.radioConfirmed.Margin = new System.Windows.Forms.Padding(4);
            this.radioConfirmed.Name = "radioConfirmed";
            this.radioConfirmed.Size = new System.Drawing.Size(114, 21);
            this.radioConfirmed.TabIndex = 6;
            this.radioConfirmed.TabStop = true;
            this.radioConfirmed.Text = "Zatwierdzone";
            this.radioConfirmed.UseVisualStyleBackColor = true;
            this.radioConfirmed.CheckedChanged += new System.EventHandler(this.radioConfirmed_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioAll);
            this.panel1.Controls.Add(this.radioActive);
            this.panel1.Controls.Add(this.radioConfirmed);
            this.panel1.Controls.Add(this.radioFinished);
            this.panel1.Location = new System.Drawing.Point(305, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 34);
            this.panel1.TabIndex = 7;
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Enabled = false;
            this.radioAll.Location = new System.Drawing.Point(341, 4);
            this.radioAll.Margin = new System.Windows.Forms.Padding(4);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(92, 21);
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
            this.buttonStat.Location = new System.Drawing.Point(951, 511);
            this.buttonStat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStat.Name = "buttonStat";
            this.buttonStat.Size = new System.Drawing.Size(100, 28);
            this.buttonStat.TabIndex = 8;
            this.buttonStat.Text = "Statystyki";
            this.buttonStat.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(231, 511);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonStat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.gridTask);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Main_Load);
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

