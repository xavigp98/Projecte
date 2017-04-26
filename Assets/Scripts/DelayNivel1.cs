using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DelayNivel1 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Cambio", 4);
    }
    void Cambio()
    {
        SceneManager.LoadScene("Menu");
    }
}
