using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRemaining = 90;
    public bool timerIsRunning = false;

    public TextMeshProUGUI timeText;
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerIsRunning)
        {
          if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        else if (timeRemaining <= 0)
        {
            Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
        }
            DisplayTime();
        }
       
            Debug.Log("timeRemaining = " + timeRemaining);
    }

    void DisplayTime()
    {
        float minutes = Mathf.FloorToInt(timeRemaining / 60); //turning to a whole number
        float seconds = Mathf.FloorToInt(timeRemaining % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    
}
