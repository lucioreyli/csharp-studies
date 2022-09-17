using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ArquivosCSharp {
  class Program {
    [Serializable]
    class Person {
      public int age;
      public string name;

      public override string ToString() {
        return age.ToString() + " " + name;
      }
    }

    [Serializable]
    class Car {
      public string brand;
      public string model;

      public override string ToString() {
        return model + " " + brand;
      }
    }

    static void Main(string[] args) {
      string path = "./test.txt";
      string binPath = "./bin.recayd";

      // Create file if not exists
      if(!File.Exists(path)) {
        File.Create(path);
      }

      // Write file
      StreamWriter streamWriter = new StreamWriter(path, append: true);
      streamWriter.WriteLine("recayd mob");
      streamWriter.Close();

      // Read file
      StreamReader reader = new StreamReader(path);
      string fileContent = reader.ReadToEnd();
      Console.Write(fileContent);
      reader.Close();


      FileStream writeStream = new FileStream(binPath, FileMode.OpenOrCreate);
      BinaryFormatter formatter = new BinaryFormatter();
      Person caio = new Person();
      caio.name = "Caio Luccas";
      caio.age = 21;

      Car jeep = new Car();
      jeep.brand = "Jeep";
      jeep.model = "Compass";

      formatter.Serialize(writeStream, caio);
      formatter.Serialize(writeStream, jeep);
      writeStream.Close();


      FileStream readStream = new FileStream(binPath, FileMode.Open);
      BinaryFormatter deserializer = new BinaryFormatter();
      var person = (Person)deserializer.Deserialize(readStream);
      var car = (Car)deserializer.Deserialize(readStream);

      Console.Write(person.ToString());
    }
  }
}
