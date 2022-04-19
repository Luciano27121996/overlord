using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Main : MonoBehaviour
{
    private float timer = 0.0f;
    private float waitTime = 1.5f;
    private bool toggle = false;
    GameObject mainCharac;

    // Start is called before the first frame update
    void Start()
    {
        mainCharac = GameObject.Find("MainChar");
        mainCharac.transform.Translate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitTime) {
            timer = timer - waitTime;
            toggle = !toggle;
            
            if (toggle)
            {
                mainCharac.transform.Translate(2, 0, 0);
            }
            else
            {
                mainCharac.transform.Translate(-2, 0, 0);
            }
        }
        //print("an update");
    }
}
