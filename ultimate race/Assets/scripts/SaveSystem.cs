using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem 
{
    public static string path=Application.persistentDataPath + "/kingsize.game";
   public static void SaveMoney(Money cash)
   {
      BinaryFormatter formatter= new BinaryFormatter();
      
      FileStream stream= new FileStream(path, FileMode.Create);
      MoneyData data = new MoneyData(cash);
      formatter.Serialize(stream, data);
      stream.Close();
   }

   public static MoneyData LoadMoney()
   {
      
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
         Debug.LogError("Data Doesn't Exist in " + path);
         return null;
      }
   }   
}
