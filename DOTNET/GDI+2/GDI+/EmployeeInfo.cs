using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace GDI_
{
    public partial class EmployeeInfo : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        int gender, status;
        string hobbies;
        SqlDataAdapter sqlDataAdapter;
        public EmployeeInfo()
        {
            InitializeComponent();
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\ADO.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection.Open();
            if (sqlConnection == null)
                MessageBox.Show("Connection Not Instablished!");

            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlDataAdapter = new SqlDataAdapter("Select * From Department",sqlConnection);
            DataSet dataSet=new DataSet();
            sqlDataAdapter.Fill(dataSet);
            emp_department.DataSource = dataSet.Tables[0];
            emp_department.DisplayMember = dataSet.Tables[0].Columns["department_name"].ToString();
            emp_department.ValueMember = dataSet.Tables[0].Columns["department_code"].ToString();

            emp_code.Select();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                checkBox1.Text = "Active";
            else
                checkBox1.Text = "InActive";
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if(emp_male.Checked==true)
                gender = 1;
            else
                gender = 2;
            
            if (checkBox1.Checked == true)
                status = 1;
            else
                status = 0;

            for (int i=0;i<checkedListBox1.CheckedItems.Count;i++)
            {
                if (i == 0)
                    hobbies = checkedListBox1.CheckedItems[i].ToString();
                else
                    hobbies = hobbies + "," + checkedListBox1.CheckedItems[i].ToString();
            }
            String insert_query = "INSERT INTO Employee ()";
        }
    }
    class Employee
    {
        private int emp_code;
        private int gender;
        private int status;
        private int depart_code;
        private string hobby, address,name;

        public int Emp_code { get => emp_code; set => emp_code = value; }
        public int Gender { get => gender; set => gender = value; }
        public int Status { get => status; set => status = value; }
        public int Depart_code { get => depart_code; set => depart_code = value; }
       
        public string Address { get => address; set => address = value; }
        public string Hobby { get => hobby; set => hobby = value; }
        public string Name { get => name; set => name = value; }

        Employee(int emp_code,int gender,int status,int depart_code,string hobby,string  address, string name)
        {
            this.Emp_code = emp_code;
            this.Gender = gender;
            this.Status = status;
            this.Depart_code = depart_code;
            this.Hobby = hobby;
            this.Address = address;
            this.Name = name;
        }
        Employee() { }
       
    }
}
