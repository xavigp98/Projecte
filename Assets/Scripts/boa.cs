using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class boa : MonoBehaviour {
    GameData data;


    // Use this for initialization
    void Start () {
        data = GameData.GetInstance();
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x >= -39.01348)
        {
            transform.position = new Vector3(transform.position.x - 0.11f, 6.5f, transform.position.z);
            transform.Rotate(0, 0, 40 * Time.deltaTime);
        }
        else
        {

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
