using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class resultController : MonoBehaviour
{
    public GameObject scoreTextObject;      //�X�R�A
    // Start is called before the first frame update
    void Start()
    {
        this.scoreTextObject.GetComponent<TextMeshProUGUI>().text = "SCORE : " + SceneData.score;
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.instance.ReturnToStart();
    }
}
