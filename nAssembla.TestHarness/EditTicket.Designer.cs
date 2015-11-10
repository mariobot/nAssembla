namespace nAssembla.TestHarness
{
    partial class EditTicket
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.priority = new System.Windows.Forms.ComboBox();
            this.assignee = new System.Windows.Forms.ComboBox();
            this.component = new System.Windows.Forms.ComboBox();
            this.milestone = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addComment = new System.Windows.Forms.Button();
            this.newComment = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketCommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCommentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "Summary", true));
            this.textBox1.Location = new System.Drawing.Point(7, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "Description", true));
            this.textBox2.Location = new System.Drawing.Point(4, 25);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(486, 430);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 13);
            label1.TabIndex = 2;
            label1.Text = "Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ticketBindingSource, "StatusName", true));
            this.status.DisplayMember = "Name";
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(12, 30);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(162, 21);
            this.status.TabIndex = 0;
            this.status.ValueMember = "Name";
            // 
            // priority
            // 
            this.priority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priority.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.ticketBindingSource, "Priority", true));
            this.priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priority.FormattingEnabled = true;
            this.priority.Location = new System.Drawing.Point(12, 72);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(162, 21);
            this.priority.TabIndex = 1;
            // 
            // assignee
            // 
            this.assignee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignee.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ticketBindingSource, "AssignedTo", true));
            this.assignee.DisplayMember = "Name";
            this.assignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignee.FormattingEnabled = true;
            this.assignee.Location = new System.Drawing.Point(12, 112);
            this.assignee.Name = "assignee";
            this.assignee.Size = new System.Drawing.Size(162, 21);
            this.assignee.TabIndex = 2;
            this.assignee.ValueMember = "Id";
            // 
            // component
            // 
            this.component.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.component.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ticketBindingSource, "ComponentId", true));
            this.component.DisplayMember = "Name";
            this.component.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.component.FormattingEnabled = true;
            this.component.Location = new System.Drawing.Point(12, 152);
            this.component.Name = "component";
            this.component.Size = new System.Drawing.Size(162, 21);
            this.component.TabIndex = 3;
            this.component.ValueMember = "Id";
            // 
            // milestone
            // 
            this.milestone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.milestone.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ticketBindingSource, "MilestoneId", true));
            this.milestone.DisplayMember = "Title";
            this.milestone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.milestone.FormattingEnabled = true;
            this.milestone.Location = new System.Drawing.Point(12, 192);
            this.milestone.Name = "milestone";
            this.milestone.Size = new System.Drawing.Size(162, 21);
            this.milestone.TabIndex = 4;
            this.milestone.ValueMember = "Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.milestone);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.component);
            this.panel1.Controls.Add(this.priority);
            this.panel1.Controls.Add(this.assignee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 555);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 555);
            this.panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 487);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Description";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addComment);
            this.tabPage2.Controls.Add(this.newComment);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Activity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addComment
            // 
            this.addComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addComment.Location = new System.Drawing.Point(390, 432);
            this.addComment.Name = "addComment";
            this.addComment.Size = new System.Drawing.Size(95, 23);
            this.addComment.TabIndex = 7;
            this.addComment.Text = "Add comment";
            this.addComment.UseVisualStyleBackColor = true;
            this.addComment.Click += new System.EventHandler(this.addComment_Click);
            // 
            // newComment
            // 
            this.newComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newComment.Location = new System.Drawing.Point(4, 342);
            this.newComment.Multiline = true;
            this.newComment.Name = "newComment";
            this.newComment.Size = new System.Drawing.Size(480, 84);
            this.newComment.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(4, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 329);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(nAssembla.DTO.Ticket);
            // 
            // ticketCommentBindingSource
            // 
            this.ticketCommentBindingSource.DataSource = typeof(nAssembla.DTO.TicketComment);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 14);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 13);
            label3.TabIndex = 5;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 56);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 6;
            label4.Text = "Priority";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(9, 96);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(62, 13);
            label5.TabIndex = 7;
            label5.Text = "Assigned to";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(9, 136);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 13);
            label6.TabIndex = 8;
            label6.Text = "Component";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(9, 176);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 13);
            label7.TabIndex = 9;
            label7.Text = "Milestone";
            // 
            // EditTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditTicket";
            this.Text = "Edit Ticket";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCommentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox milestone;
        private System.Windows.Forms.ComboBox component;
        private System.Windows.Forms.ComboBox assignee;
        private System.Windows.Forms.ComboBox priority;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource ticketCommentBindingSource;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addComment;
        private System.Windows.Forms.TextBox newComment;
    }
}