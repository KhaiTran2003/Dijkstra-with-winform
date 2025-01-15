
namespace MoPhongDijkstra
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_endnode = new System.Windows.Forms.ComboBox();
            this.cb_startnode = new System.Windows.Forms.ComboBox();
            this.btn_loadfile = new System.Windows.Forms.Button();
            this.txt_delay = new System.Windows.Forms.TextBox();
            this.btn_runstep = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_auto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cb_endnode);
            this.panel1.Controls.Add(this.cb_startnode);
            this.panel1.Controls.Add(this.btn_loadfile);
            this.panel1.Controls.Add(this.txt_delay);
            this.panel1.Controls.Add(this.btn_runstep);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_pause);
            this.panel1.Controls.Add(this.btn_auto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 629);
            this.panel1.TabIndex = 0;
            // 
            // cb_endnode
            // 
            this.cb_endnode.FormattingEnabled = true;
            this.cb_endnode.Location = new System.Drawing.Point(128, 72);
            this.cb_endnode.Name = "cb_endnode";
            this.cb_endnode.Size = new System.Drawing.Size(224, 24);
            this.cb_endnode.TabIndex = 5;
            this.cb_endnode.SelectedIndexChanged += new System.EventHandler(this.cb_endnode_SelectedIndexChanged);
            // 
            // cb_startnode
            // 
            this.cb_startnode.FormattingEnabled = true;
            this.cb_startnode.Location = new System.Drawing.Point(128, 37);
            this.cb_startnode.Name = "cb_startnode";
            this.cb_startnode.Size = new System.Drawing.Size(224, 24);
            this.cb_startnode.TabIndex = 5;
            this.cb_startnode.SelectedIndexChanged += new System.EventHandler(this.cb_startnode_SelectedIndexChanged);
            // 
            // btn_loadfile
            // 
            this.btn_loadfile.Location = new System.Drawing.Point(26, 396);
            this.btn_loadfile.Name = "btn_loadfile";
            this.btn_loadfile.Size = new System.Drawing.Size(326, 40);
            this.btn_loadfile.TabIndex = 4;
            this.btn_loadfile.Text = "Load File";
            this.btn_loadfile.UseVisualStyleBackColor = true;
            this.btn_loadfile.Click += new System.EventHandler(this.btn_loadfile_Click);
            // 
            // txt_delay
            // 
            this.txt_delay.Location = new System.Drawing.Point(185, 158);
            this.txt_delay.Name = "txt_delay";
            this.txt_delay.Size = new System.Drawing.Size(167, 22);
            this.txt_delay.TabIndex = 3;
            // 
            // btn_runstep
            // 
            this.btn_runstep.Location = new System.Drawing.Point(26, 333);
            this.btn_runstep.Name = "btn_runstep";
            this.btn_runstep.Size = new System.Drawing.Size(326, 40);
            this.btn_runstep.TabIndex = 2;
            this.btn_runstep.Text = "Chạy từng bước";
            this.btn_runstep.UseVisualStyleBackColor = true;
            this.btn_runstep.Click += new System.EventHandler(this.btn_runstep_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(26, 270);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(326, 40);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(200, 224);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(152, 40);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "Tạm dừng";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_auto
            // 
            this.btn_auto.Location = new System.Drawing.Point(26, 224);
            this.btn_auto.Name = "btn_auto";
            this.btn_auto.Size = new System.Drawing.Size(156, 40);
            this.btn_auto.TabIndex = 2;
            this.btn_auto.Text = "Chạy tự động";
            this.btn_auto.UseVisualStyleBackColor = true;
            this.btn_auto.Click += new System.EventHandler(this.btn_auto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời gian delay(ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đỉnh kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đỉnh xuất phát";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(386, 12);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(864, 629);
            this.panelGraph.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 653);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_delay;
        private System.Windows.Forms.Button btn_runstep;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_auto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_loadfile;
        private System.Windows.Forms.ComboBox cb_endnode;
        private System.Windows.Forms.ComboBox cb_startnode;
    }
}

