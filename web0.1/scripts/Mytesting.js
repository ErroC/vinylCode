$(document).ready(function () {
    ("p").hide();
    $("inner").click(function () {
        $(this).next().slideToggle(1000, function () {
            $("p").next().slideToggle(1000)
        });
    });

    

});