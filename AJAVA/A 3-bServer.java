import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.*;
class Handler implements Runnable{
	Socket s;
	DataInputStream dis;
	DataOutputStream dos;
	Thread t;
	public Handler(Socket s) {
		this.s = s;
		t = new Thread(this);
		t.start();
		System.out.println("No of Clients : "+Server.Client_Counter);
	}
	public void run() {
		try {
			dis = new DataInputStream(s.getInputStream());
			dos = new DataOutputStream(s.getOutputStream());
			String str = dis.readUTF();
			StringBuilder sb = new StringBuilder(str);
			sb.reverse();
			str = sb.toString();
			dos.writeUTF("Reversed String : "+str);
			s.close();
			Server.Client_Counter--;
			System.out.println("No of Clients : "+Server.Client_Counter);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
public class Server {
	static int Client_Counter=0;
	public static void main(String[] args) {
		ServerSocket ss;
		Socket s;
		while(true) {
			try {
				ss = new ServerSocket(1234);
				s = ss.accept();
				Server.Client_Counter++;
				new Handler(s);
				ss.close();
			} catch (Exception e) {
				e.printStackTrace();
			}
		}
	}

}
