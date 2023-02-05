using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class TrackTime : MonoBehaviour
{
    public static bool inGame = true;

	public static float passedTime =0;
	// Start is called before the first frame update
	void Start()
    {
        //DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (inGame)
        {
			passedTime = Time.timeSinceLevelLoad;
			Debug.Log(passedTime);
		}
	}
}
