public class Logger1{

    // Private static instance of Logger
    private static Logger1 instance;

    // Private constructor
    private Logger1() {
        System.out.println("Logger Instance Created");
    }

    // Public method to get the single instance
    public static Logger1 getInstance() {

        if(instance == null) {
            instance = new Logger1();
        }

        return instance;
    }

    // Logging method
    public void log(String message) {
        System.out.println("LOG: " + message);
    }
}
//The error occurs because you're trying to run the Logger class directly, but Logger does not contain a main() method.