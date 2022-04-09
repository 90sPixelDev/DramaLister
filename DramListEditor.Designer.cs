namespace DramaLister
{
    partial class Drama_Lister_Start
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drama_Lister_Start));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedStatisticsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.genre_chbxlist = new System.Windows.Forms.CheckedListBox();
            this.thoughts_txtbx = new System.Windows.Forms.TextBox();
            this.drama_listbx = new System.Windows.Forms.ListBox();
            this.dramaListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adddrama_contxtmenubtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalDramaNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalDramaCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalDramaRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalDramaCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drama_info_grpbx = new System.Windows.Forms.GroupBox();
            this.wellmade_chbx = new System.Windows.Forms.CheckBox();
            this.popular_chbx = new System.Windows.Forms.CheckBox();
            this.fave_chbx = new System.Windows.Forms.CheckBox();
            this.basicinfo_pnl = new System.Windows.Forms.Panel();
            this.name_txtbx = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.country_cbbx = new System.Windows.Forms.ComboBox();
            this.ep_count_lbl = new System.Windows.Forms.Label();
            this.ep_count_txtbx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rating_trckbr = new System.Windows.Forms.TrackBar();
            this.rating_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trope_txtbx = new System.Windows.Forms.TextBox();
            this.addtrope_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tropes_listbx = new System.Windows.Forms.ListBox();
            this.tropeListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletetrope_Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dramaListContext.SuspendLayout();
            this.drama_info_grpbx.SuspendLayout();
            this.basicinfo_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rating_trckbr)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tropeListContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save ...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loadToolStripMenuItem.Text = "Load ...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedStatisticsToolStripMenuItem,
            this.advancedStatisticsToolStripMenuItem1});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // advancedStatisticsToolStripMenuItem
            // 
            this.advancedStatisticsToolStripMenuItem.Name = "advancedStatisticsToolStripMenuItem";
            this.advancedStatisticsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.advancedStatisticsToolStripMenuItem.Text = "Basic Statistics";
            this.advancedStatisticsToolStripMenuItem.Click += new System.EventHandler(this.basicStatisticsToolStripMenuItem_Click);
            // 
            // advancedStatisticsToolStripMenuItem1
            // 
            this.advancedStatisticsToolStripMenuItem1.Name = "advancedStatisticsToolStripMenuItem1";
            this.advancedStatisticsToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.advancedStatisticsToolStripMenuItem1.Text = "Advanced Statistics";
            this.advancedStatisticsToolStripMenuItem1.Click += new System.EventHandler(this.advancedStatisticsToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.68047F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.34911F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.thoughts_txtbx, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.drama_listbx, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.drama_info_grpbx, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 501);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.genre_chbxlist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(214, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 104);
            this.panel2.TabIndex = 16;
            // 
            // genre_chbxlist
            // 
            this.genre_chbxlist.BackColor = System.Drawing.Color.DimGray;
            this.genre_chbxlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genre_chbxlist.CheckOnClick = true;
            this.genre_chbxlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genre_chbxlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_chbxlist.ForeColor = System.Drawing.SystemColors.Menu;
            this.genre_chbxlist.FormattingEnabled = true;
            this.genre_chbxlist.Items.AddRange(new object[] {
            "Romance",
            "Action",
            "Horror",
            "Fantasy",
            "Wuxia",
            "Comedy",
            "BL",
            "Drama",
            "Melodrama",
            "Sci-Fi",
            "Sports",
            "Thriller",
            "Web Drama",
            "Historical"});
            this.genre_chbxlist.Location = new System.Drawing.Point(0, 0);
            this.genre_chbxlist.MultiColumn = true;
            this.genre_chbxlist.Name = "genre_chbxlist";
            this.genre_chbxlist.Size = new System.Drawing.Size(379, 104);
            this.genre_chbxlist.TabIndex = 5;
            this.genre_chbxlist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.genre_chbxlist_MouseDown);
            // 
            // thoughts_txtbx
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.thoughts_txtbx, 2);
            this.thoughts_txtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thoughts_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoughts_txtbx.Location = new System.Drawing.Point(214, 323);
            this.thoughts_txtbx.Multiline = true;
            this.thoughts_txtbx.Name = "thoughts_txtbx";
            this.thoughts_txtbx.Size = new System.Drawing.Size(628, 175);
            this.thoughts_txtbx.TabIndex = 19;
            this.thoughts_txtbx.Leave += new System.EventHandler(this.thoughts_txtbx_Leave);
            // 
            // drama_listbx
            // 
            this.drama_listbx.ContextMenuStrip = this.dramaListContext;
            this.drama_listbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drama_listbx.FormattingEnabled = true;
            this.drama_listbx.ItemHeight = 16;
            this.drama_listbx.Items.AddRange(new object[] {
            "New Drama"});
            this.drama_listbx.Location = new System.Drawing.Point(3, 3);
            this.drama_listbx.Name = "drama_listbx";
            this.drama_listbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.SetRowSpan(this.drama_listbx, 4);
            this.drama_listbx.Size = new System.Drawing.Size(205, 495);
            this.drama_listbx.TabIndex = 0;
            this.drama_listbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drama_listbx_MouseClick);
            // 
            // dramaListContext
            // 
            this.dramaListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adddrama_contxtmenubtn,
            this.deleteDramaToolStripMenuItem,
            this.testButtonsToolStripMenuItem});
            this.dramaListContext.Name = "contxtmenu";
            this.dramaListContext.Size = new System.Drawing.Size(146, 70);
            this.dramaListContext.Text = "Edit";
            // 
            // adddrama_contxtmenubtn
            // 
            this.adddrama_contxtmenubtn.Name = "adddrama_contxtmenubtn";
            this.adddrama_contxtmenubtn.Size = new System.Drawing.Size(145, 22);
            this.adddrama_contxtmenubtn.Text = "Add Drama";
            this.adddrama_contxtmenubtn.ToolTipText = "Add Drama to your List!";
            this.adddrama_contxtmenubtn.Click += new System.EventHandler(this.adddrama_contxtmenubtn_Click);
            // 
            // deleteDramaToolStripMenuItem
            // 
            this.deleteDramaToolStripMenuItem.Name = "deleteDramaToolStripMenuItem";
            this.deleteDramaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteDramaToolStripMenuItem.Text = "Delete Drama";
            this.deleteDramaToolStripMenuItem.Click += new System.EventHandler(this.deleteDramaToolStripMenuItem_Click);
            // 
            // testButtonsToolStripMenuItem
            // 
            this.testButtonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalDramaNameToolStripMenuItem,
            this.originalDramaCountToolStripMenuItem,
            this.originalDramaRatingToolStripMenuItem,
            this.originalDramaCountryToolStripMenuItem,
            this.averageRatingToolStripMenuItem});
            this.testButtonsToolStripMenuItem.Name = "testButtonsToolStripMenuItem";
            this.testButtonsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.testButtonsToolStripMenuItem.Text = "Test Buttons";
            // 
            // originalDramaNameToolStripMenuItem
            // 
            this.originalDramaNameToolStripMenuItem.Name = "originalDramaNameToolStripMenuItem";
            this.originalDramaNameToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.originalDramaNameToolStripMenuItem.Text = "Original Drama Name";
            this.originalDramaNameToolStripMenuItem.Click += new System.EventHandler(this.originalDramaNameToolStripMenuItem_Click);
            // 
            // originalDramaCountToolStripMenuItem
            // 
            this.originalDramaCountToolStripMenuItem.Name = "originalDramaCountToolStripMenuItem";
            this.originalDramaCountToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.originalDramaCountToolStripMenuItem.Text = "Original Drama Count";
            this.originalDramaCountToolStripMenuItem.Click += new System.EventHandler(this.originalDramaCountToolStripMenuItem_Click);
            // 
            // originalDramaRatingToolStripMenuItem
            // 
            this.originalDramaRatingToolStripMenuItem.Name = "originalDramaRatingToolStripMenuItem";
            this.originalDramaRatingToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.originalDramaRatingToolStripMenuItem.Text = "Original Drama Rating";
            this.originalDramaRatingToolStripMenuItem.Click += new System.EventHandler(this.originalDramaRatingToolStripMenuItem_Click);
            // 
            // originalDramaCountryToolStripMenuItem
            // 
            this.originalDramaCountryToolStripMenuItem.Name = "originalDramaCountryToolStripMenuItem";
            this.originalDramaCountryToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.originalDramaCountryToolStripMenuItem.Text = "Original Drama Country";
            this.originalDramaCountryToolStripMenuItem.Click += new System.EventHandler(this.originalDramaCountryToolStripMenuItem_Click);
            // 
            // averageRatingToolStripMenuItem
            // 
            this.averageRatingToolStripMenuItem.Name = "averageRatingToolStripMenuItem";
            this.averageRatingToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.averageRatingToolStripMenuItem.Text = "Average Rating";
            this.averageRatingToolStripMenuItem.Click += new System.EventHandler(this.averageRatingToolStripMenuItem_Click);
            // 
            // drama_info_grpbx
            // 
            this.drama_info_grpbx.Controls.Add(this.wellmade_chbx);
            this.drama_info_grpbx.Controls.Add(this.popular_chbx);
            this.drama_info_grpbx.Controls.Add(this.fave_chbx);
            this.drama_info_grpbx.Controls.Add(this.basicinfo_pnl);
            this.drama_info_grpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drama_info_grpbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drama_info_grpbx.Location = new System.Drawing.Point(214, 3);
            this.drama_info_grpbx.Name = "drama_info_grpbx";
            this.drama_info_grpbx.Size = new System.Drawing.Size(379, 124);
            this.drama_info_grpbx.TabIndex = 1;
            this.drama_info_grpbx.TabStop = false;
            this.drama_info_grpbx.Text = "Drama Information";
            // 
            // wellmade_chbx
            // 
            this.wellmade_chbx.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.wellmade_chbx.AutoSize = true;
            this.wellmade_chbx.ForeColor = System.Drawing.Color.Gold;
            this.wellmade_chbx.Location = new System.Drawing.Point(271, 73);
            this.wellmade_chbx.Name = "wellmade_chbx";
            this.wellmade_chbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wellmade_chbx.Size = new System.Drawing.Size(101, 20);
            this.wellmade_chbx.TabIndex = 11;
            this.wellmade_chbx.Text = "Well Made";
            this.wellmade_chbx.UseVisualStyleBackColor = true;
            // 
            // popular_chbx
            // 
            this.popular_chbx.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.popular_chbx.AutoSize = true;
            this.popular_chbx.ForeColor = System.Drawing.Color.RoyalBlue;
            this.popular_chbx.Location = new System.Drawing.Point(291, 47);
            this.popular_chbx.Name = "popular_chbx";
            this.popular_chbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.popular_chbx.Size = new System.Drawing.Size(81, 20);
            this.popular_chbx.TabIndex = 10;
            this.popular_chbx.Text = "Popular";
            this.popular_chbx.UseVisualStyleBackColor = true;
            // 
            // fave_chbx
            // 
            this.fave_chbx.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fave_chbx.AutoSize = true;
            this.fave_chbx.ForeColor = System.Drawing.Color.Red;
            this.fave_chbx.Location = new System.Drawing.Point(288, 21);
            this.fave_chbx.Name = "fave_chbx";
            this.fave_chbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fave_chbx.Size = new System.Drawing.Size(84, 20);
            this.fave_chbx.TabIndex = 9;
            this.fave_chbx.Text = "Favorite";
            this.fave_chbx.UseVisualStyleBackColor = true;
            this.fave_chbx.CheckedChanged += new System.EventHandler(this.fave_chbx_CheckedChanged);
            // 
            // basicinfo_pnl
            // 
            this.basicinfo_pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.basicinfo_pnl.Controls.Add(this.name_txtbx);
            this.basicinfo_pnl.Controls.Add(this.name_lbl);
            this.basicinfo_pnl.Controls.Add(this.country_cbbx);
            this.basicinfo_pnl.Controls.Add(this.ep_count_lbl);
            this.basicinfo_pnl.Controls.Add(this.ep_count_txtbx);
            this.basicinfo_pnl.Location = new System.Drawing.Point(6, 21);
            this.basicinfo_pnl.Name = "basicinfo_pnl";
            this.basicinfo_pnl.Size = new System.Drawing.Size(259, 95);
            this.basicinfo_pnl.TabIndex = 6;
            // 
            // name_txtbx
            // 
            this.name_txtbx.Location = new System.Drawing.Point(57, 6);
            this.name_txtbx.Name = "name_txtbx";
            this.name_txtbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name_txtbx.Size = new System.Drawing.Size(194, 22);
            this.name_txtbx.TabIndex = 1;
            this.name_txtbx.Leave += new System.EventHandler(this.name_txtbx_Leave);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(3, 9);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(48, 16);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Name:";
            // 
            // country_cbbx
            // 
            this.country_cbbx.AutoCompleteCustomSource.AddRange(new string[] {
            "Chinese",
            "Korean",
            "Taiwanse",
            "Lakorn"});
            this.country_cbbx.BackColor = System.Drawing.Color.White;
            this.country_cbbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.country_cbbx.FormattingEnabled = true;
            this.country_cbbx.Items.AddRange(new object[] {
            "China",
            "Korea",
            "Taiwan",
            "Thailand",
            "Japan",
            "Philipines",
            "Mexico",
            "Brazil",
            "Spain"});
            this.country_cbbx.Location = new System.Drawing.Point(6, 62);
            this.country_cbbx.Name = "country_cbbx";
            this.country_cbbx.Size = new System.Drawing.Size(245, 24);
            this.country_cbbx.TabIndex = 4;
            this.country_cbbx.Text = "Country";
            this.country_cbbx.Leave += new System.EventHandler(this.country_cbbx_Leave);
            // 
            // ep_count_lbl
            // 
            this.ep_count_lbl.AutoSize = true;
            this.ep_count_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ep_count_lbl.Location = new System.Drawing.Point(3, 37);
            this.ep_count_lbl.Name = "ep_count_lbl";
            this.ep_count_lbl.Size = new System.Drawing.Size(99, 16);
            this.ep_count_lbl.TabIndex = 2;
            this.ep_count_lbl.Text = "Episode Count:";
            // 
            // ep_count_txtbx
            // 
            this.ep_count_txtbx.Location = new System.Drawing.Point(126, 34);
            this.ep_count_txtbx.Name = "ep_count_txtbx";
            this.ep_count_txtbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ep_count_txtbx.Size = new System.Drawing.Size(125, 22);
            this.ep_count_txtbx.TabIndex = 3;
            this.ep_count_txtbx.TextChanged += new System.EventHandler(this.ep_count_txtbx_TextChanged);
            this.ep_count_txtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ep_count_txtbx_KeyPress);
            this.ep_count_txtbx.Leave += new System.EventHandler(this.ep_count_txtbx_Leave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rating_trckbr);
            this.panel1.Controls.Add(this.rating_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(214, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 74);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rating:";
            // 
            // rating_trckbr
            // 
            this.rating_trckbr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rating_trckbr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rating_trckbr.Location = new System.Drawing.Point(0, 25);
            this.rating_trckbr.Maximum = 30;
            this.rating_trckbr.Name = "rating_trckbr";
            this.rating_trckbr.Size = new System.Drawing.Size(624, 45);
            this.rating_trckbr.TabIndex = 12;
            this.rating_trckbr.ValueChanged += new System.EventHandler(this.rating_trckbr_ValueChanged);
            // 
            // rating_lbl
            // 
            this.rating_lbl.AutoSize = true;
            this.rating_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating_lbl.Location = new System.Drawing.Point(66, 4);
            this.rating_lbl.Name = "rating_lbl";
            this.rating_lbl.Size = new System.Drawing.Size(16, 16);
            this.rating_lbl.TabIndex = 13;
            this.rating_lbl.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.trope_txtbx);
            this.panel3.Controls.Add(this.addtrope_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(599, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 104);
            this.panel3.TabIndex = 21;
            // 
            // trope_txtbx
            // 
            this.trope_txtbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trope_txtbx.Location = new System.Drawing.Point(40, 25);
            this.trope_txtbx.Name = "trope_txtbx";
            this.trope_txtbx.Size = new System.Drawing.Size(164, 22);
            this.trope_txtbx.TabIndex = 7;
            // 
            // addtrope_btn
            // 
            this.addtrope_btn.BackColor = System.Drawing.Color.White;
            this.addtrope_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtrope_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtrope_btn.Location = new System.Drawing.Point(40, 53);
            this.addtrope_btn.Name = "addtrope_btn";
            this.addtrope_btn.Size = new System.Drawing.Size(164, 29);
            this.addtrope_btn.TabIndex = 8;
            this.addtrope_btn.Text = "Add Trope";
            this.addtrope_btn.UseVisualStyleBackColor = false;
            this.addtrope_btn.Click += new System.EventHandler(this.addtrope_btn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tropes_listbx);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(599, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 124);
            this.panel4.TabIndex = 22;
            // 
            // tropes_listbx
            // 
            this.tropes_listbx.ContextMenuStrip = this.tropeListContext;
            this.tropes_listbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tropes_listbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tropes_listbx.FormattingEnabled = true;
            this.tropes_listbx.ItemHeight = 16;
            this.tropes_listbx.Location = new System.Drawing.Point(0, 0);
            this.tropes_listbx.Name = "tropes_listbx";
            this.tropes_listbx.Size = new System.Drawing.Size(243, 124);
            this.tropes_listbx.TabIndex = 6;
            // 
            // tropeListContext
            // 
            this.tropeListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletetrope_Btn});
            this.tropeListContext.Name = "tropeListContext";
            this.tropeListContext.Size = new System.Drawing.Size(140, 26);
            // 
            // deletetrope_Btn
            // 
            this.deletetrope_Btn.Name = "deletetrope_Btn";
            this.deletetrope_Btn.Size = new System.Drawing.Size(139, 22);
            this.deletetrope_Btn.Text = "Delete Trope";
            this.deletetrope_Btn.Click += new System.EventHandler(this.deletetrope_Btn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Drama_Lister_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(845, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Drama_Lister_Start";
            this.Text = "Drama Lister";
            this.Load += new System.EventHandler(this.Drama_Lister_Start_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.dramaListContext.ResumeLayout(false);
            this.drama_info_grpbx.ResumeLayout(false);
            this.drama_info_grpbx.PerformLayout();
            this.basicinfo_pnl.ResumeLayout(false);
            this.basicinfo_pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rating_trckbr)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tropeListContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox drama_listbx;
        private System.Windows.Forms.GroupBox drama_info_grpbx;
        private System.Windows.Forms.TextBox ep_count_txtbx;
        private System.Windows.Forms.Label ep_count_lbl;
        private System.Windows.Forms.TextBox name_txtbx;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ComboBox country_cbbx;
        private System.Windows.Forms.CheckedListBox genre_chbxlist;
        private System.Windows.Forms.Panel basicinfo_pnl;
        private System.Windows.Forms.TrackBar rating_trckbr;
        private System.Windows.Forms.CheckBox wellmade_chbx;
        private System.Windows.Forms.CheckBox popular_chbx;
        private System.Windows.Forms.CheckBox fave_chbx;
        private System.Windows.Forms.Label rating_lbl;
        private System.Windows.Forms.TextBox thoughts_txtbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addtrope_btn;
        private System.Windows.Forms.TextBox trope_txtbx;
        private System.Windows.Forms.ListBox tropes_listbx;
        private System.Windows.Forms.ContextMenuStrip dramaListContext;
        private System.Windows.Forms.ToolStripMenuItem adddrama_contxtmenubtn;
        private System.Windows.Forms.ToolStripMenuItem deleteDramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalDramaCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalDramaNameToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem originalDramaRatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalDramaCountryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip tropeListContext;
        private System.Windows.Forms.ToolStripMenuItem deletetrope_Btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem advancedStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedStatisticsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem averageRatingToolStripMenuItem;
    }
}

