namespace BloodBankManagementSystem
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDevTitle = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelOPositive = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOPositiveCount = new System.Windows.Forms.Label();
            this.lblOPositive = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblONagativeCount = new System.Windows.Forms.Label();
            this.lblONagative = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblANagativeCount = new System.Windows.Forms.Label();
            this.lblANagative = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAPositiveCount = new System.Windows.Forms.Label();
            this.lblAPositive = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBNagativeCount = new System.Windows.Forms.Label();
            this.lblBagative = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblBPositiveCount = new System.Windows.Forms.Label();
            this.lblBPositive = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblABNagativeCount = new System.Windows.Forms.Label();
            this.lblABNagative = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.lblABPositiveCount = new System.Windows.Forms.Label();
            this.lblABPositive = new System.Windows.Forms.Label();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.lblSerach = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.menuStripTop.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelOPositive.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.usersToolStripMenuItem,
            this.donorsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStripTop.Size = new System.Drawing.Size(1135, 41);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 21);
            this.toolStripMenuItem1.Text = " ";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.donorsToolStripMenuItem.Text = "Donors";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.Control;
            this.panelFooter.Controls.Add(this.label1);
            this.panelFooter.Controls.Add(this.lblDevTitle);
            this.panelFooter.Controls.Add(this.lblAppName);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 569);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1135, 41);
            this.panelFooter.TabIndex = 1;
            this.panelFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFooter_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(729, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "G A V DESHAN ";
            // 
            // lblDevTitle
            // 
            this.lblDevTitle.AutoSize = true;
            this.lblDevTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblDevTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDevTitle.Location = new System.Drawing.Point(578, 11);
            this.lblDevTitle.Name = "lblDevTitle";
            this.lblDevTitle.Size = new System.Drawing.Size(160, 30);
            this.lblDevTitle.TabIndex = 1;
            this.lblDevTitle.Text = "Developed By - ";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.Maroon;
            this.lblAppName.Location = new System.Drawing.Point(214, 11);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(318, 30);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Blood Bank Management System";
            // 
            // panelOPositive
            // 
            this.panelOPositive.BackColor = System.Drawing.SystemColors.Control;
            this.panelOPositive.Controls.Add(this.lblName);
            this.panelOPositive.Controls.Add(this.lblOPositiveCount);
            this.panelOPositive.Controls.Add(this.lblOPositive);
            this.panelOPositive.Location = new System.Drawing.Point(12, 53);
            this.panelOPositive.Name = "panelOPositive";
            this.panelOPositive.Size = new System.Drawing.Size(200, 100);
            this.panelOPositive.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(129, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Donors";
            // 
            // lblOPositiveCount
            // 
            this.lblOPositiveCount.AutoSize = true;
            this.lblOPositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPositiveCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblOPositiveCount.Location = new System.Drawing.Point(119, 3);
            this.lblOPositiveCount.Name = "lblOPositiveCount";
            this.lblOPositiveCount.Size = new System.Drawing.Size(77, 47);
            this.lblOPositiveCount.TabIndex = 4;
            this.lblOPositiveCount.Text = "100";
            // 
            // lblOPositive
            // 
            this.lblOPositive.AutoSize = true;
            this.lblOPositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPositive.ForeColor = System.Drawing.Color.Maroon;
            this.lblOPositive.Location = new System.Drawing.Point(14, 14);
            this.lblOPositive.Name = "lblOPositive";
            this.lblOPositive.Size = new System.Drawing.Size(98, 65);
            this.lblOPositive.TabIndex = 3;
            this.lblOPositive.Text = "O+";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblONagativeCount);
            this.panel2.Controls.Add(this.lblONagative);
            this.panel2.Location = new System.Drawing.Point(218, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Donors";
            // 
            // lblONagativeCount
            // 
            this.lblONagativeCount.AutoSize = true;
            this.lblONagativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblONagativeCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblONagativeCount.Location = new System.Drawing.Point(119, 3);
            this.lblONagativeCount.Name = "lblONagativeCount";
            this.lblONagativeCount.Size = new System.Drawing.Size(77, 47);
            this.lblONagativeCount.TabIndex = 4;
            this.lblONagativeCount.Text = "100";
            // 
            // lblONagative
            // 
            this.lblONagative.AutoSize = true;
            this.lblONagative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblONagative.ForeColor = System.Drawing.Color.Maroon;
            this.lblONagative.Location = new System.Drawing.Point(14, 14);
            this.lblONagative.Name = "lblONagative";
            this.lblONagative.Size = new System.Drawing.Size(83, 65);
            this.lblONagative.TabIndex = 3;
            this.lblONagative.Text = "O-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblANagativeCount);
            this.panel1.Controls.Add(this.lblANagative);
            this.panel1.Location = new System.Drawing.Point(218, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Donors";
            // 
            // lblANagativeCount
            // 
            this.lblANagativeCount.AutoSize = true;
            this.lblANagativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblANagativeCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblANagativeCount.Location = new System.Drawing.Point(119, 3);
            this.lblANagativeCount.Name = "lblANagativeCount";
            this.lblANagativeCount.Size = new System.Drawing.Size(77, 47);
            this.lblANagativeCount.TabIndex = 4;
            this.lblANagativeCount.Text = "100";
            // 
            // lblANagative
            // 
            this.lblANagative.AutoSize = true;
            this.lblANagative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblANagative.ForeColor = System.Drawing.Color.Maroon;
            this.lblANagative.Location = new System.Drawing.Point(14, 14);
            this.lblANagative.Name = "lblANagative";
            this.lblANagative.Size = new System.Drawing.Size(81, 65);
            this.lblANagative.TabIndex = 3;
            this.lblANagative.Text = "A-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblAPositiveCount);
            this.panel3.Controls.Add(this.lblAPositive);
            this.panel3.Location = new System.Drawing.Point(12, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Donors";
            // 
            // lblAPositiveCount
            // 
            this.lblAPositiveCount.AutoSize = true;
            this.lblAPositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPositiveCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblAPositiveCount.Location = new System.Drawing.Point(119, 3);
            this.lblAPositiveCount.Name = "lblAPositiveCount";
            this.lblAPositiveCount.Size = new System.Drawing.Size(77, 47);
            this.lblAPositiveCount.TabIndex = 4;
            this.lblAPositiveCount.Text = "100";
            // 
            // lblAPositive
            // 
            this.lblAPositive.AutoSize = true;
            this.lblAPositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPositive.ForeColor = System.Drawing.Color.Maroon;
            this.lblAPositive.Location = new System.Drawing.Point(14, 14);
            this.lblAPositive.Name = "lblAPositive";
            this.lblAPositive.Size = new System.Drawing.Size(96, 65);
            this.lblAPositive.TabIndex = 3;
            this.lblAPositive.Text = "A+";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.lblBNagativeCount);
            this.panel4.Controls.Add(this.lblBagative);
            this.panel4.Location = new System.Drawing.Point(218, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(129, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Donors";
            // 
            // lblBNagativeCount
            // 
            this.lblBNagativeCount.AutoSize = true;
            this.lblBNagativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBNagativeCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblBNagativeCount.Location = new System.Drawing.Point(119, 3);
            this.lblBNagativeCount.Name = "lblBNagativeCount";
            this.lblBNagativeCount.Size = new System.Drawing.Size(77, 47);
            this.lblBNagativeCount.TabIndex = 4;
            this.lblBNagativeCount.Text = "100";
            // 
            // lblBagative
            // 
            this.lblBagative.AutoSize = true;
            this.lblBagative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBagative.ForeColor = System.Drawing.Color.Maroon;
            this.lblBagative.Location = new System.Drawing.Point(14, 14);
            this.lblBagative.Name = "lblBagative";
            this.lblBagative.Size = new System.Drawing.Size(78, 65);
            this.lblBagative.TabIndex = 3;
            this.lblBagative.Text = "B-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.lblBPositiveCount);
            this.panel5.Controls.Add(this.lblBPositive);
            this.panel5.Location = new System.Drawing.Point(12, 265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(129, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "Donors";
            // 
            // lblBPositiveCount
            // 
            this.lblBPositiveCount.AutoSize = true;
            this.lblBPositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPositiveCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblBPositiveCount.Location = new System.Drawing.Point(119, 3);
            this.lblBPositiveCount.Name = "lblBPositiveCount";
            this.lblBPositiveCount.Size = new System.Drawing.Size(77, 47);
            this.lblBPositiveCount.TabIndex = 4;
            this.lblBPositiveCount.Text = "100";
            // 
            // lblBPositive
            // 
            this.lblBPositive.AutoSize = true;
            this.lblBPositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPositive.ForeColor = System.Drawing.Color.Maroon;
            this.lblBPositive.Location = new System.Drawing.Point(14, 14);
            this.lblBPositive.Name = "lblBPositive";
            this.lblBPositive.Size = new System.Drawing.Size(93, 65);
            this.lblBPositive.TabIndex = 3;
            this.lblBPositive.Text = "B+";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.lblABNagativeCount);
            this.panel6.Controls.Add(this.lblABNagative);
            this.panel6.Location = new System.Drawing.Point(218, 371);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(129, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 21);
            this.label17.TabIndex = 3;
            this.label17.Text = "Donors";
            // 
            // lblABNagativeCount
            // 
            this.lblABNagativeCount.AutoSize = true;
            this.lblABNagativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABNagativeCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblABNagativeCount.Location = new System.Drawing.Point(119, 3);
            this.lblABNagativeCount.Name = "lblABNagativeCount";
            this.lblABNagativeCount.Size = new System.Drawing.Size(77, 47);
            this.lblABNagativeCount.TabIndex = 4;
            this.lblABNagativeCount.Text = "100";
            // 
            // lblABNagative
            // 
            this.lblABNagative.AutoSize = true;
            this.lblABNagative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABNagative.ForeColor = System.Drawing.Color.Maroon;
            this.lblABNagative.Location = new System.Drawing.Point(14, 14);
            this.lblABNagative.Name = "lblABNagative";
            this.lblABNagative.Size = new System.Drawing.Size(112, 65);
            this.lblABNagative.TabIndex = 3;
            this.lblABNagative.Text = "AB-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.lblABPositiveCount);
            this.panel7.Controls.Add(this.lblABPositive);
            this.panel7.Location = new System.Drawing.Point(12, 371);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(129, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 21);
            this.label20.TabIndex = 3;
            this.label20.Text = "Donors";
            // 
            // lblABPositiveCount
            // 
            this.lblABPositiveCount.AutoSize = true;
            this.lblABPositiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABPositiveCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblABPositiveCount.Location = new System.Drawing.Point(119, 3);
            this.lblABPositiveCount.Name = "lblABPositiveCount";
            this.lblABPositiveCount.Size = new System.Drawing.Size(77, 47);
            this.lblABPositiveCount.TabIndex = 4;
            this.lblABPositiveCount.Text = "100";
            // 
            // lblABPositive
            // 
            this.lblABPositive.AutoSize = true;
            this.lblABPositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABPositive.ForeColor = System.Drawing.Color.Maroon;
            this.lblABPositive.Location = new System.Drawing.Point(14, 14);
            this.lblABPositive.Name = "lblABPositive";
            this.lblABPositive.Size = new System.Drawing.Size(127, 65);
            this.lblABPositive.TabIndex = 3;
            this.lblABPositive.Text = "AB+";
            // 
            // dgvDonors
            // 
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(485, 119);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.Size = new System.Drawing.Size(638, 352);
            this.dgvDonors.TabIndex = 9;
            // 
            // lblSerach
            // 
            this.lblSerach.AutoSize = true;
            this.lblSerach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerach.Location = new System.Drawing.Point(533, 83);
            this.lblSerach.Name = "lblSerach";
            this.lblSerach.Size = new System.Drawing.Size(105, 21);
            this.lblSerach.TabIndex = 10;
            this.lblSerach.Text = "Search Donor";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(644, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(479, 29);
            this.txtSearch.TabIndex = 11;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1093, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(42, 41);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 12;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1135, 610);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSerach);
            this.Controls.Add(this.dgvDonors);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelOPositive);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelOPositive.ResumeLayout(false);
            this.panelOPositive.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDevTitle;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel panelOPositive;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOPositiveCount;
        private System.Windows.Forms.Label lblOPositive;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblONagativeCount;
        private System.Windows.Forms.Label lblONagative;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblANagativeCount;
        private System.Windows.Forms.Label lblANagative;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAPositiveCount;
        private System.Windows.Forms.Label lblAPositive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBNagativeCount;
        private System.Windows.Forms.Label lblBagative;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblBPositiveCount;
        private System.Windows.Forms.Label lblBPositive;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblABNagativeCount;
        private System.Windows.Forms.Label lblABNagative;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblABPositiveCount;
        private System.Windows.Forms.Label lblABPositive;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Label lblSerach;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}

