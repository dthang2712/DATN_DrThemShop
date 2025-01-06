using System;
using System.Windows.Forms;

namespace DrThemShop.WinLibrary.CustomControl
{
    public partial class FormSearch : Form
    {
        MultiColumnComboBox.MultiColumnComboBox _ComboBox;
        int _Column = 0;
        int _Row = 0;

        public FormSearch(MultiColumnComboBox.MultiColumnComboBox comboBox)
        {
            InitializeComponent();
            _ComboBox = comboBox;
            Init();
        }

        private void Init()
        {
            //Set the datasource of the grid = datasource of the combobox
            dgvData.DataSource = _ComboBox.DataSource;
            txtStatus.Text = "";

            //Set all the columns invisible
            for (int idx = 0; idx < dgvData.Columns.Count; idx++)
            {
                dgvData.Columns[idx].Visible = false;
            }

            //Iterate through the ColumnNameCollection. If a column isn't listed
            //don't set it to visible. If a column's width is zero, don't set it to
            //visible. Set it's DisplayIndex equal to it's index in the collection.
            for (int idx = 0; idx < _ComboBox.ColumnNameCollection.Count; idx++)
            {
                dgvData.Columns[_ComboBox.ColumnNameCollection[idx]].DisplayIndex = idx;
                dgvData.Columns[_ComboBox.ColumnNameCollection[idx]].Visible =
                                      _ComboBox.ColumnWidthCollection[idx] > 0 ? true : false;
            }
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //If the user hits the <Enter> key, peform a search
            if (e.KeyCode == Keys.Enter)
            {
                SearchGrid();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void SearchGrid()
        {
            //maxSearches = the # of cells in the grid
            int maxSearches = dgvData.Rows.Count * dgvData.Columns.Count + 1;
            int idx = 1;
            bool isFound = false;
            string searchValue = txtSearch.Text.ToUpper();

            if (Convert.ToBoolean(txtSearch.Text.Length))
            {
                // If the item is not found and you haven't looked at every cell, keep searching
                while ((!isFound) & (idx < maxSearches))
                {
                    // Only search visible cells
                    if (dgvData.Columns[_Column].Visible)
                    {
                        // Do all comparing in UpperCase so it is case insensitive
                        if (dgvData[_Column, _Row].Value.ToString().ToUpper().Contains(searchValue))
                        {
                            // If found position on the item
                            dgvData.FirstDisplayedScrollingRowIndex = _Row;
                            dgvData[_Column, _Row].Selected = true;
                            isFound = true;
                            txtStatus.Text = "Search phrase found!";
                        }
                    }

                    // Increment the column.
                    _Column++;

                    // If it exceeds the column count
                    if (_Column == dgvData.Columns.Count)
                    {
                        _Column = 0; //Go to 0 column
                        _Row++;      //Go to the next row

                        // If it exceeds the row count
                        if (_Row == dgvData.Rows.Count)
                        {
                            _Row = 0; //Start over at the top
                        }
                    }

                    idx++;
                }

                // If isFound = false then the phrase has not been found in the grid
                if (!isFound)
                {
                    txtStatus.Text = "Search phrase not found!";
                }
            }
        }

        private void btnSearchData_Click(object sender, EventArgs e)
        {
            SearchGrid();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Set the SelectedIndex of the combobox to the index 
            //if the double-clicked grid row
            if (e.RowIndex > -1)
            {
                _ComboBox.SelectedIndex = e.RowIndex;
                this.Close();
            }
        }
    }
}