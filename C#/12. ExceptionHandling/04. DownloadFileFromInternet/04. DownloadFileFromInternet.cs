//Write a program that downloads a file from Internet
//(e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//and stores it the current directory. Find in Google
//how to download files in C#. Be sure to catch all 
//exceptions and to free any used resources in the
//finally block.

using System;
using System.Net;

class DownloadFileFromInternet
{
    static void Main()
    {
        WebClient downloader = new WebClient();
        string url = "http://www.devbg.org/img/Logo-BASD.jpg";
        string fileName = "downloadedPicture.jpg";

        try
        {
            downloader.DownloadFile(url, fileName);
            Console.WriteLine("The file was successfully downloaded from {0} to the current directory of the program.", url);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The url parameter is null.");
        }
        catch (WebException)
        {
            Console.WriteLine("The fileName is null or Empty, the file does not exist or an error occurred while downloading data.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
        finally
        {
            downloader.Dispose();
        }
    }
}
