using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    private GvrAudioSource audio_source_;

    void OnEnable() {
        audio_source_ = GetComponent<GvrAudioSource>();
    }

    public void OnSelect()
    {
        PlaySound();
    }

    void PlaySound()
    {
        if (audio_source_ == null)
            return;
        
        audio_source_.Play();
    }
}
