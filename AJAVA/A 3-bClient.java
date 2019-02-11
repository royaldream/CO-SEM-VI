import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.*;
import java.util.Scanner;
public class Client {
	public static void main(String[] args) {
		Socket s;
		Scanner sc = new Scanner(System.in);
		DataInputStream dis;
		DataOutputStream dos;
		try {
			s = new Socket("localhost", 1234);
			dis = new DataInputStream(s.getInputStream());
			dos = new DataOutputStream(s.getOutputStream());
			System.out.println("Enter The string : ");
			String str = sc.nextLine();
			dos.writeUTF(str);
			str = dis.readUTF();
			System.out.println(str);
			s.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

}
