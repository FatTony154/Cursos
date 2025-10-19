import java.util.Scanner;

public class OperadoresLogicosLogin {
    public static void main(String[] args)
    {
//        String[] usernames = new String[3];
//        String[] passwords = new String[3];
//        usernames[0] = "antonio";
//        passwords[0] = "12345";
//
//        usernames[1] = "admin";
//        passwords[1] = "12345";
//
//        usernames[2] = "pepe";
//        passwords[2] = "12345";

        String[] usernames = {"antonio", "admin", "pepe"};
        String[] passwords = {"123", "1234", "12345"};

        Scanner scanner = new Scanner(System.in);

        System.out.println("Ingrese el username");
        String u = scanner.next();

        System.out.println("Ingrese el password");
        String p = scanner.next();

        Boolean isAuthenticated = false;

        for(var i = 0; i < usernames.length; i++)
        {
            isAuthenticated =  (usernames[i].equals(u) && passwords[i].equals(p)) ? true : isAuthenticated;
            /*if(usernames[i].equals(u) && passwords[i].equals(p))
            {
                isAuthenticated = true;
                break;
            }*/
        }
        String mensaje = isAuthenticated ?
                "Bienvenido usuario ".concat(u).concat("!") :
                "Username o password incorrecto\nLo sentimos, requiere autenticacion.";

        System.out.println(mensaje);

//        if(isAuthenticated)
//        {
//            System.out.println("Bienvenido usuario ".concat(u).concat("!"));
//        } else {
//            System.out.println("Lo siento, requiere autenticacion");
//            System.out.println("Username o password incorrecto!");
//        }
    }
}
