namespace MinimumSpanningTree
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.EdgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.algorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.GraphToolStripMenuItem,
            this.EdgeToolStripMenuItem,
            this.algorithmToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(123, 624);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.closeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 20, 20, 50);
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(101, 89);
			this.closeToolStripMenuItem.Text = "Cancel";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// GraphToolStripMenuItem
			// 
			this.GraphToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.GraphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designToolStripMenuItem,
            this.resetToolStripMenuItem1});
			this.GraphToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
			this.GraphToolStripMenuItem.Name = "GraphToolStripMenuItem";
			this.GraphToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 20, 20, 50);
			this.GraphToolStripMenuItem.Size = new System.Drawing.Size(101, 89);
			this.GraphToolStripMenuItem.Text = "GRAPH";
			this.GraphToolStripMenuItem.Click += new System.EventHandler(this.GraphToolStripMenuItem_Click);
			// 
			// designToolStripMenuItem
			// 
			this.designToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.designToolStripMenuItem.Name = "designToolStripMenuItem";
			this.designToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.designToolStripMenuItem.Text = "Design";
			this.designToolStripMenuItem.Click += new System.EventHandler(this.designToolStripMenuItem_Click);
			// 
			// resetToolStripMenuItem1
			// 
			this.resetToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
			this.resetToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
			this.resetToolStripMenuItem1.Text = "Reset";
			this.resetToolStripMenuItem1.Click += new System.EventHandler(this.resetToolStripMenuItem1_Click);
			// 
			// EdgeToolStripMenuItem
			// 
			this.EdgeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.EdgeToolStripMenuItem.Name = "EdgeToolStripMenuItem";
			this.EdgeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 20, 20, 50);
			this.EdgeToolStripMenuItem.Size = new System.Drawing.Size(101, 89);
			this.EdgeToolStripMenuItem.Text = "EDGE";
			this.EdgeToolStripMenuItem.Click += new System.EventHandler(this.EdgesToolStripMenuItem_Click);
			// 
			// algorithmToolStripMenuItem
			// 
			this.algorithmToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
			this.algorithmToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 20, 20, 50);
			this.algorithmToolStripMenuItem.Size = new System.Drawing.Size(101, 89);
			this.algorithmToolStripMenuItem.Text = "Algorithm";
			this.algorithmToolStripMenuItem.Click += new System.EventHandler(this.algorithmToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(123, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(648, 624);
			this.panel1.TabIndex = 1;
			this.panel1.Click += new System.EventHandler(this.panel1_Click);
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(771, 624);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Minimun Spanning Tree";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EdgeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem algorithmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem GraphToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
	}
}

