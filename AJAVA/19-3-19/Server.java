import java.rmi.*;
import java.rmi.server.*;
import java.rmi.registry.*;

class Server {

    public static void main(String[] args) throws RemoteException {
        AddItem a1=new TestAdd();
        AddItem stub=(AddItem)UnicastRemoteObject.exportObject(a1,0);
        Registry reg=LocateRegistry.createRegistry(4000);
        reg.rebind("obj",stub);
    }
} 