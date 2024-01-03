using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileDataHandler
{
   private string dataDirPath = "";
   private string dataFileName = "";

    public FileDataHandler(string dataDirPath, string dataFileName){
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;
    }
   public GameData Load(){
    // use Path.Combine to account different's OS's having different path seperator
    string fullPath = Path.Combine(dataDirPath, dataFileName);
    GameData loadedData = null;
    if(File.Exists(fullPath)){
        try{
            string dataToLoad = "";
            using (FileStream stream = new FileStream(fullPath,FileMode.Open)){
                using(StreamReader reader = new StreamReader(stream)){
                    dataToLoad = reader.ReadToEnd();
                }
            }
            loadedData = JsonUtility.FromJson<GameData>(dataToLoad);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error occured when tring to Load data to file" + fullPath + "\n" + e);
            throw;
        }
    }
    return loadedData;
   }

   public void Save(GameData data){
    // use Path.Combine to account different's OS's having different path seperator
    string fullPath = Path.Combine(dataDirPath, dataFileName);
    try
    {
        //Create the directory the fill will be written to if oit doesn't already exist
        Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
        string dataToStore = JsonUtility.ToJson(data, true);
        using(FileStream stream = new FileStream(fullPath,FileMode.Create))
        {
            using (StreamWriter writer = new StreamWriter(stream)){
                writer.Write(dataToStore);
            }
        }
    }
    catch (System.Exception e)
    {
        Debug.LogError("Error occured when tring to Save data to file" + fullPath + "\n" + e);
        throw;
    }
    
   }
}
