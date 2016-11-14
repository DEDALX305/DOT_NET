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

namespace SerializationJSON
{
    [DataContract]
   
    class JSONs
    {
        public void Serialize()
        {
            // объект для сериализации
            PersonJson person1 = new PersonJson("Tom", 295151);
            PersonJson person2 = new PersonJson("Bill", 25442235);
            PersonJson[] people = new PersonJson[] { person1, person2 };

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(PersonJson[]));

            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, people);
            }

        }
        public void Deserialize()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(PersonJson[]));
            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                PersonJson[] newpeople = (PersonJson[])jsonFormatter.ReadObject(fs);

                foreach (PersonJson p in newpeople)
                {
                    Console.WriteLine("Имя: {0} --- Пароль: {1}", p.Name, p.Password);
                }
            }
        }

    }
}