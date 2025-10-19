import java.util.Scanner;

public class Print_ScanBytes_ScanStrings_ScanLine 
{
    
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Age: ");
        byte age = scanner.nextByte(); //scanning a 'byte' variable into 'age'.
        System.out.println("You're " + age);

        /*Difference between print & println is
         * print doesn't automatically address a new line
         * println automatically addresses a new line.
         */


        System.out.print("Name: ");
        String name = scanner.next();//Scans a string, excluding whitespaces.
        scanner.nextLine(); //!!!Scans a new line, so that it doesn't hinder other scans. !!!!
        System.out.println("Your name is " + name);

        System.out.print("Enter full name: ");
        String full_name = scanner.nextLine();//Scans an entire line, including white spance.
        System.out.println("Your full name is " + full_name);


        scanner.close();
    }
}