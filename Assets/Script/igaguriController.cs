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
        //�t���[�����[�g�Ǘ�
        Application.targetFrameRate = 60;
        this.director = GameObject.Find("GameDirector");
    }
    //�����郁�\�b�h
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    //���������Ƃ�
    private void OnCollisionEnter()
    {
        

        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        //�X�R�A��ScoreScript�ɒǉ�
        //100��̎��|�C���g3�{
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
            //�Q�[���I�u�W�F�N�g���폜
            Destroy(gameObject);
        }
    }
}