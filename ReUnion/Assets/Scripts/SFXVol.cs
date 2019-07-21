using UnityEngine;
using UnityEngine.Audio;

public class SFXVol : MonoBehaviour {

    public AudioMixer mixer;

    public void SetLevel (float sliderValue)
    {
        mixer.SetFloat("SFXVol", Mathf.Log10(sliderValue) * 20);
    }
}