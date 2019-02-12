import java.net.*;
import java.util.Objects;
import java.io.*;

public class Exam_Server {

	Socket socket;
	ServerSocket serverSocket;

	BufferedReader reader;
	DataInputStream dataInputStream;
	DataOutputStream dataOutputStream;

	String out;

	public Exam_Server() throws IOException {

		try {
			serverSocket = new ServerSocket(1234);
			socket = serverSocket.accept();
			System.out.print("Connection Enstablished!");

			// reader=new DataInputStream(System.in);
			dataInputStream = new DataInputStream(new BufferedInputStream(
					socket.getInputStream()));
			dataOutputStream = new DataOutputStream(new BufferedOutputStream(
					socket.getOutputStream()));

			String str1;
			str1 = dataInputStream.readUTF();
			System.out.println(str1 + "\n");

			clientMethods(str1);
			socket.close();
			serverSocket.close();

		} catch (IOException ex) {
			ex.printStackTrace();
		}
		// TODO Auto-generated constructor stub
	}

	public void clientMethods(String s) {
		int word=0;
		int j=0;
		int ch;
		char [] str_out=s.toCharArray();
		for (int i = 0; i < s.length()-1; i++) {
			if(s.charAt(i) == ' ')
			{
				j=i+1;
//				str_out[i]
				if(s.charAt(j)>=97&&s.charAt(j)<=123)
					{
						ch=(int)s.charAt(j)-(int)32;
						str_out[j]=(char)ch;
						//System.out.println(str_out[j]);
					}
				word++;
			}
			if(i==0)
			{
				if(s.charAt(j)>=97&&s.charAt(j)<=123)
				{
					ch=(int)s.charAt(j)-(int)32;
					str_out[j]=(char)ch;
					//System.out.println(str_out[j]);
				}
			}
			
		}
		word++;
		s=new String(str_out);
		System.out.println(s);
		out="No of Words :- "+word+" No of Char :-"+s.length()+" String:- "+s+"";
		
		try {
			dataOutputStream.writeUTF(out);
			dataOutputStream.flush();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		Exam_Server exam_Server = new Exam_Server();
	}

}
