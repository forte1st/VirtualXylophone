# VirtualXylophone

## 概要
Oculus Touch等を用いてVR空間で演奏できる木琴のシミュレータです。Unity2018.2.20f1で動作確認

## 利用規約
「大田マト」のクレジット表記（チャンネルまたは動画へのリンクもあると嬉しいです）をしていただければ、
商用・非商用に関わらず動画やゲームに利用していただいて構いません。  
ただし、アセット自体の再配布はご遠慮ください。  
また、本アセットは無保証であり、利用によって生じた損害等について当方は責任を負わないものとします。

大田マトチャンネル  
https://www.youtube.com/channel/UCY-rzz8F3xdJ9NS3Y5iAGjw

## 利用方法
1. [こちら](https://github.com/forte1st/VirtualXylophone/releases)からVirtualXylophone.unitypackageをダウンロード  

2. ダウンロードしたunitypackageをインポート  

3. ScenesフォルダのSample.unityを開く  
Mallet（バチ）とXylophone（本体）が配置されたシーンです。この時点ではバチは動きません。また、鍵盤は実行時に生成されるので再生するまで表示されません。 
  
4. Malletを手に連動させる  
Oculus Utilities for Unityを使用する場合、OVRCameraRigをシーンに配置して2本のMalletをそれぞれLeftHandAnchorとRightHandAnchorの子にしてください。Malletの位置と角度はいい感じに調整してください。  

利用方法に関してご不明な点がございましたらお気軽にtwitterでご連絡ください。  
https://twitter.com/ootamato

## 更新履歴
2018/09/17　ver.2.0　鍵盤が光るようになりました。鍵盤の幅などのカスタマイズが可能になりました。  
2018/03/27　ver.1.0　公開
