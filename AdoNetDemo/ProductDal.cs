using System.Data;
using System.Data.SqlClient;


namespace AdoNetDemo;

public class ProductDal
{
    public DataTable GetAll()
    {
        SqlConnection connection=new SqlConnection(@"server=ferhat\sqlexpress;initial catalog=ETrade;integrated security=true;");
        if (connection.State==ConnectionState.Closed)
        {
            connection.Open();
        }
        SqlCommand command=new SqlCommand("Select * from Products",connection);
        SqlDataReader reader=command.ExecuteReader();
        DataTable dataTable=new DataTable();
        dataTable.Load(reader);
        reader.Close();
        connection.Close();
        return dataTable;
        
        
        
    }
}
