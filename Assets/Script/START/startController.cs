using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startController : MonoBehaviour
{
    public void OnStartButtonPresssed()
    {
        GameManager.Instance.StartGame();
    }
}
