using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //this is the textbox which is in unity
    [SerializeField]  TextMeshProUGUI Timert;
    [SerializeField] float remainingTime;
    

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            //keep the timer going
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime <=0)
        {
            remainingTime = 0;
            //change screen to Game over screen
            SceneManager.LoadScene("GameOver");
            Timert.color = Color.yellow;

        }
        
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds  = Mathf.FloorToInt(remainingTime % 60);
        Timert.text = string.Format("{0:00}:{1:00}", minutes, seconds);


    }
}
