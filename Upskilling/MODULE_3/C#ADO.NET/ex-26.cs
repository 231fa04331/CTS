int counter = 0;
object locker = new();

void Increment()
{
    for(int i=0;i<10000;i++)
    {
        lock(locker)
        {
            counter++;
        }
    }
}