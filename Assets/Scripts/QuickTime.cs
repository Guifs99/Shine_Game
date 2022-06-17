using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickTime : MonoBehaviour
{
    public float mytime;
    public bool myplaying=false;
    public Text mycounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myplaying)
        {
            mytime += Time.deltaTime;
            mycounter.text = mytime.ToString("00.00");
        }
    }


    public void StartCounter()
    {
        myplaying = true;
    }
    public void StopCounter()
    {
        myplaying = false;
    }
}
