using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTime : MonoBehaviour
{


    public static float passedTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        passedTime = Time.timeSinceLevelLoad;
        Debug.Log(passedTime);
    }
}
