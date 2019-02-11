import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.*;
import java.util.Arrays;
public class Server {

	public static void main(String[] args) {
		try {
			ServerSocket ss = new ServerSocket(3333);
			Socket s = ss.accept();
			DataInputStream dis = new DataInputStream(s.getInputStream());
			DataOutputStream dos = new DataOutputStream(s.getOutputStream());
			int n = dis.read();
			System.out.println(n);
			byte a[] = new byte[n];
			dis.read(a);
			int aa[] = new int[n];
			int count = 0;
			for(byte i:a){aa[count] = (int)i;count++;}
			Arrays.sort(aa);
			count = 0;
			for(int i:aa){a[count] = (byte)i;count++;}
			dos.write(a);
			s.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

}
