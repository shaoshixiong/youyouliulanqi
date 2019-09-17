namespace USbrowser
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {

            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlNavtion = new System.Windows.Forms.Panel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.pnlMenuList = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnlContext = new System.Windows.Forms.Panel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pnlAddTag = new System.Windows.Forms.Panel();
            this.pnlURLSafe = new System.Windows.Forms.Panel();
            this.pnlForward = new System.Windows.Forms.Panel();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlNavtion.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlMenuList.SuspendLayout();
            this.pnlContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "close-blue.png");
            this.imageList1.Images.SetKeyName(2, "max.png");
            this.imageList1.Images.SetKeyName(3, "max-blue.png");
            this.imageList1.Images.SetKeyName(4, "min.png");
            this.imageList1.Images.SetKeyName(5, "mix-blue.png");
            this.imageList1.Images.SetKeyName(6, "close-tag.png");
            this.imageList1.Images.SetKeyName(7, "close-tag-select.png");
            this.imageList1.Images.SetKeyName(8, "tagImage.png");
            // 
            // pnlNavtion
            // 
            this.pnlNavtion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.pnlNavtion.Controls.Add(this.pnlLine);
            this.pnlNavtion.Controls.Add(this.pnlAddTag);
            this.pnlNavtion.Controls.Add(this.panel5);
            this.pnlNavtion.Controls.Add(this.pnlForward);
            this.pnlNavtion.Controls.Add(this.pnlBack);
            this.pnlNavtion.Controls.Add(this.btnMin);
            this.pnlNavtion.Controls.Add(this.btnMax);
            this.pnlNavtion.Controls.Add(this.btnClose);
            this.pnlNavtion.Controls.Add(this.pnlMenu);
            this.pnlNavtion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavtion.Location = new System.Drawing.Point(0, 0);
            this.pnlNavtion.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavtion.Name = "pnlNavtion";
            this.pnlNavtion.Size = new System.Drawing.Size(1023, 36);
            this.pnlNavtion.TabIndex = 2;
            this.pnlNavtion.DoubleClick += new System.EventHandler(this.btnMax_Click);
            this.pnlNavtion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLine.Location = new System.Drawing.Point(0, 34);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(1023, 2);
            this.pnlLine.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pnlURLSafe);
            this.panel5.Controls.Add(this.txtURL);
            this.panel5.Location = new System.Drawing.Point(109, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 25);
            this.panel5.TabIndex = 8;
            // 
            // txtURL
            // 
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtURL.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtURL.ForeColor = System.Drawing.Color.DimGray;
            this.txtURL.Location = new System.Drawing.Point(28, 5);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(180, 19);
            this.txtURL.TabIndex = 0;
            this.txtURL.Click += new System.EventHandler(this.textBox1_Click);
            this.txtURL.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // pnlMenuList
            // 
            this.pnlMenuList.BackColor = System.Drawing.Color.White;
            this.pnlMenuList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuList.Controls.Add(this.label4);
            this.pnlMenuList.Controls.Add(this.label3);
            this.pnlMenuList.Controls.Add(this.label2);
            this.pnlMenuList.Controls.Add(this.label1);
            this.pnlMenuList.Controls.Add(this.shapeContainer1);
            this.pnlMenuList.Location = new System.Drawing.Point(13, 1);
            this.pnlMenuList.Name = "pnlMenuList";
            this.pnlMenuList.Size = new System.Drawing.Size(135, 152);
            this.pnlMenuList.TabIndex = 9;
            this.pnlMenuList.Leave += new System.EventHandler(this.pnlMenu_Leave);
            this.pnlMenuList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "检查更新";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "导入导出";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "历史记录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "收藏标签";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(133, 150);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 14;
            this.lineShape4.X2 = 115;
            this.lineShape4.Y1 = 134;
            this.lineShape4.Y2 = 134;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 13;
            this.lineShape3.X2 = 114;
            this.lineShape3.Y1 = 100;
            this.lineShape3.Y2 = 100;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 12;
            this.lineShape2.X2 = 113;
            this.lineShape2.Y1 = 64;
            this.lineShape2.Y2 = 64;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 11;
            this.lineShape1.X2 = 112;
            this.lineShape1.Y1 = 31;
            this.lineShape1.Y2 = 31;
            // 
            // pnlContext
            // 
            this.pnlContext.Controls.Add(this.pnlMenuList);
            this.pnlContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContext.Location = new System.Drawing.Point(0, 36);
            this.pnlContext.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContext.Name = "pnlContext";
            this.pnlContext.Size = new System.Drawing.Size(1023, 525);
            this.pnlContext.TabIndex = 3;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "chat.png");
            // 
            // pnlAddTag
            // 
            this.pnlAddTag.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddTag.BackgroundImage = global::USbrowser.Properties.Resources.add;
            this.pnlAddTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAddTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAddTag.ForeColor = System.Drawing.Color.Transparent;
            this.pnlAddTag.Location = new System.Drawing.Point(325, 13);
            this.pnlAddTag.Name = "pnlAddTag";
            this.pnlAddTag.Size = new System.Drawing.Size(12, 12);
            this.pnlAddTag.TabIndex = 6;
            this.pnlAddTag.Click += new System.EventHandler(this.panel9_Click);
            // 
            // pnlURLSafe
            // 
            this.pnlURLSafe.BackColor = System.Drawing.Color.Transparent;
            this.pnlURLSafe.BackgroundImage = global::USbrowser.Properties.Resources.pass;
            this.pnlURLSafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlURLSafe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlURLSafe.ForeColor = System.Drawing.Color.Transparent;
            this.pnlURLSafe.Location = new System.Drawing.Point(4, 4);
            this.pnlURLSafe.Name = "pnlURLSafe";
            this.pnlURLSafe.Size = new System.Drawing.Size(18, 18);
            this.pnlURLSafe.TabIndex = 7;
            // 
            // pnlForward
            // 
            this.pnlForward.BackColor = System.Drawing.Color.Transparent;
            this.pnlForward.BackgroundImage = global::USbrowser.Properties.Resources.forward;
            this.pnlForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlForward.ForeColor = System.Drawing.Color.Transparent;
            this.pnlForward.Location = new System.Drawing.Point(81, 10);
            this.pnlForward.Name = "pnlForward";
            this.pnlForward.Size = new System.Drawing.Size(16, 16);
            this.pnlForward.TabIndex = 7;
            this.pnlForward.Click += new System.EventHandler(this.panel4_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.Transparent;
            this.pnlBack.BackgroundImage = global::USbrowser.Properties.Resources.back1;
            this.pnlBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBack.ForeColor = System.Drawing.Color.Transparent;
            this.pnlBack.Location = new System.Drawing.Point(47, 10);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(16, 16);
            this.pnlBack.TabIndex = 6;
            this.pnlBack.Click += new System.EventHandler(this.panel3_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = global::USbrowser.Properties.Resources.min;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.ForeColor = System.Drawing.Color.Transparent;
            this.btnMin.Location = new System.Drawing.Point(950, 9);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(16, 16);
            this.btnMin.TabIndex = 5;
            this.btnMin.Click += new System.EventHandler(this.button3_Click_1);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.BackgroundImage = global::USbrowser.Properties.Resources.max;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.ForeColor = System.Drawing.Color.Transparent;
            this.btnMax.Location = new System.Drawing.Point(973, 9);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(16, 16);
            this.btnMax.TabIndex = 4;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            this.btnMax.MouseLeave += new System.EventHandler(this.btnMax_MouseLeave);
            this.btnMax.MouseHover += new System.EventHandler(this.btnMax_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::USbrowser.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(996, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.TabIndex = 3;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BackgroundImage = global::USbrowser.Properties.Resources.menu;
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMenu.ForeColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Location = new System.Drawing.Point(13, 10);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(16, 16);
            this.pnlMenu.TabIndex = 7;
            this.pnlMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseClick);
            this.pnlMenu.MouseHover += new System.EventHandler(this.panel6_MouseHover);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.pnlContext);
            this.Controls.Add(this.pnlNavtion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "US浏览器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint_1);
            this.pnlNavtion.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlMenuList.ResumeLayout(false);
            this.pnlMenuList.PerformLayout();
            this.pnlContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavtion;
        private System.Windows.Forms.Panel btnClose;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel btnMax;
        private System.Windows.Forms.Panel btnMin;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Panel pnlForward;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlAddTag;
        private System.Windows.Forms.Panel pnlURLSafe;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnlMenuList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel pnlContext;
        private System.Windows.Forms.ImageList imageList2;


    }
}

