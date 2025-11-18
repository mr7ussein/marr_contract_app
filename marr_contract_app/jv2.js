
function ccc() {
    var p = document.getElementById("Div2");
    p.className = "pr3";
}
function ccc2() {
    var p = document.getElementById("Div2");
    p.className = "prnt";
    var p2 = document.getElementById("Div1");
    p2.className = "prnt";
    var p5 = document.getElementById("opened");
    p5.className = "pr_prev";
    var pmg = document.getElementById("imgdiv55");
    pmg.style.borderColor = "#EFEFEF";
    document.body.style.backgroundColor = "#2C3E5B";
    var p3 = document.getElementById("link1");
    p3.className = "hide";
    var p1 = document.getElementById("Button1");
    p1.className = "btn";
    var p10 = document.getElementById("Button2");
    p10.className = "hide";
    var p11 = document.getElementById("hus_id");
    p11.className = "hide";
    var p12 = document.getElementById("hus_id1");
    p12.className = "hide";
    var p13 = document.getElementById("wife_id");
    p13.className = "hide";
    var p14 = document.getElementById("wife_id1");
    p14.className = "hide";
    var p15 = document.getElementById("hus_p");
    p15.className = "hide";
    var p16 = document.getElementById("hus_p1");
    p16.className = "hide";
    var p17 = document.getElementById("wife_p");
    p17.className = "hide";
    var p19 = document.getElementById("wife_p1");
    p19.className = "hide";
    var p20 = document.getElementById("Image2");
    p20.className = "img";
    var p21 = document.getElementById("Image3");
    p21.className = "img";
    var p22 = document.getElementById("Image4");
    p22.className = "img";
    var p23 = document.getElementById("Image5");
    p23.className = "img";
    document.getElementById('Label15').innerHTML = "هوية الزوج";
    document.getElementById('Label18').innerHTML = "هوية الزوجة";
    document.getElementById('Label19').innerHTML = "صورة الزوج";
    document.getElementById('Label20').innerHTML = "صورة الزوجة";
    document.getElementById('Label_title').innerHTML = "مجلس القضاء الاعلى" + "<br/>(عقد الزواج الألكتروني )";
    document.getElementById('lbl_note').innerHTML = "السيد المراجع المحترم" + "<br/> لضمان سرعة انجاز معاملاتكم عند مراجعة محكمة الاحوال الشخصية يرجى  " + "<br/>( التأكد من صحة البيانات المتقدمة اعلاه وطباعة استمارة التقديم لأحتوائها على الرمز الخاص بك)";



}
function writeToNewWindow() {
    var p1 = document.getElementById("Button1");
    p1.className = "hide";
    var p2 = document.getElementById("divIMG");
    p2.className = "Div_img_print";

    document.body.style.backgroundColor = "white";
    var css = '@page { size: A4;   margin: 0mm; }',
      head = document.head || document.getElementsByTagName('head')[0],

      style = document.createElement('style');
    style.type = 'text/css';
    style.media = 'print';

    if (style.styleSheet) {
        style.styleSheet.cssText = css;
    } else {
        style.appendChild(document.createTextNode(css));
    }

    head.appendChild(style);

    window.print();

    //ccc();

}
function phonenumber(inputtxt) {
    var phoneno = /^\(?([0-9]{1})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$/;
    if (inputtxt.value.match(phoneno)) {
        var p = document.getElementById("Div2");
        p.className = "pr3";


    }
    else {
        alert("الرقم خاطأ تأكد من ادخالة بصورة صحيحة");
        return false;
    }



}

function Sliding() {

    var p = document.getElementById("Slider_Div");
    if (p.className.valueOf() == "Slider") {
        p.className = "Slider2";
        var x = document.getElementById("mng_item");
        x.className = "onmng";



    }

    else {
        p.className = "Slider";
        var x = document.getElementById("mng_item");
        x.className = "offdiv";
    }
}
function Sliding_C_IMG() {

    var p = document.getElementById("Slider_Div");
    if (p.className.valueOf() == "Slider") {
        p.className = "Sliderim";
        var x = document.getElementById("mng_item");
        x.className = "onmng";



    }

    else {
        p.className = "Slider";
        var x = document.getElementById("mng_item");
        x.className = "offdiv";
    }
}
function Sliding2() {

    var p = document.getElementById("Slider_Div");
    if (p.className.valueOf() == "Slider") {
        p.className = "Slider3";
        var x = document.getElementById("mng_item");
        x.className = "onmng";
        var x = document.getElementById("mng_item2");
        x.className = "offdiv";


    }

    else {
        p.className = "Slider";
        var x = document.getElementById("mng_item2");
        x.className = "offdiv";
    }
}
function Sliding0() {

    var p = document.getElementById("Slider_Div0");
    if (p.className.valueOf() == "Slider") {
        p.className = "Slider0";
        var x = document.getElementById("mng_item2");
        x.className = "onmng";



    }

    else {
        p.className = "Slider";
        var x = document.getElementById("mng_item2");
        x.className = "offdiv";
    }
}
function check_uncheck(x) {
    document.getElementById(x).checked = false;

}
function myFunction() {

    if (document.getElementById("new").checked == true) {
        window.location = "main1.aspx";
    }

    if (document.getElementById("srch").checked == true) {
        window.location = "main2.aspx";
    }


}
