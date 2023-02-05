using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class settingscript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioSource audioSource;
    public AudioClip clip;


	private void Start()
	{
		StartAudio();
	}

	public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
	}

	public void StartAudio()
	{
		audioSource.clip = clip;
        audioSource.Play();
	}
}
