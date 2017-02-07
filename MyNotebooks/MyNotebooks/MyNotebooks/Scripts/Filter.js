function filter() {
    let filterText = $("#myInput").val();
    filterText = filterText.toLowerCase();
    console.log(filterText);

    $(".thumbnail").each(function () {
        let name = $(this).attr("title");
        name = name.toLowerCase();
        console.log(name);
        if(name.indexOf(filterText) > -1){
            $(this).css("display", "");
        }
        else
        {
            $(this).css("display", "none");
        }
    });
}