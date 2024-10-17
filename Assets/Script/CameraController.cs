using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //各種オブジェクト
    public Camera MainCamera;
    public Camera EffectCamera;
    public float transitionDuration = 5.0f;     //カメラの終了時間
    //カメラの座標
    public Vector3 startPosition = new Vector3 (0, 0, 3);   //カメラのスタート位置
    public Vector3 secondPosition = new Vector3(0, 10, 5);
    public Vector3 endPosition = new Vector3(0, 5, 10);     //カメラのエンド位置
    //タイマースクリプトをインスタンス化
    public TimeScript Timercontroller;
    // Start is called before the first frame update
    void Start()
    {
        if (Timercontroller != null)
        {
            Timercontroller.PausedTimer();
        }
        StartCoroutine(CameraTransition());
    }
    private IEnumerator CameraTransition()
    {
        //演出用のカメラを有効化して、メインカメラを無効化
        MainCamera.enabled = false;
        EffectCamera.enabled = true;

        //開始時の位置を設定
        EffectCamera.transform.position = startPosition;

        //経過時間
        float elapsedTime = 0f;
        //演出開始（経過時間が終了時間まで）
        while (elapsedTime < transitionDuration)
        {
            //Learp関数で位置を保管して移動
            EffectCamera.transform.position = Vector3.Lerp(startPosition, secondPosition, elapsedTime / transitionDuration);
            elapsedTime += Time.deltaTime;
            //次のフレームまで待機する
            yield return null;
        }
        //カメラの位置を終了位置に持ってくる
        EffectCamera.transform.position = endPosition;

        //演出開始（経過時間が終了時間まで）
        while (elapsedTime < transitionDuration)
        {
            //Learp関数で位置を保管して移動
            EffectCamera.transform.position = Vector3.Lerp(secondPosition, endPosition, elapsedTime / transitionDuration);
            elapsedTime += Time.deltaTime;
            //次のフレームまで待機する
            yield return null;
        }
        //カメラの位置を終了位置に持ってくる
        EffectCamera.transform.position = endPosition;

        //メインカメラを有効化して、演出カメラを無効化
        EffectCamera.enabled = false;
        MainCamera.enabled = true;

        if (Timercontroller != null)
        {
            //演出が終わったらタイマー開始
            Timercontroller.StartTimer();
        }
    }
}   
