import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.*;
import java.util.Scanner;
public class Client {

	public static void main(String[] args) {
		try {
			Socket s = new Socket("localhost", 3333);
			DataInputStream dis = new DataInputStream(s.getInputStream());
			DataOutputStream dos = new DataOutputStream(s.getOutputStream());
			Scanner sc = new Scanner(System.in);
			System.out.println("Enter length of array : ");
			int n = sc.nextInt();
			dos.write(n);
			System.out.println("Enter Values : ");
			byte a[] = new byte[n];
			for(int i=0;i<n;i++){
				a[i] = (byte)sc.nextInt();
			}
			dos.write(a);
			byte[] op = new byte[n];
			dis.read(op);
			System.out.println("Sorted Array");
			for(byte i:op){System.out.println((int)i);}
			s.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

}
