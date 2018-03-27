using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VirsualXylophone {
    public class XyloKey : MonoBehaviour {

        private AudioSource audioSource;

        void Start() {
            audioSource = gameObject.GetComponent<AudioSource>();
        }

        void OnTriggerEnter(Collider other) {
            if (other.tag == "Mallet") {
                if (other.GetComponent<Mallet>().velocity.y < 0) {
                    audioSource.PlayOneShot(audioSource.clip);
                }
            }
        }
    }
}