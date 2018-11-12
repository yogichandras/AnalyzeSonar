var _markers = [];
var _map = null;

function initialize() {

    var myOptions = {
        center: new google.maps.LatLng(-0.0218299, 118.106079),
        zoom: 5,
        styles: [
            {
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#f5f5f5"
                    }
                ]
            },
            {
                "elementType": "labels.icon",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#616161"
                    }
                ]
            },
            {
                "elementType": "labels.text.stroke",
                "stylers": [
                    {
                        "color": "#f5f5f5"
                    }
                ]
            },
            {
                "featureType": "administrative.country",
                "elementType": "geometry.fill",
                "stylers": [
                    {
                        "visibility": "on"
                    }
                ]
            },
            {
                "featureType": "administrative.land_parcel",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#bdbdbd"
                    }
                ]
            },
            {
                "featureType": "administrative.locality",
                "elementType": "geometry.fill",
                "stylers": [
                    {
                        "color": "#1e1e1e"
                    },
                    {
                        "visibility": "on"
                    }
                ]
            },
            {
                "featureType": "administrative.neighborhood",
                "elementType": "geometry.fill",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "administrative.province",
                "elementType": "geometry.fill",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "administrative.province",
                "elementType": "geometry.stroke",
                "stylers": [
                    {
                        "color": "#1e1e1e"
                    },
                    {
                        "visibility": "on"
                    },
                    {
                        "weight": 1
                    }
                ]
            },
            {
                "featureType": "landscape.man_made",
                "elementType": "geometry.stroke",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "poi",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#eeeeee"
                    }
                ]
            },
            {
                "featureType": "poi",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#757575"
                    }
                ]
            },
            {
                "featureType": "poi.park",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#e5e5e5"
                    }
                ]
            },
            {
                "featureType": "poi.park",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#9e9e9e"
                    }
                ]
            },
            {
                "featureType": "road",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#ffffff"
                    }
                ]
            },
            {
                "featureType": "road.arterial",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#757575"
                    }
                ]
            },
            {
                "featureType": "road.highway",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#dadada"
                    }
                ]
            },
            {
                "featureType": "road.highway",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#616161"
                    }
                ]
            },
            {
                "featureType": "road.local",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#9e9e9e"
                    }
                ]
            },
            {
                "featureType": "transit.line",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#e5e5e5"
                    }
                ]
            },
            {
                "featureType": "transit.station",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#eeeeee"
                    }
                ]
            },
            {
                "featureType": "water",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#c9c9c9"
                    }
                ]
            },
            {
                "featureType": "water",
                "elementType": "geometry.fill",
                "stylers": [
                    {
                        "color": "#ffffff"
                    },
                    {
                        "visibility": "on"
                    }
                ]
            },
            {
                "featureType": "water",
                "elementType": "geometry.stroke",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
            {
                "featureType": "water",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#9e9e9e"
                    }
                ]
            }
        ]

    };
    var map = new google.maps.Map(document.getElementById("default"), myOptions);

    setMarkers(map);

}

