
$(function () {

    // tab内容切换
    $("div.head li").click(function () {
        var index = $(this).attr("data");
        if (!isNaN(index)) {
            $(this).addClass("current");
            $("ul.tab li").not("ul.tab li:eq(" + index + ")").removeClass("current");
            $("div.content .item").eq(index).attr("class", "item active");
            $("div.content .item").not("div.content .item:eq(" + index + ")").attr("class", "item none");
        }
    });

})