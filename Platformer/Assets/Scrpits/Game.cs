using System;
using System.Xml.Linq;
using UnityEngine;
using System.IO;

class Game
{
    static readonly string path = Application.persistentDataPath + "/savegame.xml";

    public static void Load()
    {
    //    if(!File.Exists(path))

    }

    public static void Save()
    {
        XElement root = new XElement("root");

        root.Add(new XElement("score", Data.Score));
        root.Add(new XElement("stars", Data.Stars));
        root.Add(new XElement("lives", Data.Lives));
        root.Add(new XElement("completedLevels", Data.CompletedLevels));
        root.Add(new XElement("starTotal", Data.StarTotal));
        root.Add(new XElement("currentLevel", Data.CurrentLevelName));

        XDocument saveGame = new XDocument(root);
        File.WriteAllText(path, saveGame.ToString());
        Debug.Log(path);
    }
}