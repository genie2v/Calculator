using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Calculator2
{
    public partial class Form2 : Form
    {
        private string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                + "(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));"
                + "User Id=person1;password=person;";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CalcRecord();
        }

        private void CalcRecord()
        {
            try
            {
                updateTextBox.Text = String.Empty;
                OracleConnection conn = new OracleConnection(strConn);

                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT CALCTIME, EXP, RESULT, ID FROM CALCRECORD ORDER BY CALCTIME";

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                conn.Close();

                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB connection fail: " + ex);
                this.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {   
                if (this.dataGridView1.RowCount == 0) return;

                DataGridViewRow row = dataGridView1.SelectedRows[0];
                String deleteData = row.Cells["ID"].Value.ToString();
                //MessageBox.Show(deleteData);

                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "DELETE FROM CALCRECORD WHERE ID ='" + deleteData + "'";
                int result = cmd.ExecuteNonQuery();

                conn.Close();

                if (result < 0) return;

                //MessageBox.Show("삭제성공");

                CalcRecord();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount == 0) return;

            //String updateCell = dataGridView1.CurrentCell.Value.ToString();
            int colIndex = dataGridView1.CurrentCell.ColumnIndex;
            String updateValue = updateTextBox.Text.ToString();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            String updateID = row.Cells["ID"].Value.ToString();

            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            if (colIndex == 1)
            {
                cmd.CommandText = "UPDATE CALCRECORD SET EXP ='" + updateValue 
                    + "', MODIFYTIME = SYSDATE WHERE ID ='" + updateID + "'";
                cmd.ExecuteNonQuery();
                //MessageBox.Show("수정성공");
            }
            else if (colIndex == 2)
            {
                cmd.CommandText = "UPDATE CALCRECORD SET RESULT ='" + updateValue 
                    + "', MODIFYTIME = SYSDATE WHERE ID ='" + updateID + "'";
                cmd.ExecuteNonQuery();
               // MessageBox.Show("수정성공");
            }
            else MessageBox.Show("수정불가");
            conn.Close();
            updateTextBox.Text = String.Empty;
            
            CalcRecord();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String selectCell = dataGridView1.CurrentCell.Value.ToString();
            int colIndex = dataGridView1.CurrentCell.ColumnIndex;
            if (colIndex == 0 || colIndex == 3)
            {
                updateTextBox.Text = String.Empty;
                return;
            }
            updateTextBox.Text = selectCell;
        }
    }
}
