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
using Moduls;
using LogHelper;
using System.Diagnostics;
using Project.UnitTesting;

namespace MainProject
{
   class Read_konfig_autodown
    {
        public String line;
        public String lineText;
        public void read_file()
        {
            try
            {
                using (StreamReader _StreamReader = new StreamReader("Автозагрузка.txt"))
                {
                    Console.WriteLine("Списко программ в автозагрузке {0}", lineText);
                    while (true)
                    {
                        line = _StreamReader.ReadLine();

                        if (line == null)
                            break;
                        lineText = line;
                        Console.WriteLine(" {0}", lineText);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл конфигурации автозагрузки не найден");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Файл конфигурации автозагрузки не может быть прочитан");
                Console.ReadLine();

            }

        }
    }

    /// <summary>
    /// Serialization XML JSON Binary
    /// </summary>
    class interface_ISerializer
    {
        public void Serialize()
        {
            Console.WriteLine("Сериализация XML");
            XMLs XML = new XMLs();
            XML.Serialize();
            Console.WriteLine("Сериализация JSON");          
            JSONs JSON = new JSONs();
            JSON.Serialize();
            Console.WriteLine("Сериализация Binary");
            Binarys Binary = new Binarys();
            Binary.Serialize();
        }

        public void Deserialize()
        {
            Console.WriteLine("Десериализация XML");
            XMLs XML = new XMLs();
            XML.Deserialize();
            Console.WriteLine("Десериализация JSON");
            JSONs JSON = new JSONs();
            JSON.Deserialize();
            Console.WriteLine("Десериализация Binary");
            Binarys Binary = new Binarys();
            Binary.Deserialize();
        }

    }

/// <summary>
/// Основной класс загружающий все модули 
/// </summary>
    public class Windows
    {
        /// <summary>
        /// Основной метод загружающий все модули
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            LogException newlog = new LogException();
            newlog.write_log();
            
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
            Read_konfig_autodown _Read_konfig_autodown = new Read_konfig_autodown();
            _Read_konfig_autodown.read_file();

            Console.WriteLine("Старое количество программ");
            Console.WriteLine(ui.NumberP);
            ui.NumberP = 26;
            Console.WriteLine("Новое количество программ");
            Console.WriteLine(ui.NumberP);
            Console.WriteLine("Имя пользователя");
            Console.WriteLine(ui.Name);

            Project.UnitTesting.NUnitTests wd = new Project.UnitTesting.NUnitTests();
            wd.Test();

            // ____________________________________________________________________Serialization XML JSON Binary
            try
            {  
                interface_ISerializer ISerialize = new interface_ISerializer();
                ISerialize.Serialize();
                ISerialize.Deserialize();    
            }
            catch (Exception)
            {
                Console.WriteLine("Не сработала сериализация");
                Console.ReadLine();
            }
            // ____________________________________________________________________Serialization XML JSON Binary


            Console.ReadLine();
        } // Главная программа
    } //  public class Windows 
} // namespace MainProject














//namespace Project
//{




//class XMLs
//{
//    static void Main(string[] args)
//    {      
//        //XmlDocument xDoc = new XmlDocument();
//        XDocument xDoc = XDocument.Load("users.xml");
//        //xDoc.Load("C:\\Users\\DEDAL\\Desktop\\DOT_NET\\Dot_Net_Project\\Project\\Project\\users.xml");
//        // получим корневой элемент
//        XmlElement xRoot = xDoc;
//        // обход всех узлов в корневом элементе
//        foreach (XmlNode xnode in xRoot)
//        {
//            // получаем атрибут name
//            if (xnode.Attributes.Count > 0)
//            {
//                XmlNode attr = xnode.Attributes.GetNamedItem("name");
//                if (attr != null)
//                    Console.WriteLine(attr.Value);
//            }
//            // обходим все дочерние узлы элемента user
//            foreach (XmlNode childnode in xnode.ChildNodes)
//            {
//                // если узел - company
//                if (childnode.Name == "company")
//                {
//                    Console.WriteLine("Компания: {0}", childnode.InnerText);
//                }
//                // если узел age
//                if (childnode.Name == "age")
//                {
//                    Console.WriteLine("Возраст: {0}", childnode.InnerText);
//                }
//            }
//            Console.WriteLine();
//        }
//        Console.Read();

