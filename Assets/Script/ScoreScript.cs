using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript: MonoBehaviour
{
    public GameObject score_object = null; // Text�I�u�W�F�N�g
    //public int score_num = 0; // �X�R�A�ϐ�
    private TextMeshProUGUI scoretext;
    private int totalScore = 0;

    // ������
    //���f�����ׂ̃��\�b�h���`
    private void Start()
    {
        //�����\��
        UpdateScoreText();
    }
    //�X�R�A���X�V���āAText�R���|�[�l���g�ɔ��f����
    public void ScoreManager(int score)
    {
        totalScore += score;
        //�R���|�[�l���g��\������
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
    //�g�[�^���̃X�R�A
    public int GetCurrentScore()
    {
        return totalScore;
    }
    // �X�V
    //void Update()
    //{
    //    // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
    //    Text score_text = score_object.GetComponent<Text>();
    //    // �e�L�X�g�̕\�������ւ���
    //    score_text.text = "Score:" + score_num;

    //    score_num += 1; // �Ƃ肠����1���Z�������Ă݂�
    //}
}