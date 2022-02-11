using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    [SerializeField] private AudioSource touch;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            touch.Play();
        }
    }
}
