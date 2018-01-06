# VideoFilePlay
Asp .Net Core 2.0 视频播放器 ，播放功能是Aliplayer

# 应用场景
可以搭建一个局域网视频分享网站，比如寝室中有好电影共同分享 嘿嘿嘿你懂得~

至于用途有很多，项目只是一个Demo至于其他功能自己动手附加。

视频目录 `wwwroot/videos`

## 发布
使用 `dotnet publish -c Release -f netcoreapp2.0 -r win-x64` 可用于非.net core环境下的windows运行

`-r win-x64` 运行时参考 https://docs.microsoft.com/zh-cn/dotnet/core/rid-catalog


## Aliplayer
https://player.alicdn.com/aliplayer/index.html

阿里云Web播放器SDK，同时支持Flash和Html5两种播放技术。

Flash 模式：<br>
视频格式： mp4、flv、m3u8、rtmp<br>
视频编码： H.264<br>
音频编码： AAC、MP3<br>
音频格式：MP3<br>

HTML5 模式：<br>
视频格式： mp4、m3u8、flv<br>
视频编码： H.264<br>
音频编码： AAC<br>
音频格式： mp3<br>
