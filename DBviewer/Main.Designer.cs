
namespace DBviewer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newTSButton = new System.Windows.Forms.ToolStripButton();
            this.loadTSButton = new System.Windows.Forms.ToolStripButton();
            this.saveTSButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.selectButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.commandTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.exeButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView = new System.Windows.Forms.TreeView();
            this.invButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.aboutTSButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSButton,
            this.loadTSButton,
            this.saveTSButton,
            this.toolStripSeparator1,
            this.aboutTSButton,
            this.toolStripLabel1,
            this.selectTextBox,
            this.selectButton,
            this.toolStripSeparator2,
            this.commandTextBox,
            this.exeButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(916, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newTSButton
            // 
            this.newTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTSButton.Image = ((System.Drawing.Image)(resources.GetObject("newTSButton.Image")));
            this.newTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTSButton.Name = "newTSButton";
            this.newTSButton.Size = new System.Drawing.Size(23, 22);
            this.newTSButton.Text = "New connection";
            this.newTSButton.Click += new System.EventHandler(this.newTSButton_Click);
            // 
            // loadTSButton
            // 
            this.loadTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadTSButton.Image = ((System.Drawing.Image)(resources.GetObject("loadTSButton.Image")));
            this.loadTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadTSButton.Name = "loadTSButton";
            this.loadTSButton.Size = new System.Drawing.Size(23, 22);
            this.loadTSButton.Text = "Load";
            this.loadTSButton.Click += new System.EventHandler(this.loadTSButton_Click);
            // 
            // saveTSButton
            // 
            this.saveTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveTSButton.Image = ((System.Drawing.Image)(resources.GetObject("saveTSButton.Image")));
            this.saveTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTSButton.Name = "saveTSButton";
            this.saveTSButton.Size = new System.Drawing.Size(23, 22);
            this.saveTSButton.Text = "Save";
            this.saveTSButton.Click += new System.EventHandler(this.saveTSButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // selectTextBox
            // 
            this.selectTextBox.AutoSize = false;
            this.selectTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.selectTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectTextBox.Name = "selectTextBox";
            this.selectTextBox.Size = new System.Drawing.Size(200, 25);
            this.selectTextBox.ToolTipText = "SELECT * FROM [TABLE NAME]\r\nOnly enter table name!";
            // 
            // selectButton
            // 
            this.selectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectButton.Image = ((System.Drawing.Image)(resources.GetObject("selectButton.Image")));
            this.selectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(42, 22);
            this.selectButton.Text = "Select";
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // commandTextBox
            // 
            this.commandTextBox.AutoSize = false;
            this.commandTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(350, 25);
            this.commandTextBox.ToolTipText = "You can execute any SQL commands directly. You need type full command.";
            // 
            // exeButton
            // 
            this.exeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exeButton.Image = ((System.Drawing.Image)(resources.GetObject("exeButton.Image")));
            this.exeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exeButton.Name = "exeButton";
            this.exeButton.Size = new System.Drawing.Size(52, 22);
            this.exeButton.Text = "Execute";
            this.exeButton.Click += new System.EventHandler(this.exeButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 412);
            this.dataGridView1.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 28);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(210, 144);
            this.treeView.TabIndex = 2;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // invButton
            // 
            this.invButton.Location = new System.Drawing.Point(12, 178);
            this.invButton.Name = "invButton";
            this.invButton.Size = new System.Drawing.Size(210, 23);
            this.invButton.TabIndex = 4;
            this.invButton.Text = "Inventory stock";
            this.invButton.UseVisualStyleBackColor = true;
            this.invButton.Click += new System.EventHandler(this.invButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.okButton);
            this.groupBox.Controls.Add(this.textBox3);
            this.groupBox.Controls.Add(this.textBox2);
            this.groupBox.Controls.Add(this.textBox1);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(12, 207);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(210, 118);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Query";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(58, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(164, 81);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(40, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // aboutTSButton
            // 
            this.aboutTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutTSButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutTSButton.Image")));
            this.aboutTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutTSButton.Name = "aboutTSButton";
            this.aboutTSButton.Size = new System.Drawing.Size(23, 22);
            this.aboutTSButton.Text = "About";
            this.aboutTSButton.ToolTipText = "About DBviewer ...";
            this.aboutTSButton.Click += new System.EventHandler(this.aboutTSButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(121, 22);
            this.toolStripLabel1.Text = "                                      ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(916, 452);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.invButton);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "DataBase viewer tool";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton loadTSButton;
        private System.Windows.Forms.ToolStripButton saveTSButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox selectTextBox;
        private System.Windows.Forms.ToolStripButton selectButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton newTSButton;
        private System.Windows.Forms.ToolStripTextBox commandTextBox;
        private System.Windows.Forms.ToolStripButton exeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button invButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ToolStripButton aboutTSButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

