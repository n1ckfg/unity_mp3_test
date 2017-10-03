using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SoundTest : MonoBehaviour {

    public string url = "Test";
    public AudioSource audio;

    private IEnumerator Start() {
        audio.clip = Resources.Load(url) as AudioClip;
        audio.Play();

        yield return null;
    }

}
