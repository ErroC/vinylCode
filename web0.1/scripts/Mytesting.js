$(document).ready(function () {
    //$("p").hide();
    $("h1").click(function () {
        $(this).next().slideToggle(1000, function () {
            $("p").next().slideToggle(1000)
        });
    });

    

});