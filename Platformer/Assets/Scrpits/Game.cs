using System;
using System.Xml.Linq;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

class Game
{
    static readonly string path = Application.persistentDataPath + @"/savegame.xml";

    public static void Load()
    {
        try
        {
            XElement saveGame = null;
            saveGame = XDocument.Parse(File.ReadAllText(path)).Element("root");

            Data.Score = int.Parse(saveGame.Element("score").Value);
            Data.Stars = int.Parse(saveGame.Element("stars").Value);
            Data.Lives = int.Parse(saveGame.Element("lives").Value);
            Data.CompletedLevels = int.Parse(saveGame.Element("completedLevels").Value);
            Data.StarTotal = int.Parse(saveGame.Element("starTotal").Value);
            //Data.CurrentLevelIndex = int.Parse(saveGame.Element("currentLevelIndex").Value);
            SceneManager.LoadScene(Data.CurrentLevelIndex);
        }
        catch
        {
            Data.DefaultValues();
            SceneManager.LoadScene("Level1");
        }
    }

    public static void Save()
    {
        XElement root = new XElement("root");

        root.Add(new XElement("score", Data.Score));
        root.Add(new XElement("stars", Data.Stars));
        root.Add(new XElement("lives", Data.Lives));
        root.Add(new XElement("completedLevels", Data.CompletedLevels));
        root.Add(new XElement("starTotal", Data.StarTotal));
        root.Add(new XElement("currentLevelIndex", Data.CurrentLevelIndex));
        root.Add(new XElement("dieCounter", Data.DieCounter));

        XDocument saveGame = new XDocument(root);
        File.WriteAllText(path, saveGame.ToString());
        Debug.Log(path);
    }
}