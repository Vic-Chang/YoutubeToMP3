using NAudio.Wave;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YoutubeToMP3
{
    public partial class form_main : Form
    {
        static string save_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        readonly string verion = "v 1.0.0";

        public form_main()
        {
            InitializeComponent();
            tb_file_save_path.Text = "預設為桌面";
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            string InsertUrl = tb_url.Text;
            //抓取標題
            tb_file_name.Text = YoutubeDownload.GetVideoName(tb_url.Text);
            //抓取Video品質
            setQualityComboBox(tb_url.Text);
            //抓取音質
            #region □ 轉換網址至winform能播的網址格式，並預覽影片 □ 
            /* 
             https://www.youtube.com/watch?v=VvHh8s2HHSk
             to 
             http://www.youtube.com/v/HLj0aLPLsys?version=3&autoplay=1
             */
            if (InsertUrl.Contains("="))
            {
                int index = InsertUrl.IndexOf("v=");
                InsertUrl = "http://www.youtube.com/v/" + InsertUrl.Substring(index + 2);
                Uri uri = new Uri(InsertUrl);
                wb_youtube.Url = uri;
            }
            else if (InsertUrl.Contains("/v/"))
            {
                Uri uri = new Uri(InsertUrl);
                wb_youtube.Url = uri;
            }
            else
            {
                MessageBox.Show("無法解析網址，請確認!");
            }
            #endregion
        }

        private async void btn_download_video_Click(object sender, EventArgs e)
        {
            /*
             * Get the available video formats.
             * We'll work with them in the video and audio download examples.
             */
            string VideoQuality = cb_mp4_quality.SelectedValue.ToString();
            string VideoTitle = tb_file_name.Text;
            if (isExist(EnumType.DownloadType.影片, VideoTitle) == false)
            {
                ListViewItem lvitemSong = new ListViewItem("[影片]" + VideoTitle + "...下載中");
                lv_downloading.Items.Add(lvitemSong);
                await Task.Factory.StartNew(() => YoutubeDownload.DownloadVideo(save_path, VideoTitle, tb_url.Text, VideoQuality));
                lv_downloading.Items.Remove(lvitemSong);
                lv_finished.Items.Add(lvitemSong);
            }
        }

        private async void btn_download_audio_Click(object sender, EventArgs e)
        {
            string AudioQuality = cb_mp3_quality.SelectedValue.ToString();
            string VideoTitle = tb_file_name.Text;
            if (isExist(EnumType.DownloadType.音樂, VideoTitle) == false)
            {
                ListViewItem lvitemSong = new ListViewItem("[音樂]" + VideoTitle + "...下載中");
                lv_downloading.Items.Add(lvitemSong);
                await Task.Factory.StartNew(() => YoutubeDownload.DownloadAudio(save_path, VideoTitle, tb_url.Text, AudioQuality));
                lv_downloading.Items.Remove(lvitemSong);
                lv_finished.Items.Add(lvitemSong);
            }
        }

        /// <summary>
        /// 下載前確認有無重複檔案
        /// </summary>
        /// <param name="type"></param>
        /// <param name="downloadName"></param>
        /// <returns></returns>
        private bool isExist(EnumType.DownloadType type, string downloadName)
        {
            string sameName = "";
            string pattern = "";
            bool isExist = false;
            if (type == EnumType.DownloadType.音樂)
            {
                pattern = "*.mp3";
            }
            else
            {
                pattern = "*.mp4";
            }
            List<string> pathList = new List<string>();
            pathList = Directory.GetFiles(save_path, pattern).Select(o => Path.GetFileName(o)).ToList();
            if (pathList.Any(o=>o.Contains(downloadName)) == true)
            {
                sameName = pathList.Where(o => o.Contains(downloadName)).FirstOrDefault().ToString();

                //抓取回答是或否
                DialogResult dialogResult = 
                    MessageBox.Show(string.Format("已有該首歌，跳過下載。" 
                    + Environment.NewLine + "檔案名稱:{0}"
                    + Environment.NewLine + "是否繼續下載?", sameName),
                    "重複的檔案",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    isExist = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        private void btn_open_folder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    tb_file_save_path.Text = fbd.SelectedPath;
                    save_path = fbd.SelectedPath;
                }
            }
        }
        private void setQualityComboBox(string _url)
        {
            ArrayList data = new ArrayList();
            var VideoQuality = YoutubeDownload.GetVideoQuality(_url);
            foreach (var i in VideoQuality)
            {
                data.Add(new DictionaryEntry(i + "p", i));
            }
            cb_mp4_quality.DisplayMember = "Key";
            cb_mp4_quality.ValueMember = "Value";
            cb_mp4_quality.DataSource = data;

            ArrayList data2 = new ArrayList();
            var AudioQuality = YoutubeDownload.GetAudioQuality(_url);
            foreach (var i in AudioQuality)
            {
                data2.Add(new DictionaryEntry(i + "p", i));
            }
            cb_mp3_quality.DisplayMember = "Key";
            cb_mp3_quality.ValueMember = "Value";
            cb_mp3_quality.DataSource = data2;
        }

        public static void AacToMp3()
        {

            // convert source audio to AAC
            // create media foundation reader to read the source (can be any supported format, mp3, wav, ...)
            using (MediaFoundationReader reader = new MediaFoundationReader(@"d:\source.mp3"))
            {
                MediaFoundationEncoder.EncodeToAac(reader, @"D:\test.mp4");
            }

            // convert "back" to WAV
            // create media foundation reader to read the AAC encoded file
            using (MediaFoundationReader reader = new MediaFoundationReader(@"D:\test.mp4"))
            // resample the file to PCM with same sample rate, channels and bits per sample
            using (ResamplerDmoStream resampledReader = new ResamplerDmoStream(reader,
                new WaveFormat(reader.WaveFormat.SampleRate, reader.WaveFormat.BitsPerSample, reader.WaveFormat.Channels)))
            // create WAVe file
            using (WaveFileWriter waveWriter = new WaveFileWriter(@"d:\test.wav", resampledReader.WaveFormat))
            {
                // copy samples
                resampledReader.CopyTo(waveWriter);
            }
        }

    }
    #region  ☆ YoutubeDownload 函式 ☆
    /*用partial切開Form , 較好維護*/
    public class YoutubeDownload
    {
        public static string GetVideoName(string _url)
        {
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(_url, false);

            return videoInfos.First().Title;
        }
        public static List<string> GetVideoQuality(string _url)
        {
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(_url, false);
            List<string> qualiList = new List<string>();
            qualiList = videoInfos.Where(o => o.VideoType == VideoType.Mp4)
                .Where(o => o.Resolution != 0 && o.AudioBitrate != 0)
                .OrderByDescending(o => o.Resolution)
                .Select(o => o.Resolution.ToString()).ToList();
            return qualiList;
        }
        public static List<string> GetAudioQuality(string _url)
        {
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(_url, false);
            List<string> qualiList = new List<string>();

            qualiList = videoInfos.Where(i => i.VideoType == VideoType.Mp4 && i.Resolution == 0)
                .Select(o => o.AudioBitrate.ToString()).ToList();
            return qualiList;
        }

        public static void DownloadAudio(string _savePath, string _title, string _url, string _resolution)
        {
            //todo: 有可能會下載到沒聲音 , 初步看因為影片只有acc or ogg
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(_url, false);
            /*
             * We want the first extractable video with the highest audio quality.
             */
            VideoInfo video = videoInfos.Where(i => i.VideoType == VideoType.Mp4 && i.Resolution == 0)
                                        .Where(q => q.AudioBitrate == Convert.ToInt32(_resolution)).First();

            /*
             * If the video has a decrypted signature, decipher it
             */
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            //TODO:如果RequiresDecryption是false
            //下載的檔案有可能不能聽

            /*
             * Create the audio downloader.
             * The first argument is the video where the audio should be extracted from.
             * The second argument is the path to save the audio file.
             */
            var videoDownloader = new VideoDownloader(video, Path.Combine(_savePath, RemoveIllegalPathCharacters(_title) + ".mp3"));

            // Register the progress events. We treat the download progress as 85% of the progress and the extraction progress only as 15% of the progress,
            // because the download will take much longer than the audio extraction.
            videoDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage);


            /*
             * Execute the audio downloader.
             * For GUI applications note, that this method runs synchronously.
             */
            videoDownloader.Execute();
        }

        public static void DownloadVideo(string _savePath, string _title, string _url, string _resolution)
        {
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(_url, false);

            /*
             * Select the first .mp4 video with 360p resolution
             */
            VideoInfo video = videoInfos
                .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == Convert.ToInt32(_resolution));

            /*
             * If the video has a decrypted signature, decipher it
             */
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            /*
             * Create the video downloader.
             * The first argument is the video to download.
             * The second argument is the path to save the video file.
             */
            var videoDownloader = new VideoDownloader(video,
                Path.Combine(_savePath, RemoveIllegalPathCharacters(_title) + video.VideoExtension));

            // Register the ProgressChanged event and print the current progress
            videoDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage);

            /*
             * Execute the video downloader.
             * For GUI applications note, that this method runs synchronously.
             */
            videoDownloader.Execute();
        }

        private static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }
    }
    #endregion

}
