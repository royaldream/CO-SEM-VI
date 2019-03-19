import java.rmi.*;
import java.rmi.registry.*;
import java.util.*;
class Client{
    
    public static void main(String[] args) throws RemoteException {
        Registry reg=LocateRegistry.getRegistry(4000);
        Scanner s=new Scanner(System.in);
        try {
            AritmeticInterface stub=(AritmeticInterface)reg.lookup("obj");    
            int ch=0;
            System.out.println("1 : Addition\n2 : Subtraction\n3 : Multiplication\n4 : Divide\n0 : Exit\n");
            ch=s.nextInt();
            while(true)
            {
                if(ch==0)
                    break;
                    int a,b;
                    a=s.nextInt();
                    b=s.nextInt();
                switch (ch) {
                    case 1:
                        System.out.println("Addition : "+ stub.add((double)a,(double)b));
                        break;
                    case 2:
                        System.out.println("Subtraction : "+ stub.sub((double)a,(double)b));
                        break;
                    case 3:
                        System.out.println("Multiplication : "+ stub.mul((double)a,(double)b));
                        break;
                    case 4:
                        System.out.println("Division : "+ stub.div((double)a,(double)b));
                        break;
                    default:
                        System.out.println("Wrong Input!");
                        break;
                }
                System.out.println("1 : Addition\n2 : Subtraction\n3 : Multiplication\n4 : Divide\n0 : Exit\n");
                ch=s.nextInt();
            }
        } catch (Exception e) {
            System.out.println(e);
        } 
    }
}