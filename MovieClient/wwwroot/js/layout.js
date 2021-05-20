$(document).ready(function () {
    if (sessionStorage.namelocal != null) {
        $("#nav-menu").append('<li><p href="#">Xin chào, <a href="#" id="changecolor">' + sessionStorage.namelocal + '</a> <p  id="changecolor" style="cursor: pointer;" onclick="logout()">Đăng xuất</p></p></li>');
    } else {
        window.location.href = '/';
    }
})

function logout() {
    sessionStorage.removeItem("namelocal");
    sessionStorage.removeItem("idlocal");
    window.location.href = '/';
}

$("#btnSearch").click(function () {
    window.location.href = '/movieSearch?' + $("#search").val();
})