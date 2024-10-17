namespace JobTrackerWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button_loadBD = new Button();
            button_search = new Button();
            tbox_search = new TextBox();
            button_searchco = new Button();
            tbox_searchco = new TextBox();
            button_searchloc = new Button();
            tbox_searchloc = new TextBox();
            button_searchstat = new Button();
            tbox_searchstat = new TextBox();
            label_search = new Label();
            gbox_addjob = new GroupBox();
            button_update = new Button();
            tbox_addID = new TextBox();
            label_coID = new Label();
            button_addapp = new Button();
            tbox_addco = new TextBox();
            tbox_addurl = new TextBox();
            tbox_addstatus = new TextBox();
            tbox_addloc = new TextBox();
            tbox_addtitle = new TextBox();
            label_addco = new Label();
            label_addurl = new Label();
            label_addstatus = new Label();
            label_addloc = new Label();
            label_addtitle = new Label();
            dataGridView2 = new DataGridView();
            label_comGrid = new Label();
            button_Delete = new Button();
            button_followURL = new Button();
            button_compUrl = new Button();
            label_app = new Label();
            gbox_addCo = new GroupBox();
            label_addcomp = new Label();
            tbox_addToCo = new TextBox();
            label_addToURL = new Label();
            tbox_addCoUrl = new TextBox();
            label_cleared = new Label();
            tbox_cleared = new TextBox();
            label_hq = new Label();
            tbox_hq = new TextBox();
            button_addToCo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbox_addjob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            gbox_addCo.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 481);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(2729, 357);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button_loadBD
            // 
            button_loadBD.BackColor = Color.SkyBlue;
            button_loadBD.Location = new Point(503, 12);
            button_loadBD.Name = "button_loadBD";
            button_loadBD.Size = new Size(294, 59);
            button_loadBD.TabIndex = 1;
            button_loadBD.Text = "Load Data";
            button_loadBD.UseVisualStyleBackColor = false;
            button_loadBD.Click += button_loadBD_Click;
            // 
            // button_search
            // 
            button_search.BackColor = Color.SkyBlue;
            button_search.Location = new Point(503, 98);
            button_search.Name = "button_search";
            button_search.Size = new Size(294, 52);
            button_search.TabIndex = 2;
            button_search.Text = "Search Job Title";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // tbox_search
            // 
            tbox_search.Location = new Point(36, 98);
            tbox_search.Multiline = true;
            tbox_search.Name = "tbox_search";
            tbox_search.Size = new Size(447, 52);
            tbox_search.TabIndex = 3;
            // 
            // button_searchco
            // 
            button_searchco.BackColor = Color.SkyBlue;
            button_searchco.Location = new Point(503, 178);
            button_searchco.Name = "button_searchco";
            button_searchco.Size = new Size(294, 64);
            button_searchco.TabIndex = 4;
            button_searchco.Text = "Search Company";
            button_searchco.UseVisualStyleBackColor = false;
            button_searchco.Click += button_searchco_Click;
            // 
            // tbox_searchco
            // 
            tbox_searchco.Location = new Point(36, 178);
            tbox_searchco.Multiline = true;
            tbox_searchco.Name = "tbox_searchco";
            tbox_searchco.Size = new Size(447, 64);
            tbox_searchco.TabIndex = 5;
            // 
            // button_searchloc
            // 
            button_searchloc.BackColor = Color.SkyBlue;
            button_searchloc.Location = new Point(503, 264);
            button_searchloc.Name = "button_searchloc";
            button_searchloc.Size = new Size(294, 66);
            button_searchloc.TabIndex = 6;
            button_searchloc.Text = "Search Location";
            button_searchloc.UseVisualStyleBackColor = false;
            button_searchloc.Click += button_searchloc_Click;
            // 
            // tbox_searchloc
            // 
            tbox_searchloc.Location = new Point(36, 264);
            tbox_searchloc.Multiline = true;
            tbox_searchloc.Name = "tbox_searchloc";
            tbox_searchloc.Size = new Size(447, 66);
            tbox_searchloc.TabIndex = 7;
            // 
            // button_searchstat
            // 
            button_searchstat.BackColor = Color.SkyBlue;
            button_searchstat.Location = new Point(503, 362);
            button_searchstat.Name = "button_searchstat";
            button_searchstat.Size = new Size(294, 56);
            button_searchstat.TabIndex = 8;
            button_searchstat.Text = "Search Status";
            button_searchstat.UseVisualStyleBackColor = false;
            button_searchstat.Click += button_searchstat_Click;
            // 
            // tbox_searchstat
            // 
            tbox_searchstat.Location = new Point(36, 367);
            tbox_searchstat.Multiline = true;
            tbox_searchstat.Name = "tbox_searchstat";
            tbox_searchstat.Size = new Size(447, 51);
            tbox_searchstat.TabIndex = 9;
            // 
            // label_search
            // 
            label_search.AutoSize = true;
            label_search.Location = new Point(152, 30);
            label_search.Name = "label_search";
            label_search.Size = new Size(190, 41);
            label_search.TabIndex = 10;
            label_search.Text = "Search Fields";
            // 
            // gbox_addjob
            // 
            gbox_addjob.BackColor = Color.Transparent;
            gbox_addjob.Controls.Add(button_update);
            gbox_addjob.Controls.Add(tbox_addID);
            gbox_addjob.Controls.Add(label_coID);
            gbox_addjob.Controls.Add(button_addapp);
            gbox_addjob.Controls.Add(tbox_addco);
            gbox_addjob.Controls.Add(tbox_addurl);
            gbox_addjob.Controls.Add(tbox_addstatus);
            gbox_addjob.Controls.Add(tbox_addloc);
            gbox_addjob.Controls.Add(tbox_addtitle);
            gbox_addjob.Controls.Add(label_addco);
            gbox_addjob.Controls.Add(label_addurl);
            gbox_addjob.Controls.Add(label_addstatus);
            gbox_addjob.Controls.Add(label_addloc);
            gbox_addjob.Controls.Add(label_addtitle);
            gbox_addjob.Location = new Point(872, 12);
            gbox_addjob.Name = "gbox_addjob";
            gbox_addjob.Size = new Size(731, 448);
            gbox_addjob.TabIndex = 11;
            gbox_addjob.TabStop = false;
            gbox_addjob.Text = "Add Application";
            // 
            // button_update
            // 
            button_update.BackColor = Color.SkyBlue;
            button_update.Location = new Point(515, 0);
            button_update.Name = "button_update";
            button_update.Size = new Size(188, 58);
            button_update.TabIndex = 15;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // tbox_addID
            // 
            tbox_addID.Location = new Point(176, 378);
            tbox_addID.Name = "tbox_addID";
            tbox_addID.Size = new Size(468, 47);
            tbox_addID.TabIndex = 12;
            // 
            // label_coID
            // 
            label_coID.AutoSize = true;
            label_coID.Location = new Point(6, 378);
            label_coID.Name = "label_coID";
            label_coID.Size = new Size(73, 41);
            label_coID.TabIndex = 11;
            label_coID.Text = "ID #";
            // 
            // button_addapp
            // 
            button_addapp.BackColor = Color.SkyBlue;
            button_addapp.Location = new Point(246, 0);
            button_addapp.Name = "button_addapp";
            button_addapp.Size = new Size(188, 58);
            button_addapp.TabIndex = 10;
            button_addapp.Text = "Add";
            button_addapp.UseVisualStyleBackColor = false;
            button_addapp.Click += button_addapp_Click;
            // 
            // tbox_addco
            // 
            tbox_addco.Location = new Point(176, 320);
            tbox_addco.Name = "tbox_addco";
            tbox_addco.Size = new Size(468, 47);
            tbox_addco.TabIndex = 9;
            // 
            // tbox_addurl
            // 
            tbox_addurl.Location = new Point(176, 255);
            tbox_addurl.Name = "tbox_addurl";
            tbox_addurl.Size = new Size(468, 47);
            tbox_addurl.TabIndex = 8;
            // 
            // tbox_addstatus
            // 
            tbox_addstatus.Location = new Point(176, 189);
            tbox_addstatus.Name = "tbox_addstatus";
            tbox_addstatus.Size = new Size(468, 47);
            tbox_addstatus.TabIndex = 7;
            // 
            // tbox_addloc
            // 
            tbox_addloc.Location = new Point(176, 127);
            tbox_addloc.Name = "tbox_addloc";
            tbox_addloc.Size = new Size(468, 47);
            tbox_addloc.TabIndex = 6;
            // 
            // tbox_addtitle
            // 
            tbox_addtitle.Location = new Point(176, 64);
            tbox_addtitle.Name = "tbox_addtitle";
            tbox_addtitle.Size = new Size(468, 47);
            tbox_addtitle.TabIndex = 5;
            // 
            // label_addco
            // 
            label_addco.AutoSize = true;
            label_addco.Location = new Point(6, 320);
            label_addco.Name = "label_addco";
            label_addco.Size = new Size(146, 41);
            label_addco.TabIndex = 4;
            label_addco.Text = "Company";
            // 
            // label_addurl
            // 
            label_addurl.AutoSize = true;
            label_addurl.Location = new Point(6, 255);
            label_addurl.Name = "label_addurl";
            label_addurl.Size = new Size(146, 41);
            label_addurl.TabIndex = 3;
            label_addurl.Text = "Webpage";
            // 
            // label_addstatus
            // 
            label_addstatus.AutoSize = true;
            label_addstatus.Location = new Point(6, 189);
            label_addstatus.Name = "label_addstatus";
            label_addstatus.Size = new Size(98, 41);
            label_addstatus.TabIndex = 2;
            label_addstatus.Text = "Status";
            // 
            // label_addloc
            // 
            label_addloc.AutoSize = true;
            label_addloc.Location = new Point(6, 127);
            label_addloc.Name = "label_addloc";
            label_addloc.Size = new Size(131, 41);
            label_addloc.TabIndex = 1;
            label_addloc.Text = "Location";
            // 
            // label_addtitle
            // 
            label_addtitle.AutoSize = true;
            label_addtitle.Location = new Point(6, 64);
            label_addtitle.Name = "label_addtitle";
            label_addtitle.Size = new Size(129, 41);
            label_addtitle.TabIndex = 0;
            label_addtitle.Text = "Job Title";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.WhiteSmoke;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(36, 893);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 102;
            dataGridView2.Size = new Size(1567, 246);
            dataGridView2.TabIndex = 12;
            // 
            // label_comGrid
            // 
            label_comGrid.AutoSize = true;
            label_comGrid.Location = new Point(36, 849);
            label_comGrid.Name = "label_comGrid";
            label_comGrid.Size = new Size(146, 41);
            label_comGrid.TabIndex = 13;
            label_comGrid.Text = "Company";
            // 
            // button_Delete
            // 
            button_Delete.BackColor = Color.SkyBlue;
            button_Delete.Location = new Point(1621, 16);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(188, 50);
            button_Delete.TabIndex = 14;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = false;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_followURL
            // 
            button_followURL.BackColor = Color.SkyBlue;
            button_followURL.Location = new Point(1678, 893);
            button_followURL.Name = "button_followURL";
            button_followURL.Size = new Size(344, 61);
            button_followURL.TabIndex = 15;
            button_followURL.Text = "Follow URL";
            button_followURL.UseVisualStyleBackColor = false;
            button_followURL.Click += button_followURL_Click;
            // 
            // button_compUrl
            // 
            button_compUrl.BackColor = Color.SkyBlue;
            button_compUrl.Location = new Point(1678, 987);
            button_compUrl.Name = "button_compUrl";
            button_compUrl.Size = new Size(344, 57);
            button_compUrl.TabIndex = 16;
            button_compUrl.Text = "Company Website";
            button_compUrl.UseVisualStyleBackColor = false;
            button_compUrl.Click += button_compUrl_Click;
            // 
            // label_app
            // 
            label_app.AutoSize = true;
            label_app.Location = new Point(36, 437);
            label_app.Name = "label_app";
            label_app.Size = new Size(168, 41);
            label_app.TabIndex = 17;
            label_app.Text = "Application";
            // 
            // gbox_addCo
            // 
            gbox_addCo.Controls.Add(button_addToCo);
            gbox_addCo.Controls.Add(tbox_hq);
            gbox_addCo.Controls.Add(label_hq);
            gbox_addCo.Controls.Add(tbox_cleared);
            gbox_addCo.Controls.Add(label_cleared);
            gbox_addCo.Controls.Add(tbox_addCoUrl);
            gbox_addCo.Controls.Add(label_addToURL);
            gbox_addCo.Controls.Add(tbox_addToCo);
            gbox_addCo.Controls.Add(label_addcomp);
            gbox_addCo.Location = new Point(1896, 30);
            gbox_addCo.Name = "gbox_addCo";
            gbox_addCo.Size = new Size(808, 430);
            gbox_addCo.TabIndex = 18;
            gbox_addCo.TabStop = false;
            gbox_addCo.Text = "Add Company";
            // 
            // label_addcomp
            // 
            label_addcomp.AutoSize = true;
            label_addcomp.Location = new Point(29, 52);
            label_addcomp.Name = "label_addcomp";
            label_addcomp.Size = new Size(146, 41);
            label_addcomp.TabIndex = 19;
            label_addcomp.Text = "Company";
            // 
            // tbox_addToCo
            // 
            tbox_addToCo.Location = new Point(255, 52);
            tbox_addToCo.Name = "tbox_addToCo";
            tbox_addToCo.Size = new Size(514, 47);
            tbox_addToCo.TabIndex = 20;
            // 
            // label_addToURL
            // 
            label_addToURL.AutoSize = true;
            label_addToURL.Location = new Point(29, 130);
            label_addToURL.Name = "label_addToURL";
            label_addToURL.Size = new Size(203, 41);
            label_addToURL.TabIndex = 21;
            label_addToURL.Text = "Company Site";
            // 
            // tbox_addCoUrl
            // 
            tbox_addCoUrl.Location = new Point(255, 130);
            tbox_addCoUrl.Name = "tbox_addCoUrl";
            tbox_addCoUrl.Size = new Size(514, 47);
            tbox_addCoUrl.TabIndex = 22;
            // 
            // label_cleared
            // 
            label_cleared.AutoSize = true;
            label_cleared.Location = new Point(29, 209);
            label_cleared.Name = "label_cleared";
            label_cleared.Size = new Size(198, 41);
            label_cleared.TabIndex = 23;
            label_cleared.Text = "Cleared Roles";
            // 
            // tbox_cleared
            // 
            tbox_cleared.Location = new Point(255, 209);
            tbox_cleared.Name = "tbox_cleared";
            tbox_cleared.Size = new Size(514, 47);
            tbox_cleared.TabIndex = 24;
            // 
            // label_hq
            // 
            label_hq.AutoSize = true;
            label_hq.Location = new Point(29, 282);
            label_hq.Name = "label_hq";
            label_hq.Size = new Size(197, 41);
            label_hq.TabIndex = 25;
            label_hq.Text = "Headquarters";
            // 
            // tbox_hq
            // 
            tbox_hq.Location = new Point(255, 282);
            tbox_hq.Name = "tbox_hq";
            tbox_hq.Size = new Size(514, 47);
            tbox_hq.TabIndex = 26;
            // 
            // button_addToCo
            // 
            button_addToCo.BackColor = Color.SkyBlue;
            button_addToCo.Location = new Point(255, 354);
            button_addToCo.Name = "button_addToCo";
            button_addToCo.Size = new Size(275, 58);
            button_addToCo.TabIndex = 27;
            button_addToCo.Text = "Add Company";
            button_addToCo.UseVisualStyleBackColor = false;
            button_addToCo.Click += button_addToCo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(2803, 1229);
            Controls.Add(gbox_addCo);
            Controls.Add(label_app);
            Controls.Add(button_compUrl);
            Controls.Add(button_followURL);
            Controls.Add(button_Delete);
            Controls.Add(label_comGrid);
            Controls.Add(dataGridView2);
            Controls.Add(gbox_addjob);
            Controls.Add(label_search);
            Controls.Add(tbox_searchstat);
            Controls.Add(button_searchstat);
            Controls.Add(tbox_searchloc);
            Controls.Add(button_searchloc);
            Controls.Add(tbox_searchco);
            Controls.Add(button_searchco);
            Controls.Add(tbox_search);
            Controls.Add(button_search);
            Controls.Add(button_loadBD);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Job Applications";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbox_addjob.ResumeLayout(false);
            gbox_addjob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            gbox_addCo.ResumeLayout(false);
            gbox_addCo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_loadBD;
        private Button button_search;
        private TextBox tbox_search;
        private Button button_searchco;
        private TextBox tbox_searchco;
        private Button button_searchloc;
        private TextBox tbox_searchloc;
        private Button button_searchstat;
        private TextBox tbox_searchstat;
        private Label label_search;
        private GroupBox gbox_addjob;
        private Label label_addtitle;
        private TextBox tbox_addurl;
        private TextBox tbox_addstatus;
        private TextBox tbox_addloc;
        private TextBox tbox_addtitle;
        private Label label_addco;
        private Label label_addurl;
        private Label label_addstatus;
        private Label label_addloc;
        private Button button_addapp;
        private TextBox tbox_addco;
        private DataGridView dataGridView2;
        private Label label_comGrid;
        private Button button_Delete;
        private TextBox tbox_addID;
        private Label label_coID;
        private Button button_update;
        private Button button_followURL;
        private Button button_compUrl;
        private Label label_app;
        private GroupBox gbox_addCo;
        private TextBox tbox_addCoUrl;
        private Label label_addToURL;
        private TextBox tbox_addToCo;
        private Label label_addcomp;
        private Button button_addToCo;
        private TextBox tbox_hq;
        private Label label_hq;
        private TextBox tbox_cleared;
        private Label label_cleared;
    }
}
