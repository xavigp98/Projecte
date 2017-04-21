using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



public class GameData
{
    private GameData()
    {
    }

    private static GameData _Instance = null;

    public static GameData GetInstance()
    {
        if (_Instance == null)
            _Instance = new GameData();
        return _Instance;
    }

    private Dictionary<String, bool> data = new Dictionary<String, bool>();

    

    public void AddValue(String key, bool value)
    {
        data.Add(key, value);
    }

    public bool GetValue(String key)
    {
        return data[key];
    }
}

