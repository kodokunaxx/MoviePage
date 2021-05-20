$(document).ready(function () {

    $.ajax({
        url: "https://localhost:44367/api/movie?categoryID=1",
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        success: function (data) {
            for (let i = 0; i < data.length; i++) {
                $(".movies-slide").eq(0).append(
                    '<a href="MovieDetail?' + data[i].id + '" class="movie-item">' +
                    '<img src=' + data[i].poster + ' alt="">' +
                    '<div class="movie-item-content">' +
                    '<div class="movie-item-title">' + data[i].title + '</div>' +
                    '<div class="movie-infos"><div class="movie-info"><i class="bx bxs-star"></i><span>9.5</span></div>' +
                    '<div class="movie-info"><i class="bx bxs-time"></i><span>' + data[i].time + ' mins</span></div>' +
                    '<div class="movie-info"><span>HD</span></div>' +
                    '<div class="movie-info"><span>16+</span></div>' +
                    '</div>' +
                    '</div>' +
                    '</a>'
                );
            }
            owl(0);
        }
    })

    $.ajax({
        url: "https://localhost:44367/api/movie?categoryID=2",
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        success: function (data) {
            for (let i = 0; i < data.length; i++) {
                $(".movies-slide").eq(1).append(
                    '<a href="MovieDetail?' + data[i].id + '" class="movie-item">' +
                    '<img src=' + data[i].poster + ' alt="">' +
                    '<div class="movie-item-content">' +
                    '<div class="movie-item-title">' + data[i].title + '</div>' +
                    '<div class="movie-infos"><div class="movie-info"><i class="bx bxs-star"></i><span>9.5</span></div>' +
                    '<div class="movie-info"><i class="bx bxs-time"></i><span>' + data[i].time + ' mins</span></div>' +
                    '<div class="movie-info"><span>HD</span></div>' +
                    '<div class="movie-info"><span>16+</span></div>' +
                    '</div>' +
                    '</div>' +
                    '</a>'
                );
            }
            owl(1);
        }
    })

    $.ajax({
        url: "https://localhost:44367/api/movie?categoryID=3",
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        success: function (data) {
            for (let i = 0; i < data.length; i++) {
                $(".movies-slide").eq(2).append(
                    '<a href="MovieDetail?' + data[i].id + '" class="movie-item">' +
                    '<img src=' + data[i].poster + ' alt="">' +
                    '<div class="movie-item-content">' +
                    '<div class="movie-item-title">' + data[i].title + '</div>' +
                    '<div class="movie-infos"><div class="movie-info"><i class="bx bxs-star"></i><span>9.5</span></div>' +
                    '<div class="movie-info"><i class="bx bxs-time"></i><span>' + data[i].time + ' mins</span></div>' +
                    '<div class="movie-info"><span>HD</span></div>' +
                    '<div class="movie-info"><span>16+</span></div>' +
                    '</div>' +
                    '</div>' +
                    '</a>'
                );
            }
            owl(2);
        }
    })

    $.ajax({
        url: "https://localhost:44367/api/movie?categoryID=4",
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        success: function (data) {
            for (let i = 0; i < data.length; i++) {
                $(".movies-slide").eq(3).append(
                    '<a href="MovieDetail?' + data[i].id + '" class="movie-item">' +
                    '<img src=' + data[i].poster + ' alt="">' +
                    '<div class="movie-item-content">' +
                    '<div class="movie-item-title">' + data[i].title + '</div>' +
                    '<div class="movie-infos"><div class="movie-info"><i class="bx bxs-star"></i><span>9.5</span></div>' +
                    '<div class="movie-info"><i class="bx bxs-time"></i><span>' + data[i].time + ' mins</span></div>' +
                    '<div class="movie-info"><span>HD</span></div>' +
                    '<div class="movie-info"><span>16+</span></div>' +
                    '</div>' +
                    '</div>' +
                    '</a>'
                );
            }
            owl(3);
        }
    })

    $.ajax({
        url: "https://localhost:44367/api/movie?categoryID=5",
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        success: function (data) {
            for (let i = 0; i < data.length; i++) {
                $(".movies-slide").eq(4).append(
                    '<a href="MovieDetail?' + data[i].id + '" class="movie-item">' +
                    '<img src=' + data[i].poster + ' alt="">' +
                    '<div class="movie-item-content">' +
                    '<div class="movie-item-title">' + data[i].title + '</div>' +
                    '<div class="movie-infos"><div class="movie-info"><i class="bx bxs-star"></i><span>9.5</span></div>' +
                    '<div class="movie-info"><i class="bx bxs-time"></i><span>' + data[i].time + ' mins</span></div>' +
                    '<div class="movie-info"><span>HD</span></div>' +
                    '<div class="movie-info"><span>16+</span></div>' +
                    '</div>' +
                    '</div>' +
                    '</a>'
                );
            }
            owl(4);
        }
    })

    $.ajax({
        url: "https://localhost:44367/api/movie?categoryID=6",
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        success: function (data) {
            for (let i = 0; i < data.length; i++) {
                $(".movies-slide").eq(5).append(
                    '<a href="MovieDetail?' + data[i].id + '" class="movie-item">' +
                    '<img src=' + data[i].poster + ' alt="">' +
                    '<div class="movie-item-content">' +
                    '<div class="movie-item-title">' + data[i].title + '</div>' +
                    '<div class="movie-infos"><div class="movie-info"><i class="bx bxs-star"></i><span>9.5</span></div>' +
                    '<div class="movie-info"><i class="bx bxs-time"></i><span>' + data[i].time + ' mins</span></div>' +
                    '<div class="movie-info"><span>HD</span></div>' +
                    '<div class="movie-info"><span>16+</span></div>' +
                    '</div>' +
                    '</div>' +
                    '</a>'
                );
            }
            owl(5);
        }
    })
});

function owl(i) {
    let navText = ["<i class='bx bx-chevron-left'></i>", "<i class='bx bx-chevron-right'></i>"]
    $('.movies-slide').eq(i).owlCarousel({
        items: 2,
        dots: false,
        nav: true,
        navText: navText,
        margin: 15,
        responsive: {
            500: {
                items: 2
            },
            1280: {
                items: 4
            },
            1600: {
                items: 6
            }
        }
    })
}