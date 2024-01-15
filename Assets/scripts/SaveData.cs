using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.PlayerLoop;

public static class SaveData
{
    //th place on the user pc
    private static string filePath = Application.persistentDataPath + "/score.json";
    //2 function save and load
    public static void Save(Scores scoreData)
    {
        //put the info in a file
        string data = JsonUtility.ToJson(scoreData);
      
        File.WriteAllText(filePath,data);
        
    }

    public static Scores Load()
    {
        //the file doesnt exsist so we stop here
        if (!File.Exists(filePath))
        {
            return new Scores();
        }
        
        //put the information
        string data = File.ReadAllText(filePath);
        Scores scoreData = JsonUtility.FromJson<Scores>(data);
        return scoreData;
    }
    
}
