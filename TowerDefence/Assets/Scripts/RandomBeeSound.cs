using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBeeSound : MonoBehaviour
{
    public AudioSource mySource;
    public AudioClip[] myAudio;
    public bool debugging;
    private int soundsToPlay;
    private Rigidbody rigidbody;

	void Awake() {
		rigidbody = GetComponent<Rigidbody>();
	}

    void PlaySound() {
        soundsToPlay = Random.Range(0, myAudio.Length);
        if (debugging) {
            Debug.Log("Sound play");
        }
        mySource.PlayOneShot(myAudio[soundsToPlay], 0.5f);
        mySource.Play();
    }

	void OnCollisionEnter(Collision collision) {
		if (Time.timeSinceLevelLoad > 1)
			PlaySound();
	}
}