使用DX11 

0.Package Manager (往後簡稱PM)裡的 visual studio editor 更新

vscode開發untiy拓展：
C#
Debugger for Unity

Unity Code Snippets

Unity Code Snippets Improved

Unity Tools

Prettier-Code formatter

1.在左上 Window->PM->Unity Registry 下載 (1)Universal RP + (2)Shader Graph

2.Edit->project settings->按Graphics-> Scriptable Render Pipeline Setting->選擇"URP"。

3.Edit->project settings->Graphics->URP Global Setting->可能需要按下fix按鈕 ，確保第一行是
"UniversalRenderPipelineGlobalSettings"。

4.設定layer 看 "Layersetting"。
5.設定player physics 看 "playersetting"。
![image](https://github.com/JohnnnyKuo/Fanp_1/blob/main/ToolBok/Layersetting.png)
![image](https://github.com/JohnnnyKuo/Fanp_1/blob/main/ToolBok/Layersetting.png)

6.新增NaughtyAttributes套件
7.新增Tag GravityAffect (給會受到重力影響之物件)
8.新增Tag Projecter (給投射類像子彈)
9.新增視差paralax 遠景->腳色地面->近景(參數調整為0.5->0->-0.5)共能分10檔位