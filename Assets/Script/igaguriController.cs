using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class igaguriController : MonoBehaviour
{
    ScoreScript ScoreScript;
    GameObject director;
    public int count = 0;
    public int point = 10;
    void Start()
    {
        //フレームレート管理
        Application.targetFrameRate = 60;
        this.director = GameObject.Find("GameDirector");
    }
    //投げるメソッド
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    //当たったとき
    private void OnCollisionEnter()
    {
        

        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        //スコアをScoreScriptに追加
        //100回の時ポイント3倍
        if (count == 100)
        {
            this.director.GetComponent<GameDirector>().threeHit();
            count = 0;
        }
        else
        {
            this.director.GetComponent<GameDirector>().Hit();
        }
        if (count != 0 && count % 20 == 0)
        {
            //ゲームオブジェクトを削除
            Destroy(gameObject);
        }
    }
}