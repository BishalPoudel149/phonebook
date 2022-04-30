
namespace PhonebookApp
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
this.lbFName = new System.Windows.Forms.ListBox();
this.lbLName = new System.Windows.Forms.ListBox();
this.LbNumber = new System.Windows.Forms.ListBox();
this.label1 = new System.Windows.Forms.Label();
this.tbFName = new System.Windows.Forms.TextBox();
this.tbLName = new System.Windows.Forms.TextBox();
this.label2 = new System.Windows.Forms.Label();
this.tbNumber = new System.Windows.Forms.TextBox();
this.label3 = new System.Windows.Forms.Label();
this.btnSave = new System.Windows.Forms.Button();
this.btnDelete = new System.Windows.Forms.Button();
this.btnClear = new System.Windows.Forms.Button();
this.menuStrip1 = new System.Windows.Forms.MenuStrip();
this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
this.rbFName = new System.Windows.Forms.RadioButton();
this.rbLName = new System.Windows.Forms.RadioButton();
this.rbNumber = new System.Windows.Forms.RadioButton();
this.tbSearch = new System.Windows.Forms.TextBox();
this.label4 = new System.Windows.Forms.Label();
this.lblStatus = new System.Windows.Forms.Label();
this.label5 = new System.Windows.Forms.Label();
this.label6 = new System.Windows.Forms.Label();
this.label7 = new System.Windows.Forms.Label();
this.panel1 = new System.Windows.Forms.Panel();
this.panel2 = new System.Windows.Forms.Panel();
this.label8 = new System.Windows.Forms.Label();
this.menuStrip1.SuspendLayout();
this.panel1.SuspendLayout();
this.panel2.SuspendLayout();
this.SuspendLayout();
// 
// lbFName
// 
this.lbFName.DisplayMember = "FirstName";
this.lbFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lbFName.FormattingEnabled = true;
this.lbFName.ItemHeight = 22;
this.lbFName.Location = new System.Drawing.Point(33, 312);
this.lbFName.Margin = new System.Windows.Forms.Padding(4);
this.lbFName.Name = "lbFName";
this.lbFName.Size = new System.Drawing.Size(277, 312);
this.lbFName.TabIndex = 0;
this.lbFName.ValueMember = "FirstName";
// 
// lbLName
// 
this.lbLName.DisplayMember = "LastName";
this.lbLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lbLName.FormattingEnabled = true;
this.lbLName.ItemHeight = 22;
this.lbLName.Location = new System.Drawing.Point(336, 312);
this.lbLName.Margin = new System.Windows.Forms.Padding(4);
this.lbLName.Name = "lbLName";
this.lbLName.Size = new System.Drawing.Size(277, 312);
this.lbLName.TabIndex = 1;
this.lbLName.ValueMember = "LastName";
// 
// LbNumber
// 
this.LbNumber.DisplayMember = "Number";
this.LbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.LbNumber.FormattingEnabled = true;
this.LbNumber.ItemHeight = 22;
this.LbNumber.Location = new System.Drawing.Point(637, 312);
this.LbNumber.Margin = new System.Windows.Forms.Padding(4);
this.LbNumber.Name = "LbNumber";
this.LbNumber.Size = new System.Drawing.Size(277, 312);
this.LbNumber.TabIndex = 2;
this.LbNumber.ValueMember = "Number";
// 
// label1
// 
this.label1.AutoSize = true;
this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label1.Location = new System.Drawing.Point(15, 16);
this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.label1.Name = "label1";
this.label1.Size = new System.Drawing.Size(112, 25);
this.label1.TabIndex = 3;
this.label1.Text = "First Name:";
// 
// tbFName
// 
this.tbFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.tbFName.Location = new System.Drawing.Point(135, 16);
this.tbFName.Margin = new System.Windows.Forms.Padding(4);
this.tbFName.Name = "tbFName";
this.tbFName.Size = new System.Drawing.Size(228, 30);
this.tbFName.TabIndex = 4;
// 
// tbLName
// 
this.tbLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.tbLName.Location = new System.Drawing.Point(535, 19);
this.tbLName.Margin = new System.Windows.Forms.Padding(4);
this.tbLName.Name = "tbLName";
this.tbLName.Size = new System.Drawing.Size(228, 30);
this.tbLName.TabIndex = 6;
// 
// label2
// 
this.label2.AutoSize = true;
this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label2.Location = new System.Drawing.Point(415, 19);
this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.label2.Name = "label2";
this.label2.Size = new System.Drawing.Size(112, 25);
this.label2.TabIndex = 5;
this.label2.Text = "Last Name:";
// 
// tbNumber
// 
this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.tbNumber.Location = new System.Drawing.Point(923, 19);
this.tbNumber.Margin = new System.Windows.Forms.Padding(4);
this.tbNumber.MaxLength = 11;
this.tbNumber.Name = "tbNumber";
this.tbNumber.Size = new System.Drawing.Size(235, 30);
this.tbNumber.TabIndex = 8;
// 
// label3
// 
this.label3.AutoSize = true;
this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label3.Location = new System.Drawing.Point(814, 19);
this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.label3.Name = "label3";
this.label3.Size = new System.Drawing.Size(87, 25);
this.label3.TabIndex = 7;
this.label3.Text = "Number:";
// 
// btnSave
// 
this.btnSave.BackColor = System.Drawing.Color.Lime;
this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.btnSave.Location = new System.Drawing.Point(588, 93);
this.btnSave.Margin = new System.Windows.Forms.Padding(4);
this.btnSave.Name = "btnSave";
this.btnSave.Size = new System.Drawing.Size(133, 40);
this.btnSave.TabIndex = 9;
this.btnSave.Text = "Insert";
this.btnSave.UseVisualStyleBackColor = false;
this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
// 
// btnDelete
// 
this.btnDelete.Enabled = false;
this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.btnDelete.ForeColor = System.Drawing.Color.Red;
this.btnDelete.Location = new System.Drawing.Point(936, 432);
this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
this.btnDelete.Name = "btnDelete";
this.btnDelete.Size = new System.Drawing.Size(197, 38);
this.btnDelete.TabIndex = 10;
this.btnDelete.Text = "Delete";
this.btnDelete.UseVisualStyleBackColor = true;
this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
// 
// btnClear
// 
this.btnClear.Enabled = false;
this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.btnClear.Location = new System.Drawing.Point(936, 516);
this.btnClear.Margin = new System.Windows.Forms.Padding(4);
this.btnClear.Name = "btnClear";
this.btnClear.Size = new System.Drawing.Size(197, 38);
this.btnClear.TabIndex = 11;
this.btnClear.Text = "Clear";
this.btnClear.UseVisualStyleBackColor = true;
this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
// 
// menuStrip1
// 
this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
this.fileToolStripMenuItem,
this.exitToolStripMenuItem});
this.menuStrip1.Location = new System.Drawing.Point(0, 0);
this.menuStrip1.Name = "menuStrip1";
this.menuStrip1.Size = new System.Drawing.Size(1206, 30);
this.menuStrip1.TabIndex = 12;
this.menuStrip1.Text = "menuStrip1";
// 
// fileToolStripMenuItem
// 
this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
this.loadToolStripMenuItem,
this.saveToolStripMenuItem});
this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
this.fileToolStripMenuItem.Text = "File";
// 
// loadToolStripMenuItem
// 
this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
this.loadToolStripMenuItem.Text = "Load";
this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
// 
// saveToolStripMenuItem
// 
this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
this.saveToolStripMenuItem.Text = "Save";
this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
// 
// exitToolStripMenuItem
// 
this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
this.exitToolStripMenuItem1});
this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
this.exitToolStripMenuItem.Text = "Exit";
// 
// exitToolStripMenuItem1
// 
this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
this.exitToolStripMenuItem1.Size = new System.Drawing.Size(116, 26);
this.exitToolStripMenuItem1.Text = "Exit";
this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
// 
// rbFName
// 
this.rbFName.AutoSize = true;
this.rbFName.Location = new System.Drawing.Point(43, 207);
this.rbFName.Margin = new System.Windows.Forms.Padding(4);
this.rbFName.Name = "rbFName";
this.rbFName.Size = new System.Drawing.Size(97, 21);
this.rbFName.TabIndex = 13;
this.rbFName.TabStop = true;
this.rbFName.Text = "First Name";
this.rbFName.UseVisualStyleBackColor = true;
// 
// rbLName
// 
this.rbLName.AutoSize = true;
this.rbLName.Location = new System.Drawing.Point(171, 207);
this.rbLName.Margin = new System.Windows.Forms.Padding(4);
this.rbLName.Name = "rbLName";
this.rbLName.Size = new System.Drawing.Size(97, 21);
this.rbLName.TabIndex = 14;
this.rbLName.TabStop = true;
this.rbLName.Text = "Last Name";
this.rbLName.UseVisualStyleBackColor = true;
// 
// rbNumber
// 
this.rbNumber.AutoSize = true;
this.rbNumber.Location = new System.Drawing.Point(313, 207);
this.rbNumber.Margin = new System.Windows.Forms.Padding(4);
this.rbNumber.Name = "rbNumber";
this.rbNumber.Size = new System.Drawing.Size(79, 21);
this.rbNumber.TabIndex = 15;
this.rbNumber.TabStop = true;
this.rbNumber.Text = "Number";
this.rbNumber.UseVisualStyleBackColor = true;
// 
// tbSearch
// 
this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.tbSearch.Location = new System.Drawing.Point(491, 15);
this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
this.tbSearch.MaxLength = 11;
this.tbSearch.Name = "tbSearch";
this.tbSearch.Size = new System.Drawing.Size(477, 30);
this.tbSearch.TabIndex = 16;
this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
// 
// label4
// 
this.label4.AutoSize = true;
this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label4.ForeColor = System.Drawing.Color.Chocolate;
this.label4.Location = new System.Drawing.Point(943, 303);
this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.label4.Name = "label4";
this.label4.Size = new System.Drawing.Size(162, 25);
this.label4.TabIndex = 17;
this.label4.Text = "Contacts Count";
// 
// lblStatus
// 
this.lblStatus.AutoSize = true;
this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lblStatus.ForeColor = System.Drawing.Color.DodgerBlue;
this.lblStatus.Location = new System.Drawing.Point(1004, 342);
this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.lblStatus.Name = "lblStatus";
this.lblStatus.Size = new System.Drawing.Size(40, 42);
this.lblStatus.TabIndex = 18;
this.lblStatus.Text = "0";
// 
// label5
// 
this.label5.AutoSize = true;
this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label5.Location = new System.Drawing.Point(87, 288);
this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.label5.Name = "label5";
this.label5.Size = new System.Drawing.Size(97, 20);
this.label5.TabIndex = 19;
this.label5.Text = "First Name:";
// 
// label6
// 
this.label6.AutoSize = true;
this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label6.Location = new System.Drawing.Point(419, 288);
this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.label6.Name = "label6";
this.label6.Size = new System.Drawing.Size(91, 20);
this.label6.TabIndex = 20;
this.label6.Text = "Last Name";
// 
// label7
// 
this.label7.AutoSize = true;
this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label7.Location = new System.Drawing.Point(702, 288);
this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.label7.Name = "label7";
this.label7.Size = new System.Drawing.Size(120, 20);
this.label7.TabIndex = 21;
this.label7.Text = "Phone Number";
// 
// panel1
// 
this.panel1.Controls.Add(this.label1);
this.panel1.Controls.Add(this.tbFName);
this.panel1.Controls.Add(this.label2);
this.panel1.Controls.Add(this.tbLName);
this.panel1.Controls.Add(this.label3);
this.panel1.Controls.Add(this.tbNumber);
this.panel1.Location = new System.Drawing.Point(13, 32);
this.panel1.Name = "panel1";
this.panel1.Size = new System.Drawing.Size(1167, 111);
this.panel1.TabIndex = 22;
// 
// panel2
// 
this.panel2.Controls.Add(this.tbSearch);
this.panel2.Location = new System.Drawing.Point(13, 184);
this.panel2.Name = "panel2";
this.panel2.Size = new System.Drawing.Size(1167, 71);
this.panel2.TabIndex = 23;
// 
// label8
// 
this.label8.AutoSize = true;
this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label8.Location = new System.Drawing.Point(28, 171);
this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.label8.Name = "label8";
this.label8.Size = new System.Drawing.Size(112, 24);
this.label8.TabIndex = 24;
this.label8.Text = "Search By-";
// 
// Form1
// 
this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
this.ClientSize = new System.Drawing.Size(1206, 641);
this.Controls.Add(this.label8);
this.Controls.Add(this.label7);
this.Controls.Add(this.label6);
this.Controls.Add(this.label5);
this.Controls.Add(this.lblStatus);
this.Controls.Add(this.label4);
this.Controls.Add(this.rbNumber);
this.Controls.Add(this.rbLName);
this.Controls.Add(this.rbFName);
this.Controls.Add(this.btnClear);
this.Controls.Add(this.btnDelete);
this.Controls.Add(this.btnSave);
this.Controls.Add(this.LbNumber);
this.Controls.Add(this.lbLName);
this.Controls.Add(this.lbFName);
this.Controls.Add(this.menuStrip1);
this.Controls.Add(this.panel1);
this.Controls.Add(this.panel2);
this.MainMenuStrip = this.menuStrip1;
this.Margin = new System.Windows.Forms.Padding(4);
this.MaximizeBox = false;
this.Name = "Form1";
this.Text = "30013014";
this.Load += new System.EventHandler(this.Form1_Load);
this.menuStrip1.ResumeLayout(false);
this.menuStrip1.PerformLayout();
this.panel1.ResumeLayout(false);
this.panel1.PerformLayout();
this.panel2.ResumeLayout(false);
this.panel2.PerformLayout();
this.ResumeLayout(false);
this.PerformLayout();

  }

#endregion

private System.Windows.Forms.ListBox lbFName;
private System.Windows.Forms.ListBox lbLName;
private System.Windows.Forms.ListBox LbNumber;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.TextBox tbFName;
private System.Windows.Forms.TextBox tbLName;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.TextBox tbNumber;
private System.Windows.Forms.Label label3;
private System.Windows.Forms.Button btnSave;
private System.Windows.Forms.Button btnDelete;
private System.Windows.Forms.Button btnClear;
private System.Windows.Forms.MenuStrip menuStrip1;
private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
private System.Windows.Forms.RadioButton rbFName;
private System.Windows.Forms.RadioButton rbLName;
private System.Windows.Forms.RadioButton rbNumber;
private System.Windows.Forms.TextBox tbSearch;
private System.Windows.Forms.Label label4;
private System.Windows.Forms.Label lblStatus;
private System.Windows.Forms.Label label5;
private System.Windows.Forms.Label label6;
private System.Windows.Forms.Label label7;
private System.Windows.Forms.Panel panel1;
private System.Windows.Forms.Panel panel2;
private System.Windows.Forms.Label label8;
 }
}

