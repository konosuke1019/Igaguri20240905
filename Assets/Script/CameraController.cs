using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //�e��I�u�W�F�N�g
    public Camera MainCamera;
    public Camera EffectCamera;
    public float transitionDuration = 5.0f;     //�J�����̏I������
    //�J�����̍��W
    public Vector3 startPosition = new Vector3 (0, 0, 3);   //�J�����̃X�^�[�g�ʒu
    public Vector3 secondPosition = new Vector3(0, 10, 5);
    public Vector3 endPosition = new Vector3(0, 5, 10);     //�J�����̃G���h�ʒu
    //�^�C�}�[�X�N���v�g���C���X�^���X��
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
        //���o�p�̃J������L�������āA���C���J�����𖳌���
        MainCamera.enabled = false;
        EffectCamera.enabled = true;

        //�J�n���̈ʒu��ݒ�
        EffectCamera.transform.position = startPosition;

        //�o�ߎ���
        float elapsedTime = 0f;
        //���o�J�n�i�o�ߎ��Ԃ��I�����Ԃ܂Łj
        while (elapsedTime < transitionDuration)
        {
            //Learp�֐��ňʒu��ۊǂ��Ĉړ�
            EffectCamera.transform.position = Vector3.Lerp(startPosition, secondPosition, elapsedTime / transitionDuration);
            elapsedTime += Time.deltaTime;
            //���̃t���[���܂őҋ@����
            yield return null;
        }
        //�J�����̈ʒu���I���ʒu�Ɏ����Ă���
        EffectCamera.transform.position = endPosition;

        //���o�J�n�i�o�ߎ��Ԃ��I�����Ԃ܂Łj
        while (elapsedTime < transitionDuration)
        {
            //Learp�֐��ňʒu��ۊǂ��Ĉړ�
            EffectCamera.transform.position = Vector3.Lerp(secondPosition, endPosition, elapsedTime / transitionDuration);
            elapsedTime += Time.deltaTime;
            //���̃t���[���܂őҋ@����
            yield return null;
        }
        //�J�����̈ʒu���I���ʒu�Ɏ����Ă���
        EffectCamera.transform.position = endPosition;

        //���C���J������L�������āA���o�J�����𖳌���
        EffectCamera.enabled = false;
        MainCamera.enabled = true;

        if (Timercontroller != null)
        {
            //���o���I�������^�C�}�[�J�n
            Timercontroller.StartTimer();
        }
    }
}   
