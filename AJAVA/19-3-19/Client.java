import java.rmi.*;
import java.rmi.registry.*;
class Client{
    
    public static void main(String[] args) throws RemoteException {
        Registry reg=LocateRegistry.getRegistry(4000);
        
        try {
            
            AddItem stub=(AddItem)reg.lookup("obj");    
            System.out.println(stub.addItem(10,20));
        } catch (Exception e) {
            System.out.println(e);
            //TODO: handle exception
        } 
    }
}