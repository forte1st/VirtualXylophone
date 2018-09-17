using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VirtualXylophone {
    public class Mallet : MonoBehaviour {

		[System.NonSerialized]
        public Vector3 velocity;

		private Vector3 prevPos;

		void FixedUpdate() {
			//速度を求める
            velocity = (transform.position - prevPos) / Time.deltaTime;
            prevPos = transform.position;
        }
    }
}