function setMarkers(map) {
    console.log("assas");
    var diloMarkers = [];
    var mylatlongs = [


        { "dilo": "DILo Bandung", "lat": "-6.9043832", "lng": "107.6149274", "add": "Gedung Balemotekar", "add2": "Jalan Banda No.40", "url": "http://web-portal-dilo-web.apps.playcourt.id/bandung", "idmenu": "menu-bandung" },
        { "dilo": "DILo Banda Aceh", "lat": " 3.2599123", "lng": "97.1778532", "add": "Gedung Digital inovation Lounge (DILo)", "add2": "Jalan Syekh Muda Wali", "url": "http://web-portal-dilo-web.apps.playcourt.id/banda-aceh", "idmenu": "menu-banda-aceh" },
        { "dilo": "DILO Bogor", "lat": "-6.5865907", "lng": "106.8029565", "add": "Gedung OPMC TelkomBogor", "add2": "Jln. Padjadjaran no.39 - Jawa Barat - Indonesia", "url": "http://web-portal-dilo-web.apps.playcourt.id/bogor", "idmenu": "menu-bogor" },
        { "dilo": "DILO Tangerang", "lat": "-6.285334", "lng": "106.6633106", "add": "BSD Junction Blok A10", "add2": "Jalan pahalawan Seribu - Tangerang Selatan - Banten ", "url": "http://web-portal-dilo-web.apps.playcourt.id/tangerang", "idmenu": "menu-tangerang" },
        { "dilo": "DILO Makassar", "lat": "-5.1403044", "lng": "119.437582", "add": "", "add2": "Jalan Andi Pangerang Pettarani No. 13 Makassar 90215 ", "url": "http://web-portal-dilo-web.apps.playcourt.id/makassar", "idmenu": "menu-makassar" },
        { "dilo": "DILO Pekanbaru", "lat": "0.5268824", "lng": "101.4569661", "add": "", "add2": "Jln. Kinabalu no.12 Pekanbaru, Indonesia", "url": "http://web-portal-dilo-web.apps.playcourt.id/pekanbaru", "idmenu": "menu-pekanbaru" },
        { "dilo": "DILO Bekasi", "lat": "-6.2495154", "lng": "106.9524882", "add": "", "add2": "Jln. KH. Noer Ali no.1 A, Kalimalang, Bekasi , Indonesia<br>no telp: (021) 2284 4116", "url": "http://web-portal-dilo-web.apps.playcourt.id/bekasi", "idmenu": "menu-bekasi" },
        { "dilo": "DILo Balikpapan", "lat": "-1.2394878", "lng": "116.8705657", "add": "", "add2": "Jln. Mt Haryono Gedung Telkom STO 3 Pertokoan Balikpapan Baru, Kalimantan Timur, Indonesia", "url": "http://web-portal-dilo-web.apps.playcourt.id/balikpapan", "idmenu": "menu-balikpapan" },
        { "dilo": "DILO Denpasar", "lat": "-8.6386865", "lng": "115.2529742", "add": "Bali Creative Industry Center", "add2": "Jl. Wage Rudolf Supratman No.302, Denpasar Tim., Kota Denpasar, Bali 80237", "url": "http://web-portal-dilo-web.apps.playcourt.id/denpasar", "idmenu": "menu-denpasar" },
        { "dilo": "DILO Medan", "lat": "3.5715058", "lng": "98.6681892", "add": "", "add2": "Jln. Monginsidi no.6 Medan, Sumatera Utara, Indonesia", "url": "http://web-portal-dilo-web.apps.playcourt.id/medan", "idmenu": "menu-medan" },
        { "dilo": "DILO Malang", "lat": "-7.9800529", "lng": "112.6278911", "add": "", "add2": "Jln. Basuki Rahmad 11a - Malang - Jawa Timur - Indonesia", "url": "http://web-portal-dilo-web.apps.playcourt.id/malang", "idmenu": "menu-malang" },
        { "dilo": "DILo Depok", "lat": "-6.3815906", "lng": "106.8209501", "add": "", "add2": "Jln. Margonda Raya no. 23 Pancoran Mas, Depok, Indonesia<br>no telp: 021 77801655 <br>email: dilodepok@gmail.com", "url": "http://web-portal-dilo-web.apps.playcourt.id/depok", "idmenu": "menu-depok" },
        { "dilo": "DILo Surabaya", "lat": "-7.3107407", "lng": "112.7265223", "add": "Telkom Indonesia Divre V", "add2": "Jl Ketintang No 156 Surabaya, Jawa Timur, Indonesia<br>082220032374 - Fikri", "url": "http://web-portal-dilo-web.apps.playcourt.id/surabaya", "idmenu": "menu-surabaya" },
        { "dilo": "DILo Solo", "lat": "-7.5612514", "lng": "110.8130346", "add": "", "add2": "Jl Dr Soepomo no. 66 Unggawan, Banjarsari, Surakarta", "url": "http://web-portal-dilo-web.apps.playcourt.id/solo", "idmenu": "menu-solo" },
        { "dilo": "DILo Padang", "lat": "-0.9276187", "lng": "100.3604108", "add": "", "add2": "Jl. Batang Tarusan No.3, Alai Parak Kopi, Padang Utara, Kota Padang, Sumatera Barat 25139", "url": "http://web-portal-dilo-web.apps.playcourt.id/padang", "idmenu": "menu-padang" },
        { "dilo": "DILo Yogyakarta", "lat": "-7.7797217", "lng": "110.3758431", "add": "Gedung Digital Innovation Lounge(DILo)", "add2": "Jl. Kartini No. 7, Gondokusuman Yogyakarta", "url": "http://web-portal-dilo-web.apps.playcourt.id/yogyakarta", "idmenu": "menu-yogyakarta" },
        { "dilo": "DILo Kemenpora Jakarta", "lat": "-6.2120375", "lng": "106.7998504", "add": "Wisma Menpora", "add2": "JL. Gerbang Pemuda, RT.1/RW.3, Gelora Tanah Abang Jakarta Pusat, Jawa Barat, Indonesia", "url": "http://web-portal-dilo-web.apps.playcourt.id/jakarta-pusat", "idmenu": "menu-jakarta" }


    ];

    var infowindow = null;


    var infowindow = new google.maps.InfoWindow({
        content: ""
    });

    jQuery.each(mylatlongs, function (i, m) {
        var StartLatLng = new google.maps.LatLng(-25.901820984476252, 134.00135040279997);

        var marker = new google.maps.Marker({
            position: new google.maps.LatLng(m.lat, m.lng),
            bounds: true,
            map: map,
            icon: '/img/marker/dilo-inactive.png'
        });

        google.maps.event.addListener(marker, 'click', function () {
            infowindow.close();
            for (var j = 0; j < _markers.length; j++) {
                _markers[j].setIcon("/img/marker/dilo-inactive.png");
            }
            console.log("uyeah:" + m.idmenu);
            $(".amap").removeClass("active");
            $(".amap").removeClass("map-active");
            var _menu = m.idmenu.toString();
            $("#" + _menu).addClass("active map-active");

            marker.setIcon("/img/marker/dilo-active.png");
            infowindow.setContent(content);
            infowindow.open(map, marker);
        });

        var content = '<div style="max-width:250px;padding: 10px;border:1px soid red;border-radius:5px;"><center><h6><strong>' + m.dilo + '</strong></h6></center>' +
            '<h6>' + m.add + '</h6>' +
            '<ul style="padding-left: 18px;"><li> <h6>' + m.add2 + '</h6>' +
            '</li></ul>' + '<a target="_blank" href=' + m.url + '><h6 style="padding-left:18px !important; text-decoration: underline;">Kunjungi Website</h6></a></div>';

        diloMarkers.push(marker);

        _markers.push(marker);
    });
    marker = diloMarkers[3];
    console.log(marker);


}


function klikPeta(id) {

    for (var j = 0; j < _markers.length; j++) {
        _markers[j].setIcon("/img/marker/dilo-inactive.png");
    }

    marker = _markers[id];
    google.maps.event.trigger(marker, 'click');
    marker.setIcon("/img/marker/dilo-active.png");
};

$(function () {
    $(".amap").click(function (e) {

        var providerContainer = $(this).closest(".amap");
        $(".amap").removeClass("active");
        $(".amap").removeClass("map-active");
        $(this).addClass("active map-active");
    });
});