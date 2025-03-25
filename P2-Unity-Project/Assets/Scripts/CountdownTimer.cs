using UnityEngine;
using UnityEngine.UI;
using TMPro; // If using TextMeshPro for UI text

public class TimerReset : MonoBehaviour
{
    public float countdownTime = 30f;
    private float timer;
    public TextMeshProUGUI timerText; // Drag your UI Text (TMP) here
    public Button resetButton; // Drag the "Cool Button" here

    private bool isCounting = true;

    void Start()
    {
        timer = countdownTime;
        resetButton.onClick.AddListener(ResetTimer);
    }

    void Update()
    {
        if (isCounting && timer > 0)
        {
            timer -= Time.deltaTime;
            UpdateTimerText();
        }
        else if (timer <= 0)
        {
            timer = 0;
            isCounting = false; // Stops the countdown at zero
        }
    }

    void ResetTimer()
    {
        timer = countdownTime;
        isCounting = true; // Restart the countdown
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        timerText.text = Mathf.Ceil(timer).ToString() + " sec";
    }
}