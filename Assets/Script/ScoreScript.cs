using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript: MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト
    //public int score_num = 0; // スコア変数
    private TextMeshProUGUI scoretext;
    private int totalScore = 0;

    // 初期化
    //反映される為のメソッドを定義
    private void Start()
    {
        //初期表示
        UpdateScoreText();
    }
    //スコアを更新して、Textコンポーネントに反映する
    public void ScoreManager(int score)
    {
        totalScore += score;
        //コンポーネントを表示する
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        scoretext.text = score_object.GetComponent<Text>();
        if (scoretext != null)
        {
            scoretext.text = "Score : " + totalScore.ToString();
        }
    }
    //トータルのスコア
    public int GetCurrentScore()
    {
        return totalScore;
    }
    // 更新
    //void Update()
    //{
    //    // オブジェクトからTextコンポーネントを取得
    //    Text score_text = score_object.GetComponent<Text>();
    //    // テキストの表示を入れ替える
    //    score_text.text = "Score:" + score_num;

    //    score_num += 1; // とりあえず1加算し続けてみる
    //}
}