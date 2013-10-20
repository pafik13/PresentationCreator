namespace WindowsFormsApplication1
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьПрезентациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТематикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panTree = new System.Windows.Forms.Panel();
            this.tvPresentations = new System.Windows.Forms.TreeView();
            this.btnDownTheme = new System.Windows.Forms.Button();
            this.il_24 = new System.Windows.Forms.ImageList(this.components);
            this.btnUpTheme = new System.Windows.Forms.Button();
            this.btnAddTheme = new System.Windows.Forms.Button();
            this.il_16 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddPresantation = new System.Windows.Forms.Button();
            this.panDetail = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AddImg = new System.Windows.Forms.Button();
            this.lvImages = new System.Windows.Forms.ListView();
            this.il_128_80 = new System.Windows.Forms.ImageList(this.components);
            this.splDetail = new System.Windows.Forms.Splitter();
            this.il_32 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panTree.SuspendLayout();
            this.panDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПрезентациюToolStripMenuItem,
            this.добавитьТематикуToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 48);
            // 
            // добавитьПрезентациюToolStripMenuItem
            // 
            this.добавитьПрезентациюToolStripMenuItem.Name = "добавитьПрезентациюToolStripMenuItem";
            this.добавитьПрезентациюToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.добавитьПрезентациюToolStripMenuItem.Text = "Добавить презентацию";
            this.добавитьПрезентациюToolStripMenuItem.Click += new System.EventHandler(this.добавитьПрезентациюToolStripMenuItem_Click);
            // 
            // добавитьТематикуToolStripMenuItem
            // 
            this.добавитьТематикуToolStripMenuItem.Name = "добавитьТематикуToolStripMenuItem";
            this.добавитьТематикуToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.добавитьТематикуToolStripMenuItem.Text = "Добавить тематику";
            this.добавитьТематикуToolStripMenuItem.Click += new System.EventHandler(this.добавитьТематикуToolStripMenuItem_Click);
            // 
            // panTree
            // 
            this.panTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTree.Controls.Add(this.tvPresentations);
            this.panTree.Controls.Add(this.btnDownTheme);
            this.panTree.Controls.Add(this.btnUpTheme);
            this.panTree.Controls.Add(this.btnAddTheme);
            this.panTree.Controls.Add(this.btnAddPresantation);
            this.panTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.panTree.Location = new System.Drawing.Point(0, 0);
            this.panTree.MinimumSize = new System.Drawing.Size(280, 2);
            this.panTree.Name = "panTree";
            this.panTree.Size = new System.Drawing.Size(280, 392);
            this.panTree.TabIndex = 1;
            // 
            // tvPresentations
            // 
            this.tvPresentations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvPresentations.HideSelection = false;
            this.tvPresentations.ImageIndex = 4;
            this.tvPresentations.ImageList = this.il_16;
            this.tvPresentations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tvPresentations.Location = new System.Drawing.Point(11, 47);
            this.tvPresentations.Name = "tvPresentations";
            this.tvPresentations.SelectedImageIndex = 5;
            this.tvPresentations.Size = new System.Drawing.Size(262, 340);
            this.tvPresentations.TabIndex = 4;
            this.tvPresentations.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPresentations_AfterSelect);
            // 
            // btnDownTheme
            // 
            this.btnDownTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownTheme.ImageIndex = 1;
            this.btnDownTheme.ImageList = this.il_24;
            this.btnDownTheme.Location = new System.Drawing.Point(243, 11);
            this.btnDownTheme.Name = "btnDownTheme";
            this.btnDownTheme.Size = new System.Drawing.Size(30, 30);
            this.btnDownTheme.TabIndex = 3;
            this.btnDownTheme.UseVisualStyleBackColor = true;
            // 
            // il_24
            // 
            this.il_24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_24.ImageStream")));
            this.il_24.TransparentColor = System.Drawing.Color.Transparent;
            this.il_24.Images.SetKeyName(0, "gnome_go_up.png");
            this.il_24.Images.SetKeyName(1, "gnome_go_down.png");
            // 
            // btnUpTheme
            // 
            this.btnUpTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpTheme.ImageIndex = 0;
            this.btnUpTheme.ImageList = this.il_24;
            this.btnUpTheme.Location = new System.Drawing.Point(207, 11);
            this.btnUpTheme.Name = "btnUpTheme";
            this.btnUpTheme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpTheme.Size = new System.Drawing.Size(30, 30);
            this.btnUpTheme.TabIndex = 2;
            this.btnUpTheme.UseVisualStyleBackColor = true;
            // 
            // btnAddTheme
            // 
            this.btnAddTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTheme.ImageIndex = 0;
            this.btnAddTheme.ImageList = this.il_16;
            this.btnAddTheme.Location = new System.Drawing.Point(117, 11);
            this.btnAddTheme.Name = "btnAddTheme";
            this.btnAddTheme.Size = new System.Drawing.Size(84, 30);
            this.btnAddTheme.TabIndex = 1;
            this.btnAddTheme.Text = "Тематика";
            this.btnAddTheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTheme.UseVisualStyleBackColor = true;
            this.btnAddTheme.Click += new System.EventHandler(this.btnAddTheme_Click);
            // 
            // il_16
            // 
            this.il_16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_16.ImageStream")));
            this.il_16.TransparentColor = System.Drawing.Color.Transparent;
            this.il_16.Images.SetKeyName(0, "plus.png");
            this.il_16.Images.SetKeyName(1, "gnome_go_up.png");
            this.il_16.Images.SetKeyName(2, "gnome_go_down.png");
            this.il_16.Images.SetKeyName(3, "presentation.png");
            this.il_16.Images.SetKeyName(4, "slides.png");
            this.il_16.Images.SetKeyName(5, "arrow_right.png");
            // 
            // btnAddPresantation
            // 
            this.btnAddPresantation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPresantation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPresantation.ImageIndex = 0;
            this.btnAddPresantation.ImageList = this.il_16;
            this.btnAddPresantation.Location = new System.Drawing.Point(11, 11);
            this.btnAddPresantation.Name = "btnAddPresantation";
            this.btnAddPresantation.Size = new System.Drawing.Size(100, 30);
            this.btnAddPresantation.TabIndex = 0;
            this.btnAddPresantation.Text = "Презентация";
            this.btnAddPresantation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPresantation.UseVisualStyleBackColor = true;
            this.btnAddPresantation.Click += new System.EventHandler(this.btnAddPresantation_Click);
            // 
            // panDetail
            // 
            this.panDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDetail.Controls.Add(this.button2);
            this.panDetail.Controls.Add(this.button1);
            this.panDetail.Controls.Add(this.pictureBox1);
            this.panDetail.Controls.Add(this.btn_AddImg);
            this.panDetail.Controls.Add(this.lvImages);
            this.panDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDetail.Location = new System.Drawing.Point(280, 0);
            this.panDetail.Name = "panDetail";
            this.panDetail.Size = new System.Drawing.Size(450, 392);
            this.panDetail.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_AddImg
            // 
            this.btn_AddImg.Enabled = false;
            this.btn_AddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddImg.ImageIndex = 0;
            this.btn_AddImg.ImageList = this.il_16;
            this.btn_AddImg.Location = new System.Drawing.Point(10, 11);
            this.btn_AddImg.Name = "btn_AddImg";
            this.btn_AddImg.Size = new System.Drawing.Size(70, 30);
            this.btn_AddImg.TabIndex = 3;
            this.btn_AddImg.Text = "Слайд";
            this.btn_AddImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddImg.UseVisualStyleBackColor = true;
            this.btn_AddImg.Click += new System.EventHandler(this.btn_AddImg_Click);
            // 
            // lvImages
            // 
            this.lvImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvImages.LargeImageList = this.il_128_80;
            this.lvImages.Location = new System.Drawing.Point(10, 47);
            this.lvImages.MultiSelect = false;
            this.lvImages.Name = "lvImages";
            this.lvImages.Size = new System.Drawing.Size(435, 110);
            this.lvImages.TabIndex = 2;
            this.lvImages.UseCompatibleStateImageBehavior = false;
            this.lvImages.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvImages_ItemSelectionChanged);
            this.lvImages.SelectedIndexChanged += new System.EventHandler(this.lvImages_SelectedIndexChanged);
            // 
            // il_128_80
            // 
            this.il_128_80.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il_128_80.ImageSize = new System.Drawing.Size(128, 80);
            this.il_128_80.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splDetail
            // 
            this.splDetail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splDetail.Location = new System.Drawing.Point(280, 0);
            this.splDetail.Name = "splDetail";
            this.splDetail.Size = new System.Drawing.Size(5, 392);
            this.splDetail.TabIndex = 3;
            this.splDetail.TabStop = false;
            // 
            // il_32
            // 
            this.il_32.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il_32.ImageSize = new System.Drawing.Size(32, 32);
            this.il_32.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "SaveToXml";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "LoadFromXml";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 392);
            this.Controls.Add(this.splDetail);
            this.Controls.Add(this.panDetail);
            this.Controls.Add(this.panTree);
            this.Name = "Main";
            this.Text = "Главная форма";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panTree.ResumeLayout(false);
            this.panDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьПрезентациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТематикуToolStripMenuItem;
        private System.Windows.Forms.Panel panTree;
        private System.Windows.Forms.Panel panDetail;
        private System.Windows.Forms.Splitter splDetail;
        private System.Windows.Forms.Button btnDownTheme;
        private System.Windows.Forms.ImageList il_24;
        private System.Windows.Forms.Button btnUpTheme;
        private System.Windows.Forms.Button btnAddTheme;
        private System.Windows.Forms.ImageList il_16;
        private System.Windows.Forms.Button btnAddPresantation;
        private System.Windows.Forms.ImageList il_32;
        private System.Windows.Forms.ListView lvImages;
        private System.Windows.Forms.Button btn_AddImg;
        private System.Windows.Forms.ImageList il_128_80;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView tvPresentations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}