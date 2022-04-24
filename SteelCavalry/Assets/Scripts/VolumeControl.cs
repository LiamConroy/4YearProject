using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class VolumeControl : MonoBehaviour
{
    // Start is called before the first frame update
    public string volumePara = "MasterVolume";
    public AudioMixer mixer;
    public Slider slider;
    private float multiplier = 30f;

    private void Awake(){
        slider.onValueChanged.AddListener(SliderValueChange);
    }

    private void OnDisable(){
        PlayerPrefs.SetFloat(volumePara, slider.value);
    }

    private void SliderValueChange(float value){
        mixer.SetFloat(volumePara, Mathf.Log10(value) * multiplier);
    }
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat(volumePara, slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
