namespace 文件检测
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
            this.textBox_mulu = new System.Windows.Forms.TextBox();
            this.liulan = new System.Windows.Forms.Button();
            this.textBox_mubiao = new System.Windows.Forms.TextBox();
            this.mubiao = new System.Windows.Forms.Button();
            this.begin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_mulu
            // 
            this.textBox_mulu.Location = new System.Drawing.Point(12, 25);
            this.textBox_mulu.Name = "textBox_mulu";
            this.textBox_mulu.Size = new System.Drawing.Size(353, 21);
            this.textBox_mulu.TabIndex = 0;
            // 
            // liulan
            // 
            this.liulan.Location = new System.Drawing.Point(371, 25);
            this.liulan.Name = "liulan";
            this.liulan.Size = new System.Drawing.Size(75, 23);
            this.liulan.TabIndex = 1;
            this.liulan.Text = "浏览";
            this.liulan.UseVisualStyleBackColor = true;
            this.liulan.Click += new System.EventHandler(this.liulan_Click);
            // 
            // textBox_mubiao
            // 
            this.textBox_mubiao.Location = new System.Drawing.Point(12, 68);
            this.textBox_mubiao.Name = "textBox_mubiao";
            this.textBox_mubiao.Size = new System.Drawing.Size(353, 21);
            this.textBox_mubiao.TabIndex = 2;
            // 
            // mubiao
            // 
            this.mubiao.Location = new System.Drawing.Point(371, 68);
            this.mubiao.Name = "mubiao";
            this.mubiao.Size = new System.Drawing.Size(75, 23);
            this.mubiao.TabIndex = 3;
            this.mubiao.Text = "目标文件";
            this.mubiao.UseVisualStyleBackColor = true;
            this.mubiao.Click += new System.EventHandler(this.mubiao_Click);
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(12, 132);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(75, 23);
            this.begin.TabIndex = 4;
            this.begin.Text = "开始检测";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 182);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.mubiao);
            this.Controls.Add(this.textBox_mubiao);
            this.Controls.Add(this.liulan);
            this.Controls.Add(this.textBox_mulu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件检测";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_mulu;
        private System.Windows.Forms.Button liulan;
        private System.Windows.Forms.TextBox textBox_mubiao;
        private System.Windows.Forms.Button mubiao;
        private System.Windows.Forms.Button begin;
    }
}

