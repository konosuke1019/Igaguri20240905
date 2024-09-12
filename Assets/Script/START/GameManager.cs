using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //スタートメソッド
    public void StartGame()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneData.score = 0;
            SceneManager.LoadScene("game");
        }
    }
    ////エンドメソッド
    //public void EndGame()
    //{
    //    if (SceneData.time == 0)
    //    {
    //        //獲得したスコアとリザルト画面への遷移
    //        SceneData.score = ScoreScript.instance.GetCurrentScore();
    //        SceneManager.LoadScene("Result");
    //    }
    //}
    ////リスタートメソッド
    //public void ReturnToStart()
    //{
    //    ResetGame();
    //    SceneManager.LoadScene("Start");
    //}
    //public void ResetGame()
    //{
    //    SceneData.score = 0;
    //    SceneData.time = 30;

    //    //すべてのブロックを削除
    //    GameObject[] igaguris = GameObject.FindGameObjectsWithTag("igaguri");

    //    foreach (GameObject igaguri in igaguris)
    //    {
    //        Destroy(igaguri);
    //    }

    //    //スコアの初期化
    //    if (ScoreScript.instance != null)
    //    {
    //        ScoreScript.instance.ScoreManager(-ScoreScript.instance.GetCurrentScore());
    //    }
    //}
}
