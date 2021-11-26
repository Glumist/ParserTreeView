namespace ParserTreeView
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btParse = new System.Windows.Forms.Button();
            this.tvStructure = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tsTree = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tstbSearchText = new System.Windows.Forms.ToolStripTextBox();
            this.tbFullText = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbParseText = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btTest = new System.Windows.Forms.Button();
            this.tbTestText = new System.Windows.Forms.TextBox();
            this.btShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tsTree.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(20, 45);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(1077, 26);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddress_KeyDown);
            // 
            // btParse
            // 
            this.btParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btParse.Location = new System.Drawing.Point(1105, 41);
            this.btParse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btParse.Name = "btParse";
            this.btParse.Size = new System.Drawing.Size(117, 35);
            this.btParse.TabIndex = 2;
            this.btParse.Text = "Распарсить";
            this.btParse.UseVisualStyleBackColor = true;
            this.btParse.Click += new System.EventHandler(this.btParse_Click);
            // 
            // tvStructure
            // 
            this.tvStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvStructure.Location = new System.Drawing.Point(0, 31);
            this.tvStructure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvStructure.Name = "tvStructure";
            this.tvStructure.Size = new System.Drawing.Size(994, 762);
            this.tvStructure.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvStructure);
            this.splitContainer1.Panel1.Controls.Add(this.tsTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbFullText);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1356, 793);
            this.splitContainer1.SplitterDistance = 994;
            this.splitContainer1.SplitterWidth = 9;
            this.splitContainer1.TabIndex = 5;
            // 
            // tsTree
            // 
            this.tsTree.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTree.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbSearch,
            this.tstbSearchText});
            this.tsTree.Location = new System.Drawing.Point(0, 0);
            this.tsTree.Name = "tsTree";
            this.tsTree.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsTree.Size = new System.Drawing.Size(994, 31);
            this.tsTree.TabIndex = 5;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(95, 28);
            this.toolStripLabel1.Text = "Структура";
            // 
            // tsbSearch
            // 
            this.tsbSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = global::ParserTreeView.Properties.Resources.IconSearch;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(28, 28);
            this.tsbSearch.Text = "Поиск";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tstbSearchText
            // 
            this.tstbSearchText.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbSearchText.Name = "tstbSearchText";
            this.tstbSearchText.Size = new System.Drawing.Size(148, 31);
            this.tstbSearchText.TextChanged += new System.EventHandler(this.tstbSearchText_TextChanged);
            // 
            // tbFullText
            // 
            this.tbFullText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFullText.Location = new System.Drawing.Point(0, 32);
            this.tbFullText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFullText.MaxLength = 999999999;
            this.tbFullText.Multiline = true;
            this.tbFullText.Name = "tbFullText";
            this.tbFullText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFullText.Size = new System.Drawing.Size(353, 761);
            this.tbFullText.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tsbParseText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(353, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 29);
            this.toolStripLabel2.Text = "Текст";
            // 
            // tsbParseText
            // 
            this.tsbParseText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbParseText.Image = ((System.Drawing.Image)(resources.GetObject("tsbParseText.Image")));
            this.tsbParseText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbParseText.Name = "tsbParseText";
            this.tsbParseText.Size = new System.Drawing.Size(107, 29);
            this.tsbParseText.Text = "Распарсить";
            this.tsbParseText.Click += new System.EventHandler(this.btParse_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 137);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer2.Size = new System.Drawing.Size(1356, 985);
            this.splitContainer2.SplitterDistance = 793;
            this.splitContainer2.SplitterWidth = 9;
            this.splitContainer2.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1356, 183);
            this.webBrowser1.TabIndex = 0;
            // 
            // btTest
            // 
            this.btTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTest.Location = new System.Drawing.Point(1226, 90);
            this.btTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(117, 35);
            this.btTest.TabIndex = 7;
            this.btTest.Text = "Test";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // tbTestText
            // 
            this.tbTestText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTestText.Location = new System.Drawing.Point(20, 90);
            this.tbTestText.Name = "tbTestText";
            this.tbTestText.Size = new System.Drawing.Size(1196, 26);
            this.tbTestText.TabIndex = 8;
            // 
            // btShow
            // 
            this.btShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btShow.Location = new System.Drawing.Point(1230, 41);
            this.btShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(117, 35);
            this.btShow.TabIndex = 9;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 1122);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.tbTestText);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.btParse);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Парсер";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tsTree.ResumeLayout(false);
            this.tsTree.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btParse;
        private System.Windows.Forms.TreeView tvStructure;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbFullText;
        private System.Windows.Forms.ToolStrip tsTree;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstbSearchText;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbParseText;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.TextBox tbTestText;
        private System.Windows.Forms.Button btShow;
    }
}

