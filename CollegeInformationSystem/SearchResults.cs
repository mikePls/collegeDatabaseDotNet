using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeInformationSystem
{
    public sealed partial class ResultsForm : UserControl
    {
        QueryHelper queryHelper;
        string tableName;
        private static ResultsForm? instance = null;
        private ResultsForm()
        {
            InitializeComponent();

            queryHelper = QueryHelper.GetInstance;
        }

        /// <summary>
        /// Takes a table name and additional parameters which sends
        /// to sqlhelper.Then displays the resulting data on datagrid
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="args"></param>
        public void View(string tableName, string? args)
        {
            this.tableName = tableName;
            Visible = true;
            dataGrid.DataSource = queryHelper.FindAll(tableName, args);
            dataGrid.DataMember = tableName;
            if(tableName == "student")
            {
                headerLbl.Text = $"Showing results from '{tableName}' table.\n" +
                $"Double-click on row to view individual student record.";
            }
            else
            {
                headerLbl.Text = $"Showing results from '{tableName}' table.\n";
            }
            
        }

        /// <summary>
        /// Returns the instance of this Singleton class.
        /// </summary>
        public static ResultsForm GetInstance
        {
            get { return instance ?? (instance = new ResultsForm()); }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //get first column value(student id) from selected row and store it as string
            string? student_id = dataGrid.CurrentRow.Cells[0].Value.ToString();
            //if resulted string is not null, find student and show resulting RecordCard
            if(student_id != null && tableName == "student")
            {
                StudentRecordCard.GetInstance.LoadRecord(student_id);
            }
        }
    }
}
