using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace JobTrackerWinForm
{
    public partial class Form1 : Form
    {
        BindingSource appBindingSource = new BindingSource();
        BindingSource companyBindingSource = new BindingSource();



        List<JobApplication> applicationList = new List<JobApplication>();
        public Form1()
        {
            InitializeComponent();
        }
        #region buttoncmds
        private void button_loadBD_Click(object sender, EventArgs e)
        {
            JobDB applicationOne = new JobDB();
            //connect list to the grid view

            appBindingSource.DataSource = applicationOne.GetApplications();

            dataGridView1.DataSource = appBindingSource;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            JobDB applicationOne = new JobDB();
            //connect list to the grid view
            appBindingSource.DataSource = applicationOne.SearchJobs(tbox_search.Text);

            dataGridView1.DataSource = appBindingSource;
        }

        private void button_searchco_Click(object sender, EventArgs e)
        {
            JobDB applicationOne = new JobDB();
            //connect list to the grid view
            appBindingSource.DataSource = applicationOne.SearchCompany(tbox_searchco.Text);

            dataGridView1.DataSource = appBindingSource;
        }

        private void button_searchloc_Click(object sender, EventArgs e)
        {
            JobDB applicationOne = new JobDB();
            //connect list to the grid view
            appBindingSource.DataSource = applicationOne.SearchLocation(tbox_searchloc.Text);

            dataGridView1.DataSource = appBindingSource;
        }


        private void button_searchstat_Click(object sender, EventArgs e)
        {
            JobDB applicationOne = new JobDB();
            //connect list to the grid view
            appBindingSource.DataSource = applicationOne.SearchStatus(tbox_searchstat.Text);

            dataGridView1.DataSource = appBindingSource;
        }

        private void button_addapp_Click(object sender, EventArgs e)
        {
            //add new item to the database
            JobApplication newApp = new JobApplication
            {
                jobTitle = tbox_addtitle.Text,
                location = tbox_addloc.Text,
                status = tbox_addstatus.Text,
                jobUrl = tbox_addurl.Text,
                appCo = tbox_addco.Text,
                coID = int.Parse(tbox_addID.Text)
            };
            //
            JobDB addedJob = new JobDB();
            int result = addedJob.addOneJob(newApp);
            MessageBox.Show(result + " new row(s) inserted.");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            //get the row number clicked
            JobDB applications = new JobDB();

            int rowClicked = dataGridView.CurrentRow.Index;
            companyBindingSource.DataSource = applications.GetCompanyForApp((int)dataGridView.Rows[rowClicked].Cells[6].Value);
            dataGridView2.DataSource = companyBindingSource;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

            // get the row number clicked
            int rowClicked = dataGridView1.CurrentRow.Index;
            int rowID = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;
            MessageBox.Show("You selected application " + rowID);
            //call deletion method
            JobDB jobDelete = new JobDB();
            int result = jobDelete.deleteApp(rowID);
            MessageBox.Show("Deleted Application number " + rowID);
            //clear out data grid
            dataGridView1.DataSource = null;

        }

        private void button_update_Click(object sender, EventArgs e)
        {

            int rowClicked = dataGridView1.CurrentRow.Index;
            JobApplication newApp = new JobApplication
            {
                applicationNumber = (int)dataGridView1.Rows[rowClicked].Cells[0].Value,
                jobTitle = tbox_addtitle.Text,
                location = tbox_addloc.Text,
                status = tbox_addstatus.Text,
                jobUrl = tbox_addurl.Text,
                appCo = tbox_addco.Text,
                coID = int.Parse(tbox_addID.Text)
            };
            //
            JobDB addedJob = new JobDB();
            int result = addedJob.updateApplication(newApp);
            MessageBox.Show(result + " application updated.");


        }

        private void button_followURL_Click(object sender, EventArgs e)
        {
            // find url in dataview, using system.diagonostics
            int rowClicked = dataGridView1.CurrentRow.Index;
            string rowUrl = dataGridView1.Rows[rowClicked].Cells[4].Value.ToString();

            Process.Start("explorer", rowUrl);


        }

        private void button_compUrl_Click(object sender, EventArgs e)
        {
            // find url in dataview, using system.diagonostics
            int rowClicked = dataGridView2.CurrentRow.Index;
            string rowUrl = dataGridView2.Rows[rowClicked].Cells[2].Value.ToString();

            Process.Start("explorer", rowUrl);
        }
        #endregion

        private void button_addToCo_Click(object sender, EventArgs e)
        {
            //add new company to the database
            Company newCompany = new Company
            {
                name = tbox_addToCo.Text,
                website = tbox_addCoUrl.Text,
                clearedRoles = tbox_cleared.Text,
                location = tbox_hq.Text,
            };
            //
            JobDB addedCompany = new JobDB();
            int result = addedCompany.addOneCompany(newCompany);
            MessageBox.Show(result + " new row(s) inserted.");
        }
    }
}
