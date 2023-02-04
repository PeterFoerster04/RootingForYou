using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveVolumeLautstärke : MonoBehaviour
{
    [SerializeField] private Slider volumeSliderLautstärke = null;
    [SerializeField] private Text volumeSliderUI1 = null;

    // Start is called before the first frame update
    void Start()
    {
        LoadValuesLautstärke();
    }
    private void FixedUpdate()
    {
        LoadValuesLautstärke();
    }
    public void VolumeSliderLautstärke(float _valume)
    {
        volumeSliderUI1.text = _valume.ToString("0.0");
    }
    public void SaveVolumeButtonLautstärke()
    {
        float volumeValueL = volumeSliderLautstärke.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValueL);
        LoadValuesLautstärke();
    }
    void LoadValuesLautstärke()
    {
        float volumeValueL = PlayerPrefs.GetFloat("VolumeValue");
        volumeSliderLautstärke.value = volumeValueL;
        AudioListener.volume = volumeValueL;
    }

}
