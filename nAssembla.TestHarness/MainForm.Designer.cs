namespace nAssembla.TestHarness
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.spacesCombo = new System.Windows.Forms.ComboBox();
            this.reportsGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milestoneIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assignee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsCombo = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.streamPanel = new nAssembla.TestHarness.Controls.StackPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshCache = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDetailBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spacesCombo
            // 
            this.spacesCombo.DisplayMember = "Name";
            this.spacesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spacesCombo.FormattingEnabled = true;
            this.spacesCombo.Location = new System.Drawing.Point(76, 9);
            this.spacesCombo.Name = "spacesCombo";
            this.spacesCombo.Size = new System.Drawing.Size(342, 21);
            this.spacesCombo.TabIndex = 0;
            this.spacesCombo.SelectedIndexChanged += new System.EventHandler(this.spacesCombo_SelectedIndexChanged);
            // 
            // reportsGrid
            // 
            this.reportsGrid.AllowUserToAddRows = false;
            this.reportsGrid.AllowUserToDeleteRows = false;
            this.reportsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportsGrid.AutoGenerateColumns = false;
            this.reportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.summaryDataGridViewTextBoxColumn,
            this.statusNameDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.milestoneIdDataGridViewTextBoxColumn,
            this.componentIdDataGridViewTextBoxColumn,
            this.reporterIdDataGridViewTextBoxColumn,
            this.Assignee,
            this.createdOnDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn});
            this.reportsGrid.DataSource = this.ticketDetailBindingSource;
            this.reportsGrid.Enabled = false;
            this.reportsGrid.Location = new System.Drawing.Point(6, 33);
            this.reportsGrid.Name = "reportsGrid";
            this.reportsGrid.ReadOnly = true;
            this.reportsGrid.Size = new System.Drawing.Size(994, 489);
            this.reportsGrid.TabIndex = 1;
            this.reportsGrid.DataSourceChanged += new System.EventHandler(this.reportsGrid_DataSourceChanged);
            this.reportsGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportsGrid_CellContentDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 70;
            // 
            // summaryDataGridViewTextBoxColumn
            // 
            this.summaryDataGridViewTextBoxColumn.DataPropertyName = "Summary";
            this.summaryDataGridViewTextBoxColumn.HeaderText = "Summary";
            this.summaryDataGridViewTextBoxColumn.Name = "summaryDataGridViewTextBoxColumn";
            this.summaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.summaryDataGridViewTextBoxColumn.Width = 300;
            // 
            // statusNameDataGridViewTextBoxColumn
            // 
            this.statusNameDataGridViewTextBoxColumn.DataPropertyName = "StatusName";
            this.statusNameDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusNameDataGridViewTextBoxColumn.Name = "statusNameDataGridViewTextBoxColumn";
            this.statusNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // milestoneIdDataGridViewTextBoxColumn
            // 
            this.milestoneIdDataGridViewTextBoxColumn.DataPropertyName = "MilestoneName";
            this.milestoneIdDataGridViewTextBoxColumn.HeaderText = "Milestone";
            this.milestoneIdDataGridViewTextBoxColumn.Name = "milestoneIdDataGridViewTextBoxColumn";
            this.milestoneIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // componentIdDataGridViewTextBoxColumn
            // 
            this.componentIdDataGridViewTextBoxColumn.DataPropertyName = "ComponentName";
            this.componentIdDataGridViewTextBoxColumn.HeaderText = "Component";
            this.componentIdDataGridViewTextBoxColumn.Name = "componentIdDataGridViewTextBoxColumn";
            this.componentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reporterIdDataGridViewTextBoxColumn
            // 
            this.reporterIdDataGridViewTextBoxColumn.DataPropertyName = "ReporterName";
            this.reporterIdDataGridViewTextBoxColumn.HeaderText = "Reporter";
            this.reporterIdDataGridViewTextBoxColumn.Name = "reporterIdDataGridViewTextBoxColumn";
            this.reporterIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Assignee
            // 
            this.Assignee.DataPropertyName = "AssigneeName";
            this.Assignee.HeaderText = "Assignee";
            this.Assignee.Name = "Assignee";
            this.Assignee.ReadOnly = true;
            // 
            // createdOnDataGridViewTextBoxColumn
            // 
            this.createdOnDataGridViewTextBoxColumn.DataPropertyName = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.HeaderText = "Created On";
            this.createdOnDataGridViewTextBoxColumn.Name = "createdOnDataGridViewTextBoxColumn";
            this.createdOnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "Updated At";
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketDetailBindingSource
            // 
            this.ticketDetailBindingSource.DataSource = typeof(nAssembla.TestHarness.ViewModel.TicketDetail);
            this.ticketDetailBindingSource.CurrentChanged += new System.EventHandler(this.ticketDetailBindingSource_CurrentChanged);
            // 
            // reportsCombo
            // 
            this.reportsCombo.DisplayMember = "Name";
            this.reportsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportsCombo.Enabled = false;
            this.reportsCombo.FormattingEnabled = true;
            this.reportsCombo.Location = new System.Drawing.Point(60, 6);
            this.reportsCombo.Name = "reportsCombo";
            this.reportsCombo.Size = new System.Drawing.Size(342, 21);
            this.reportsCombo.TabIndex = 2;
            this.reportsCombo.SelectedIndexChanged += new System.EventHandler(this.reportsCombo_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1038, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Space";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Report";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 554);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.streamPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Activity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // streamPanel
            // 
            this.streamPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streamPanel.Location = new System.Drawing.Point(3, 3);
            this.streamPanel.Name = "streamPanel";
            this.streamPanel.Size = new System.Drawing.Size(1000, 522);
            this.streamPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportsGrid);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.reportsCombo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tickets";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Assignee";
            this.dataGridViewTextBoxColumn1.HeaderText = "Assignee";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Assignee";
            this.dataGridViewTextBoxColumn2.HeaderText = "Assignee";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // refreshCache
            // 
            this.refreshCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshCache.Location = new System.Drawing.Point(929, 9);
            this.refreshCache.Name = "refreshCache";
            this.refreshCache.Size = new System.Drawing.Size(97, 23);
            this.refreshCache.TabIndex = 7;
            this.refreshCache.Text = "Refresh cache";
            this.refreshCache.UseVisualStyleBackColor = true;
            this.refreshCache.Click += new System.EventHandler(this.refreshCache_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 615);
            this.Controls.Add(this.refreshCache);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.spacesCombo);
            this.Name = "MainForm";
            this.Text = "nAssembla";
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDetailBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox spacesCombo;
        private System.Windows.Forms.DataGridView reportsGrid;
        private System.Windows.Forms.ComboBox reportsCombo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource ticketDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestoneIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignee;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button refreshCache;
        private Controls.StackPanel streamPanel;

    }
}

