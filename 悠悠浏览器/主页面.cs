using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace 悠悠浏览器
{
    public partial class 主页面 : Form
    {
        string Path = string.Empty;
        public static 主页面 fm;
        public 主页面(string[] path)
        {
            InitializeComponent();
            if (path.Length > 0 && path[0] != null)
            {
                Path = path[0];
            }
            fm = this;
        }
        WebKit.WebKitBrowser browser;
        private string userAgent = "US浏览器/1.0 (Windows; U; Windows NT 6.2; zh-CN) AppleWebKit/533+ (KHTML, like Gecko)";
        private void Form1_Load(object sender, EventArgs e)
        {
            pnlNavtion.BackColor = Color.FromArgb(239, 239, 242);
            pnlNavtion.Height -= 3;
            if (DateTime.Now.Second % 2 == 0)
            {
                pnlLine.BackColor = Color.FromArgb(51, 133, 255);//蓝色
            }
            cms = new System.Windows.Forms.ContextMenuStrip();
            p = addTag();
            addPage();
            //  p = panel7;
            //  TagContext(p);
            // panel7.Click += p_Click;
            //     addPage();        
            cms.Items.Add("关闭当前标签页");
            cms.Items.Add("关闭其它标签页");
            cms.Items.Add("关闭左边标签页");
            cms.Items.Add("关闭右边标签页");
            cms.Items.Add("重新加载");
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.WindowState = FormWindowState.Maximized;
            pnlMenuList.Hide();

        }
      
        public void Add(string[] path)
        {
            if (path.Length > 0)
            {
                Path = path[0];
            }
            p = addTag();
            addPage();
        }

        //添加页


        private void addPage()
        {
            browser = new WebKit.WebKitBrowser();
            browser.UserAgent = userAgent;
            browser.Dock = DockStyle.Fill;
            pnlContext.Controls.Clear();
            pnlContext.Controls.Add(browser);
            browser.Focus();
            //   MessageBox.Show(Path);
            browser.Navigate(Path == string.Empty ? "http://www.baidu.com" : Path);
            Path = string.Empty;
            browser.NewWindowCreated += browser_NewWindowCreated;
            browser.DocumentTitleChanged += browser_DocumentTitleChanged;
            lsKB.Add(browser);
        }

        void browser_DocumentTitleChanged(object sender, EventArgs e)
        {
            WebKit.WebKitBrowser wb = ((WebKit.WebKitBrowser)sender);
            txtURL.Text = wb.Url.ToString().ToLower().Replace("http://", "");
            if (p.Controls.Count >= 1)
                p.Controls[1].Text = wb.DocumentTitle.Length > 10 ? wb.DocumentTitle.Substring(0, 10) + "..." : wb.DocumentTitle;
            this.Text = p.Controls[1].Text;
        }
        //点击URL新打开标签
        Panel p;
        void browser_NewWindowCreated(object sender, WebKit.NewWindowCreatedEventArgs e)
        {
            p = addTag();
            browser = e.WebKitBrowser;
            browser.UserAgent = userAgent;
            browser.Dock = DockStyle.Fill;
            browser.NewWindowCreated += browser_NewWindowCreated;
            browser.DocumentTitleChanged += browser_DocumentTitleChanged;
            lsKB.Add(browser);
            pnlContext.Controls.Clear();
            pnlContext.Controls.Add(browser);
            browser.Focus();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = imageList1.Images[1];
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = imageList1.Images[0];
        }

        //最大化最小化
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.WindowState = FormWindowState.Maximized;
            }
        }

        #region 窗体操作
        private void btnMax_MouseHover(object sender, EventArgs e)
        {
            btnMax.BackgroundImage = imageList1.Images[3];
        }

        private void btnMax_MouseLeave(object sender, EventArgs e)
        {
            btnMax.BackgroundImage = imageList1.Images[2];
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            btnMin.BackgroundImage = imageList1.Images[5];
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackgroundImage = imageList1.Images[4];
        }
        #endregion

        //输入URL回车
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                browser.Navigate("http://" + this.txtURL.Text.Trim().ToLower().Replace("http://", ""));
                browser.Focus();
            }
        }
        //后退
        private void panel3_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
            {
                browser.GoBack();
            }
        }
        //前进
        private void panel4_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward)
            {
                browser.GoForward();
            }
        }

        //双击选择所有文本


        private void textBox1_Click(object sender, EventArgs e)
        {

            txtURL.SelectAll();

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            txtURL.Select(0, 0);
        }


        private void pnlMenu_Leave(object sender, EventArgs e)
        {
            pnlMenuList.Hide();
        }

        private void pnlMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (!pnlMenuList.Focus())
            {
                pnlMenuList.Hide();
            }
        }
        //页面集合对象
        List<WebKit.WebKitBrowser> lsKB = new List<WebKit.WebKitBrowser>();

        //添加新标签

        private ContextMenuStrip cms;
        int i = 0;
        private Panel addTag()
        {
            Panel p = new Panel();
            p.Click += p_Click;
            p.ContextMenuStrip = cms;
            p.Size = new Size(180, panel5.Size.Height + 2);
            pnlNavtion.Controls.Add(p);
            p.Tag = i;
            p.Location = new Point(pnlAddTag.Location.X, panel5.Location.Y);
            pnlAddTag.Location = new Point(p.Location.X + 184, pnlAddTag.Location.Y);
            TagContext(p);
            setSelectColor(p);
            i++;
            return p;
        }
        private void TagContext(Panel p)
        {
            //图标
            Panel pnlImage = new Panel();
            pnlImage.BackgroundImage = imageList1.Images[8];
            pnlImage.Location = new Point(6, p.Height / 6 + 1);
            pnlImage.Size = new Size(16, 16);
            pnlImage.BackgroundImageLayout = ImageLayout.Stretch;
            pnlImage.Click += p_Click;
            p.Controls.Add(pnlImage);
            //标题
            Label lblTitle = new Label();
            lblTitle.AutoSize = true;
            Font font = new System.Drawing.Font("微软雅黑", 9);
            lblTitle.Font = font;
            lblTitle.Location = new Point(22, p.Height / 6 + 1);
            lblTitle.Click += p_Click;
            p.Controls.Add(lblTitle);
            //关闭标签页


            Panel pnlClose = new Panel();
            pnlClose.BackgroundImage = imageList1.Images[6];
            pnlClose.Location = new Point(160, p.Height / 4 + 1);
            pnlClose.Anchor = AnchorStyles.Right;
            pnlClose.Size = new Size(12, 12);
            pnlClose.Cursor = Cursors.Hand;
            pnlClose.BackgroundImageLayout = ImageLayout.Zoom;
            pnlClose.Click += pnlClose_Click;
            p.Controls.Add(pnlClose);
        }
        //关闭标签页


        void pnlClose_Click(object sender, EventArgs e)
        {
            //判断是否只有一个标签


            if (pnlNavtion.Controls.Count == 10)
            {
                DialogResult dr = MessageBox.Show("是否退出浏览器?", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK) Application.Exit();
                else return;
            }
            Panel pnlTag = (Panel)(((Panel)sender).Parent);
            lsKB[Convert.ToInt32(pnlTag.Tag)].Dispose();

            pnlAddTag.Location = new Point(pnlAddTag.Location.X - 184, pnlAddTag.Location.Y);//添加
            for (int i = 0; i < pnlNavtion.Controls.Count; i++)
            {
                if (pnlNavtion.Controls[i].Controls.Count == 3)//为网页标签时
                {
                    if (pnlNavtion.Controls[i].Tag == pnlTag.Tag)
                    {
                        if (pnlNavtion.Controls.Count > i + 1)//如果当前页右边有标签页，关闭当前标签页选择后面一页

                        {
                            browser = lsKB[Convert.ToInt32(pnlNavtion.Controls[i + 1].Tag)];
                            setSelectColor(pnlNavtion.Controls[i + 1] as Panel);
                        }
                        else//关闭当前页选择前一页

                        {
                            browser = lsKB[Convert.ToInt32(pnlNavtion.Controls[i - 1].Tag)];
                            setSelectColor(pnlNavtion.Controls[i - 1] as Panel);
                        }
                        pnlContext.Controls.Clear();
                        pnlContext.Controls.Add(browser);
                        browser.Focus();
                    }
                    if (Convert.ToInt32(pnlNavtion.Controls[i].Tag) > Convert.ToInt32(pnlTag.Tag)) //右边标签页移动到左边
                    {
                        pnlNavtion.Controls[i].Location = new Point(pnlNavtion.Controls[i].Location.X - 184, pnlNavtion.Controls[i].Location.Y);
                    }
                }
            }
            pnlTag.Dispose();//不能写for循环里面，会影响count，然后保存

        }

        //添加新标签页
        private void panel9_Click(object sender, EventArgs e)
        {
            p = addTag();
            addPage();
        }

        //选中标签页


        void p_Click(object sender, EventArgs e)
        {
            Panel p;
            if (sender is Panel)
            {
                if (((Panel)sender).HasChildren)
                    p = (Panel)sender;
                else
                    p = (Panel)(((Panel)sender).Parent);
            }
            else
                p = (Panel)(((Label)sender).Parent);
            pnlContext.Controls.Clear();
            browser = lsKB[Convert.ToInt32(p.Tag)];
            txtURL.Text = browser.Url.ToString().ToLower().Replace("http://", "");
            pnlContext.Controls.Add(browser);
            browser.Focus();
            setSelectColor(p);
        }

        //设置选中页的颜色
        private void setSelectColor(Panel p)
        {
            for (int i = 0; i < pnlNavtion.Controls.Count; i++)
            {
                if (pnlNavtion.Controls[i].Controls.Count == 3)
                {
                    pnlNavtion.Controls[i].BackColor = pnlNavtion.BackColor;
                    pnlNavtion.Controls[i].Controls[1].ForeColor = Color.Black;
                    pnlNavtion.Controls[i].Controls[2].BackgroundImage = imageList1.Images[6];
                }
            }
            p.BackColor = pnlLine.BackColor;
            p.Controls[1].ForeColor = Color.White;
            p.Controls[2].BackgroundImage = imageList1.Images[7];
            this.Text = p.Controls[1].Text;
        }

        Form frmChat;
        private void panel6_MouseHover(object sender, EventArgs e)
        {
            if (frmChat != null) { frmChat.Visible = false; frmChat.Show(this); return; };
            frmChat = new Form();
            frmChat.Size = new System.Drawing.Size(325, pnlContext.Size.Height);
            frmChat.Location = new Point(this.Location.X, this.Location.Y + 36);
            //  frmChat.TopMost = true;
            frmChat.FormBorderStyle = FormBorderStyle.None;
            frmChat.BackColor = Color.FromArgb(0, 122, 204);
            //  frmChat.BackgroundImage = global::悠悠浏览器.Properties.Resources.chat;
            //frmChat.BackgroundImageLayout = ImageLayout.Stretch;
            frmChat.StartPosition = FormStartPosition.Manual;
            frmChat.Padding = new Padding(0);
            frmChat.MouseLeave += frmChat_MouseLeave;
            frmChat.ShowInTaskbar = false;
            frmChat.Visible = false;
            frmChat.Show(this);
            Panel pnlTouxiang = new Panel();
            pnlTouxiang.Size = new Size(48, 48);
            pnlTouxiang.Location = new Point(40, 40);
            pnlTouxiang.BorderStyle = BorderStyle.FixedSingle;
            pnlTouxiang.BackgroundImage = global::悠悠浏览器.Properties.Resources.add;
            pnlTouxiang.BackgroundImageLayout = ImageLayout.Stretch;
            frmChat.Controls.Add(pnlTouxiang);
            Label lblName = new Label();
            lblName.Text = "Jason.shao";
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(pnlTouxiang.Location.X + 50, pnlTouxiang.Location.Y);
            frmChat.Controls.Add(lblName);
            Dictionary<int, string[]> dicGroup = new Dictionary<int, string[]>();
            dicGroup.Add(0, new string[] { "︻┳═一我的好友 [51/104]", "jason.shao", "何丽萍", "建站-技术" });
            dicGroup.Add(1, new string[] { "︻┳═一大学同学 [28/38]", "陈立勇", "刘洋", "毛老师" });
            dicGroup.Add(2, new string[] { "︻┳═一兄弟姐妹 [3/12]", "哥哥", "姐姐", "弟弟" });
            dicGroup.Add(3, new string[] { "︻┳═一274班 [16/25]", "jason.shao", "何丽萍", "建站-技术" });
            dicGroup.Add(4, new string[] { "︻┳═一碧林 [10/17]", "jason.shao", "何丽萍", "建站-技术" });
            dicGroup.Add(5, new string[] { "︻┳═一78班 [4/9]", "jason.shao", "何丽萍", "建站-技术" });
            List<string[]> ls = dicGroup.Values.ToList();
            for (int i = 0; i < 6; i++)
            {
                Label lblGroup = new Label();
                lblGroup.Text = ls[i][0];
                lblGroup.ForeColor = Color.White;
                lblGroup.AutoSize = true;
                lblGroup.Location = new Point(12, 24 * (10 + i));
                lblGroup.Tag = ls[i];
                lblGroup.Click += lblGroup_Click;
                frmChat.Controls.Add(lblGroup);
            }
            TextBox tbUserName = new TextBox();
            tbUserName.Text = "aa";
            frmChat.Controls.Add(tbUserName);
            TextBox tbPassWord = new TextBox();
            tbPassWord.Text = "bb";
            tbPassWord.Location = new Point(0, 40);
            Button btnLogin = new Button();
            btnLogin.Click += btnLogin_Click;
            btnLogin.Location = new Point(0, 60);
            frmChat.Controls.Add(btnLogin);
            frmChat.Controls.Add(tbPassWord);
            //  Panel pChat = new Panel();
            //  pChat.Size = new Size(325, 648);
            //  pChat.Location = new Point(0, 0);
            //  Label lblName = new Label();
            //  lblName.Text = "jason.shao";
            //  pChat.Controls.Add(lblName);
            //  pChat.Dock = DockStyle.Left;
            ////  panel2.SendToBack();
            //  panel2.Controls.Add(pChat);
            // pnlMenu.Show();
        }

        void btnLogin_Click(object sender, EventArgs e)
        {
            SqlHelper.Update("update sys_User set ip='192.168.1.111:50001' where id='100000'");
        }

        void lblGroup_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string[] strFriend = (string[])lbl.Tag;
            for (int i = 1; i < strFriend.Length; i++)
            {
                Panel pnl = new Panel();
                pnl.Size = new Size(262, 47);
                pnl.Location = new Point(lbl.Location.X + 10, lbl.Location.Y + 50 * (i + 1));
                Panel pnlTx = new Panel();
                pnlTx.Size = new Size(40, 40);
                pnlTx.Click += pnlTx_Click;
                pnlTx.BackgroundImage = global::悠悠浏览器.Properties.Resources.add;
                pnlTx.BackgroundImageLayout = ImageLayout.Stretch;
                pnl.Controls.Add(pnlTx);
                Label lblName = new Label();
                lblName.Text = strFriend[i];
                lblName.Click += pnlTx_Click;
                lblName.ForeColor = lbl.ForeColor;
                lblName.Location = new Point(40, 20);
                pnl.Controls.Add(lblName);
                frmChat.Controls.Add(pnl);
            }
        }

        void pnlTx_Click(object sender, EventArgs e)
        {
            frmChat.Hide();
            Panel pnl = new Panel();
            pnl.Dock = DockStyle.Fill;
            pnl.Click += pnl_Click;
            Panel pnlTop = new Panel();
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Height = 48;
            Panel pnlTx = new Panel();

            pnlTx.BackgroundImageLayout = ImageLayout.Stretch;
            pnlTx.Size = new Size(40, 40);
            pnlTx.Location = new Point(16, 16);
            pnlTop.Controls.Add(pnlTx);
            Label lblName = new Label();
            lblName.Location = new Point(60, 20);
            if (sender is Label)
            {
                lblName.Text = ((Label)sender).Text;
                pnlTx.BackgroundImage = ((Label)sender).Parent.Controls[0].BackgroundImage;
            }
            else
            {
                pnlTx.BackgroundImage = ((Panel)sender).BackgroundImage;
                lblName.Text = ((Panel)sender).Parent.Controls[1].Text;
            }
            pnlTop.Controls.Add(lblName);
            pnl.Controls.Add(pnlTop);
            pnlContext.Controls.Clear();
            pnlContext.Controls.Add(pnl);
        }

        void pnl_Click(object sender, EventArgs e)
        {
            frmChat.Hide();
        }

        void frmChat_MouseLeave(object sender, EventArgs e)
        {
            //  frmChat.Hide();
        }

        #region 窗体操作
        //移动窗体
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;


        //调整大小
        #region 控制改变窗体大小
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        const int WM_NCHITTEST = 0x0084;
        const int HTLEFT = 10;    //左边界


        const int HTRIGHT = 11;   //右边界


        const int HTTOP = 12; //上边界


        const int HTTOPLEFT = 13; //左上角


        const int HTTOPRIGHT = 14;    //右上角


        const int HTBOTTOM = 15;  //下边界


        const int HTBOTTOMLEFT = 0x10;    //左下角


        const int HTBOTTOMRIGHT = 17; //右下角



        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    {
                        Point vPoint = new Point((int)m.LParam & 0xFFFF,
                            (int)m.LParam >> 16 & 0xFFFF);
                        vPoint = PointToClient(vPoint);
                        //判断：仅当当前窗体状态不是最大化时，相关鼠标事件生效
                        if (this.WindowState != FormWindowState.Maximized)
                        {
                            if (vPoint.X <= 5)
                            {
                                if (vPoint.Y <= 5)
                                {
                                    m.Result = (IntPtr)HTTOPLEFT;
                                }
                                else if (vPoint.Y >= ClientSize.Height - 5)
                                {
                                    m.Result = (IntPtr)HTBOTTOMLEFT;
                                }
                                else
                                {
                                    m.Result = (IntPtr)HTLEFT;
                                }
                            }
                            else if (vPoint.X >= ClientSize.Width - 5)
                            {
                                if (vPoint.Y <= 5)
                                {
                                    m.Result = (IntPtr)HTTOPRIGHT;
                                }
                                else if (vPoint.Y >= ClientSize.Height - 5)
                                {
                                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                                }
                                else
                                {
                                    m.Result = (IntPtr)HTRIGHT;
                                }
                            }
                            else if (vPoint.Y <= 5)
                            {
                                m.Result = (IntPtr)HTTOP;
                            }
                            else if (vPoint.Y >= ClientSize.Height - 5)
                            {
                                m.Result = (IntPtr)HTBOTTOM;
                            }

                        }
                        break;
                    }
            }
        }
        #endregion

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            frmChat.Visible = false;
            frmChat.Hide();
        }


        #endregion

        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Paint_1(object sender, PaintEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.Padding = new Padding(0, 0, 1, 0);
            else
                this.Padding = new Padding(1);
        }

    }
}
