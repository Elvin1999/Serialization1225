using ConsoleApp5;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{


    #region XML
    class Car
    {
        [JsonIgnore]
        public string Model { get; set; }
        public string Vendor { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Model?.PadRight(15)} {Vendor} {Year}";
        }
    }
    //class Program
    //{
    //    public static void Write()
    //    {
    //        List<Car> cars = new List<Car>
    //        {
    //            new Car
    //            {
    //                Model="Mustang",
    //                Vendor="Ford",
    //                Year=1964
    //            },
    //            new Car
    //            {
    //                Model="Charger",
    //                Vendor="Dodge",
    //                Year=1964
    //            },
    //            new Car
    //            {
    //                Model="Veyron",
    //                Vendor="Bugatti",
    //                Year=2020
    //            },
    //            new Car
    //            {
    //                Model="F10",
    //                Vendor="BMW",
    //                Year=2022
    //            }
    //        };

    //        using (var writer = new XmlTextWriter("car.xml", Encoding.UTF8))
    //        {
    //            writer.Formatting = Formatting.Indented;
    //            writer.WriteStartDocument();

    //            writer.WriteStartElement("Cars");

    //            foreach (var car in cars)
    //            {
    //                writer.WriteStartElement("Car");

    //                writer.WriteAttributeString(nameof(car.Vendor), car.Vendor);
    //                writer.WriteAttributeString(nameof(car.Model), car.Model);
    //                writer.WriteAttributeString(nameof(car.Year), car.Year.ToString());

    //                writer.WriteEndElement();
    //            }

    //            writer.WriteEndElement();

    //            writer.WriteEndDocument();
    //        }
    //    }

    //    public static void Read()
    //    {
    //        XmlDocument doc = new XmlDocument();

    //        doc.Load("car.xml");
    //        var root = doc.DocumentElement;

    //        if (root.HasChildNodes)
    //        {
    //            foreach (XmlNode car_node in root.ChildNodes)
    //            {
    //                var c = new Car
    //                {
    //                    Vendor = car_node.Attributes[0].Value,
    //                    Model = car_node.Attributes[1].Value,
    //                    Year = int.Parse(car_node.Attributes[2].Value),
    //                };
    //                Console.WriteLine(c);
    //            }
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        //Write();
    //        //Read();
    //    }

    //}
    #endregion



    #region XML Serialization

    //class Program
    //{
    //    static void XmlSerialize()
    //    {
    //        var army = new TranslatorArmy
    //        {
    //            Name = "Step IT Academy",
    //            Location = "Koroglu Rehimov 71",
    //            Translators = new List<Translator>
    //            {
    //                new Translator(1, "Tural", "Eliyev")
    //                {
    //                    Subjects=new List<Subject>
    //                    {
    //                        new Subject
    //                        {
    //                            Name="C++",
    //                            Degree=42,
    //                            Lessons=68
    //                        },
    //                        new Subject
    //                        {
    //                            Name="C#",
    //                            Degree=46,
    //                            Lessons=84
    //                        }
    //                    }
    //                },
    //                new Translator(2,"Eli","Mammadov")
    //                {
    //                    Subjects=new List<Subject>
    //                    {
    //                        new Subject
    //                        {
    //                            Name="Adobe Photoshop",
    //                            Degree=42,
    //                            Lessons=30
    //                        },
    //                        new Subject
    //                        {
    //                            Name="PHP",
    //                            Degree=42,
    //                            Lessons=30
    //                        }
    //                    }
    //                },
    //                new Translator(3, "Leyla", "Axmedova")
    //                {
    //                    Subjects=new List<Subject>
    //                    {
    //                        new Subject
    //                        {
    //                            Name="HTML/CSS",
    //                            Degree=35,
    //                            Lessons=45
    //                        },
    //                        new Subject
    //                        {
    //                            Name="Angular 9",
    //                            Degree=50,
    //                            Lessons=30
    //                        },
    //                    }
    //                }
    //            }
    //        };

    //        var xml = new XmlSerializer(typeof(TranslatorArmy));
    //        using (var fs = new FileStream("Translator.xml", FileMode.OpenOrCreate))
    //        {
    //            xml.Serialize(fs, army);
    //        }

    //    }
    //    static void XmlDeserialize()
    //    {
    //        TranslatorArmy army = null;
    //        var xml = new XmlSerializer(typeof(TranslatorArmy));

    //        using (var fs = new FileStream("Translator.xml", FileMode.OpenOrCreate))
    //        {
    //            army = xml.Deserialize(fs) as TranslatorArmy;
    //            Console.WriteLine("Deserialized");
    //        }
    //        Console.WriteLine(army);
    //    }

    //    static void Main(string[] args)
    //    {
    //        XmlSerialize();
    //        //XmlDeserialize();
    //    }
    //}


    #endregion


    #region BinarySerialization
    //class Program
    //{
    //    static void BinarySerialize()
    //    {
    //        var database = new Translator[]
    //        {
    //            new Translator(1,"Akif","Akifli"),
    //            new Translator(2,"Leyla","Mammadova"),
    //            new Translator(3,"Tural","Eliyev"),
    //            new Translator(4,"Nergiz","Nergizli")
    //        };

    //        var bf = new BinaryFormatter();
    //        using (var fs = new FileStream("file.bin", FileMode.OpenOrCreate))
    //        {
    //            bf.Serialize(fs, database);
    //        }
    //        Console.WriteLine("Ready");

    //    }
    //    static void BinaryDeserialize()
    //    {
    //        Translator[] db = null;
    //        var bf = new BinaryFormatter();
    //        using (var fs = new FileStream("file.bin", FileMode.OpenOrCreate))
    //        {
    //            db = bf.Deserialize(fs) as Translator[];
    //        }
    //        foreach (var item in db)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //         //BinarySerialize();
    //        BinaryDeserialize();
    //    }
    //}
    #endregion


    #region JsonSerialization

    class Program
    {
        static void WriteJson()
        {
            List<Car> cars = new List<Car>
             {
                 new Car
                 {
                     Model="Mustang",
                     Vendor="Ford",
                     Year=1964
                 },
                 new Car
                 {
                     Model="Charger",
                     Vendor="Dodge",
                     Year=1964
                 },
                 new Car
                 {
                     Model="Veyron",
                     Vendor="Bugatti",
                     Year=2020
                 },
                 new Car
                 {
                     Model="F10",
                     Vendor="BMW",
                     Year=2022
                 }
             };


            var serializer = new JsonSerializer();
            using (var sw=new StreamWriter("cars.json"))
            {
                using (var jw=new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, cars);
                }
            }

        }

        static void ReadJson()
        {
            Car[] cars = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("cars.json"))
            {
                using (var jr=new JsonTextReader(sr))
                {
                    cars = serializer.Deserialize<Car[]>(jr);
                }
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
        static void Main(string[] args)
        {
           // WriteJson();
            ReadJson();
        }
    }

    #endregion
}
