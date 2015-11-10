namespace nAssembla.TestHarness.Controls
{
    partial class StreamEvent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.user = new System.Windows.Forms.LinkLabel();
            this.action = new System.Windows.Forms.LinkLabel();
            this.summary = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(108, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(23, 13);
            this.title.TabIndex = 0;
            this.title.Text = "title";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.user);
            this.flowLayoutPanel1.Controls.Add(this.action);
            this.flowLayoutPanel1.Controls.Add(this.title);
            this.flowLayoutPanel1.Controls.Add(this.summary);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(660, 49);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(3, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(57, 13);
            this.user.TabIndex = 0;
            this.user.TabStop = true;
            this.user.Text = "UserName";
            // 
            // action
            // 
            this.action.AutoSize = true;
            this.action.Location = new System.Drawing.Point(66, 0);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(36, 13);
            this.action.TabIndex = 1;
            this.action.TabStop = true;
            this.action.Text = "action";
            // 
            // summary
            // 
            this.summary.AutoSize = true;
            this.summary.Location = new System.Drawing.Point(137, 0);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(48, 13);
            this.summary.TabIndex = 2;
            this.summary.Text = "summary";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(0, 4);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(30, 13);
            this.time.TabIndex = 2;
            this.time.Text = "Time";
            // 
            // StreamEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.time);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StreamEvent";
            this.Size = new System.Drawing.Size(740, 56);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel user;
        private System.Windows.Forms.LinkLabel action;
        private System.Windows.Forms.Label summary;
        private System.Windows.Forms.Label time;
    }
}
