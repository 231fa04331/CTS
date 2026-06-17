public class testlogger1 {

    public static void main(String[] args) {

        Logger1 logger1 = Logger1.getInstance();

        Logger1 logger2 = Logger1.getInstance();

        logger1.log("Application Started");

        logger2.log("User Logged In");

        System.out.println();

        System.out.println("Logger1 HashCode: " + logger1.hashCode());
        System.out.println("Logger2 HashCode: " + logger2.hashCode());

        if(logger1 == logger2) {
            System.out.println("Only One Logger Instance Exists");
        }
        else {
            System.out.println("Multiple Instances Exist");
        }
    }
}