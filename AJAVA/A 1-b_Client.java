import java.io.IOException;
import java.net.*;
public class Practical_2_Client {

	DatagramSocket datagramSocket;
	InetAddress address;
	DatagramPacket  datagramPacket;
	public Practical_2_Client() throws IOException{
		datagramSocket=new DatagramSocket();
		address=InetAddress.getByName("172.16.1.29");
		// TODO Auto-generated constructor stub3
		byte [] buffer = new byte[1024];
		buffer="Hi, Client".getBytes();
		datagramPacket=new DatagramPacket(buffer, buffer.length,address,5000);
		datagramSocket.send(datagramPacket);
		datagramSocket.receive(datagramPacket);
		String s=new String(datagramPacket.getData(),0,datagramPacket.getLength());
		System.out.println(s.toString()+"Parth Roy");
		datagramSocket.close();
	}
	public static void main(String[] args) throws IOException{
		Practical_2_Client client=new Practical_2_Client();
	}
}
