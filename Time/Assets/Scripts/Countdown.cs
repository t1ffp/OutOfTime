using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    public float timeLeft = 180f;
    public TextMeshProUGUI timerText;
    public GameObject failScreen;

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = (timeLeft).ToString("0");

        if(timeLeft < 0)
        {
            failScreen.SetActive(true);
        }
    }
}
