using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VirtualXylophone {
    public class XylophoneGenerator : MonoBehaviour {

        public GameObject key;
        public int keyCount;            // 生成する鍵盤の数 (デフォルト: 50)
        public int centerKey;           //ラ（440Hz）を0とした時の中央の鍵盤の音（デフォルト：0）

        public float keyWidth;          //鍵盤の幅（デフォルト：0.05f）
        public float keyDepth;          //鍵盤の深さ（デフォルト：0.04f）
        public float keyLength;         //鍵盤の長さ（デフォルト：0.15f）
        public float blackKeyOffsetY;   //黒鍵をy方向にずらす量（デフォルト：0.012f）
        public float blackKeyOffsetZ;   //黒鍵をz方向にずらす量（デフォルト：0.15f）

        private readonly float keyWidthRatio = 0.8f;                        //隙間を除いた鍵盤の幅の比率
        private readonly bool[] blackKeys = { false, true, false, false, true, false, true, false, false, true, false, true };  //ラを基準とした黒鍵の位置
        private readonly float frequencyRatio = Mathf.Pow(2, 1.0f / 12.0f);     //隣り合う音の周波数比

        void Start() {
            int leftEnd = -keyCount / 2;    //左端
            int whiteKeyCount = 0;      //白鍵の数
            GameObject[] keys = new GameObject[keyCount];

            for (int i = 0; i < keyCount; i++) {
                //鍵盤を生成
                keys[i] = Instantiate(key, transform) as GameObject;

                keys[i].transform.localScale = new Vector3(keyWidth * keyWidthRatio, keyDepth, keyLength);

                //黒鍵と白鍵で位置を変える
                Vector3 keyPos;
                if (blackKeys[Mod(centerKey + leftEnd + i, blackKeys.Length)]) {
                    keyPos = Vector3.right * (whiteKeyCount - 0.5f) * keyWidth + new Vector3(0, blackKeyOffsetY, blackKeyOffsetZ);
                }
                else {
                    keyPos = Vector3.right * whiteKeyCount * keyWidth;
                    whiteKeyCount++;
                }

                keys[i].transform.position = transform.TransformPoint(keyPos);
                keys[i].GetComponent<AudioSource>().pitch = Mathf.Pow(frequencyRatio, centerKey + leftEnd + i);
            }

            //鍵盤全体を中央に移動
            for (int i = 0; i < keyCount; i++) {
                keys[i].transform.position += Vector3.left * whiteKeyCount * keyWidth / 2.0f;
            }
        }

        // 正剰余
        int Mod(int a, int b) {
            return a - b * Mathf.FloorToInt((float)a / (float)b);
        }
    }
}
