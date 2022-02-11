using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class O_Ball : MonoBehaviour
{
    
  
    private void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().score_up();
        Destroy(gameObject);
    }
}
