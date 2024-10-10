using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public GameObject time = null; // Textオブジェクト
    //カウントダウン
    public float countdown = 50.0f;

    //時間を表示するText型の変数
    //public Text timeText;

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text time_text = time.GetComponent<Text>();
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        time_text.text = countdown.ToString("f1") + "秒";

        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            time_text.text = "終了！";
        }
    }
}
