using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MoPhongDijkstra
{
    public partial class FrmMain : Form
    {
        string filePath;
        bool isfinish = false;
        bool isFile = false;
        Dictionary<char, Dictionary<char, int>> graph = new Dictionary<char, Dictionary<char, int>> ();
        List<char> Points= new List<char>();
        List<Circle> circles = new List<Circle> ();
        char start_node = ' ';
        char end_node = ' ';
        int ttime;
        Timer myTimer;
        Dictionary<char,List<List<char>>> allPaths = new Dictionary<char, List<List<char>>>();
        List<char> visitedOrder = new List<char>();
        int step = 0;
        public FrmMain()
        {
            InitializeComponent();
            panelGraph.Paint += new PaintEventHandler(Form1_Paint);
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(MyTimer_Tick);

        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if(start_node != ' ')
            {
                step += 1;
                handleStep();
            }
            else
            {
                myTimer.Stop();
                MessageBox.Show("Please enter start node! ");
            }
        
        }
        private void handleStep()
        {
            
            if (step <= Points.Count)
            {
                char visit = visitedOrder[step - 1];
                int pos = visit - 'A';
                circles[pos]._color=Color.Green;
                panelGraph.Invalidate();
            }
            else
            {
                if (end_node != ' ')
                {
                    isfinish = true;
                    myTimer.Stop();
                    panelGraph.Invalidate();
                }
            }
        }
        private void readFile(string data)
        {
            circles.Clear();
            Points.Clear();
            graph.Clear();
            allPaths.Clear();
            visitedOrder.Clear();
            isfinish = false;
            start_node = ' ';
            end_node = ' ';
            step = 0;
            cb_startnode.SelectedIndex = -1;
            cb_endnode.SelectedIndex = -1;
            cb_startnode.Items.Clear();
            cb_endnode.Items.Clear();
            
            panelGraph.Invalidate();
            //Console.WriteLine(data);
            string[] lines = data.Split('\n');
            //Console.WriteLine(lines[0]);
            for (int i = 0; i < int.Parse((lines[0])); i++) {
                Points.Add(Convert.ToChar(i + 'A'));
                
                graph[Points[i]] = new Dictionary<char, int>();
                string[] toado = lines[i + 1].Split(' ');
                circles.Add(new Circle(Points[i], int.Parse(toado[0]), int.Parse(toado[1]), 10));

                string row = lines[i + 10].Replace(" ", "");
                for (int j = 0; j < int.Parse((lines[0])); j++){
                    if (i != j && row[j]!='0')
                    {
                        graph[Points[i]].Add(Convert.ToChar(j + 'A'), row[j] - '0');
                    }
                }
            }
            panelGraph.Invalidate();
            cb_startnode.Items.AddRange(Points.Cast<object>().ToArray());
            cb_endnode.Items.AddRange(Points.Cast<object>().ToArray());
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Filled Circle 1 (Solid Color)
            foreach(Circle circle in circles)
            {
                int x1 = circle.X;
                int y1 = circle.Y;
                int radius1 = circle.Radius;
                int current = circle.Label - 'A';
                Brush brush1 = new SolidBrush(circle._color);
                g.FillEllipse(brush1, x1 - radius1, y1 - radius1, 2 * radius1, 2 * radius1);
                brush1.Dispose(); 
                g.DrawString(circle.Label.ToString(), new Font("Arial", 16), new SolidBrush(Color.Blue), x1 -10 ,  y1-30);
                using (Pen bluePen = new Pen(Color.Blue, 3))
                {
                    Dictionary<char, int> neighbor = graph[circle.Label];
                    foreach (KeyValuePair<char, int> kvp in neighbor)
                    {
                        char key = kvp.Key;
                        int value = kvp.Value;
                        int i = key - 'A';
                        if (i > current)
                        {
                            int x2 = circles[i].X;
                            int y2 = circles[i].Y;
                            g.DrawLine(bluePen, x1, y1, x2, y2);
                            Console.WriteLine(circle.Label.ToString() + key + value.ToString());
                            g.DrawString(value.ToString(), new Font("Arial", 16), new SolidBrush(Color.Red), (x1 + x2) / 2, (y1 + y2)/2);
                        }
                        
                    }
                    
                }
                    
            }
            using (Pen greenPen = new Pen(Color.Green, 3))
            {
                if (isfinish)
                {
                    try
                    {

                        int pos = start_node - 'A';
                        int x1 = circles[pos].X;
                        int y1 = circles[pos].Y;
                        var path = allPaths[end_node][0];

                        Console.WriteLine(string.Join(" -> ", path));
                        foreach (char p in path)
                        {
                            if (p != start_node)
                            {
                                pos = p - 'A';
                                int x2 = circles[pos].X;
                                int y2 = circles[pos].Y;
                                Console.WriteLine(x1.ToString() + x2.ToString());
                                g.DrawLine(greenPen, x1, y1, x2, y2);
                                x1 = x2;
                                y1 = y2;
                            }
                            
                        }
                    }
                    catch (Exception)
                    {

                    }

                }

            }
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
            openFileDialog1.Title = "Chọn tệp";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
              
                filePath = openFileDialog1.FileName;
                try
                {
                    string fileContent = System.IO.File.ReadAllText(filePath);
                    isFile = true;
                    readFile(fileContent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_auto_Click(object sender, EventArgs e)
        {
            myTimer.Start();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            allPaths.Clear();
            visitedOrder.Clear();
            foreach (Circle circle in circles)
            {
                circle._color = Color.Blue;
            }
            
            isfinish = false;
            isFile = false;
            start_node = ' ';
            end_node = ' ';
            step = 0;
            cb_startnode.SelectedIndex = -1;
            cb_endnode.SelectedIndex = -1;
            panelGraph.Invalidate();

        }

        private void btn_runstep_Click(object sender, EventArgs e)
        {
            if (start_node != ' ')
            {
                step += 1;
                handleStep();
            }
            else
            {
                MessageBox.Show("Please enter start node! ");
            }
        }

        private void cb_startnode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_startnode.SelectedIndex != -1)
            {
                start_node = cb_startnode.SelectedItem.ToString()[0];
                (allPaths, visitedOrder) = DijkstraAllPaths.FindAllShortestPathsWithOrder(graph, start_node);
                if (allPaths != null)
                {
                    Console.WriteLine("Visited Order:");
                    Console.WriteLine(string.Join(" -> ", visitedOrder));
                    foreach (var endNode in allPaths.Keys)
                    {
                        Console.WriteLine($"Paths from {start_node} to {endNode}:");
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
            }
            
        }

        private void cb_endnode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cb_endnode.SelectedIndex != -1)
            {
                end_node = cb_endnode.SelectedItem.ToString()[0];
            }
            
        }

        private void txt_delay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ttime = int.Parse(txt_delay.Text);
                myTimer.Interval = ttime;
            }
            catch(Exception)
            {

            }
        }
    }
}
