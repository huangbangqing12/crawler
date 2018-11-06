namespace CrawlHelper
{
    partial class CrawHelper
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.type_list = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_now_reg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_next_reg = new System.Windows.Forms.TextBox();
            this.dgview_data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.btn_link_list = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_enable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // txt_url
            // 
            this.txt_url.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_url.Location = new System.Drawing.Point(82, 12);
            this.txt_url.Multiline = true;
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(711, 62);
            this.txt_url.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(820, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "备注";
            // 
            // txt_mark
            // 
            this.txt_mark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_mark.Location = new System.Drawing.Point(888, 12);
            this.txt_mark.Multiline = true;
            this.txt_mark.Name = "txt_mark";
            this.txt_mark.Size = new System.Drawing.Size(203, 60);
            this.txt_mark.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1113, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "类型";
            // 
            // type_list
            // 
            this.type_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_list.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.type_list.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type_list.FormattingEnabled = true;
            this.type_list.Items.AddRange(new object[] {
            "文本",
            "图片",
            "音频",
            "视频"});
            this.type_list.Location = new System.Drawing.Point(1210, 26);
            this.type_list.Name = "type_list";
            this.type_list.Size = new System.Drawing.Size(123, 28);
            this.type_list.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "页面解析JSON";
            // 
            // txt_now_reg
            // 
            this.txt_now_reg.Location = new System.Drawing.Point(27, 136);
            this.txt_now_reg.Multiline = true;
            this.txt_now_reg.Name = "txt_now_reg";
            this.txt_now_reg.Size = new System.Drawing.Size(504, 152);
            this.txt_now_reg.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(649, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "下个页面解析JSON";
            // 
            // txt_next_reg
            // 
            this.txt_next_reg.Location = new System.Drawing.Point(653, 136);
            this.txt_next_reg.Multiline = true;
            this.txt_next_reg.Name = "txt_next_reg";
            this.txt_next_reg.Size = new System.Drawing.Size(489, 152);
            this.txt_next_reg.TabIndex = 9;
            // 
            // dgview_data
            // 
            this.dgview_data.AllowUserToAddRows = false;
            this.dgview_data.AllowUserToDeleteRows = false;
            this.dgview_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgview_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgview_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgview_data.Location = new System.Drawing.Point(27, 313);
            this.dgview_data.Name = "dgview_data";
            this.dgview_data.ReadOnly = true;
            this.dgview_data.RowTemplate.Height = 27;
            this.dgview_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgview_data.Size = new System.Drawing.Size(1324, 319);
            this.dgview_data.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 52;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "url";
            this.Column2.HeaderText = "URL";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "mark";
            this.Column3.HeaderText = "备注";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 66;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.DataPropertyName = "type";
            this.Column4.HeaderText = "类型";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.ToolTipText = "0-文本，1-图片，2-音频，3-视频";
            this.Column4.Width = 66;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "link_reg";
            this.Column5.HeaderText = "页面解析";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 96;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "next_reg";
            this.Column6.HeaderText = "下一页解析";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 111;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "craw_flag";
            this.Column7.HeaderText = "爬取标志";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 96;
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_del.Location = new System.Drawing.Point(759, 656);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(110, 40);
            this.btn_del.TabIndex = 12;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(27, 658);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(110, 40);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(156, 656);
            this.txt_keyword.Multiline = true;
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(583, 42);
            this.txt_keyword.TabIndex = 15;
            // 
            // btn_link_list
            // 
            this.btn_link_list.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_link_list.Location = new System.Drawing.Point(1167, 656);
            this.btn_link_list.Name = "btn_link_list";
            this.btn_link_list.Size = new System.Drawing.Size(166, 40);
            this.btn_link_list.TabIndex = 11;
            this.btn_link_list.Text = "任务详情";
            this.btn_link_list.UseVisualStyleBackColor = true;
            this.btn_link_list.Click += new System.EventHandler(this.btn_link_list_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clear.Location = new System.Drawing.Point(1210, 236);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(110, 40);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(1210, 125);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 40);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_enable
            // 
            this.btn_enable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_enable.Location = new System.Drawing.Point(888, 656);
            this.btn_enable.Name = "btn_enable";
            this.btn_enable.Size = new System.Drawing.Size(134, 40);
            this.btn_enable.TabIndex = 18;
            this.btn_enable.Text = "全部启用";
            this.btn_enable.UseVisualStyleBackColor = true;
            this.btn_enable.Click += new System.EventHandler(this.btn_enable_Click);
            // 
            // CrawHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 710);
            this.Controls.Add(this.btn_enable);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_keyword);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_link_list);
            this.Controls.Add(this.dgview_data);
            this.Controls.Add(this.txt_next_reg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_now_reg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.type_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CrawHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "爬虫助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrawHelper_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox type_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_now_reg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_next_reg;
        private System.Windows.Forms.DataGridView dgview_data;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_keyword;
        private System.Windows.Forms.Button btn_link_list;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btn_enable;
    }
}

