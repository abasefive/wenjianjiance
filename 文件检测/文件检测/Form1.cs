using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace 文件检测
{
    public partial class Form1 : Form
    {
        static string foldPath = "";
        static string file = "";

        public Form1()
        {
            InitializeComponent();
            if (File.Exists("data.bin") == true)
            {
                //StreamReader reader = new StreamReader("data.bin", Encoding.Default);
                //int i = 0;
                ////循环读取所有行
                //while (!reader.EndOfStream)
                //{
                //    if (i == 0)
                //        textBox_mulu.Text = reader.ReadLine();
                //    if (i == 1)
                //        textBox_mubiao.Text = reader.ReadLine();
                //    i++;
                //}
                ////关闭文件
                //reader.Close();

            }
            else
            {
                FileStream myFs = new FileStream("data.bin", FileMode.Create);
                StreamWriter mySw = new StreamWriter(myFs);
                mySw.Close();
                myFs.Close();
            }
        }
        /// <summary>
        /// 浏览设置检测文件夹
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void liulan_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;
                MessageBox.Show("已选择文件夹:" + foldPath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox_mulu.Text = foldPath;
            FileStream aFile = new FileStream("data.bin", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine(foldPath);
            sw.Close();
            aFile.Close();
        }

        private void mubiao_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择目标文件";
            fileDialog.Filter = "所有文件(*.txt)|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = fileDialog.FileName;
                MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox_mubiao.Text = file;
            FileStream aFile = new FileStream("data.bin", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine(file);
            sw.Close();
            aFile.Close();
        }

        private void begin_Click(object sender, EventArgs e)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = foldPath;
            watcher.Filter = "*.txt";
            watcher.Changed += new FileSystemEventHandler(OnProcess);
            watcher.Created += new FileSystemEventHandler(OnProcess);
            watcher.Deleted += new FileSystemEventHandler(OnProcess);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.EnableRaisingEvents = true;
            /*watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess
                                   | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;*/
            watcher.NotifyFilter = NotifyFilters.Size;//数据写入
            watcher.IncludeSubdirectories = true;
        }

        private static void OnProcess(object source, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Created)
            {
                OnCreated(source, e);
            }
            else if (e.ChangeType == WatcherChangeTypes.Changed)
            {
                OnChanged(source, e);
            }
            else if (e.ChangeType == WatcherChangeTypes.Deleted)
            {
                OnDeleted(source, e);
            }

        }
        private static void OnCreated(object source, FileSystemEventArgs e)
        {
            
        }
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
           // Console.WriteLine("文件改变事件处理逻辑{0}  {1}  {2}", e.ChangeType, e.FullPath, e.Name);
            StreamReader reader = new StreamReader(foldPath + "\\" + e.Name, Encoding.Default);
            string newyzm = "";
            while (!reader.EndOfStream)
            {//读取最后一行文本
                newyzm = reader.ReadLine();
            }
            //关闭文件
            reader.Close();

            //写入文件
            FileStream aFile = new FileStream(file, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile, Encoding.GetEncoding("GB2312"));
            sw.WriteLine(newyzm);
            sw.Close();
            aFile.Close();
        }

        private static void OnDeleted(object source, FileSystemEventArgs e)
        {
            //Console.WriteLine("文件删除事件处理逻辑{0}  {1}   {2}", e.ChangeType, e.FullPath, e.Name);
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            //Console.WriteLine("文件重命名事件处理逻辑{0}  {1}  {2}", e.ChangeType, e.FullPath, e.Name);
        }
    }
}
