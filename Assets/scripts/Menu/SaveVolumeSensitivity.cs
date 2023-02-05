using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveVolumeSensitivity : MonoBehaviour
{
    [SerializeField] private Slider volumeSliderSensi = null;
    public float volumeValueS = 1;
    // Start is called before the first frame update
    void Start()
    {
        LoadValuesSensi();
    }
    public void SaveVolumeButtonSensi()
    {
        volumeValueS = volumeSliderSensi.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValueS);
        LoadValuesSensi();
    }
    void LoadValuesSensi()
    {
        float volumeValueS = PlayerPrefs.GetFloat("VolumeValue");
        volumeSliderSensi.value = volumeValueS;
        MouseMovement.xSens*= volumeValueS;
        //AudioListener.volume = volumeValueS;
        Debug.Log(MouseMovement.xSens);
    }

}
