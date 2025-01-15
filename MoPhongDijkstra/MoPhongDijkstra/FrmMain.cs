using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDijkstra
{
    public partial class FrmMain : Form
    {
        string filePath;
        bool isFile = false;
        Dictionary<char,> graph;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void readFile()
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_loadfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Thiết lập các thuộc tính cho OpenFileDialog (tùy chọn)
            //openFileDialog1.Filter = "Text files (.txt)|.txt";
            openFileDialog1.Title = "Chọn tệp"; // Tiêu đề hộp thoại
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Thư mục ban đầu

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
              
                filePath = openFileDialog1.FileName;
                try
                {
                    string fileContent = System.IO.File.ReadAllText(filePath);
                    isFile = true;
                    MessageBox.Show("File successful");
                    readFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_auto_Click(object sender, EventArgs e)
        {

        }

        private void btn_pause_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }

        private void btn_runstep_Click(object sender, EventArgs e)
        {

        }

        private void cb_startnode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_endnode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