//    } // конец static void Main(string[] args)

//} // конец class Program

//class XmlTextWriter
//{
//    XmlTextWriter textWritter = new XmlTextWriter(pathToXml, Encoding.UTF8); // Создаём сам XML-файл
//    textWritter.WriteStartDocument(); // Создаём в файле заголовок XML-документа
//    textWritter.WriteStartElement("head"); // Создём голову (head)
//    textWritter.WriteEndElement(); // Закрываем её
//    textWritter.Close(); // И закрываем наш XmlTextWriter
//    }

//class XmlDocument // Для занесения данных мы будем использовать класс XmlDocument
//{
//    XmlDocument document = new XmlDocument();
//    // Создаём XML-запись
//    document.Load(pathToXml); // Загружаем наш файл
//    XmlNode element = document.CreateElement("element");
//    document.DocumentElement.AppendChild(element); // указываем родителя
//    XmlAttribute attribute = document.CreateAttribute("number"); // создаём атрибут
//    attribute.Value = 1; // устанавливаем значение атрибута
//    element.Attributes.Append(attribute); // добавляем атрибут
//    // Добавляем в запись данные
//    XmlNode subElement1 = document.CreateElement("subElement1"); // даём имя
//    subElement1.InnerText = "Hello"; // и значение
//    element.AppendChild(subElement1); // и указываем кому принадлежит
//    XmlNode subElement2 = document.CreateElement("subElement2");
//    subElement2.InnerText = "Dear";
//    element.AppendChild(subElement2);
//    XmlNode subElement3 = document.CreateElement("subElement3");
//    subElement3.InnerText = "Habr";
//    element.AppendChild(subElement3);
//    document.Save(pathToXml); // Сохраняем

//    }






////class TypeDownload
////{
////    static void Main(string[] args)
////    {
////        int XX;

////        Console.Write("Fast >0\n");
////        Console.Write("Slow 0\n");
////        XX = Console.Read();
////        if (XX > 0)
////        {
////            Windows fast = new Windows(new FastDownload());
////            fast.Hit();
////        }
////        else
////        {
////            Windows Slow = new Windows(new SlowDownload());
////            Slow.Run();
////        }
////        Console.ReadLine();
////        Console.ReadKey();
////    }
////}
////// абстрактный класс быстро
////abstract class Fast
////{
////    public abstract void CMDnot();
////    public abstract void Netnot();
////}

////// абстрактный класс медленно
////abstract class Slow
////{
////    public abstract void CMDyes();
////    public abstract void Netyes();
////}
////// класс CMDyes
////class CMDInclude : Slow
////{
////    public override void CMDyes()
////    {
////        Console.WriteLine("CMDyes");
////    }
////    public override void Netyes()
////    {
////        Console.WriteLine("Netyes");
////    }
////}
////// класс CMDnot
////class CMDnotInclude : Fast
////{
////    public override void CMDnot()
////    {
////        Console.WriteLine("CMDnot");
////    }
////    public override void Netnot()
////    {
////        Console.WriteLine("Netnot");
////    }
////}
////// класс абстрактной фабрики
////abstract class DownloadFactory
////{
////    public abstract Slow CreateSlow();
////    public abstract Fast CreateFast();
////}
////// Фабрика создания летящего героя с арбалетом
////class FastDownload : DownloadFactory
////{
////    public override Slow CreateSlow()
////    {
////        return new CMDInclude();
////    }

