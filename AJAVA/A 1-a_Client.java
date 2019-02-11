import java.io.*;
import java.net.*;
public class Practical_1_Client {

	static Socket socket;
	static DataInputStream  inputStream;
	static DataOutputStream outputStream;
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub

		socket=new Socket("172.16.1.29",4444);
		System.out.print("Connection Sussefully\n");
		
		inputStream=new DataInputStream(new BufferedInputStream(socket.getInputStream()));
		
		String s=inputStream.readLine();
		System.out.println("server call :- "+s+"");
		
		inputStream.close();
		socket.close();
//		outputStream=new DataOutputStream(socket.getOutputStream());
//		socket.get
	}

}
