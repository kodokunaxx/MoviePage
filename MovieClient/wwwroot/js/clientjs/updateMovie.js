$(document).ready(function () {
    var x = document.URL;
    var res = x.slice(35, x.length);
    $("#btnSua").attr("href", "UpdateMovie?" + res);
    $.ajax({
        url: "https://localhost:44367/api/movie/" + res,
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        success: function (data) {
            $("[name=movie]").eq(0).val(data.title),
                $("[name=movie]").eq(1).val(data.time),
                $("[name=movie]").eq(2).val(data.episodes),
                $("[name=movie]").eq(3).val((data.release_date).slice(0, 10)),
                $("[name=movie]").eq(4).val(data.language),
                $("[name=movie]").eq(5).val(data.nation),
                $("[name=movie]").eq(6).val(data.director),
                $("[name=movie]").eq(7).val(data.overview),
                $("[name=movie]").eq(8).val(data.youtube),
                $("#posterimg").attr("src", data.poster),
                $("#backdropimg").attr("src", data.backdrop)
        }
    })
});

$("#add").click(function () {
    let status = true;
    let mv = $("[name=movie]");
    let ckbox = $("[name=checkbox]");
    for (let i = 0; i < mv.length; i++) {
        if (mv.eq(i).val() == '') {
            status = false;
        }
    }

    if (status == true) {
        var x = document.URL;
        var res = x.slice(35, x.length);
        $.ajax({
            url: "https://localhost:44367/api/moviecategory/" + res,
            method: "GET",
            async: false,
            headers: { "Accept": "application/json; odata=verbose" },
            success: function (data) {
                for (let i = 0; i < data.length; i++) {
                    $.ajax({
                        url: "https://localhost:44367/api/moviecategory/delete/" + data[i].id,
                        method: "POST",
                        async: false,
                        headers: { "Accept": "application/json; odata=verbose" }
                    })
                }
            }
        })
        var input1 = document.getElementById("poster");
        var input2 = document.getElementById("backdrop");
        //var files = input1.files;
        let formData = new FormData();

        let posterdata;
        let backdropdata;
        if (input1.value == "") {
            posterdata = $("#posterimg").attr("src");
        } else {
            posterdata = "https://localhost:44367/api/image/" + input1.files[0].name;
            formData.append("files", input1.files[0]);
        }
        if (input2.value == "") {
            backdropdata = $("#backdropimg").attr("src");
        } else {
            backdropdata = "https://localhost:44367/api/image/" + input2.files[0].name;
            formData.append("files", input2.files[0]);
        }
        saveImg(formData);

        for (let i = 0; i < ckbox.length; i++) {
            if (ckbox.eq(i).prop('checked') == true) {
                saveCategory(ckbox.eq(i).val(), res);
            }
        }
        let formData1 = {
            id: parseInt(res),
            title: $("[name=movie]").eq(0).val(),
            overview: $("[name=movie]").eq(7).val(),
            release_date: $("[name=movie]").eq(3).val(),
            director: $("[name=movie]").eq(6).val(),
            backdrop: backdropdata,
            poster: posterdata,
            time: parseInt($("[name=movie]").eq(1).val()),
            nation: $("[name=movie]").eq(5).val(),
            episodes: parseInt($("[name=movie]").eq(2).val()),
            language: $("[name=movie]").eq(4).val(),
            youtube: $("[name=movie]").eq(8).val()
        }
        $.ajax({
            type: "POST",
            url: "https://localhost:44367/api/movie/update",
            dataType: "json",
            async: false,
            data: JSON.stringify(formData1),
            contentType: 'application/json'
        });
        window.location.href = '/MovieDetail?' + res;
    } else {
        alert("Không được bỏ trống");
    }

});

function saveImg(formData) {
    $.ajax({
        url: "https://localhost:44367/api/image",
        data: formData,
        async: false,
        processData: false,
        contentType: false,
        type: "POST"
    });
}

function saveCategory(idCategory, idMovie) {
    let formData = {
        idCategory: parseInt(idCategory),
        idMovie: parseInt(idMovie)
    }
    $.ajax(
        {
            url: "https://localhost:44367/api/moviecategory/add",
            dataType: "json",
            async: false,
            data: JSON.stringify(formData),
            contentType: 'application/json',
            type: "POST"
        }
    );
}




