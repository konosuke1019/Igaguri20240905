using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public GameObject time = null; // Text�I�u�W�F�N�g
    //�J�E���g�_�E��
    public float countdown = 50.0f;

    //���Ԃ�\������Text�^�̕ϐ�
    //public Text timeText;

    // Update is called once per frame
    void Update()
    {
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text time_text = time.GetComponent<Text>();
        //���Ԃ��J�E���g�_�E������
        countdown -= Time.deltaTime;

        //���Ԃ�\������
        time_text.text = countdown.ToString("f1") + "�b";

        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0)
        {
            time_text.text = "�I���I";
        }
    }
}
