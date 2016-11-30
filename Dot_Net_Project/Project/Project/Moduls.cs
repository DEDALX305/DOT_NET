using System;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows;
using System.Web;
using System.Threading;
using System.Security;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using SerializationXML;
using SerializationJSON;
using SerializationBinary;

namespace Moduls
{
    public class Registry
    {
        public string Registry_status(string registry_s)
        {
            //Console.WriteLine("Registry uploaded.");
            return registry_s;
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
} // namespace MainProject