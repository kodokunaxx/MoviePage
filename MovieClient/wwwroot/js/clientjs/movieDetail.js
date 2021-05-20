$(document).ready(function () {
    var x = document.URL;
    var res = x.slice(35, x.length);
    $("#btnSua").attr("href", "UpdateMovie?" + res);
    $.ajax({
        url: "https://localhost:44367/api/movie/" + res,
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        success: function (data) {
            $("#youtube").attr("href", data.youtube);
            $("#title").append(data.title);
            $("#img").attr("src", data.poster);
            getCategory(res);
            $(".pricing-name > p").eq(1).append(data.time);
            $(".pricing-name > p").eq(2).append(data.episodes);
            $(".pricing-name > p").eq(3).append((data.release_date).slice(0, 10));
            $(".pricing-name > p").eq(4).append(data.language);
            $(".pricing-name > p").eq(5).append(data.nation);
            $(".pricing-name > p").eq(6).append(data.director);
            $(".pricing-name > p").eq(7).append(data.overview);
        }
    })
});

function getCategory(res) {
    $.ajax({
        url: "https://localhost:44367/api/category/" + res,
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        success: function (data) {
            for (let i = 0; i < data.length; i++) {
                if (i == data.length - 1) {
                    $(".pricing-name > p").eq(0).append(data[i].name + ".");
                } else {
                    $(".pricing-name > p").eq(0).append(data[i].name + ", ");
                }
            }
        }
    })
}
$("#btnXoa").click(function () {
    var x = document.URL;
    var res = x.slice(35, x.length);
    $.ajax({
        url: "https://localhost:44367/api/movie/delete/" + res,
        method: "POST",
        headers: { "Accept": "application/json; odata=verbose" }
    })
});