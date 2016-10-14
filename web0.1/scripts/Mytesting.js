$(document).ready(function call(val) {
    $("p").hide();

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
    var name ="d"+number.toString()+".jpg";
    document.getElementById(val).src="/image/"+name;
}

