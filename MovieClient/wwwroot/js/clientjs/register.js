$("#register").click(function () {
    let status = true;
    let acc = $("[name=account]");
    let gt = $("#gender");
    for (let i = 0; i < acc.length; i++) {
        if ((acc.eq(i).val()).trim() < 1) {
            status = false;
        }
    }

    console.log(status);
    let status2 = true;
    $.ajax({
        url: "https://localhost:44367/api/user/check?username=" + (acc.eq(1).val()).trim(),
        method: "GET",
        async: false,
        headers: { "Accept": "application/json; odata=verbose" },
        success: function (data) {
            if (data) {
                status2 = false;
            }
        }
    })

    let status3 = true;
    if ((acc.eq(2).val()).trim() != (acc.eq(3).val()).trim()) {
        status3 = false;
    }

    console.log(status2);
    let formData1 = {
        username: (acc.eq(1).val()).trim(),
        password: (acc.eq(2).val()).trim(),
        fullname: acc.eq(0).val(),
        gender: parseInt(gt.val()),
        email: acc.eq(4).val(),
        doB: acc.eq(5).val(),
        phoneNumber: acc.eq(6).val(),
        position: 1
    }
    if (status == true && status2 == true) {
        $.ajax({
            type: "POST",
            url: "https://localhost:44367/api/user/add",
            dataType: "json",
            async: false,
            data: JSON.stringify(formData1),
            contentType: 'application/json'
        });
        window.location.href = '/';
    } else if (status == false) {
        alert("Không được bỏ trống");
    } else if (status3 == false) {
        alert("Mật khẩu phải giống nhau!");
    } else {
        alert("Tài khoản này đã tồn tại!");
    }

});









