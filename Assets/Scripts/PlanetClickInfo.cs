using UnityEngine;
using TMPro;

public class PlanetClickInfo : MonoBehaviour
{
    public GameObject factPanel;
    public TextMeshProUGUI factText;
    public string funFact;

    public TextMeshProUGUI namePopupText;
    public GameObject namePopupPanel;
    public string planetName;

    void OnMouseDown()
    {
        factPanel.SetActive(true);
        factText.text = funFact;

        StopAllCoroutines();
        StartCoroutine(ShowNamePopup());
    }

    System.Collections.IEnumerator ShowNamePopup()
    {
        namePopupText.text = planetName;
        namePopupPanel.SetActive(true);
        yield return new WaitForSeconds(2f);
        namePopupPanel.SetActive(false);
    }
}
