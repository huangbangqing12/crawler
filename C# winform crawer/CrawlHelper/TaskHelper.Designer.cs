namespace CrawlHelper
{
    partial class TaskHelper
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_reg = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgview_link = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_link)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(87, 12);
            this.txt_url.Multiline = true;
            this.txt_url.Name = "txt_url";
            this.txt_url.ReadOnly = true;
            this.txt_url.Size = new System.Drawing.Size(615, 45);
            this.txt_url.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "子任务解析规则";
            // 
            // txt_reg
            // 
            this.txt_reg.Location = new System.Drawing.Point(12, 112);
            this.txt_reg.Multiline = true;
            this.txt_reg.Name = "txt_reg";
            this.txt_reg.Size = new System.Drawing.Size(447, 59);
            this.txt_reg.TabIndex = 3;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(587, 128);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 43);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "设置";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgview_link
            // 
            this.dgview_link.AllowUserToAddRows = false;
            this.dgview_link.AllowUserToDeleteRows = false;
            this.dgview_link.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_link.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgview_link.Location = new System.Drawing.Point(13, 187);
            this.dgview_link.Name = "dgview_link";
            this.dgview_link.RowTemplate.Height = 27;
            this.dgview_link.Size = new System.Drawing.Size(689, 474);
            this.dgview_link.TabIndex = 7;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.DataPropertyName = "id";
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "href";
            this.Column2.HeaderText = "HREF";
            this.Column2.Name = "Column2";
            this.Column2.Width = 82;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "reg";
            this.Column3.HeaderText = "解析REG";
            this.Column3.Name = "Column3";
            this.Column3.Width = 113;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.DataPropertyName = "craw_flag";
            this.Column4.HeaderText = "爬取标志";
            this.Column4.Name = "Column4";
            this.Column4.Width = 122;
            // 
            // TaskHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 673);
            this.Controls.Add(this.dgview_link);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_reg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskHelper";
            this.Text = "任务助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskHelper_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_link)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_reg;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgview_link;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}