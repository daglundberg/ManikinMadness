﻿
namespace ManikinMadness.SetCreator
{
	partial class ProjectControl
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
			this.components = new System.ComponentModel.Container();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.addAudioFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnNext = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(3, 36);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(171, 184);
			this.listBox1.TabIndex = 2;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAudioFileToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
			this.toolStripMenuItem1.Text = "Project";
			// 
			// addAudioFileToolStripMenuItem
			// 
			this.addAudioFileToolStripMenuItem.Name = "addAudioFileToolStripMenuItem";
			this.addAudioFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.addAudioFileToolStripMenuItem.Text = "Add Audio File...";
			this.addAudioFileToolStripMenuItem.Click += new System.EventHandler(this.addAudioFileToolStripMenuItem_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(198, 205);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(136, 32);
			this.btnNext.TabIndex = 3;
			this.btnNext.Text = "Next...";
			this.btnNext.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 243);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(678, 151);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// ProjectControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.listBox1);
			this.Name = "ProjectControl";
			this.Size = new System.Drawing.Size(681, 397);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem addAudioFileToolStripMenuItem;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}