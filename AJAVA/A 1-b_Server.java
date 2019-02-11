import java.net.*;
import java.io.*;
public class Practical_2_Server {

	DatagramSocket datagramSocket;
	DatagramPacket datagramPacket;
	
	public Practical_2_Server() throws IOException {
		
		datagramSocket=new DatagramSocket(2222);
		System.out.println("Create Server");
		byte [] buffer1=new byte[1024];
//		System.out.print(buffer+"\n"+s.getBytes()+"\n");
		datagramPacket=new DatagramPacket(buffer1, buffer1.length);
			
		datagramSocket.receive(datagramPacket);
//		InputStream outputStream=new DataInputStream(new BufferedInputStream());
		System.out.println(datagramPacket.getData().toString()+"\n"+datagramSocket.getReceiveBufferSize());
		/*String s=new String("Hi I am Server");
		buffer1=s.getBytes();		
		DatagramPacket  packet=new DatagramPacket(buffer1, buffer1.length,datagramPacket.getAddress(),datagramPacket.getPort());
		

		datagramSocket.send(datagramPacket);
		System.out.println("send Data Packet");*/
		datagramSocket.close();
		// TODO Auto-generated constructor stub
	}
	public static void main(String[] args) throws IOException{
		Practical_2_Server practical_2_Server=new Practical_2_Server();
	}
}
