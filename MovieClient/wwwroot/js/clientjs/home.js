$(document).ready(() => {
    // setting owl carousel

    $.ajax({
        url: "https://localhost:44367/api/movie",
        method: "GET",
        headers: {"Accept": "application/json; odata=verbose"},
        success: function(data){
            let limit;
            if(data.length>5){
                limit = 5;
            }
            else{
                limit = data.length;
            }
            for (let i = 0; i < limit; i++) {
                $("#hero-carousel").append(
                    '<div class="hero-slide-item">'+
                        '<img src='+ data[i].backdrop +' alt="">'+
                        '<div class="overlay"></div>'+
                        '<div class="hero-slide-item-content">'+
                            '<div class="item-content-wraper">'+
                                '<div class="item-content-title top-down">'+ data[i].title +'</div>'+
                                '<div class="movie-infos top-down delay-2">'+
                                    '<div class="movie-info"><i class="bx bxs-star"></i><span>9.5</span></div>'+
                                    '<div class="movie-info"><i class="bx bxs-time"></i><span>'+ data[i].time +' mins</span></div>'+
                                    '<div class="movie-info"><span>HD</span></div>'+
                                    '<div class="movie-info"><span>16+</span></div>'+
                                '</div>'+
                                '<div class="item-content-description top-down delay-4">'+ data[i].overview +'</div>'+
                                '<div class="item-action top-down delay-6"><a href='+ data[i].youtube +' class="btn btn-hover"><i class="bx bxs-right-arrow"></i><span>Watch trailer</span></a></div>'+
                            '</div>'+
                        '</div>'+
                    '</div>'
                );
            }

            for (let i = 0; i < data.length; i++) {
                $(".movies-slide").append(
                    '<a href="MovieDetail?'+ data[i].id +'" class="movie-item">'+
                        '<img src='+ data[i].poster +' alt="">'+
                        '<div class="movie-item-content">'+
                            '<div class="movie-item-title">'+ data[i].title +'</div>'+
                            '<div class="movie-infos"><div class="movie-info"><i class="bx bxs-star"></i><span>9.5</span></div>'+
                                '<div class="movie-info"><i class="bx bxs-time"></i><span>'+ data[i].time +' mins</span></div>'+
                                '<div class="movie-info"><span>HD</span></div>'+
                                '<div class="movie-info"><span>16+</span></div>'+
                            '</div>'+
                        '</div>'+
                    '</a>'
                );       
            }

            let navText = ["<i class='bx bx-chevron-left'></i>", "<i class='bx bx-chevron-right'></i>"]

            $('#hero-carousel').owlCarousel({
                items: 1,
                dots: false,
                loop: true,
                nav:true,
                navText: navText,
                autoplay: true,
                autoplayHoverPause: true
            })
            
            $('.movies-slide').owlCarousel({
                items: 2,
                dots: false,
                nav:true,
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
    })
})