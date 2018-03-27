using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VirsualXylophone {
    public class Mallet : MonoBehaviour {

        private Vector3 prevPos;
        [System.NonSerialized]
        public Vector3 velocity;

        void FixedUpdate() {
            velocity = (transform.position - prevPos) / Time.deltaTime;
            prevPos = transform.position;
        }
    }
}