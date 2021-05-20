$("#add").click(function () {
    let status = true;
    let mv = $("[name=movie]");
    let ckbox = $("[name=checkbox]");
    for (let i = 0; i < mv.length; i++) {
        if (mv.eq(i).val() == '') {
            status = false;
        }
    }
    let count = 0;
    for (let i = 0; i < ckbox.length; i++) {
        if (ckbox.eq(i).prop('checked') == true) {
            count++;
        }
    }

    if (status == true && count > 0) {
        var input1 = document.getElementById("poster");
        var input2 = document.getElementById("backdrop");
        //var files = input1.files;
        let formData = new FormData();
        formData.append("files", input1.files[0]);
        formData.append("files", input2.files[0]);

        let formData1 = {
            title: $("[name=movie]").eq(0).val(),
            overview: $("[name=movie]").eq(7).val(),
            release_date: $("[name=movie]").eq(3).val(),
            director: $("[name=movie]").eq(6).val(),
            backdrop: "https://localhost:44367/api/image/" + input2.files[0].name,
            poster: "https://localhost:44367/api/image/" + input1.files[0].name,
            time: parseInt($("[name=movie]").eq(1).val()),
            nation: $("[name=movie]").eq(5).val(),
            episodes: parseInt($("[name=movie]").eq(2).val()),
            language: $("[name=movie]").eq(4).val(),
            youtube: $("[name=movie]").eq(10).val()
        }
        $.ajax({
            type: "POST",
            url: "https://localhost:44367/api/movie/add",
            dataType: "json",
            async: false,
            data: JSON.stringify(formData1),
            contentType: 'application/json',
            success: function (data) {
                for (let i = 0; i < ckbox.length; i++) {
                    if (ckbox.eq(i).prop('checked') == true) {
                        saveCategory(ckbox.eq(i).val(), data);
                    }
                }
            }
        });
        saveImg(formData);
        window.location.href = '/Movie';
    } else {
        alert("Không được bỏ trống");
    }

});
function saveImg(data) {
    $.ajax(
        {
            url: "https://localhost:44367/api/image",
            data: data,
            processData: false,
            contentType: false,
            async: false,
            type: "POST"
        }
    );
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










