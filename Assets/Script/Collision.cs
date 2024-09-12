using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int score = 10;
    igaguriGenerator generator;
    // Start is called before the first frame update
    private void Start()
    {
        generator = FindObjectOfType<igaguriGenerator>();
    }
    // Update is called once per frame
    //private void OnCollisionEnter()
    //{
    //    //ScoreScript.instance.ScoreManager(score);
    //    //ÉXÉRÉAÇScoreScriptÇ…í«â¡
    //    if (ScoreScript.instance != null)
    //    {
    //        ScoreScript.instance.ScoreManager(score);
    //    }
    //    else
    //    {
    //        Debug.LogError("ScoreScript instance is not set.");
    //    }
    //}
}
