using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveVolumeSensi : MonoBehaviour
{
    [SerializeField] private Slider volumeSliderSensi = null;
    [SerializeField] private Text volumeSliderUI3 = null;

    // Start is called before the first frame update
    void Start()
    {
        LoadValuesSensi();
    }
    public void VolumeSliderSensi(float _valume)
    {
        volumeSliderUI3.text = _valume.ToString("0.0");
    }
    public void SaveVolumeButtonSensi()
    {
        float volumeValueS = volumeSliderSensi.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValueS);
        LoadValuesSensi();
    }
    void LoadValuesSensi()
    {
        float volumeValueS = PlayerPrefs.GetFloat("VolumeValue");
        volumeSliderSensi.value = volumeValueS;
        AudioListener.volume = volumeValueS;
    }

}
