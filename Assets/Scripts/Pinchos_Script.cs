using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos_Script : MonoBehaviour {
    private int health = 10;
    public bool isDamaged = false;
    IEnumerator OnTriggerEnter2D(Collider2D collision)
    {       
        isDamaged = true;
        
        if(isDamaged == true && collision.gameObject.tag == "enemy")
        {
            health = health - 1;
            yield return new WaitForSeconds (3);
            isDamaged = false;
        }
      


    }
}
