$(function () {
    $("#zhuye_centre_centre_1 .title li,#zhuye_centre_centre_2 .title li").mouseover(function () {
        $(this).parent().children().removeClass("current");
        $(this).addClass("current");
        $(this).parent().siblings().hide();
        $(this).parent().siblings().eq($(this).index()).show();
    });
});