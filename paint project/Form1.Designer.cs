namespace paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plus_eraser_btn = new System.Windows.Forms.Button();
            this.minus_eraser_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.minus_button = new System.Windows.Forms.Button();
            this.plus_btn = new System.Windows.Forms.Button();
            this.rec_btn = new System.Windows.Forms.Button();
            this.line_btn = new System.Windows.Forms.Button();
            this.fill_btn = new System.Windows.Forms.Button();
            this.circle_btn = new System.Windows.Forms.Button();
            this.eraser_btn = new System.Windows.Forms.Button();
            this.pencil_btn = new System.Windows.Forms.Button();
            this.color_btn = new System.Windows.Forms.Button();
            this.pick_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.plus_eraser_btn);
            this.panel1.Controls.Add(this.minus_eraser_btn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.minus_button);
            this.panel1.Controls.Add(this.plus_btn);
            this.panel1.Controls.Add(this.rec_btn);
            this.panel1.Controls.Add(this.line_btn);
            this.panel1.Controls.Add(this.fill_btn);
            this.panel1.Controls.Add(this.circle_btn);
            this.panel1.Controls.Add(this.eraser_btn);
            this.panel1.Controls.Add(this.pencil_btn);
            this.panel1.Controls.Add(this.color_btn);
            this.panel1.Controls.Add(this.pick_color);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 90);
            this.panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(564, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(77, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Edit eraser size";
            // 
            // plus_eraser_btn
            // 
            this.plus_eraser_btn.Location = new System.Drawing.Point(647, 51);
            this.plus_eraser_btn.Name = "plus_eraser_btn";
            this.plus_eraser_btn.Size = new System.Drawing.Size(18, 19);
            this.plus_eraser_btn.TabIndex = 10;
            this.plus_eraser_btn.Text = "+";
            this.plus_eraser_btn.UseVisualStyleBackColor = true;
            this.plus_eraser_btn.Click += new System.EventHandler(this.plus_eraser_btn_Click);
            // 
            // minus_eraser_btn
            // 
            this.minus_eraser_btn.Location = new System.Drawing.Point(540, 51);
            this.minus_eraser_btn.Name = "minus_eraser_btn";
            this.minus_eraser_btn.Size = new System.Drawing.Size(18, 19);
            this.minus_eraser_btn.TabIndex = 9;
            this.minus_eraser_btn.Text = "-";
            this.minus_eraser_btn.UseVisualStyleBackColor = true;
            this.minus_eraser_btn.Click += new System.EventHandler(this.minus_eraser_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(564, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Edit line size";
            // 
            // minus_button
            // 
            this.minus_button.Location = new System.Drawing.Point(540, 14);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(18, 19);
            this.minus_button.TabIndex = 8;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = true;
            this.minus_button.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // plus_btn
            // 
            this.plus_btn.Location = new System.Drawing.Point(647, 15);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(18, 19);
            this.plus_btn.TabIndex = 2;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = true;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // rec_btn
            // 
            this.rec_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rec_btn.Image = global::paint.Properties.Resources.rec3;
            this.rec_btn.Location = new System.Drawing.Point(457, 12);
            this.rec_btn.Name = "rec_btn";
            this.rec_btn.Size = new System.Drawing.Size(61, 56);
            this.rec_btn.TabIndex = 4;
            this.rec_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rec_btn.UseVisualStyleBackColor = true;
            this.rec_btn.Click += new System.EventHandler(this.rec_btn_Click);
            // 
            // line_btn
            // 
            this.line_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.line_btn.Image = global::paint.Properties.Resources.line;
            this.line_btn.Location = new System.Drawing.Point(323, 12);
            this.line_btn.Name = "line_btn";
            this.line_btn.Size = new System.Drawing.Size(61, 56);
            this.line_btn.TabIndex = 6;
            this.line_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.line_btn.UseVisualStyleBackColor = true;
            this.line_btn.Click += new System.EventHandler(this.line_btn_Click);
            // 
            // fill_btn
            // 
            this.fill_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fill_btn.Image = global::paint.Properties.Resources.fill2;
            this.fill_btn.Location = new System.Drawing.Point(189, 12);
            this.fill_btn.Name = "fill_btn";
            this.fill_btn.Size = new System.Drawing.Size(61, 56);
            this.fill_btn.TabIndex = 4;
            this.fill_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fill_btn.UseVisualStyleBackColor = true;
            this.fill_btn.Click += new System.EventHandler(this.fill_btn_Click);
            // 
            // circle_btn
            // 
            this.circle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circle_btn.Image = global::paint.Properties.Resources.circle;
            this.circle_btn.Location = new System.Drawing.Point(390, 12);
            this.circle_btn.Name = "circle_btn";
            this.circle_btn.Size = new System.Drawing.Size(61, 56);
            this.circle_btn.TabIndex = 5;
            this.circle_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.circle_btn.UseVisualStyleBackColor = true;
            this.circle_btn.Click += new System.EventHandler(this.circle_btn_Click);
            // 
            // eraser_btn
            // 
            this.eraser_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraser_btn.Image = global::paint.Properties.Resources.eraser;
            this.eraser_btn.Location = new System.Drawing.Point(256, 12);
            this.eraser_btn.Name = "eraser_btn";
            this.eraser_btn.Size = new System.Drawing.Size(61, 56);
            this.eraser_btn.TabIndex = 4;
            this.eraser_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eraser_btn.UseVisualStyleBackColor = true;
            this.eraser_btn.Click += new System.EventHandler(this.eraser_btn_Click);
            // 
            // pencil_btn
            // 
            this.pencil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pencil_btn.Image = global::paint.Properties.Resources.R;
            this.pencil_btn.Location = new System.Drawing.Point(122, 12);
            this.pencil_btn.Name = "pencil_btn";
            this.pencil_btn.Size = new System.Drawing.Size(61, 56);
            this.pencil_btn.TabIndex = 4;
            this.pencil_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pencil_btn.UseVisualStyleBackColor = true;
            this.pencil_btn.Click += new System.EventHandler(this.pencil_btn_Click);
            // 
            // color_btn
            // 
            this.color_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_btn.Image = global::paint.Properties.Resources.colors2;
            this.color_btn.Location = new System.Drawing.Point(55, 12);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(61, 56);
            this.color_btn.TabIndex = 3;
            this.color_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // pick_color
            // 
            this.pick_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pick_color.Location = new System.Drawing.Point(23, 29);
            this.pick_color.Name = "pick_color";
            this.pick_color.Size = new System.Drawing.Size(26, 24);
            this.pick_color.TabIndex = 2;
            this.pick_color.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 47);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 114);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(985, 289);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button pick_color;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Button rec_btn;
        private System.Windows.Forms.Button line_btn;
        private System.Windows.Forms.Button fill_btn;
        private System.Windows.Forms.Button circle_btn;
        private System.Windows.Forms.Button eraser_btn;
        private System.Windows.Forms.Button pencil_btn;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button plus_eraser_btn;
        private System.Windows.Forms.Button minus_eraser_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

