namespace win1
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
            this.code = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stop = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.compile = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ir = new System.Windows.Forms.Label();
            this.ac = new System.Windows.Forms.Label();
            this.pc = new System.Windows.Forms.Label();
            this.ar = new System.Windows.Forms.Label();
            this.dr = new System.Windows.Forms.Label();
            this.decode = new System.Windows.Forms.Label();
            this.ien = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.Label();
            this.sc = new System.Windows.Forms.Label();
            this.fgi = new System.Windows.Forms.Label();
            this.fgo = new System.Windows.Forms.Label();
            this.inpr = new System.Windows.Forms.Label();
            this.opcode = new System.Windows.Forms.Label();
            this.outr = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.AcceptsTab = true;
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Font = new System.Drawing.Font("IRANYekan", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.code.Location = new System.Drawing.Point(3, 77);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(236, 480);
            this.code.TabIndex = 0;
            this.code.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.label1.Font = new System.Drawing.Font("IRANYekan", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.open);
            this.panel1.Controls.Add(this.pause);
            this.panel1.Controls.Add(this.all);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.compile);
            this.panel1.Controls.Add(this.about);
            this.panel1.Location = new System.Drawing.Point(254, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 32);
            this.panel1.TabIndex = 12;
            // 
            // stop
            // 
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Image = global::win1.Properties.Resources.stop;
            this.stop.Location = new System.Drawing.Point(178, 1);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(29, 29);
            this.stop.TabIndex = 52;
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // open
            // 
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.Image = global::win1.Properties.Resources.files_and_folders;
            this.open.Location = new System.Drawing.Point(38, 1);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(29, 29);
            this.open.TabIndex = 59;
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // pause
            // 
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause.Image = global::win1.Properties.Resources.symbols__5_;
            this.pause.Location = new System.Drawing.Point(283, 1);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(29, 29);
            this.pause.TabIndex = 60;
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // all
            // 
            this.all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all.Image = global::win1.Properties.Resources.next1;
            this.all.Location = new System.Drawing.Point(248, 1);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(29, 29);
            this.all.TabIndex = 56;
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.All_Click);
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Image = global::win1.Properties.Resources.refresh__1_;
            this.clear.Location = new System.Drawing.Point(3, 1);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(29, 29);
            this.clear.TabIndex = 58;
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // next
            // 
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Image = global::win1.Properties.Resources.forward1;
            this.next.Location = new System.Drawing.Point(213, 1);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(29, 29);
            this.next.TabIndex = 55;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.Next_Click);
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Image = global::win1.Properties.Resources.star;
            this.save.Location = new System.Drawing.Point(73, 1);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(29, 29);
            this.save.TabIndex = 61;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // compile
            // 
            this.compile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.compile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compile.Image = global::win1.Properties.Resources.loop1;
            this.compile.Location = new System.Drawing.Point(143, 1);
            this.compile.Name = "compile";
            this.compile.Size = new System.Drawing.Size(29, 29);
            this.compile.TabIndex = 54;
            this.compile.UseVisualStyleBackColor = true;
            this.compile.Click += new System.EventHandler(this.Compile_Click);
            // 
            // about
            // 
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Image = global::win1.Properties.Resources.info;
            this.about.Location = new System.Drawing.Point(108, 1);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(29, 29);
            this.about.TabIndex = 57;
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.About_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Controls.Add(this.close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 35);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("IRANYekan", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(51, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "FARKOO Simulator";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::win1.Properties.Resources.infinity__1_;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 32);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Image = global::win1.Properties.Resources.Webp1;
            this.minimize.Location = new System.Drawing.Point(511, 0);
            this.minimize.Margin = new System.Windows.Forms.Padding(0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(37, 35);
            this.minimize.TabIndex = 15;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Image = global::win1.Properties.Resources.Webp_net_resizeimage__4_;
            this.close.Location = new System.Drawing.Point(548, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(37, 35);
            this.close.TabIndex = 15;
            this.close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(51)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(80, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "AC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "IR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(17)))), ((int)(((byte)(159)))));
            this.label6.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(10, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "PC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(150, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "AR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(160)))));
            this.label8.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(150, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "SC";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label9.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(80, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "DR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.label11.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(80, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "E";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.label12.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(10, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 23);
            this.label12.TabIndex = 32;
            this.label12.Text = "I";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(192)))));
            this.label13.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(150, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 23);
            this.label13.TabIndex = 33;
            this.label13.Text = "IEN";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(136)))));
            this.label14.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(80, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 23);
            this.label14.TabIndex = 36;
            this.label14.Text = "OPCode";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.label15.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(10, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 23);
            this.label15.TabIndex = 37;
            this.label15.Text = "Decode";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(17)))), ((int)(((byte)(15)))));
            this.label17.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(80, 237);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 23);
            this.label17.TabIndex = 40;
            this.label17.Text = "FGI";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.label18.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(10, 237);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 23);
            this.label18.TabIndex = 43;
            this.label18.Text = "FGO";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(200)))));
            this.label19.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(150, 311);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 23);
            this.label19.TabIndex = 45;
            this.label19.Text = "INPR";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(41)))), ((int)(((byte)(221)))));
            this.label20.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(10, 311);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 23);
            this.label20.TabIndex = 46;
            this.label20.Text = "OUTR";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.ir);
            this.panel3.Controls.Add(this.ac);
            this.panel3.Controls.Add(this.pc);
            this.panel3.Controls.Add(this.ar);
            this.panel3.Controls.Add(this.dr);
            this.panel3.Controls.Add(this.decode);
            this.panel3.Controls.Add(this.ien);
            this.panel3.Controls.Add(this.e);
            this.panel3.Controls.Add(this.i);
            this.panel3.Controls.Add(this.sc);
            this.panel3.Controls.Add(this.fgi);
            this.panel3.Controls.Add(this.fgo);
            this.panel3.Controls.Add(this.inpr);
            this.panel3.Controls.Add(this.opcode);
            this.panel3.Controls.Add(this.outr);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(307, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 370);
            this.panel3.TabIndex = 51;
            // 
            // ir
            // 
            this.ir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ir.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.ir.ForeColor = System.Drawing.Color.Black;
            this.ir.Location = new System.Drawing.Point(150, 35);
            this.ir.Name = "ir";
            this.ir.Size = new System.Drawing.Size(55, 23);
            this.ir.TabIndex = 53;
            this.ir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ac
            // 
            this.ac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(118)))));
            this.ac.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.ac.ForeColor = System.Drawing.Color.Black;
            this.ac.Location = new System.Drawing.Point(80, 35);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(55, 23);
            this.ac.TabIndex = 54;
            this.ac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pc
            // 
            this.pc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.pc.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.pc.ForeColor = System.Drawing.Color.Black;
            this.pc.Location = new System.Drawing.Point(10, 35);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(55, 23);
            this.pc.TabIndex = 53;
            this.pc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ar
            // 
            this.ar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(154)))));
            this.ar.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.ar.ForeColor = System.Drawing.Color.Black;
            this.ar.Location = new System.Drawing.Point(150, 110);
            this.ar.Name = "ar";
            this.ar.Size = new System.Drawing.Size(55, 23);
            this.ar.TabIndex = 53;
            this.ar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dr
            // 
            this.dr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.dr.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.dr.ForeColor = System.Drawing.Color.Black;
            this.dr.Location = new System.Drawing.Point(80, 110);
            this.dr.Name = "dr";
            this.dr.Size = new System.Drawing.Size(55, 23);
            this.dr.TabIndex = 53;
            this.dr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decode
            // 
            this.decode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(222)))), ((int)(((byte)(138)))));
            this.decode.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.decode.ForeColor = System.Drawing.Color.Black;
            this.decode.Location = new System.Drawing.Point(10, 110);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(55, 23);
            this.decode.TabIndex = 53;
            this.decode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ien
            // 
            this.ien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(214)))), ((int)(((byte)(240)))));
            this.ien.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.ien.ForeColor = System.Drawing.Color.Black;
            this.ien.Location = new System.Drawing.Point(150, 186);
            this.ien.Name = "ien";
            this.ien.Size = new System.Drawing.Size(55, 23);
            this.ien.TabIndex = 53;
            this.ien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // e
            // 
            this.e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(14)))));
            this.e.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.e.ForeColor = System.Drawing.Color.Black;
            this.e.Location = new System.Drawing.Point(80, 186);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(55, 23);
            this.e.TabIndex = 53;
            this.e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // i
            // 
            this.i.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(140)))), ((int)(((byte)(138)))));
            this.i.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.i.ForeColor = System.Drawing.Color.Black;
            this.i.Location = new System.Drawing.Point(10, 186);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(55, 23);
            this.i.TabIndex = 53;
            this.i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sc
            // 
            this.sc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(240)))), ((int)(((byte)(95)))));
            this.sc.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.sc.ForeColor = System.Drawing.Color.Black;
            this.sc.Location = new System.Drawing.Point(150, 260);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(55, 23);
            this.sc.TabIndex = 53;
            this.sc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fgi
            // 
            this.fgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.fgi.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.fgi.ForeColor = System.Drawing.Color.Black;
            this.fgi.Location = new System.Drawing.Point(80, 260);
            this.fgi.Name = "fgi";
            this.fgi.Size = new System.Drawing.Size(55, 23);
            this.fgi.TabIndex = 53;
            this.fgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fgo
            // 
            this.fgo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(120)))));
            this.fgo.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.fgo.ForeColor = System.Drawing.Color.Black;
            this.fgo.Location = new System.Drawing.Point(10, 260);
            this.fgo.Name = "fgo";
            this.fgo.Size = new System.Drawing.Size(55, 23);
            this.fgo.TabIndex = 53;
            this.fgo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inpr
            // 
            this.inpr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(85)))));
            this.inpr.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.inpr.ForeColor = System.Drawing.Color.Black;
            this.inpr.Location = new System.Drawing.Point(150, 334);
            this.inpr.Name = "inpr";
            this.inpr.Size = new System.Drawing.Size(55, 23);
            this.inpr.TabIndex = 53;
            this.inpr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opcode
            // 
            this.opcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(196)))), ((int)(((byte)(60)))));
            this.opcode.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.opcode.ForeColor = System.Drawing.Color.Black;
            this.opcode.Location = new System.Drawing.Point(80, 334);
            this.opcode.Name = "opcode";
            this.opcode.Size = new System.Drawing.Size(55, 23);
            this.opcode.TabIndex = 53;
            this.opcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outr
            // 
            this.outr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(240)))));
            this.outr.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.outr.ForeColor = System.Drawing.Color.Black;
            this.outr.Location = new System.Drawing.Point(10, 334);
            this.outr.Name = "outr";
            this.outr.Size = new System.Drawing.Size(55, 23);
            this.outr.TabIndex = 53;
            this.outr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(183)))));
            this.line.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Bold);
            this.line.ForeColor = System.Drawing.Color.Black;
            this.line.Location = new System.Drawing.Point(296, 111);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(237, 30);
            this.line.TabIndex = 55;
            this.line.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.label3.Image = global::win1.Properties.Resources.coding__3_1;
            this.label3.Location = new System.Drawing.Point(194, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 30);
            this.label3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(585, 563);
            this.ControlBox = false;
            this.Controls.Add(this.line);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.code);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label outr;
        private System.Windows.Forms.Label opcode;
        private System.Windows.Forms.Label ir;
        private System.Windows.Forms.Label ac;
        private System.Windows.Forms.Label pc;
        private System.Windows.Forms.Label ar;
        private System.Windows.Forms.Label dr;
        private System.Windows.Forms.Label decode;
        private System.Windows.Forms.Label ien;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Label sc;
        private System.Windows.Forms.Label fgi;
        private System.Windows.Forms.Label fgo;
        private System.Windows.Forms.Label inpr;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Button compile;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button stop;
        //private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

