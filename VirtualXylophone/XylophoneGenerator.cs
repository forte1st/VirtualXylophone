using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VirsualXylophone {
    public class XylophoneGenerator : MonoBehaviour {

        public GameObject xyloKey;
        [Range(1, 100)]
        public int keyCount;                            // 生成する鍵盤の数 (デフォルト: 48)
        public int lowestSound;                         // ラ(440Hz)を0とした時の最低音 (デフォルト: -28)
        private GameObject[] keys;
        private int[] blackKeys = { 1, 4, 6, 9, 11 };   // ラを0とした時の黒鍵の音階
        private float keyDistance = 0.045f;             // 鍵盤の間隔

        void Start() {
            keys = new GameObject[keyCount];

            int whiteKeyCount = 0;

            for (int i = 0; i < keyCount; i++) {
                bool isBlackKey = false;
                foreach (int j in blackKeys) {
                    if (Mod(lowestSound + i, 12) == j) {
                        isBlackKey = true;
                        break;
                    }
                }

                keys[i] = Instantiate(xyloKey, transform);

                if (isBlackKey) {
                    keys[i].transform.localPosition = new Vector3(((float)whiteKeyCount - 0.5f) * keyDistance, 0.012f, 0.15f);
                } else {
                    keys[i].transform.localPosition = new Vector3(whiteKeyCount * keyDistance, 0, 0);
                    whiteKeyCount++;
                }

                keys[i].GetComponent<AudioSource>().pitch = Mathf.Pow(2, (float)(lowestSound + i) / 12);
            }
        }

        // 正剰余
        int Mod(int a, int b) {
            return a - b * Mathf.FloorToInt((float)a / (float)b);
        }
    }
}