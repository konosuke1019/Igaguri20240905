using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public GameObject timeText;
    public string nextSceneName;
    public float transitionTime = 10f;

    private float elapsedTime = 0f;

    //�^�C�}�[�ꎞ��~�t���O
    private bool isPaused = true;

    // Update is called once per frame
    void Update()
    {
        if(isPaused)
        {
            return;
        }
        elapsedTime += Time.deltaTime;

        UpdatetimeText();

        if (elapsedTime >= transitionTime)
        {
            GameManager.Instance.EndGame();
        }

    }
    private void UpdatetimeText()
    {
        this.timeText.GetComponent<TextMeshProUGUI>().text = "Time:" + elapsedTime.ToString("F2") + " Sec";
    }
    //�^�C�}�[���J�n����
    public void StartTimer()
    {
        isPaused = false;
    }
    //�^�C�}�[�̈ꎞ��~
    public void PausedTimer()
    {
        isPaused = true;
    }
}
