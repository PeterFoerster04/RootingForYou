using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class ExitScene : MonoBehaviour
{
	public Text counterText;
	float counter = 0;
	float timescore;
    // Start is called before the first frame update
    void Start()
    {
		timescore = TrackTime.passedTime;
		counterText.text = timescore.ToString();

    }



	// Update is called once per frame
	private void FixedUpdate()
	{
		if(counter<50)
		{
			counter += 0.35f;
		}
		else
		{
	
			SceneManager.LoadScene("HomeScene");
		}
	}
}
