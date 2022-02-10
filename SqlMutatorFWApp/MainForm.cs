using SqlMutatorCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlMutatorFWApp
{
    public partial class formSqlMutatorMainForm : Form
    {
        public string FilePath { get; set; }
        public string FileContent { get; set; }
        public SqlMutatorMainRunner MainRunner { get; set; }

        public formSqlMutatorMainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\anas\source\repos\repos\SQLMutatorSample\SQLMutatorSample";
                openFileDialog.Filter = "CSharp files (*.cs)|*.cs|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtFilePath.Text = openFileDialog.FileName;
                    FilePath = txtFilePath.Text;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        FileContent = reader.ReadToEnd();
                    }

                    rtbCode.Text = FileContent;

                    // Initializing Main Runner object and enabling mutation buttons.
                    MainRunner = new SqlMutatorMainRunner(FilePath, FileContent);
                    btnSelOperator.Enabled = true;
                    btnOrdOperators.Enabled = true;
                    btnUniOperators.Enabled = true;
                    btnRelationalOperators.Enabled = true;
                    btnLogicalOperators.Enabled = true;
                    btnNullOperators.Enabled = true;
                }
            }
        }

        private void btnSelOperator_Click(object sender, EventArgs e)
        {
            try
            {
                MainRunner.StartMutation(SqlMutatorMainRunner.MutationType.SelectToSelectDistinct);
                MainRunner.StartMutation(SqlMutatorMainRunner.MutationType.SelectDistinctToSelect);

                MessageBox.Show("Mutations are Completed.", "Completed");
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private void btnOrdOperators_Click(object sender, EventArgs e)
        {
            try
            {
                MainRunner.StartMutation(SqlMutatorMainRunner.MutationType.OrderByToOrderByDesc);
                MainRunner.StartMutation(SqlMutatorMainRunner.MutationType.OrderByDescToOrderBy);

                MessageBox.Show("Mutations are Completed.", "Completed");
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private void btnUniOperators_Click(object sender, EventArgs e)
        {
            try
            {
                MainRunner.StartMutation(SqlMutatorMainRunner.MutationType.UnionToUnionAll);
                MainRunner.StartMutation(SqlMutatorMainRunner.MutationType.UnionAllToUnion);

                MessageBox.Show("Mutations are Completed.", "Completed");
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private void btnRelationalOperators_Click(object sender, EventArgs e)
        {
            try
            {
                MainRunner.StartMutation(SqlMutatorMainRunner.MutationType.RelationalOperator);

                MessageBox.Show("Mutations are Completed.", "Completed");
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private void btnLogicalOperators_Click(object sender, EventArgs e)
        {
            try
            {
                MainRunner.StartMutation(SqlMutatorMainRunner.MutationType.LogicalOperator);

                MessageBox.Show("Mutations are Completed.", "Completed");
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private void btnNullOperators_Click(object sender, EventArgs e)
        {
            try
            {
                MainRunner.StartMutation(SqlMutatorMainRunner.MutationType.NullOperator);

                MessageBox.Show("Mutations are Completed.", "Completed");
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private void HandleException(Exception ex)
        {
            if (ex is NotImplementedException)
                MessageBox.Show("\"" + ex.Message + "\" is not implemented yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Error from SQL Mutator Core: " + ex.Message + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}



