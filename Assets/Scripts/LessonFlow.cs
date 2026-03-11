using UnityEngine;
using TMPro;

public class LessonFlow : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI lessonText;
    public string[] lessons;
    private int currentStep = 0;

    void Start()
    {
        lessonText.text = lessons[0];
    }

    public void NextStep()
    {
        currentStep++;
        if (currentStep < lessons.Length)
        {
            lessonText.text = lessons[currentStep];
        }
        else
        {
            panel.SetActive(false);
        }
    }
}
