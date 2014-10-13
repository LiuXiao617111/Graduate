$().ready(function () {
    //课程表特效
    $('.Scheduletable td').bind("mouseover", function () {
        $(this).addClass("onmouseoverScheduletableTd");
    });
    $('.Scheduletable td').bind("mouseleave", function () {
        $(this).removeClass("onmouseoverScheduletableTd");
    });
});