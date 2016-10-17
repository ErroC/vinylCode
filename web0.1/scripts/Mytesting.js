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

function changeimage(val,val2) {
    document.getElementById("maini").src = "/images/" + val;
    changedisplay(val2);
};

function changedisplay(val) {
    var number=Math.floor(Math.random()*11)+1;
    var name ="d"+number+".jpg";
    document.getElementById(val).src = "/images/" + name;
};

function  Getinfor(){

    return 0;
};
