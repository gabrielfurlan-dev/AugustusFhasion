//using AugustusFahsion.Model;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AugustusFahsion.DAO
//{
//    class EmailDAO
//    {
//        private void EnviarEmail(VendaModel vendaModel)
//        {
//            SqlConnection sqlConnection = new SqlConnection();
//            sqlConnection.ConnectionString = "server = YOURSERVERNAME; database = YOURDBNAME; User ID = sa; Password = YOURPASSWORD"; //Connection Details  
//                                                                                                                                      //select fields to mail example student details  
//            SqlCommand sqlCommand = new SqlCommand("select Name,DOB,Email,Mob from Student", sqlConnection); //select query command  
//            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
//            sqlDataAdapter.SelectCommand = sqlCommand; //add selected rows to sql data adapter  
//            DataSet dataSetStud = new DataSet(); //create new data set  
//            try
//            {
//                sqlDataAdapter.Fill(dataSetStud, "student"); //fill sql data adapter rows to data set  
//                dgStudent.ColumnCount = 4;
//                dgStudent.Columns[0].HeaderText = "Student Name";
//                dgStudent.Columns[0].DataPropertyName = "Name";
//                dgStudent.Columns[1].HeaderText = "Date of birth";
//                dgStudent.Columns[1].DataPropertyName = "DOB";
//                dgStudent.Columns[2].HeaderText = "Mail Id";
//                dgStudent.Columns[2].DataPropertyName = "Email";
//                dgStudent.Columns[3].HeaderText = "Mobile No";
//                dgStudent.Columns[3].DataPropertyName = "Mob";
//                dgStudent.DataSource = dataSetStud;
//                dgStudent.DataMember = "student";
//            }
//            catch (Exception Ex)
//            {
//                System.Windows.Forms.MessageBox.Show(Ex.Message);
//                sqlConnection.Close();
//            }
//        }
//    }
//}
