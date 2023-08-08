using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem 
{
   public static void SavePlayer(Money money)
   {
      BinaryFormatter formatter= new BinaryFormatter();
      string path = Application.persistentDataPath + "Racing.prime";
      FileStream stream= new FileStream(path, FileMode.Create);
      MoneyData data= new MoneyData(money);
      formatter.Serialize(stream, data);
      stream.Close();
      
   }

   public static MoneyData LoadPlayer()
   {
      string path = Application.persistentDataPath + "Racing.prime";
      if (File.Exists(path))
      {
         BinaryFormatter formatter= new BinaryFormatter();
         FileStream stream = new FileStream(path, FileMode.Open);
         MoneyData data= formatter.Deserialize(stream) as MoneyData;
         stream.Close();
         return data;
      }
      else
      {
         Debug.LogError("Data doesn't exist in " + path);
         return null;
      }
   }
}
