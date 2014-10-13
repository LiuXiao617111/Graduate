$(function () {
    $("#zhuye_centre_centre_1 .title li,#zhuye_centre_centre_2 .title li").mouseover(function () {
        $(this).parent().children().removeClass("current");//去除样式
        $(this).addClass("current");//添加样式
        $(this).parent().siblings().hide();
        $(this).parent().siblings().eq($(this).index()).show();
    });
});