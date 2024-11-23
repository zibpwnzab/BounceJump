using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    static public bool TimerStop = true;
    public TextMeshProUGUI TextTimer;
    private float startTime; // ����� ������ ����

    void Start()
    {
        startTime = Time.time; // ��������� ����� ������ ����
    }

    void Update()
    {
        if (TimerStop == true)
        {
            float elapsedTime = Time.time - startTime; // �����, ��������� � ������� ������

            int minutes = (int)(elapsedTime / 60); // ������
            int seconds = (int)(elapsedTime % 60); // �������
            int milliseconds = (int)((elapsedTime * 1000) % 1000); // ������������

            // ������� ��������� � �������
            Debug.Log($"{minutes:00}:{seconds:00}:{milliseconds:000}");
            TextTimer.text = $"{minutes:00}:{seconds:00}:{milliseconds:000}";

        }

      
    }
}