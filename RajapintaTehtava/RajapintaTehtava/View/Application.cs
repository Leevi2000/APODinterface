using RajapintaTehtava.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RajapintaTehtava
{
    public partial class Application : Form
    {
        Controller.Controller controller = new Controller.Controller();
        Search.Response currentResult = new Search.Response();

        List<Button> bookmarkBtnList = new List<Button>();

        public Application()
        {
            if (!controller.VerifyDB())
            {
                MessageBox.Show("There was a problem verifying the database. Bookmarks can't be used.");
            }

            InitializeComponent();
            DisplayBookmarks();
            Looper(this);
            tbURL.Visible = false;
        }

        /// <summary>
        /// Assigns a MouseClick event to given control and all of it's child controls.
        /// </summary>
        /// <param name="ctrl"></param>
        private void Looper(Control ctrl)
        {
            ctrl.Click += new EventHandler(ClickControl);
            foreach (Control i in ctrl.Controls)
            {
                if (i.HasChildren)
                {
                    Looper(i);
                }
                else
                {
                    i.Click += new EventHandler(ClickControl);
                }
            }
        }

        private void ClickControl(object s, EventArgs e)
        {
            if ((Control)s != gbBookmarks && (Control)s != flowPanel && (Control)s != btnExpandBM)
            {
                ExpandBookmarks(true);
            }
        }

        /// <summary>
        /// Expands or shrinks the bookmarks control.
        /// </summary>
        /// <param name="shrink"></param>
        private void ExpandBookmarks(bool shrink = false)
        {
            if (shrink)
            {
                flowPanel.Height = 23;
                gbBookmarks.Height = 43;
            }
            else
            {
                flowPanel.Height = 150;
                gbBookmarks.Height = 170;
            }
        }

        /// <summary>
        /// Gets bookmarks from the database and displays them for the user.
        /// </summary>
        private void DisplayBookmarks()
        {
            List<Bookmark> bookmarkList = controller.GetBookmarks();

            // Removing obsolete buttons
            flowPanel.Controls.Clear();
            foreach (var b in bookmarkBtnList)
            {
                b.Dispose();
            }
            foreach (var bookmark in bookmarkList)
            {
                Button b = new Button();
                b.Height = 20;
                b.Tag = bookmark.Date.ToString("yyyy-MM-dd");
                b.Text = bookmark.Name;
                Size txtSize = TextRenderer.MeasureText(bookmark.Name, b.Font);
                b.Width = 150;
                b.MouseClick += new MouseEventHandler(ClickBookmark);
                flowPanel.Controls.Add(b);
                bookmarkBtnList.Add(b);
            }
        }

        /// <summary>
        /// Gets a random picture.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Search.Search obj = new Search.Search(tbAuth.Text, true);
            Search(obj);
        }

        /// <summary>
        /// Gets a latest picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToday_Click(object sender, EventArgs e)
        {
            Search.Search obj = new Search.Search(tbAuth.Text);
            Search(obj);
        }

        private void ClickBookmark(object s, MouseEventArgs e)
        {
            Button b = (Button)s;
            Search.Search obj = new Search.Search(tbAuth.Text, DateTime.Parse(b.Tag.ToString()));
            Search(obj);
        }

        /// <summary>
        /// Saves current picture as a bookmark to the database.
        /// </summary>
        private void SaveBookmark()
        {
            controller.SaveBookmark(new Controller.Bookmark(currentResult.Title, DateTime.Parse(currentResult.Date)));
        }

        /// <summary>
        /// Displays information given from the Respone object.
        /// </summary>
        /// <param name="result"></param>
        private async void DisplayResult(Search.Response result)
        {
            if (result != null)
                try
                {
                    if (result.Url.Contains("youtube")) { await LoadVideo(result.Url); webVideo.Visible = true; pBox.Image = null; }
                    else { pBox.LoadAsync(result.Url); webVideo.Visible = false; webVideo.DocumentText = null; }

                    rtb.Text = result.Title + "\n \n" + result.Explanation;

                    lbDate.Text = $"{result.Date}";
                    if (result.Copyright != null) lbCopyright.Text = $"Copyright: {result.Copyright}";
                    else lbCopyright.Text = "";

                    tbURL.Visible = true;
                    tbURL.Text = result.Url;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
        }

        /// <summary>
        /// Loads a youtube url to web component
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private async Task LoadVideo(string url)
        {
            var embed = $"<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            $"<iframe width=\"{webVideo.Width}\" height=\"{webVideo.Height}\" " +
            "src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";

            this.webVideo.DocumentText = string.Format(embed, url);
        }

        /// <summary>
        /// Common search method. Give Search object and this searches and displays the results.
        /// </summary>
        /// <param name="searchObj"></param>
        private void Search(Search.Search searchObj)
        {
            currentResult = controller.APISearch(searchObj);
            DisplayResult(currentResult);
        }

        /// <summary>
        /// Changes the text size of picture explanation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            rtb.ZoomFactor = float.Parse(numericUpDown1.Value.ToString());
        }

        /// <summary>
        /// Search after changing date in dateTimePicker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Search.Search obj = new Search.Search(tbAuth.Text, DateTime.Parse(dateTimePicker1.Text));
            Search(obj);
        }

        /// <summary>
        /// Add new bookmark. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBookmark_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentResult == null)
                {
                    Console.WriteLine("Can't add a bookmark. Your previous result did not succeed.");
                }
                else
                {
                    if (currentResult.Title != null && currentResult.Title != "")
                    {
                        bool bookmarkExists = false;
                        foreach (Control i in flowPanel.Controls)
                        {
                            if (i.Tag.ToString() == currentResult.Date.ToString()) // Picture date is certainly unique. One pic per day.
                            {
                                bookmarkExists = true;
                                break;
                            }
                        }

                        if (!bookmarkExists) // Do not add bookmark if the bookmark exists already.
                        {
                            SaveBookmark();
                            DisplayBookmarks();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Opens up the bookmark manager dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManage_Click(object sender, EventArgs e)
        {
            View.BookmarkManager bookmarkManager = new View.BookmarkManager();
            bookmarkManager.ShowDialog();

            DisplayBookmarks();
        }

        /// <summary>
        /// Expands or shrinks the bookmark list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpandBM_Click(object sender, EventArgs e)
        {
            bool shrink;
            if (flowPanel.Height == 150) shrink = true;
            else shrink = false;
            ExpandBookmarks(shrink);
        }

        /// <summary>
        /// Open creator's github page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Leevi2000");
        }

        /// <summary>
        /// Opens a help document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1AZyBa5MHGcev7kvjisQFuTfvus3OEwwXUybZsZcdklM/edit?usp=sharing");
        }
    }
}
