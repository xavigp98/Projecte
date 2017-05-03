using UnityEngine;
using System.Collections;

public class Puerta2TriggerLoco : MonoBehaviour {

    GameData data;
    void Start()
    {
        data = GameData.GetInstance();
    }

    void Update()
    {
        if (data.GetLlave(1))
            gameObject.SetActive(false);
    }
    // Use this for initialization
   
}
