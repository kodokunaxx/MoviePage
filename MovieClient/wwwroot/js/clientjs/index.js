$("#login").click(function () {
    let name = $("[name=account]").eq(0).val();
    let pass = $("[name=account]").eq(1).val();

    $.ajax({
        url: "https://localhost:44367/api/user/login?username=" + name + "&password=" + pass,
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        success: function (data) {
            if (!data) {
                alert("Sai thông tin đăng nhập!");
            } else {
                sessionStorage.setItem("namelocal", data.fullname);
                sessionStorage.setItem("idlocal", data.id);
                window.location.href = '/Home';
            }
        }
    })
})

$('#search').keypress(function (e) {
    if (e.which == 13) {
        window.location.href = '/MovieSearch?' + $('#search').val();
        return false;    //<---- Add this line
    }
});