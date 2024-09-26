using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //�X�^�[�g���\�b�h
    public void StartGame()
    {
        SceneData.score = 0;
        SceneManager.LoadScene("game");
    }
    //���X�^�[�g���\�b�h
    public void ReturnToStart()
    {
        ResetGame();
        SceneManager.LoadScene("start");
    }
    public void ResetGame()
    {
        SceneData.score = 0;
        SceneData.time = 30;

        //���ׂẴu���b�N���폜
        GameObject[] igaguris = GameObject.FindGameObjectsWithTag("igaguri");

        foreach (GameObject igaguri in igaguris)
        {
            Destroy(igaguri);
        }
    }
}
