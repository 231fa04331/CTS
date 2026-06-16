using System;
using System.Threading.Tasks;

class Program
{
    static async Task<string> UploadFile()
    {
        await Task.Delay(3000);
        return "Upload Successful";
    }

    static async Task Main()
    {
        try
        {
            string result = await UploadFile();
            Console.WriteLine(result);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}