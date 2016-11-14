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
using MainProject;

namespace SerializationXML
{
    // класс и его члены объявлены как public
    [Serializable]
   
    class XMLs
    {
      public void Serialize()
        {
            // объект для сериализации
            PersonXML person = new PersonXML("Alex", 565154485);

            Console.WriteLine("Объект создан");

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(PersonXML));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);

                Console.WriteLine("Объект сериализован");

            }          
        }

        public void Deserialize()
        {
            // десериализация
            XmlSerializer formatter = new XmlSerializer(typeof(PersonXML));

            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                PersonXML newPerson = (PersonXML)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Имя: {0} --- Пароль: {1}", newPerson.Name, newPerson.Password);
            }
        }
    }
}