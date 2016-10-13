$(document).ready(function call(val) {
    $("p").hide();

    $("#inner").click(function () {
        $(this).next().slideToggle(3000, function () {
            $(this).next().slideToggle(3000)
        });
    });
});

function info() {
    document.getElementById("image").scr = "";
};

function showinfo(val) {
   
    document.getElementById(val).click(
        $("."+val).slideToggle(3000)

    );
};