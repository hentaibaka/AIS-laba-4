namespace AIS_laba_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StudentsGrid = new System.Windows.Forms.DataGridView();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.GlistButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsGrid
            // 
            this.StudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.StudentsGrid.Location = new System.Drawing.Point(0, 0);
            this.StudentsGrid.Margin = new System.Windows.Forms.Padding(6);
            this.StudentsGrid.Name = "StudentsGrid";
            this.StudentsGrid.RowHeadersWidth = 72;
            this.StudentsGrid.Size = new System.Drawing.Size(836, 734);
            this.StudentsGrid.TabIndex = 10;
            // 
            // zedGraph
            // 
            this.zedGraph.Dock = System.Windows.Forms.DockStyle.Right;
            this.zedGraph.Location = new System.Drawing.Point(834, 0);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(11);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(878, 734);
            this.zedGraph.TabIndex = 14;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.DeleteButton,
            this.GlistButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1712, 40);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(55, 34);
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(77, 34);
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // GlistButton
            // 
            this.GlistButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GlistButton.Image = ((System.Drawing.Image)(resources.GetObject("GlistButton.Image")));
            this.GlistButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GlistButton.Name = "GlistButton";
            this.GlistButton.Size = new System.Drawing.Size(124, 34);
            this.GlistButton.Text = "Ghistogram";
            this.GlistButton.Click += new System.EventHandler(this.GlistButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StudentsGrid);
            this.panel1.Controls.Add(this.zedGraph);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1712, 734);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView StudentsGrid;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton GlistButton;
        private System.Windows.Forms.Panel panel1;
    }
}

