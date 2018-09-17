using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VirtualXylophone {
    public class XyloKey : MonoBehaviour {

		public float maxVolumeSpeed;        //音量が最大となるマレットの速さ。この値よりゆっくり叩いた場合、速さに比例して音量が変わります（デフォルト：1.0f）
		public Color inactiveKeyColor;      //通常時の色（デフォルト：new Color32(145, 75, 20, 255)）
		public Color activeKeyColor;        //叩いた直後の色（デフォルト：new Color32(255, 255, 0, 255)）
		public float coolDownSpeed;			//色が元に戻るスピード（デフォルト：3.0f）

		private AudioSource audioSource;
		private Renderer ren;
		private float activeLevel = 0;

        void Start() {
            audioSource = gameObject.GetComponent<AudioSource>();
			ren = gameObject.GetComponent<Renderer>();
			ren.material.color = inactiveKeyColor;
		}

		void Update() {
			//activeLevelを少しずつ減少させる
			 if(activeLevel > 0) {
				activeLevel -= Time.deltaTime * coolDownSpeed;
			} else {
				activeLevel = 0;
			}
			ren.material.color = Color.Lerp(inactiveKeyColor, activeKeyColor, activeLevel);		//activeLevelに応じて色を変える
		}

		void OnTriggerEnter(Collider other) {
            if (other.tag == "Mallet") {
				//振り下ろした時のみ音を鳴らす（振り上げる際に誤って隣のキーを鳴らしてしまうのを防ぐため）
				float speedY = other.GetComponent<Mallet>().velocity.y;
				if (speedY < 0) {
					audioSource.PlayOneShot(audioSource.clip, Mathf.Clamp01(-speedY));
					activeLevel = 1;														//叩いた直後はactiveLevelが最大になる
                }
            }
        }
    }
}