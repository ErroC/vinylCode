var value;
$(document).ready(function call(val) {
    $("").hide();

    $("#inner").click(function () {
        $(this).next().slideToggle(3000, function () {
            $(this).next().slideToggle(3000)
        });
    });
});


function showinfo(val) {

    document.getElementById(val).click(
        $("." + val).slideToggle(3000)


    );
};

function changeimage(val, val2, val3) {
    document.getElementById("maini").src = "/images/" + val;
    changedisplay(val2);
    value = val3;
};

function changedisplay(val) {
    var number = Math.floor(Math.random() * 11) + 1;
    var name = "d" + number + ".jpg";
    document.getElementById(val).src = "/images/" + name;


};
function move() {

    return value;
};


function getids(p) {

    $("#" + p).val(value);
    
    alert($("#" + p).val());
    $("#ProductForm").submit();


};
function bigImg(x) {
    x.style.height = "303px";
    x.style.width = "427px";
}

function normalImg(x) {
    x.style.height = "150px";
    x.style.width = "150px";
}
