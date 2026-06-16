object lock1 = new();
object lock2 = new();

if(Monitor.TryEnter(lock1,1000))
{
    try
    {
        if(Monitor.TryEnter(lock2,1000))
        {
            try
            {
                Console.WriteLine("Both Locks Acquired");
            }
            finally
            {
                Monitor.Exit(lock2);
            }
        }
    }
    finally
    {
        Monitor.Exit(lock1);
    }
}