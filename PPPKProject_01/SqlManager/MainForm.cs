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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init() => CbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void CbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbTables.DataSource = (CbDatabases.SelectedItem as Database).Tables;
            LbViews.DataSource = (CbDatabases.SelectedItem as Database).Views;
            LbProcedures.DataSource = (CbDatabases.SelectedItem as Database).Procedures;
        }

        private void LbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbTableColumns.DataSource = (LbTables.SelectedItem as DBEntity).Columns;
        }

        private void LbViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbViewColumns.DataSource = (LbViews.SelectedItem as DBEntity).Columns;
        }

        private void LbProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbDefinition.Text = (LbProcedures.SelectedItem as Procedure).Definition;
            LbParameters.DataSource = (LbProcedures.SelectedItem as Procedure).Parameters;
        }

        private void SelectButtonClicked(object sender, EventArgs e)
        {
            DBEntity dBEntity = null;
            switch ((sender as Button).Name)
            {
                case nameof(BtnSelectTable):
                    dBEntity = LbTables.SelectedItem as DBEntity;
                    break;
                case nameof(BtnSelectView):
                    dBEntity = LbViews.SelectedItem as DBEntity;
                    break;
            }
            DataSet ds = RepositoryFactory.GetRepository().CreateDataSet(dBEntity);
            new SelectResultsForm(ds.Tables[0]).ShowDialog();
        }

        private void tsNewQuery_Click(object sender, EventArgs e)
        {
            new NewQueryForm(CbDatabases.SelectedItem.ToString()).ShowDialog();
        }
    }
}
