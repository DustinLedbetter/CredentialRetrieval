/***************************************************************************************************************************************************
*                                                 GOD First                                                                                        *
* Author: Dustin Ledbetter                                                                                                                         *
* Release Date: 10-26-2018                                                                                                                         *
* Version: 1.0                                                                                                                                     *
* Purpose: A simple application to show a computers credentials when ran                                                                           *
***************************************************************************************************************************************************/

using System;
using System.Net;

namespace CredentialRetrievelTest
{
    class CredentialRetrieval
    {
        static void Main(string[] args)
        {

            // This section prints out user and machine information
            Console.WriteLine("TimeStamp:               " + DateTime.Now);                       // Timestamp of the moment this is ran
            Console.WriteLine("Current Logged UserName: " + Environment.UserName); // Name of user logged onto PC
            Console.WriteLine("Local Machine Name:      " + Environment.MachineName);   // DNS from System namespace itself
            Console.WriteLine("Local Machine Name:      " + Dns.GetHostName());         // DNS from System.Net

            // This section is used to get the IP address
            IPHostEntry ip = Dns.GetHostEntry(Dns.GetHostName());                  
            IPAddress[] IPaddr = ip.AddressList;

            // Loop through and print IP adresses out
            for (int i = 0; i < IPaddr.Length; i++)
            {
                Console.WriteLine("IP Address :             {0}", IPaddr[i].ToString());
            }

            // Wait for user to input to close
            Console.ReadLine();
        }
    }
}
