using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //�X�^�[�g���\�b�h
    public void StartGame()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneData.score = 0;
            SceneManager.LoadScene("game");
        }
    }
    ////�G���h���\�b�h
    //public void EndGame()
    //{
    //    if (SceneData.time == 0)
    //    {
    //        //�l�������X�R�A�ƃ��U���g��ʂւ̑J��
    //        SceneData.score = ScoreScript.instance.GetCurrentScore();
    //        SceneManager.LoadScene("Result");
    //    }
    //}
    ////���X�^�[�g���\�b�h
    //public void ReturnToStart()
    //{
    //    ResetGame();
    //    SceneManager.LoadScene("Start");
    //}
    //public void ResetGame()
    //{
    //    SceneData.score = 0;
    //    SceneData.time = 30;

    //    //���ׂẴu���b�N���폜
    //    GameObject[] igaguris = GameObject.FindGameObjectsWithTag("igaguri");

    //    foreach (GameObject igaguri in igaguris)
    //    {
    //        Destroy(igaguri);
    //    }

    //    //�X�R�A�̏�����
    //    if (ScoreScript.instance != null)
    //    {
    //        ScoreScript.instance.ScoreManager(-ScoreScript.instance.GetCurrentScore());
    //    }
    //}
}
