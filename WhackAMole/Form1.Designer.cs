namespace WhackAMole
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mapTile3 = new MapTile();
            this.mapTile2 = new MapTile();
            this.mapTile1 = new MapTile();
            this.mapTile4 = new MapTile();
            this.mapTile5 = new MapTile();
            this.mapTile6 = new MapTile();
            this.mapTile7 = new MapTile();
            this.mapTile8 = new MapTile();
            this.mapTile9 = new MapTile();
            this.mapTile10 = new MapTile();
            this.mapTile11 = new MapTile();
            this.mapTile12 = new MapTile();
            this.mapTile13 = new MapTile();
            this.mapTile14 = new MapTile();
            this.mapTile15 = new MapTile();
            this.mapTile16 = new MapTile();
            this.mapTile17 = new MapTile();
            this.mapTile18 = new MapTile();
            this.mapTile19 = new MapTile();
            this.mapTile20 = new MapTile();
            this.mapTile21 = new MapTile();
            this.mapTile22 = new MapTile();
            this.mapTile23 = new MapTile();
            this.mapTile24 = new MapTile();
            this.mapTile25 = new MapTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile25)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hammer-down.gif");
            this.imageList1.Images.SetKeyName(1, "hammer-up.gif");
            this.imageList1.Images.SetKeyName(2, "l1.jpg");
            this.imageList1.Images.SetKeyName(3, "l2.jpg");
            this.imageList1.Images.SetKeyName(4, "l3.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "打中次数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(122, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(288, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "第0关";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mapTile3
            // 
            this.mapTile3.Location = new System.Drawing.Point(152, 55);
            this.mapTile3.Name = "mapTile3";
            this.mapTile3.Size = new System.Drawing.Size(70, 70);
            this.mapTile3.TabIndex = 2;
            this.mapTile3.TabStop = false;
            this.mapTile3.Coordinate = new System.Drawing.Point(0, 2);
            this.mapTile3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile3_MouseDown);
            this.mapTile3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);

            // 
            // mapTile2
            // 
            this.mapTile2.Location = new System.Drawing.Point(82, 55);
            this.mapTile2.Name = "mapTile2";
            this.mapTile2.Size = new System.Drawing.Size(70, 70);
            this.mapTile2.TabIndex = 1;
            this.mapTile2.TabStop = false;
            this.mapTile2.Coordinate = new System.Drawing.Point(0, 1);
            this.mapTile2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile2_MouseDown);
            this.mapTile2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile1
            // 
            this.mapTile1.Location = new System.Drawing.Point(12, 55);
            this.mapTile1.Name = "mapTile1";
            this.mapTile1.Size = new System.Drawing.Size(70, 70);
            this.mapTile1.TabIndex = 0;
            this.mapTile1.TabStop = false;
            this.mapTile1.Coordinate = new System.Drawing.Point(0, 0);
            this.mapTile1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile1_MouseDown);
            this.mapTile1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile4
            // 
            this.mapTile4.Location = new System.Drawing.Point(222, 55);
            this.mapTile4.Name = "mapTile4";
            this.mapTile4.Size = new System.Drawing.Size(70, 70);
            this.mapTile4.TabIndex = 6;
            this.mapTile4.TabStop = false;
            this.mapTile4.Coordinate = new System.Drawing.Point(0, 3);
            this.mapTile4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile4_MouseDown);
            this.mapTile4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile5
            // 
            this.mapTile5.Location = new System.Drawing.Point(292, 55);
            this.mapTile5.Name = "mapTile5";
            this.mapTile5.Size = new System.Drawing.Size(70, 70);
            this.mapTile5.TabIndex = 7;
            this.mapTile5.TabStop = false;
            this.mapTile5.Coordinate = new System.Drawing.Point(0, 4);
            this.mapTile5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile5_MouseDown);
            this.mapTile5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile6
            // 
            this.mapTile6.Location = new System.Drawing.Point(12, 125);
            this.mapTile6.Name = "mapTile6";
            this.mapTile6.Size = new System.Drawing.Size(70, 70);
            this.mapTile6.TabIndex = 8;
            this.mapTile6.TabStop = false;
            this.mapTile6.Coordinate = new System.Drawing.Point(1, 0);
            this.mapTile6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile6_MouseDown);
            this.mapTile6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile7
            // 
            this.mapTile7.Location = new System.Drawing.Point(82, 125);
            this.mapTile7.Name = "mapTile7";
            this.mapTile7.Size = new System.Drawing.Size(70, 70);
            this.mapTile7.TabIndex = 9;
            this.mapTile7.TabStop = false;
            this.mapTile7.Coordinate = new System.Drawing.Point(1, 1);
            this.mapTile7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile7_MouseDown);
            this.mapTile7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile8
            // 
            this.mapTile8.Location = new System.Drawing.Point(152, 125);
            this.mapTile8.Name = "mapTile8";
            this.mapTile8.Size = new System.Drawing.Size(70, 70);
            this.mapTile8.TabIndex = 10;
            this.mapTile8.TabStop = false;
            this.mapTile8.Coordinate = new System.Drawing.Point(1, 2);
            this.mapTile8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile8_MouseDown);
            this.mapTile8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile9
            // 
            this.mapTile9.Location = new System.Drawing.Point(222, 125);
            this.mapTile9.Name = "mapTile9";
            this.mapTile9.Size = new System.Drawing.Size(70, 70);
            this.mapTile9.TabIndex = 11;
            this.mapTile9.TabStop = false;
            this.mapTile9.Coordinate = new System.Drawing.Point(1, 3);
            this.mapTile9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile9_MouseDown);
            this.mapTile9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile10
            // 
            this.mapTile10.Location = new System.Drawing.Point(292, 125);
            this.mapTile10.Name = "mapTile10";
            this.mapTile10.Size = new System.Drawing.Size(70, 70);
            this.mapTile10.TabIndex = 12;
            this.mapTile10.TabStop = false;
            this.mapTile10.Coordinate = new System.Drawing.Point(1, 4);
            this.mapTile10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile10_MouseDown);
            this.mapTile10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile11
            // 
            this.mapTile11.Location = new System.Drawing.Point(12, 195);
            this.mapTile11.Name = "mapTile11";
            this.mapTile11.Size = new System.Drawing.Size(70, 70);
            this.mapTile11.TabIndex = 13;
            this.mapTile11.TabStop = false;
            this.mapTile11.Coordinate = new System.Drawing.Point(2, 0);
            this.mapTile11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile11_MouseDown);
            this.mapTile11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile12
            // 
            this.mapTile12.Location = new System.Drawing.Point(82, 195);
            this.mapTile12.Name = "mapTile12";
            this.mapTile12.Size = new System.Drawing.Size(70, 70);
            this.mapTile12.TabIndex = 14;
            this.mapTile12.TabStop = false;
            this.mapTile12.Coordinate = new System.Drawing.Point(2, 1);
            this.mapTile12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile12_MouseDown);
            this.mapTile12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile13
            // 
            this.mapTile13.Location = new System.Drawing.Point(152, 195);
            this.mapTile13.Name = "mapTile13";
            this.mapTile13.Size = new System.Drawing.Size(70, 70);
            this.mapTile13.TabIndex = 15;
            this.mapTile13.TabStop = false;
            this.mapTile13.Coordinate = new System.Drawing.Point(2, 2);
            this.mapTile13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile13_MouseDown);
            this.mapTile13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile14
            // 
            this.mapTile14.Location = new System.Drawing.Point(222, 195);
            this.mapTile14.Name = "mapTile14";
            this.mapTile14.Size = new System.Drawing.Size(70, 70);
            this.mapTile14.TabIndex = 16;
            this.mapTile14.TabStop = false;
            this.mapTile14.Coordinate = new System.Drawing.Point(2, 3);
            this.mapTile14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile14_MouseDown);
            this.mapTile14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile15
            // 
            this.mapTile15.Location = new System.Drawing.Point(292, 195);
            this.mapTile15.Name = "mapTile15";
            this.mapTile15.Size = new System.Drawing.Size(70, 70);
            this.mapTile15.TabIndex = 17;
            this.mapTile15.TabStop = false;
            this.mapTile15.Coordinate = new System.Drawing.Point(2, 4);
            this.mapTile15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile15_MouseDown);
            this.mapTile15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile16
            // 
            this.mapTile16.Location = new System.Drawing.Point(12, 265);
            this.mapTile16.Name = "mapTile16";
            this.mapTile16.Size = new System.Drawing.Size(70, 70);
            this.mapTile16.TabIndex = 18;
            this.mapTile16.TabStop = false;
            this.mapTile16.Coordinate = new System.Drawing.Point(3, 0);
            this.mapTile16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile16_MouseDown);
            this.mapTile16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile17
            // 
            this.mapTile17.Location = new System.Drawing.Point(82, 265);
            this.mapTile17.Name = "mapTile17";
            this.mapTile17.Size = new System.Drawing.Size(70, 70);
            this.mapTile17.TabIndex = 19;
            this.mapTile17.TabStop = false;
            this.mapTile17.Coordinate = new System.Drawing.Point(3, 1);
            this.mapTile17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile17_MouseDown);
            this.mapTile17.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile18
            // 
            this.mapTile18.Location = new System.Drawing.Point(152, 265);
            this.mapTile18.Name = "mapTile18";
            this.mapTile18.Size = new System.Drawing.Size(70, 70);
            this.mapTile18.TabIndex = 20;
            this.mapTile18.TabStop = false;
            this.mapTile18.Coordinate = new System.Drawing.Point(3, 2);
            this.mapTile18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile18_MouseDown);
            this.mapTile18.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile19
            // 
            this.mapTile19.Location = new System.Drawing.Point(222, 265);
            this.mapTile19.Name = "mapTile19";
            this.mapTile19.Size = new System.Drawing.Size(70, 70);
            this.mapTile19.TabIndex = 21;
            this.mapTile19.TabStop = false;
            this.mapTile19.Coordinate = new System.Drawing.Point(3, 3);
            this.mapTile19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile19_MouseDown);
            this.mapTile19.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile20
            // 
            this.mapTile20.Location = new System.Drawing.Point(292, 265);
            this.mapTile20.Name = "mapTile20";
            this.mapTile20.Size = new System.Drawing.Size(70, 70);
            this.mapTile20.TabIndex = 21;
            this.mapTile20.TabStop = false;
            this.mapTile20.Coordinate = new System.Drawing.Point(3, 4);
            this.mapTile20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile20_MouseDown);
            this.mapTile20.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile21
            // 
            this.mapTile21.Location = new System.Drawing.Point(12, 335);
            this.mapTile21.Name = "mapTile21";
            this.mapTile21.Size = new System.Drawing.Size(70, 70);
            this.mapTile21.TabIndex = 22;
            this.mapTile21.TabStop = false;
            this.mapTile21.Coordinate = new System.Drawing.Point(4, 0);
            this.mapTile21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile21_MouseDown);
            this.mapTile21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile22
            // 
            this.mapTile22.Location = new System.Drawing.Point(82, 335);
            this.mapTile22.Name = "mapTile22";
            this.mapTile22.Size = new System.Drawing.Size(70, 70);
            this.mapTile22.TabIndex = 23;
            this.mapTile22.TabStop = false;
            this.mapTile22.Coordinate = new System.Drawing.Point(4, 1);
            this.mapTile22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile22_MouseDown);
            this.mapTile22.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile23
            // 
            this.mapTile23.Location = new System.Drawing.Point(152, 335);
            this.mapTile23.Name = "mapTile23";
            this.mapTile23.Size = new System.Drawing.Size(70, 70);
            this.mapTile23.TabIndex = 24;
            this.mapTile23.TabStop = false;
            this.mapTile23.Coordinate = new System.Drawing.Point(4, 2);
            this.mapTile23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile23_MouseDown);
            this.mapTile23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile24
            // 
            this.mapTile24.Location = new System.Drawing.Point(222, 335);
            this.mapTile24.Name = "mapTile24";
            this.mapTile24.Size = new System.Drawing.Size(70, 70);
            this.mapTile24.TabIndex = 25;
            this.mapTile24.TabStop = false;
            this.mapTile24.Coordinate = new System.Drawing.Point(4, 3);
            this.mapTile24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile24_MouseDown);
            this.mapTile24.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // mapTile25
            // 
            this.mapTile25.Location = new System.Drawing.Point(292, 335);
            this.mapTile25.Name = "mapTile25";
            this.mapTile25.Size = new System.Drawing.Size(70, 70);
            this.mapTile25.TabIndex = 26;
            this.mapTile25.TabStop = false;
            this.mapTile25.Coordinate = new System.Drawing.Point(4, 4);
            this.mapTile25.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapTile25_MouseDown);
            this.mapTile25.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(303, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "退出";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(241, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "开始";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(376, 480);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mapTile25);
            this.Controls.Add(this.mapTile24);
            this.Controls.Add(this.mapTile23);
            this.Controls.Add(this.mapTile22);
            this.Controls.Add(this.mapTile21);
            this.Controls.Add(this.mapTile20);
            this.Controls.Add(this.mapTile19);
            this.Controls.Add(this.mapTile18);
            this.Controls.Add(this.mapTile17);
            this.Controls.Add(this.mapTile16);
            this.Controls.Add(this.mapTile15);
            this.Controls.Add(this.mapTile14);
            this.Controls.Add(this.mapTile13);
            this.Controls.Add(this.mapTile12);
            this.Controls.Add(this.mapTile11);
            this.Controls.Add(this.mapTile10);
            this.Controls.Add(this.mapTile9);
            this.Controls.Add(this.mapTile8);
            this.Controls.Add(this.mapTile7);
            this.Controls.Add(this.mapTile6);
            this.Controls.Add(this.mapTile5);
            this.Controls.Add(this.mapTile4);
            this.Controls.Add(this.mapTile3);
            this.Controls.Add(this.mapTile2);
            this.Controls.Add(this.mapTile1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "打地鼠";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapTile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapTile25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MapTile mapTile3;
        private MapTile mapTile2;
        private MapTile mapTile1;
        private MapTile mapTile4;
        private MapTile mapTile5;
        private MapTile mapTile6;
        private MapTile mapTile7;
        private MapTile mapTile8;
        private MapTile mapTile9;
        private MapTile mapTile10;
        private MapTile mapTile11;
        private MapTile mapTile12;
        private MapTile mapTile13;
        private MapTile mapTile14;
        private MapTile mapTile15;
        private MapTile mapTile16;
        private MapTile mapTile17;
        private MapTile mapTile18;
        private MapTile mapTile19;
        private MapTile mapTile20;
        private MapTile mapTile21;
        private MapTile mapTile22;
        private MapTile mapTile23;
        private MapTile mapTile24;
        private MapTile mapTile25;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

