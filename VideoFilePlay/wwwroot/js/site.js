// Write your JavaScript code.
$(document).ready(function () {
    $('#container').css('height', window.innerHeight + 'px');

    var videoUrl = "https://player.alicdn.com/video/aliyunmedia.mp4"; //获取的视频地址
    // 初始化播放器
    var player = new Aliplayer({
        id: "J_prismPlayer",    // 容器id
        source: videoUrl,       // 视频url
        width: "100%",          // 播放器宽度
        height: "500px"          // 播放器高度
    });

    $('.file-item').on('click', function () {
        var url = $(this).attr('data-url');
        player.loadByUrl(url);
    });
});