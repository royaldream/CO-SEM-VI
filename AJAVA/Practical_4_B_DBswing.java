package database;
import java.awt.*;
import java.awt.event.*;

import javax.swing.*;

public class DBswing  {
	JFrame mainFrame;
	JLabel title;
	 JLabel id;
	 JLabel name;
	 JLabel spi;
	 JTextField textid;
	 JTextField textname;
	 JTextField textspi;
	 JButton btninsert;
	 JButton btnshow;
	 int flag=0;
	 JButton btnupdate;
	 JButton btndelete;
	
	public DBswing(){
		  mainFrame = new JFrame("Database");
	      mainFrame.setSize(500,500);
	      mainFrame.setLayout(null); 
	      
	      
	      
	      title=new JLabel("Student Table");
	       title.setBounds(50,00,150,20);
	      
	      id=new JLabel("ID");
	      id.setBounds(10,40,100,20);
	      textid=new JTextField("");
	       textid.setBounds(100,40,120,20);

	      name=new JLabel("Name");
	      name.setBounds(10,70,100,20);
	        textname=new JTextField("");
	       textname.setBounds(100,70,120,20);

	      spi=new JLabel("SPI");
	      spi.setBounds(10,100,100,20);
	        textspi=new JTextField("");
	       textspi.setBounds(100,100,120,20);
	       
			btninsert=new JButton("INSERT");
	        btninsert.setBounds(10,130,100,20);
	    
			
			
			btnupdate=new JButton("UPDATE");
	        btnupdate.setBounds(10,160,100,20);
	    
			btnshow=new JButton("SHOW ALL");
			btnshow.setBounds(10,190,100,20);
	     
			btndelete=new JButton("DELETE");
	        btndelete.setBounds(10,220,100,20);
			
		   mainFrame.add(title);
	       mainFrame.add(id);
	       mainFrame.add(textid);
	       mainFrame.add(name);
	       mainFrame.add(textname);
	       mainFrame.add(spi);
	       mainFrame.add(textspi);
	       mainFrame.add(btninsert);
	       mainFrame.add(btnupdate);
	       mainFrame.add(btnshow);
	       mainFrame.add(btndelete);
           mainFrame.setVisible(true);
	}
}
