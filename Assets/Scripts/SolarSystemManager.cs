using UnityEngine;
using TMPro;

public class SolarSystemManager : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPaused = !isPaused;

            if (pauseText != null)
            {
                pauseText.SetActive(isPaused);
            }
        }
    }
}
