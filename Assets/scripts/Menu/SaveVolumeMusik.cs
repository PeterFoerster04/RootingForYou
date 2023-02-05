using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveVolumeMusik : MonoBehaviour
{
    [SerializeField] private Slider volumeSliderMusik = null;
    // Start is called before the first frame update
    void Start()
    {
        LoadValuesMusik();
    }
    
    public void SaveVolumeButtonMusik()
    {
        float volumeValueM = volumeSliderMusik.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValueM);
        LoadValuesMusik();
    }
    void LoadValuesMusik()
    {
        float volumeValueM = PlayerPrefs.GetFloat("VolumeValue");
        volumeSliderMusik.value = volumeValueM;
        //AudioListener.volume = volumeValueM;
    }

}
