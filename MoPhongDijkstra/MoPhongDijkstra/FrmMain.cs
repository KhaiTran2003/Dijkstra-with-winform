using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MoPhongDijkstra
{
    public partial class FrmMain : Form
    {
        string filePath;
        bool isFile = false;
        Dictionary<char, Dictionary<char, int>> graph = new Dictionary<char, Dictionary<char, int>> ();
        List<char> Points= new List<char>();
        
        public FrmMain()
        {
            InitializeComponent();
        }
        private void readFile(string data)
        {
            //Console.WriteLine(data);
            string[] lines = data.Split('\n');
            //Console.WriteLine(lines[0]);
            for (int i = 0; i < int.Parse((lines[0])); i++) {
                Points.Add(Convert.ToChar(i + 'A'));
                graph[Points[i]] = new Dictionary<char, int>();
                string row = lines[i + 1].Replace(" ","");
                for (int j = 0; j < int.Parse((lines[0])); j++){
                    if (i != j && row[j]!='0')
                    {
                        graph[Points[i]].Add(Convert.ToChar(j + 'A'), row[j] - '0');
                    }
                }
            }
            char startNode = 'A';
            (var allPaths, var visitedOrder) = DijkstraAllPaths.FindAllShortestPathsWithOrder(graph, startNode);

            if (allPaths != null)
            {
                Console.WriteLine("Visited Order:");
                Console.WriteLine(string.Join(" -> ", visitedOrder));
                foreach (var endNode in allPaths.Keys)
                {
                    Console.WriteLine($"Paths from {startNode} to {endNode}:");
                    foreach (var path in allPaths[endNode])
                    {
                        Console.WriteLine(string.Join(" -> ", path));
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid graph or start node.");
            }
            //foreach (var node in graph)
            //{
            //    Console.Write($"{node.Key}: ");
            //    foreach (var neighbor in node.Value)
            //    {
            //        Console.Write($"({neighbor.Key}, {neighbor.Value}) ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(Points.Count);

            //var graph = new Dictionary<char, Dictionary<char, int>>
            //{
            //{'A', new Dictionary<char, int> {{'B', 4}, {'C', 2}}},
            //{'B', new Dictionary<char, int> { {'A',4 }, {'D', 5}, {'E', 10}}},
            //{'C', new Dictionary<char, int> { {'A', 2}, {'D', 1}, {'F', 3}}},
            //{'D', new Dictionary<char, int> { { 'B',1}, {'E', 2}, { 'C',1} }},
            //{'E', new Dictionary<char, int> { {'B', 10},{'F', 1},{ 'D',2} }},
            //{'F', new Dictionary<char, int> { { 'C', 3 },{'E',1 } } }
            //};
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
                    readFile(fileContent);
                    MessageBox.Show(fileContent);
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
