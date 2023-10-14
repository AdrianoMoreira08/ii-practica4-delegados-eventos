using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayWin : MonoBehaviour
{
    Winning winning;
    TextMeshProUGUI displayText;
    // Start is called before the first frame update
    void Start()
    {
        displayText = GetComponent<TextMeshProUGUI>();
        winning = GameObject.Find("Final").GetComponent<Winning>();
        winning.OnWinning += UpdateText;
    }

    void UpdateText()
    {
        displayText.text = "HAS GANADO!";
    }
}
