namespace Ranak_Pinak
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EncBut = new System.Windows.Forms.Button();
			this.DecrBut = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.aboutAppToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(392, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem});
			this.runToolStripMenuItem.Image = global::Ranak_Pinak.Properties.Resources.Apps_Run;
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.runToolStripMenuItem.Text = "Run";
			// 
			// aboutAppToolStripMenuItem
			// 
			this.aboutAppToolStripMenuItem.Image = global::Ranak_Pinak.Properties.Resources.about_app;
			this.aboutAppToolStripMenuItem.Name = "aboutAppToolStripMenuItem";
			this.aboutAppToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
			this.aboutAppToolStripMenuItem.Text = "About App";
			this.aboutAppToolStripMenuItem.Click += new System.EventHandler(this.aboutAppToolStripMenuItem_Click);
			// 
			// encryptToolStripMenuItem
			// 
			this.encryptToolStripMenuItem.Image = global::Ranak_Pinak.Properties.Resources.lock_file;
			this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
			this.encryptToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.encryptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.encryptToolStripMenuItem.Text = "Encrypt";
			this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
			// 
			// decryptToolStripMenuItem
			// 
			this.decryptToolStripMenuItem.Image = global::Ranak_Pinak.Properties.Resources.unlock_file;
			this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
			this.decryptToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.decryptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.decryptToolStripMenuItem.Text = "Decrypt";
			this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
			// 
			// EncBut
			// 
			this.EncBut.BackColor = System.Drawing.Color.Transparent;
			this.EncBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EncBut.Image = global::Ranak_Pinak.Properties.Resources.lock_file;
			this.EncBut.Location = new System.Drawing.Point(13, 38);
			this.EncBut.Name = "EncBut";
			this.EncBut.Size = new System.Drawing.Size(69, 81);
			this.EncBut.TabIndex = 1;
			this.EncBut.UseVisualStyleBackColor = false;
			this.EncBut.Click += new System.EventHandler(this.EncBut_Click);
			// 
			// DecrBut
			// 
			this.DecrBut.BackColor = System.Drawing.Color.Transparent;
			this.DecrBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DecrBut.Image = global::Ranak_Pinak.Properties.Resources.unlock_file;
			this.DecrBut.Location = new System.Drawing.Point(12, 143);
			this.DecrBut.Name = "DecrBut";
			this.DecrBut.Size = new System.Drawing.Size(69, 81);
			this.DecrBut.TabIndex = 2;
			this.DecrBut.UseVisualStyleBackColor = false;
			this.DecrBut.Click += new System.EventHandler(this.DecrBut_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(111, 38);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(257, 186);
			this.textBox1.TabIndex = 3;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 230);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.DecrBut);
			this.Controls.Add(this.EncBut);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Ranak Pinak";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutAppToolStripMenuItem;
		private System.Windows.Forms.Button EncBut;
		private System.Windows.Forms.Button DecrBut;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

