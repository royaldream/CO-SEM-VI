import java.net.*;
import java.io.*;
public class Practical_1_Server {

	ServerSocket serverSocket;
	Socket socket;
	InputStream inputStream;
	OutputStream outputStream; 
	public Practical_1_Server() throws IOException{
		// TODO Auto-generated constructor stub
		
		serverSocket=new ServerSocket(4444);
		System.out.println("Create Server");
		
		socket=serverSocket.accept();
		System.out.println("get client");
		
//		inputStream=new DataInputStream(System.in);
		outputStream=new DataOutputStream(new BufferedOutputStream(socket.getOutputStream()));
		
		
		outputStream.write("Hi I am Server".getBytes());
		outputStream.flush();
		socket.close();
		serverSocket.close();
	
	}
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		Practical_1_Server practical_1_Server=new Practical_1_Server();

	}

}
