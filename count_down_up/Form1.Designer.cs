
namespace count_down_up
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ss = new System.Windows.Forms.NumericUpDown();
            this.mm = new System.Windows.Forms.NumericUpDown();
            this.hh = new System.Windows.Forms.NumericUpDown();
            this.set_time = new System.Windows.Forms.Label();
            this.now_time = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hh)).BeginInit();
            this.SuspendLayout();
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ss.Location = new System.Drawing.Point(136, 240);
            this.ss.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(50, 34);
            this.ss.TabIndex = 1;
            // 
            // mm
            // 
            this.mm.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mm.Location = new System.Drawing.Point(80, 240);
            this.mm.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(50, 34);
            this.mm.TabIndex = 2;
            this.mm.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // hh
            // 
            this.hh.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hh.Location = new System.Drawing.Point(24, 240);
            this.hh.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hh.Name = "hh";
            this.hh.Size = new System.Drawing.Size(50, 34);
            this.hh.TabIndex = 3;
            this.hh.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // set_time
            // 
            this.set_time.AutoSize = true;
            this.set_time.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.set_time.Location = new System.Drawing.Point(220, 179);
            this.set_time.Name = "set_time";
            this.set_time.Size = new System.Drawing.Size(153, 40);
            this.set_time.TabIndex = 4;
            this.set_time.Text = "--:--:--";
            // 
            // now_time
            // 
            this.now_time.AutoSize = true;
            this.now_time.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.now_time.Location = new System.Drawing.Point(220, 139);
            this.now_time.Name = "now_time";
            this.now_time.Size = new System.Drawing.Size(153, 40);
            this.now_time.TabIndex = 5;
            this.now_time.Text = "--:--:--";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("MS UI Gothic", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.count.Location = new System.Drawing.Point(1, 5);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(406, 134);
            this.count.TabIndex = 0;
            this.count.Text = "X-000";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.start.Location = new System.Drawing.Point(203, 240);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(82, 34);
            this.start.TabIndex = 6;
            this.start.Text = "開始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stop.Location = new System.Drawing.Point(291, 240);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(82, 34);
            this.stop.TabIndex = 7;
            this.stop.Text = "停止";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(17, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "設定時刻";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(17, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "現在時刻";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(486, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.now_time);
            this.Controls.Add(this.set_time);
            this.Controls.Add(this.hh);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.count);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown ss;
        private System.Windows.Forms.NumericUpDown mm;
        private System.Windows.Forms.NumericUpDown hh;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label set_time;
        public System.Windows.Forms.Label now_time;
        public System.Windows.Forms.Label count;
    }
}

