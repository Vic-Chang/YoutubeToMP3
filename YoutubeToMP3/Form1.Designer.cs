namespace YoutubeToMP3
{
    partial class form_main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_preview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.wb_youtube = new System.Windows.Forms.WebBrowser();
            this.btn_download_video = new System.Windows.Forms.Button();
            this.btn_audio_video = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_mp3_quality = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_mp4_quality = new System.Windows.Forms.ComboBox();
            this.tb_file_save_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_open_folder = new System.Windows.Forms.Button();
            this.tb_file_name = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbc_downPanel = new System.Windows.Forms.TabControl();
            this.tab_downloading = new System.Windows.Forms.TabPage();
            this.tab_finish = new System.Windows.Forms.TabPage();
            this.lv_downloading = new System.Windows.Forms.ListView();
            this.lv_finished = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbc_downPanel.SuspendLayout();
            this.tab_downloading.SuspendLayout();
            this.tab_finish.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_preview.Location = new System.Drawing.Point(312, 11);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(78, 50);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.Text = "分析網址";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "網址";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(41, 11);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(265, 22);
            this.tb_url.TabIndex = 2;
            // 
            // wb_youtube
            // 
            this.wb_youtube.Location = new System.Drawing.Point(396, 11);
            this.wb_youtube.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_youtube.Name = "wb_youtube";
            this.wb_youtube.Size = new System.Drawing.Size(578, 343);
            this.wb_youtube.TabIndex = 7;
            // 
            // btn_download_video
            // 
            this.btn_download_video.Location = new System.Drawing.Point(17, 75);
            this.btn_download_video.Name = "btn_download_video";
            this.btn_download_video.Size = new System.Drawing.Size(121, 44);
            this.btn_download_video.TabIndex = 8;
            this.btn_download_video.Text = "下載影片(mp4)";
            this.btn_download_video.UseVisualStyleBackColor = true;
            this.btn_download_video.Click += new System.EventHandler(this.btn_download_video_Click);
            // 
            // btn_audio_video
            // 
            this.btn_audio_video.Location = new System.Drawing.Point(19, 75);
            this.btn_audio_video.Name = "btn_audio_video";
            this.btn_audio_video.Size = new System.Drawing.Size(121, 44);
            this.btn_audio_video.TabIndex = 9;
            this.btn_audio_video.Text = "下載音樂(mp3)";
            this.btn_audio_video.UseVisualStyleBackColor = true;
            this.btn_audio_video.Click += new System.EventHandler(this.btn_download_audio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_mp3_quality);
            this.groupBox1.Controls.Add(this.btn_audio_video);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 136);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MP3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "音樂音質:";
            // 
            // cb_mp3_quality
            // 
            this.cb_mp3_quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mp3_quality.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_mp3_quality.FormattingEnabled = true;
            this.cb_mp3_quality.Location = new System.Drawing.Point(19, 49);
            this.cb_mp3_quality.Name = "cb_mp3_quality";
            this.cb_mp3_quality.Size = new System.Drawing.Size(121, 20);
            this.cb_mp3_quality.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cb_mp4_quality);
            this.groupBox2.Controls.Add(this.btn_download_video);
            this.groupBox2.Location = new System.Drawing.Point(216, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 136);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MP4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "影片品質:";
            // 
            // cb_mp4_quality
            // 
            this.cb_mp4_quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mp4_quality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_mp4_quality.FormattingEnabled = true;
            this.cb_mp4_quality.Location = new System.Drawing.Point(17, 49);
            this.cb_mp4_quality.Name = "cb_mp4_quality";
            this.cb_mp4_quality.Size = new System.Drawing.Size(121, 20);
            this.cb_mp4_quality.TabIndex = 14;
            // 
            // tb_file_save_path
            // 
            this.tb_file_save_path.Location = new System.Drawing.Point(74, 72);
            this.tb_file_save_path.Name = "tb_file_save_path";
            this.tb_file_save_path.ReadOnly = true;
            this.tb_file_save_path.Size = new System.Drawing.Size(232, 22);
            this.tb_file_save_path.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "儲存位置:";
            // 
            // btn_open_folder
            // 
            this.btn_open_folder.Location = new System.Drawing.Point(302, 72);
            this.btn_open_folder.Name = "btn_open_folder";
            this.btn_open_folder.Size = new System.Drawing.Size(88, 22);
            this.btn_open_folder.TabIndex = 15;
            this.btn_open_folder.Text = "選擇資料夾";
            this.btn_open_folder.UseVisualStyleBackColor = true;
            this.btn_open_folder.Click += new System.EventHandler(this.btn_open_folder_Click);
            // 
            // tb_file_name
            // 
            this.tb_file_name.Location = new System.Drawing.Point(74, 39);
            this.tb_file_name.Name = "tb_file_name";
            this.tb_file_name.Size = new System.Drawing.Size(232, 22);
            this.tb_file_name.TabIndex = 16;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 42);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 12);
            this.label.TabIndex = 17;
            this.label.Text = "檔案名稱:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "下載駐列:";
            // 
            // tbc_downPanel
            // 
            this.tbc_downPanel.Controls.Add(this.tab_downloading);
            this.tbc_downPanel.Controls.Add(this.tab_finish);
            this.tbc_downPanel.Location = new System.Drawing.Point(12, 252);
            this.tbc_downPanel.Name = "tbc_downPanel";
            this.tbc_downPanel.SelectedIndex = 0;
            this.tbc_downPanel.Size = new System.Drawing.Size(378, 111);
            this.tbc_downPanel.TabIndex = 21;
            // 
            // tab_downloading
            // 
            this.tab_downloading.Controls.Add(this.lv_downloading);
            this.tab_downloading.Location = new System.Drawing.Point(4, 22);
            this.tab_downloading.Name = "tab_downloading";
            this.tab_downloading.Padding = new System.Windows.Forms.Padding(3);
            this.tab_downloading.Size = new System.Drawing.Size(370, 85);
            this.tab_downloading.TabIndex = 0;
            this.tab_downloading.Text = "下載佇列";
            this.tab_downloading.UseVisualStyleBackColor = true;
            // 
            // tab_finish
            // 
            this.tab_finish.Controls.Add(this.lv_finished);
            this.tab_finish.Location = new System.Drawing.Point(4, 22);
            this.tab_finish.Name = "tab_finish";
            this.tab_finish.Padding = new System.Windows.Forms.Padding(3);
            this.tab_finish.Size = new System.Drawing.Size(370, 85);
            this.tab_finish.TabIndex = 1;
            this.tab_finish.Text = "下載完成";
            this.tab_finish.UseVisualStyleBackColor = true;
            // 
            // lv_downloading
            // 
            this.lv_downloading.Location = new System.Drawing.Point(0, 0);
            this.lv_downloading.Name = "lv_downloading";
            this.lv_downloading.Size = new System.Drawing.Size(370, 85);
            this.lv_downloading.TabIndex = 1;
            this.lv_downloading.UseCompatibleStateImageBehavior = false;
            this.lv_downloading.View = System.Windows.Forms.View.List;
            // 
            // lv_finished
            // 
            this.lv_finished.Location = new System.Drawing.Point(0, 0);
            this.lv_finished.Name = "lv_finished";
            this.lv_finished.Size = new System.Drawing.Size(370, 85);
            this.lv_finished.TabIndex = 2;
            this.lv_finished.UseCompatibleStateImageBehavior = false;
            this.lv_finished.View = System.Windows.Forms.View.List;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 364);
            this.Controls.Add(this.tbc_downPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tb_file_name);
            this.Controls.Add(this.btn_open_folder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_file_save_path);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wb_youtube);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_preview);
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube下載器";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbc_downPanel.ResumeLayout(false);
            this.tab_downloading.ResumeLayout(false);
            this.tab_finish.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.WebBrowser wb_youtube;
        private System.Windows.Forms.Button btn_download_video;
        private System.Windows.Forms.Button btn_audio_video;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_mp3_quality;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_mp4_quality;
        private System.Windows.Forms.TextBox tb_file_save_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_open_folder;
        private System.Windows.Forms.TextBox tb_file_name;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tbc_downPanel;
        private System.Windows.Forms.TabPage tab_downloading;
        private System.Windows.Forms.TabPage tab_finish;
        private System.Windows.Forms.ListView lv_downloading;
        private System.Windows.Forms.ListView lv_finished;
    }
}

