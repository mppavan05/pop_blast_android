using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject wintext;
    public GameObject restart;
    int score = 0;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void score_up()
    {
        score++;

        if(score >= 6)
        {
            win();
        }
    }

    void win()
    {
        wintext.SetActive(true);
        restart.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("game view");

    }




}
