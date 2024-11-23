using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    static public bool TimerStop = true;
    public TextMeshProUGUI TextTimer;
    private float startTime; // Время начала игры

    void Start()
    {
        startTime = Time.time; // Сохраняем время начала игры
    }

    void Update()
    {
        if (TimerStop == true)
        {
            float elapsedTime = Time.time - startTime; // Время, прошедшее с момента старта

            int minutes = (int)(elapsedTime / 60); // Минуты
            int seconds = (int)(elapsedTime % 60); // Секунды
            int milliseconds = (int)((elapsedTime * 1000) % 1000); // Миллисекунды

            // Выводим результат в консоль
            Debug.Log($"{minutes:00}:{seconds:00}:{milliseconds:000}");
            TextTimer.text = $"{minutes:00}:{seconds:00}:{milliseconds:000}";

        }

      
    }
}