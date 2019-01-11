using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet("emp");
            //아래 onj 는 $ORACLE_HOME/network/admin 의 tnsnames.ora 파일에 정의된 TNS 이름
            //string conStr = "Provider=ORAOLEDB.ORACLE;data source=topcredu;User ID = scott; Password = tiger";
            string conStr = "Provider=OraOLEDB.ORACLE;data source=topcredu;User ID=scott;Password=tiger";
            using (OleDbConnection connection = new OleDbConnection(conStr))
            {
                OleDbCommand command = new OleDbCommand();
                OleDbTransaction tr = null;
                try
                {
                    connection.Open();
                    tr = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = tr;
                    command.CommandText = "insert into emp (empno, ename)"
                    + " values (1309, '3000 길동')";
                    int i = command.ExecuteNonQuery();
                    Console.WriteLine(i + "건 Inserted!");
                    command.CommandText = "insert into emp (empno, ename)"
                    + " values (1310, '3000 길동')";
                    i = command.ExecuteNonQuery();
                    tr.Commit();
                    adapter = new OleDbDataAdapter("select * from emp", connection);
                    adapter.Fill(ds, "EMP");
                    dataGridView1.DataSource = ds.Tables["EMP"];
                    adapter.Fill(ds, "EMP");
                }
                catch (Exception ex)
                {
                    tr?.Rollback();
                    MessageBox.Show(ex.Message, "emp Table Loading Error");
                }
                finally
                {
                    connection.Close();
                }

            }
        }
    }
}
