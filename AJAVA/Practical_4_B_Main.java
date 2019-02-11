package database;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;

public class Main {
	static DBswing swingobj;

	public static Connection makecoonnection() throws ClassNotFoundException,
			SQLException {

		Class.forName("com.mysql.jdbc.Driver"); //for mysql
		Connection con = DriverManager.getConnection(
				"jdbc:mysql://localhost/test", "root", "");
		System.out.println("Connection Established...");
		return con;

	}
	//import oracle connector
     // for oracle s16cos153 student
	public static void action() {

		swingobj.btnshow.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				String select = "select * from student";
				try {
					Connection con = makecoonnection();
					Statement st = con.createStatement();

					ResultSet rs = st.executeQuery(select);
					
					while (rs.next()) {
						System.out.println(rs.getString(1)+"    "+ rs.getString(2)+"    "
								+ rs.getString(3));
					}
				} catch (ClassNotFoundException e1) {
					e1.printStackTrace();
				} catch (SQLException e1) {
					e1.printStackTrace();
				}

			}
		});
		swingobj.btninsert.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				String id=swingobj.textid.getText();
				String name=swingobj.textname.getText();
				String spi=swingobj.textspi.getText();
				
				String insert = "insert into student(id,name,spi) values(\""+id+"\",\""+name+"\",\""+spi+"\")";
				try {
					Connection con = makecoonnection();
					Statement st = con.createStatement();
					int val=st.executeUpdate(insert);
					System.out.println("Successfully Inserted...");

				} catch (ClassNotFoundException e1) {
					e1.printStackTrace();
				} catch (SQLException e1) {
					e1.printStackTrace();
				}

			}
		});
		swingobj.btnupdate.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				String id=swingobj.textid.getText();
				String name=swingobj.textname.getText();
				String spi=swingobj.textspi.getText();
				
				String update = "UPDATE student SET name =\"" + name + "\","
						+ "spi=\"" + spi + "\" WHERE id=\"" + id + "\"";
				try {
					Connection con = makecoonnection();
					Statement st = con.createStatement();
					int val=st.executeUpdate(update);
					System.out.println("Successfully Updated...");

				} catch (ClassNotFoundException e1) {
					e1.printStackTrace();
				} catch (SQLException e1) {
					e1.printStackTrace();
				}

			}
		});
		swingobj.btndelete.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				String id=swingobj.textid.getText();
				String name=swingobj.textname.getText();
				String spi=swingobj.textspi.getText();
				
				String delete = "DELETE FROM student WHERE id=\""+id+"\"";
				try {
					Connection con = makecoonnection();
					Statement st = con.createStatement();
					int val=st.executeUpdate(delete);
					System.out.println("Successfully Deleted...");

				} catch (ClassNotFoundException e1) {
					e1.printStackTrace();
				} catch (SQLException e1) {
					e1.printStackTrace();
				}

			}
		});
		
	}

	public static void main(String[] args) throws ClassNotFoundException,
			SQLException {
		String result;

		swingobj = new DBswing();
		action();


		/*
		 * //TYPES OF EXECUTES int val=st.executeUpdate(insert);
		 * System.out.println(val);
		 * 
		 * 
		 * ResultSet rs=st.executeQuery(select); while(rs.next()){
		 * System.out.println(rs.getString(1)+rs.getString(2)+rs.getString(3));
		 * }
		 * 
		 * boolean b=st.execute(select); System.out.println(b);
		 */

	}

}
