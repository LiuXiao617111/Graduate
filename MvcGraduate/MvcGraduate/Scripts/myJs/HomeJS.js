$().ready(function () {
    //课程表特效
    $('.Scheduletable td').bind("mouseover", function () {
        $(this).addClass("onmouseoverScheduletableTd");
    });
    $('.Scheduletable td').bind("mouseleave", function () {
        $(this).removeClass("onmouseoverScheduletableTd");
    });
    //添加导航点击的背景图片样式  navigation_menu_bg
    $('.navigation_centre_left div').bind('click', function () {
        $('.navigation_centre_left div').removeClass('navigation_menu_bg');
        $(this).addClass('navigation_menu_bg');
    });
});