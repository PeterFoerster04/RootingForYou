using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveVolumeMusik : MonoBehaviour
{
    [SerializeField] private Slider volumeSliderMusik = null;
    [SerializeField] private Text volumeSliderUI2 = null;
    // Start is called before the first frame update
    void Start()
    {
        LoadValuesMusik();
    }
    private void FixedUpdate()
    {
        LoadValuesMusik();
    }
    public void VolumeSliderMusik(float _valume)
    {
        volumeSliderUI2.text = _valume.ToString("0.0");
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
        AudioListener.volume = volumeValueM;
    }

}
