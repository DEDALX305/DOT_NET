using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Lab_OOP
{
       public class Registry
       {
           public void Registry_status()
           {
               Console.WriteLine("Registry uploaded.");
           }
       }
       public class Explorer
       {
           public void Explorer_status()
           {
               Console.WriteLine("Explorer uploaded.");
           }
       }
       public class Windows_API
       {
           public void Windows_API_status()
           {
               Console.WriteLine("Windows API uploaded.");
           }
       }
       public class Kernel
       {
           public void Kernel_status()
           {
               Console.WriteLine("Kernel uploaded.");
           }
       }
       public class DirectX
       {
           public void DirectX_status()
           {
               Console.WriteLine("DirectX uploaded.");
           }
       }
       public class User
       {
           public void User_status()
           {
               Console.WriteLine("User uploaded.");
           }
       }
       public class Service
       {
           public void Service_status()
           {
               Console.WriteLine("Service uploaded.");
           }
       }
       public class Processes
       {
           public void Processes_status()
           {
               Console.WriteLine("Processes uploaded.");
           }
       }
       public abstract class NumberProcesses
       {
           public void Number_Processes()
           {
               Console.WriteLine("Количество процессов 10");   
       }
           abstract public void NumberService();
       }
       public class ManagerProcesses : NumberProcesses
       {
           public override void NumberService()
           {
               Console.WriteLine("Количество служб 99");
           }
       }
    
       class UserInfo
       {
           int Number_program = 15;
           string UserName = "Alex";
           public int NumberP
           {
               get
               {
                   if (Number_program <= 0)
                       return 1;
                   return Number_program;
               }
    
               set
               {
                   Number_program = value;
               }
           }
           public string Name
           {
               get
               {
                   return UserName;
               }
           }
       }
    
       public class Windows
       {
           private static void Main(string[] args)
           {
               Console.WriteLine("Прогресс загрузки");
               Registry status1 = new Registry();
               status1.Registry_status();
               Explorer status2 = new Explorer();
               status2.Explorer_status();
               Windows_API status3 = new Windows_API();
               status3.Windows_API_status();
               Kernel status4 = new Kernel();
               status4.Kernel_status();
               DirectX status5 = new DirectX();
               status5.DirectX_status();
               User status6 = new User();
               status6.User_status();
               Service status7 = new Service();
               status7.Service_status();
               Processes status8 = new Processes();
               status8.Processes_status();
               ManagerProcesses status9 = new ManagerProcesses();
               status9.NumberService();
               status9.Number_Processes();          
               
               UserInfo ui = new UserInfo();
               Console.WriteLine("Старое количество программ");
               Console.WriteLine(ui.NumberP);
               ui.NumberP = 26;
               Console.WriteLine("Новое количество программ");
               Console.WriteLine(ui.NumberP);
               Console.WriteLine("Имя пользователя");
               Console.WriteLine(ui.Name);
               Console.ReadLine();
           } 
       }
}

