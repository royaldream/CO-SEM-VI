import java.net.*;
import java.util.Scanner;
import java.io.*;

public class Exam_Client {

	Socket socket;
//	ServerSocket serverSocket;

	BufferedReader reader;
	DataInputStream dataInputStream;
	DataOutputStream dataOutputStream;
	public Exam_Client() throws IOException {

		try {
//			serverSocket = new ServerSocket(4444);
			socket = new Socket("172.16.1.5",1234);
			System.out.print("Connection Sucessfully!");
			
//			reader=new DataInputStream(System.in);
			dataInputStream=new DataInputStream(new BufferedInputStream(socket.getInputStream()));
			dataOutputStream=new DataOutputStream(new BufferedOutputStream(socket.getOutputStream()));
			Scanner s=new Scanner(System.in);
			System.out.print("\nInsert String\n");
			String str=s.nextLine();
			dataOutputStream.writeUTF(str+"");
			dataOutputStream.flush();
			String str1;
			str1 = dataInputStream.readUTF();
			System.out.println(str1 + "\n");
//			String str1;
//			str1=dataInputStream.readLine();
//			System.out.println(str1+"\n");
			socket.close();
//			serverSocket.close();
			
		} catch (IOException ex) {
			ex.printStackTrace();
		}
		// TODO Auto-generated constructor stub
	}


	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
Exam_Client client=new Exam_Client();
	}

}
