# VirtualXylophone

## 概要
Oculus Touch等を用いてバーチャル空間で演奏できる木琴のシミュレータです。Unity5以上対応

## 利用規約
「大田マト」のクレジット表記（チャンネルまたは動画へのリンクもあると嬉しいです）をしていただければ、
商用・非商用に関わらず動画やゲームに利用していただいて構いません。  
ただし、アセット自体の再配布はご遠慮ください。  
また、本アセットは無保証であり、利用によって生じた損害等について当方は責任を負わないものとします。

大田マトチャンネル  
https://www.youtube.com/channel/UCY-rzz8F3xdJ9NS3Y5iAGjw

## 利用方法
1. VirtualXylophone.unitypackageをダウンロードしてインポート 

2. Example.unityを開く  
Mallet.prefab（バチ）とXylophone.prefab（本体）が配置されたシーンです。この時点ではバチは動きません。また、鍵盤は実行時に生成されるので再生するまで表示されません。 
  
3. Malletを手に連動させる  
Oculus Utilities for Unityを使用する場合、OVRCameraRigをシーンに配置して2本のMalletをそれぞれLeftHandAnchorとRightHandAnchorの子Objectにする。Malletの位置と角度はいい感じに調整してください。
