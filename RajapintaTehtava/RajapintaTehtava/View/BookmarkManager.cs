using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RajapintaTehtava.View
{
    public partial class BookmarkManager : Form
    {
        Controller.Controller controller = new Controller.Controller();
        List<int> rowsToDelete = new List<int>();
        public BookmarkManager()
        {
            try
            {
                InitializeComponent();
                dataGridView1.DataSource = controller.GetBookmarksDatatable();
                if (dataGridView1.Columns != null) // Error handler if there is no bookmarks.
                    dataGridView1.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Adds deleted datagrid rows to list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var id = int.Parse(e.Row.Cells[0].Value.ToString());
            rowsToDelete.Add(id);
        }

        /// <summary>
        /// Deletes bookmarks from database. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var i in rowsToDelete)
                {
                    controller.RemoveBookmark(i);
                }
            }
            catch (Exception ex)
            {

            }
            this.Dispose();
        }
    }
}
