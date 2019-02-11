import java.sql.*;

public class LoginForm {
	public static void main(String[] args) {
		try{
		Class.forName("com.mysql.jdbc.Driver");
		Connection con=DriverManager.getConnection("jdbc:mysql://localhost/mysql","root","");
		Statement stmt=con.createStatement();
		String sql="abc",b="comp";
		//boolean rs2=stmt.execute("insert into student(id,name,branch) values(6,\""+sql+"\",\""+b+"\")");
		ResultSet rs=stmt.executeQuery("select * from student");
		rs.setFetchDirection(ResultSet.FETCH_REVERSE);
		rs.last();
		while(rs.previous())
		{
			//String name=rs.getString("name");
			System.out.println("Id : "+rs.getString(1)+"  Name : "+rs.getString(2)+"  Branch : "+rs.getString(3)); 
		}
	
		}
		 catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

}
