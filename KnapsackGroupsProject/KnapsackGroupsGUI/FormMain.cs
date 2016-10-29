using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace KnapsackGroupsProject
{
    public partial class FormMain : Form
    {
        private DynamicTable table;
        private FormHelp formHelp;
        private KnapsackGroupsCore knapsackGroupsCore;


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            pnlMain.Hide();

            // faster grid render
            typeof(DataGridView).InvokeMember(
            "DoubleBuffered",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
            null,
            gridMain,
            new object[] { true });

            knapsackGroupsCore = new KnapsackGroupsCore();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                table = knapsackGroupsCore.ParseInitialTableFromFile(tbDirAdd.Text.Trim());

                tbTarget.Text = table.TargetCost.ToString();
                pnlMain.Show();
                PopulateVCGrid();
                PopulateMainGrid();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PopulateVCGrid()
        {
            //reset grid
            gridVC.EnableHeadersVisualStyles = false;
            gridVC.Rows.Clear();
            gridVC.Columns.Clear();
            gridVC.Refresh();

            gridVC.Columns.Add("C0", "");
            gridVC.Rows.Add("V");
            gridVC.Rows.Add("C");

            int c = 1;
            foreach (DynamicTableObject tableObject in table.TableObjects)
            {
                gridVC.Columns.Add("C" + c, tableObject.Name);
                gridVC.Rows[0].Cells[c].Value = tableObject.Value;
                gridVC.Rows[1].Cells[c].Value = tableObject.Cost;

                string groupName = table.GroupNames[tableObject.GroupIndex];
                gridVC.Rows[0].Cells[c].ToolTipText = groupName;
                gridVC.Rows[1].Cells[c].ToolTipText = groupName;

                DataGridViewColumn column = gridVC.Columns[c];
                column.ToolTipText = groupName;
                column.DefaultCellStyle.BackColor = tableObject.GroupIndex % 2 == 1 ?
                    Color.White : Color.LightCyan;
                column.HeaderCell.Style.BackColor = tableObject.GroupIndex % 2 == 1 ?
                    Color.LightGray : Color.LightSteelBlue;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                c += 1;
            }
        }

        private List<int> rows = null;

        private void PopulateMainGrid()
        {
            //reset grid
            gridMain.EnableHeadersVisualStyles = false;
            gridMain.Rows.Clear();
            gridMain.Columns.Clear();
            gridMain.Refresh();

            lbBest.Items.Clear();
            table.Reset();

            gridMain.Columns.Add("C0", "");
            int c = 1;

            foreach (DynamicTableObject tableObject in table.TableObjects)
            {
                gridMain.Columns.Add("C" + c, tableObject.Name);
                string groupName = table.GroupNames[tableObject.GroupIndex];
                DataGridViewColumn column = gridMain.Columns[c];
                column.ToolTipText = groupName;
                column.DefaultCellStyle.BackColor = tableObject.GroupIndex % 2 == 1 ?
                    Color.White : Color.LightCyan;
                column.HeaderCell.Style.BackColor = tableObject.GroupIndex % 2 == 1 ?
                    Color.LightGray : Color.LightSteelBlue;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                c += 1;
            }

            rows = knapsackGroupsCore.SolveProblem(true);

            for (int currentCost = 0; currentCost <= table.TargetCost; currentCost++)
            {
                gridMain.Rows.Add(currentCost.ToString());
                for (int objectIndex = 0; objectIndex < table.TableObjects.Count; objectIndex++)
                {
                    string groupName = table.GroupNames[table.TableObjects[objectIndex].GroupIndex];
                    gridMain.Rows[currentCost].Cells[objectIndex + 1].Value = table.CostList[objectIndex][currentCost];
                    gridMain.Rows[currentCost].Cells[objectIndex + 1].ToolTipText = groupName;


                }
            }

            MarkKeyCells();
        }

        private void MarkKeyCells()
        {
            rows.Reverse();
            table.BestTableObjects.Reverse();
            DynamicTableObject firstTableObject = null;
            DynamicTableObject lastTableObject = null;
            int previousGroup = -1;
            int row = 0;
            for (int rowIndex = 0; rowIndex < rows.Count; rowIndex++)
            {
                int col = table.BestTableObjects[rowIndex];
                DynamicTableObject tableObject = table.TableObjects[col];
                if (firstTableObject == null) firstTableObject = tableObject;
                if (rowIndex == rows.Count - 1) lastTableObject = tableObject;
                lbBest.Items.Add(table.GroupNames[tableObject.GroupIndex] + ": " + tableObject.ToString());

                if (previousGroup == -1)
                {
                    previousGroup = tableObject.GroupIndex;
                }
                else
                {
                    for (int previousIndex = previousGroup + 1; previousIndex < tableObject.GroupIndex; previousIndex++)
                    {
                        int previousCol = table.GroupMaxIndices[previousIndex][row];
                        gridMain.Rows[row].Cells[previousCol + 1].Style.BackColor = Color.Yellow;
                    }
                    previousGroup = tableObject.GroupIndex;
                }
                row = rows[rowIndex];
                Color color;
                if (rowIndex != rows.Count - 1)
                {
                    color = Color.Green;
                }
                else
                {
                    color = Color.Red;
                }

                gridMain.Rows[row].Cells[col + 1].Style.BackColor = color;
            }

            if (firstTableObject != null && firstTableObject.GroupIndex != 0)
            {
                for (int previousGroupIndex = 0; previousGroupIndex < firstTableObject.GroupIndex; previousGroupIndex++)
                {
                    int previousCol = table.GroupMaxIndices[previousGroupIndex][0];
                    gridMain.Rows[0].Cells[previousCol + 1].Style.BackColor = Color.Yellow;
                }
            }

            if (lastTableObject != null && lastTableObject.GroupIndex != table.GroupNames.Count - 1)
            {
                for (int afterGroupIndex = lastTableObject.GroupIndex + 1; afterGroupIndex < table.GroupNames.Count; afterGroupIndex++)
                {
                    int afterCol = table.GroupMaxIndices[afterGroupIndex][row];
                    gridMain.Rows[row].Cells[afterCol + 1].Style.BackColor = Color.Yellow;
                }
            }

            tbBestValue.Text = table.BestValue.ToString();
            tbBestCost.Text = table.BestCost.ToString();
        }

        private void btnDirAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Tekstualna datoteka|*.txt|Sve datoteke (*.*)|*.*";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbDirAdd.Text = ofd.FileName;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                for (int objectIndex = 0; objectIndex < table.TableObjects.Count; objectIndex++)
                {
                    DynamicTableObject tableObject = table.TableObjects[objectIndex];
                    tableObject.Value = int.Parse(gridVC.Rows[0].Cells[objectIndex + 1].Value.ToString());
                    tableObject.Cost = int.Parse(gridVC.Rows[1].Cells[objectIndex + 1].Value.ToString());
                    table.CostList[objectIndex].Clear();
                }
                for (int i = 0; i < table.GroupMaxValues.Count; i++)
                {
                    table.GroupMaxValues[i].Clear();
                    table.GroupMaxIndices[i].Clear();
                }

                table.TargetCost = int.Parse(tbTarget.Text.Trim());

                PopulateMainGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Dopušteni su isključivo nenegativni cijeli brojevi.");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (formHelp == null || formHelp.IsDisposed)
            {
                formHelp = new FormHelp();
                formHelp.Show();
            }
            else if (formHelp.Visible)
            {
                formHelp.Hide();
            }
            else
            {
                formHelp.Show();
            }
        }

        private void lbBest_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row = rows[lbBest.SelectedIndex];
            int col = table.BestTableObjects[lbBest.SelectedIndex];
            gridMain.CurrentCell = gridMain.Rows[row].Cells[col + 1];
        }
    }
}
