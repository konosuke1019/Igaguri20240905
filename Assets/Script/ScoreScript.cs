using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScript: MonoBehaviour
{
    //クラスの唯一のインスタンスを保持するための静的な変数
    public static ScoreScript instance;
    //スコアの表示するためのTextコンポーネントとトータルスコア
    private GameObject scoreText;//TextMeshProUGUIコンポーネントを保持する形に変更
    private int totalScore = 0;

    //プライベートコンストラクタ
    private void Awake()
    {
        //インスタンスが存在しない場合はこのインスタンスを設定
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);          //シーンをまたいでもインスタンスを保持
        }
        //既に存在する場合は新しいインスタンスを破棄
        else
        {
            Destroy(gameObject);
        }
    }
    //スコアを更新して、Textコンポーネントに反映する
    public void ScoreManager(int score)
    {
        totalScore += score;
        //コンポーネントを表示する
        UpdateScoreText();
    }
    //スコアをTextコンポーネントに表示するメソッド
    private void UpdateScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + totalScore.ToString();
    }
    //トータルのスコア
    public int GetCurrentScore()
    {
        return totalScore;
    }
}