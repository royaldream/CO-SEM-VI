import java.rmi.*;
import java.rmi.server.*;
import java.rmi.registry.*;

class Server {

    public static void main(String[] args) throws RemoteException {
        AritmeticInterface a1=new AritmeticClass();
        AritmeticInterface stub=(AritmeticInterface)UnicastRemoteObject.exportObject(a1,0);
        Registry reg=LocateRegistry.createRegistry(4000);
        reg.rebind("obj",stub);
    }
} 