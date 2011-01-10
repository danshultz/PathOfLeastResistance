using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PathOfLeastResistanceLibrary;

namespace PathOfLeastResistance
{
    public partial class DataGridGenerator : Form
    {
        public DataGridGenerator()
        {
            InitializeComponent();
            this.InitializeFormFields();
        }

        private void InitializeFormFields()
        {
            this.labelDidPathMakeIt.Text = "";
            this.labelPathTaken.Text = "";
            this.labelTotalResistance.Text = "";
            //Load the Min and Max Range Drop Downs
            Array.ForEach<int>(Enumerable.Range(-25, 50).ToArray(), i =>
            {
                this.comboBoxMinRange.Items.Add(i);
                this.comboBoxMaxRange.Items.Add(i);
            });
            //Load the Column and Rows Drop Downs
            Array.ForEach<int>(Enumerable.Range(1, 100).ToArray(), i =>
            {
                this.comboBoxColumns.Items.Add(i);
                this.comboBoxRows.Items.Add(i);
            });
            this.dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grid grid = this.GetGrid();
            PathResults pathDetails = grid.FindPathOfLeastResistance(new Water());
            this.PaintGridAndPathOnUi(grid, pathDetails);
        }

        private Grid GetGrid()
        {
            int[,] intArray = this.GetIntArray();
            return new Grid(intArray);
        }

        private int[,] GetIntArray()
        {
            int rows = int.Parse(this.comboBoxColumns.Text);
            int columns = int.Parse(this.comboBoxRows.Text);
            int minRange = int.Parse(this.comboBoxMinRange.Text);
            int maxRange = int.Parse(this.comboBoxMaxRange.Text);

            int[,] myArray = new int[columns, rows];

            Random random = new Random();
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    myArray[x, y] = random.Next(minRange, maxRange);
                }
            }

            return myArray;
        }

        private void PaintGridAndPathOnUi(Grid grid, PathResults pathDetails)
        {
            this.dataGridView1.DataSource = grid.ToDataSet().Tables[0];
            this.DisplayPathResults(pathDetails);
            this.HighlightPath(grid.Width, pathDetails);
        }

        private void DisplayPathResults(PathResults pathDetails)
        {
            this.labelTotalResistance.Text = pathDetails.TotalResistance.ToString();
            this.labelDidPathMakeIt.Text = pathDetails.DidWaterFlowThroughEntireGrid ? "Yes" : "No";
            StringBuilder sb = new StringBuilder();
            pathDetails.PathTaken.Each(i => { sb.Append(i).Append(" "); });
            this.labelPathTaken.Text = sb.ToString();
        }

        private void HighlightPath(int width, PathResults pathDetails)
        {
            Color cellColor = pathDetails.DidWaterFlowThroughEntireGrid ? Color.Green : Color.Red;
            for (int i = 0; i < pathDetails.PathTaken.Count; i++)
            {
                this.dataGridView1[i, pathDetails.PathTaken[i] - 1].Style.BackColor = cellColor;
            }
        }
    }
}
