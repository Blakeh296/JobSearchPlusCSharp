namespace JobSearchPlus
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ActiveCallList = new System.Windows.Forms.TabPage();
            this.LeadsBySource = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.SearchLog = new System.Windows.Forms.TabPage();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbEmploymentType = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnAddLead = new System.Windows.Forms.Button();
            this.tbJobTitle = new System.Windows.Forms.TextBox();
            this.tbRecordDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ActiveCallList.SuspendLayout();
            this.LeadsBySource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SearchLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ActiveCallList);
            this.tabControl1.Controls.Add(this.LeadsBySource);
            this.tabControl1.Controls.Add(this.SearchLog);
            this.tabControl1.Location = new System.Drawing.Point(38, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 369);
            this.tabControl1.TabIndex = 3;
            // 
            // ActiveCallList
            // 
            this.ActiveCallList.BackColor = System.Drawing.Color.White;
            this.ActiveCallList.Controls.Add(this.dataGridView1);
            this.ActiveCallList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ActiveCallList.Location = new System.Drawing.Point(4, 22);
            this.ActiveCallList.Name = "ActiveCallList";
            this.ActiveCallList.Padding = new System.Windows.Forms.Padding(3);
            this.ActiveCallList.Size = new System.Drawing.Size(552, 343);
            this.ActiveCallList.TabIndex = 0;
            this.ActiveCallList.Text = "Active Call List";
            // 
            // LeadsBySource
            // 
            this.LeadsBySource.Controls.Add(this.dataGridView4);
            this.LeadsBySource.Location = new System.Drawing.Point(4, 22);
            this.LeadsBySource.Name = "LeadsBySource";
            this.LeadsBySource.Size = new System.Drawing.Size(552, 343);
            this.LeadsBySource.TabIndex = 3;
            this.LeadsBySource.Text = "Leads By Source";
            this.LeadsBySource.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(543, 337);
            this.dataGridView4.TabIndex = 3;
            // 
            // SearchLog
            // 
            this.SearchLog.Controls.Add(this.lblOutput);
            this.SearchLog.Controls.Add(this.tbLocation);
            this.SearchLog.Controls.Add(this.tbEmploymentType);
            this.SearchLog.Controls.Add(this.tbDescription);
            this.SearchLog.Controls.Add(this.btnAddLead);
            this.SearchLog.Controls.Add(this.tbJobTitle);
            this.SearchLog.Controls.Add(this.tbRecordDate);
            this.SearchLog.Location = new System.Drawing.Point(4, 22);
            this.SearchLog.Name = "SearchLog";
            this.SearchLog.Size = new System.Drawing.Size(552, 343);
            this.SearchLog.TabIndex = 4;
            this.SearchLog.Text = "Search Log";
            this.SearchLog.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Wheat;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(15, 35);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 23);
            this.lblOutput.TabIndex = 8;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(15, 179);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(100, 20);
            this.tbLocation.TabIndex = 7;
            // 
            // tbEmploymentType
            // 
            this.tbEmploymentType.Location = new System.Drawing.Point(15, 153);
            this.tbEmploymentType.Name = "tbEmploymentType";
            this.tbEmploymentType.Size = new System.Drawing.Size(100, 20);
            this.tbEmploymentType.TabIndex = 6;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(15, 127);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 20);
            this.tbDescription.TabIndex = 5;
            // 
            // btnAddLead
            // 
            this.btnAddLead.Location = new System.Drawing.Point(132, 177);
            this.btnAddLead.Name = "btnAddLead";
            this.btnAddLead.Size = new System.Drawing.Size(75, 23);
            this.btnAddLead.TabIndex = 4;
            this.btnAddLead.Text = "Click Me";
            this.btnAddLead.UseVisualStyleBackColor = true;
            // 
            // tbJobTitle
            // 
            this.tbJobTitle.Location = new System.Drawing.Point(15, 101);
            this.tbJobTitle.Name = "tbJobTitle";
            this.tbJobTitle.Size = new System.Drawing.Size(100, 20);
            this.tbJobTitle.TabIndex = 3;
            // 
            // tbRecordDate
            // 
            this.tbRecordDate.Location = new System.Drawing.Point(15, 74);
            this.tbRecordDate.Name = "tbRecordDate";
            this.tbRecordDate.Size = new System.Drawing.Size(100, 20);
            this.tbRecordDate.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 427);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ActiveCallList.ResumeLayout(false);
            this.LeadsBySource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.SearchLog.ResumeLayout(false);
            this.SearchLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ActiveCallList;
        private System.Windows.Forms.TabPage LeadsBySource;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage SearchLog;
        private System.Windows.Forms.Button btnAddLead;
        private System.Windows.Forms.TextBox tbJobTitle;
        private System.Windows.Forms.TextBox tbRecordDate;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbEmploymentType;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblOutput;
    }
}

