using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class resultController : MonoBehaviour
{
    private int totalcore = 0;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        totalcore = ScoreScript.instance.GetCurrentScore();
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Result \n TotalScore : " + totalcore.ToString() + " POINT";
    }
}