////    public override Fast CreateFast()
////    {
////        return new CMDnotInclude();
////    }
////}
////// Фабрика создания бегущего героя с мечом
////class SlowDownload : DownloadFactory
////{
////    public override Slow CreateSlow()
////    {
////        return new CMDInclude();
////    }

////    public override Fast CreateFast()
////    {
////        return new CMDnotInclude();
////    }
////}
////// 
////class Windows
////{
////    private Fast Litlemodule;
////    private Slow Manymodule;
////    public Windows(DownloadFactory factory)
////    {
////        Litlemodule = factory.CreateFast();
////        Manymodule = factory.CreateSlow();
////    }


////    public void Run()
////    {
////        Manymodule.Netyes();
////        Manymodule.CMDyes();
////    }
////    public void Hit()
////    {
////        Litlemodule.CMDnot();
////        Litlemodule.Netnot();
////    }
////}







////public class Registry
////{
////    public void Registry_status()
////    {
////        Console.WriteLine("Registry uploaded.");
////    }
////}
////public class Explorer
////{
////    public void Explorer_status()
////    {
////        Console.WriteLine("Explorer uploaded.");
////    }
////}
////public class Windows_API
////{
////    public void Windows_API_status()
////    {
////        Console.WriteLine("Windows API uploaded.");
////    }
////}
////public class Kernel
////{
////    public void Kernel_status()
////    {
////        Console.WriteLine("Kernel uploaded.");
////    }
////}
////public class DirectX
////{
////    public void DirectX_status()
////    {
////        Console.WriteLine("DirectX uploaded.");
////    }
////}
////public class User
////{
////    public void User_status()
////    {
////        Console.WriteLine("User uploaded.");
////    }
////}
////public class Service
////{
////    public void Service_status()
////    {
////        Console.WriteLine("Service uploaded.");
////    }
////}
////public class Processes
////{
////    public void Processes_status()
////    {
////        Console.WriteLine("Processes uploaded.");
////    }
////}
////public abstract class NumberProcesses
////{
////    public void Number_Processes()
////    {
////        Console.WriteLine("Количество процессов 10");
////    }
////    abstract public void NumberService();
////}
////public class ManagerProcesses : NumberProcesses
////{
////    public override void NumberService()
////    {
////        Console.WriteLine("Количество служб 99");
////    }
////}

////class UserInfo
////{
////    int Number_program = 15;
////    string UserName = "Alex";
////    public int NumberP
////    {
////        get
////        {
////            if (Number_program <= 0)
////                return 1;
////            return Number_program;
////        }

////        set
////        {
////            Number_program = value;
////        }
////    }
////    public string Name
////    {
////        get
////        {
////            return UserName;
////        }
////    }
////}

////public class Windows
////{
////    private static void Main(string[] args)
////    {
////        Console.WriteLine("Прогресс загрузки");
////        Registry status1 = new Registry();
////        status1.Registry_status();
////        Explorer status2 = new Explorer();
////        status2.Explorer_status();
////        Windows_API status3 = new Windows_API();
////        status3.Windows_API_status();
////        Kernel status4 = new Kernel();
////        status4.Kernel_status();
////        DirectX status5 = new DirectX();
////        status5.DirectX_status();
////        User status6 = new User();
////        status6.User_status();
////        Service status7 = new Service();
////        status7.Service_status();
////        Processes status8 = new Processes();
////        status8.Processes_status();
////        ManagerProcesses status9 = new ManagerProcesses();
////        status9.NumberService();
////        status9.Number_Processes();

////        UserInfo ui = new UserInfo();
////        Console.WriteLine("Старое количество программ");
////        Console.WriteLine(ui.NumberP);
////        ui.NumberP = 26;
////        Console.WriteLine("Новое количество программ");
////        Console.WriteLine(ui.NumberP);
////        Console.WriteLine("Имя пользователя");
////        Console.WriteLine(ui.Name);
////        Console.ReadLine();
////    }
////}
//}