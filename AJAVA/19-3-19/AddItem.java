import java.rmi.*;
interface AddItem extends Remote
{
    public int addItem(int a,int b) throws RemoteException;
} 