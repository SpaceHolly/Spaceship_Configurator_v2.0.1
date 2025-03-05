using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ShipCalculatorUpdate
{
	public class DescAndCostWindow : Form
	{
		private IContainer components;

		private TabPage tabPage3;

		private RichTextBox richTextBox3;

		private TabPage tabPage2;

		private RichTextBox richTextBox2;

		private TabControl tabControl1;

		public DescAndCostWindow()
		{
			InitializeComponent();
		}

		private void DescAndCostWindow_Load(object sender, EventArgs e)
		{
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipCalculatorUpdate.DescAndCostWindow));
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage3.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			base.SuspendLayout();
			this.tabPage3.AutoScroll = true;
			this.tabPage3.Controls.Add(this.richTextBox3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(557, 430);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Вооружение";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox3.Location = new System.Drawing.Point(3, 3);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.ReadOnly = true;
			this.richTextBox3.Size = new System.Drawing.Size(551, 424);
			this.richTextBox3.TabIndex = 0;
			this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
			this.tabPage2.AutoScroll = true;
			this.tabPage2.Controls.Add(this.richTextBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(557, 430);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Ячейки";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox2.Location = new System.Drawing.Point(3, 3);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ReadOnly = true;
			this.richTextBox2.Size = new System.Drawing.Size(551, 424);
			this.richTextBox2.TabIndex = 0;
			this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
			this.richTextBox2.TextChanged += new System.EventHandler(richTextBox2_TextChanged);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(565, 456);
			this.tabControl1.TabIndex = 0;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(565, 456);
			base.Controls.Add(this.tabControl1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "DescAndCostWindow";
			this.Text = "Описание модулей";
			base.Load += new System.EventHandler(DescAndCostWindow_Load);
			this.tabPage3.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			base.ResumeLayout(false);
		}
	}
}
