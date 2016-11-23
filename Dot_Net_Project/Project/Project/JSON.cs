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

namespace SerializationJSON
{
    /// <summary>
    /// SerializationJSON
    /// </summary>
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Password { get; set; }

        public Person(string name, int password)
        {
            Name = name;
            Password = password;
        }
    }
    class JSONs
    {
        public void Serialize()
        {
            // объект для сериализации
            Person person1 = new Person("Tom", 295151);
            Person person2 = new Person("Bill", 25442235);
            Person[] people = new Person[] { person1, person2 };

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Person[]));

            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, people);
            }

        }
        public void Deserialize()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Person[]));
            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                Person[] newpeople = (Person[])jsonFormatter.ReadObject(fs);

                foreach (Person p in newpeople)
                {
                    Console.WriteLine("Имя: {0} --- Пароль: {1}", p.Name, p.Password);
                }
            }
        }

    }
}