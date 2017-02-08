function testImage(URL, image) {
    var tester = new Image();
    tester.onload = imageFound.bind(image);
    tester.onerror = imageNotFound.bind(image);
    tester.src = URL;
}

function imageFound(arguments) {
    
}

function imageNotFound() {
    console.log(this);
    $(this).attr("src", "http://www.caribbeanmemoryproject.com/uploads/3/9/6/8/39688192/__9240509.jpg");
}

$(".profile-image").each(function () {
    let src = $(this).attr("src");
    console.log(this)
    testImage(src, this);
});