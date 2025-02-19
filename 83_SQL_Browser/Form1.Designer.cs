namespace _83_SQL_Browser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtServerName = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            txtUsername = new ToolStripTextBox();
            toolStripLabel3 = new ToolStripLabel();
            txtPassword = new ToolStripTextBox();
            btnBaglan = new ToolStripButton();
            toolStrip2 = new ToolStrip();
            toolStripLabel4 = new ToolStripLabel();
            cmbDatabases = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel5 = new ToolStripLabel();
            cmbTables = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            btnCalistir = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            clbColumns = new CheckedListBox();
            splitContainer2 = new SplitContainer();
            txtQuery = new TextBox();
            dvgResults = new DataGridView();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgResults).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtServerName, toolStripLabel2, txtUsername, toolStripLabel3, txtPassword, btnBaglan });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(876, 26);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            toolStripLabel1.ForeColor = Color.Red;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(102, 23);
            toolStripLabel1.Text = "Server Name:";
            // 
            // txtServerName
            // 
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(150, 26);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            toolStripLabel2.ForeColor = Color.Red;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(80, 23);
            toolStripLabel2.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 26);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            toolStripLabel3.ForeColor = Color.Red;
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(77, 23);
            toolStripLabel3.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 26);
            // 
            // btnBaglan
            // 
            btnBaglan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBaglan.ForeColor = Color.Teal;
            btnBaglan.Image = Properties.Resources.connected;
            btnBaglan.ImageTransparentColor = Color.Magenta;
            btnBaglan.Name = "btnBaglan";
            btnBaglan.Size = new Size(75, 23);
            btnBaglan.Text = "Bağlan";
            btnBaglan.Click += btnBaglan_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel4, cmbDatabases, toolStripSeparator1, toolStripLabel5, cmbTables, toolStripSeparator2, btnCalistir });
            toolStrip2.Location = new Point(0, 26);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(876, 25);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripLabel4.ForeColor = Color.FromArgb(64, 64, 0);
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(66, 22);
            toolStripLabel4.Text = "Databases:";
            // 
            // cmbDatabases
            // 
            cmbDatabases.Name = "cmbDatabases";
            cmbDatabases.Size = new Size(121, 25);
            cmbDatabases.SelectedIndexChanged += cmbDatabases_SelectedIndexChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripLabel5.ForeColor = Color.FromArgb(64, 64, 0);
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(44, 22);
            toolStripLabel5.Text = "Tables:";
            // 
            // cmbTables
            // 
            cmbTables.Name = "cmbTables";
            cmbTables.Size = new Size(121, 25);
            cmbTables.SelectedIndexChanged += cmbTables_SelectedIndexChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnCalistir
            // 
            btnCalistir.Image = Properties.Resources.play_buttton;
            btnCalistir.ImageTransparentColor = Color.Magenta;
            btnCalistir.Name = "btnCalistir";
            btnCalistir.Size = new Size(63, 22);
            btnCalistir.Text = "Çalıştır";
            btnCalistir.Click += btnCalistir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 51);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(clbColumns);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(876, 399);
            splitContainer1.SplitterDistance = 375;
            splitContainer1.TabIndex = 0;
            // 
            // clbColumns
            // 
            clbColumns.Dock = DockStyle.Fill;
            clbColumns.FormattingEnabled = true;
            clbColumns.Location = new Point(0, 0);
            clbColumns.Name = "clbColumns";
            clbColumns.Size = new Size(375, 399);
            clbColumns.TabIndex = 0;
            clbColumns.SelectedIndexChanged += clbColumns_SelectedIndexChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(txtQuery);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dvgResults);
            splitContainer2.Size = new Size(497, 399);
            splitContainer2.SplitterDistance = 165;
            splitContainer2.TabIndex = 0;
            // 
            // txtQuery
            // 
            txtQuery.Dock = DockStyle.Fill;
            txtQuery.Location = new Point(0, 0);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(497, 165);
            txtQuery.TabIndex = 0;
            // 
            // dvgResults
            // 
            dvgResults.AllowUserToAddRows = false;
            dvgResults.AllowUserToDeleteRows = false;
            dvgResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgResults.Dock = DockStyle.Fill;
            dvgResults.Location = new Point(0, 0);
            dvgResults.Name = "dvgResults";
            dvgResults.ReadOnly = true;
            dvgResults.Size = new Size(497, 230);
            dvgResults.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "My SQL Browser";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtServerName;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox txtUsername;
        private ToolStripLabel toolStripLabel3;
        private ToolStripTextBox txtPassword;
        private ToolStripButton btnBaglan;
        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabel4;
        private ToolStripComboBox cmbDatabases;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel5;
        private ToolStripComboBox cmbTables;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnCalistir;
        private SplitContainer splitContainer1;
        private CheckedListBox clbColumns;
        private SplitContainer splitContainer2;
        private TextBox txtQuery;
        private DataGridView dvgResults;
    }
}
