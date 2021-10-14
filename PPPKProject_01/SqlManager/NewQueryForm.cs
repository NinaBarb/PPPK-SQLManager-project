using SqlManager.Dal;
using SqlManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlManager
{
    public partial class NewQueryForm : Form
    {
        public NewQueryForm(string databaseName)
        {
            InitializeComponent();
            Init(databaseName);
        }

        private void Init(string databaseName)
        {
            SetStatusText(databaseName);
            SetUsingDatabase(databaseName);
        }

        private void SetUsingDatabase(string databaseName)
        {
            TbQuery.Text = string.Format("use {0}", databaseName);
        }

        private void SetStatusText(string databaseName)
        {
            LbStatus.Text = string.Format("using {0}", databaseName);
        }

        private void TsExecute_Click(object sender, EventArgs e)
        {
            Flp.Controls.Clear();
            tabControl1.SelectedTab = TabResults;
            try
            {
                DataSet  ds= RepositoryFactory.GetRepository().ExecuteQuery(TbQuery.Text);
                int numOfTables = ds.Tables.Count;
                DataTable dt = ds.Tables[numOfTables-1];
                LbMessage.Text = $"({string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)))}  " + $"rows affected)\nCompletion time: {DateTime.Now}";
                LbMessage.ForeColor = Color.Black;

                foreach (DataTable dataTable in ds.Tables)
                {
                    if (dataTable == dt) return;
                    DataGrid results = new DataGrid();
                    results.DataSource = dataTable;
                    results.Width = Flp.Width;
                    Flp.Controls.Add(results);
                }
            }
            catch (Exception ex)
            {
                LbMessage.Text = ex.Message;
                tabControl1.SelectedTab = TabMsg;
            }
        }

        private void NewQueryForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.X)
            {
                TsExecute.PerformClick();
            }
        }
    }
}
