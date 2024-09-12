using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    public int i = 0;
    // Update is called once per frame
    void Update()
    {
        if (i < 100)
        {
            //クリックでイガグリを生成し続ける
            if (Input.GetMouseButtonDown(0))
            {
                i++;
                GameObject igaguri = Instantiate(igaguriPrefab);
                //igaguri.GetComponent<igaguriController>().Shoot(new Vector3(0, 200, 2000));

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 worldDir = ray.direction;

                igaguri.GetComponent<igaguriController>().Shoot(worldDir.normalized * 2000);
            }
        }
    }
}
