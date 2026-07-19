using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private float countdownTime = 60f;

    private float currentTime;
    private bool isRunning = true;

    void Start()
    {
        currentTime = countdownTime;
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (isRunning && currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerDisplay();

            if (currentTime <= 0f)
            {
                currentTime = countdownTime;
                isRunning = true;
            }
        }
    }


    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);
        int milliseconds = Mathf.FloorToInt((currentTime * 100f) % 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }
}
