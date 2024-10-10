using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText;
    float time = 60.0f;
    int point = 0;
    bool hitflg = false;
    public void Hit()
    {
        this.point += 10;
    }
    public void threeHit()
    {
        this.point += 30;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text=
            this.time.ToString("F1");
        this.pointText.GetComponent<TextMeshProUGUI>().text =
            this.point.ToString() + "point";
        if (time == 0)
        {
            SceneManager.LoadScene("result");
        }
    }
}
