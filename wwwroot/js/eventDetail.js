$(document).ready(function () {
		$(".event-filter").hide();
		$(".event-filter-button").hide();
		var url = window.location.pathname;
    var id = url.substring(url.lastIndexOf('/') + 1);

		$.getScript("/jquery-dateformat.min.js", function () {
			$.ajax({
				type: "GET",
				url: "http://web-api-dilo-web.apps.playcourt.id/api/services/app/API/GetEvent?eventId=" + id + "",
				contentType: "application/json;",
				dataType: "json",
				beforeSend: function () {
                    $('#preloader').show();
				},
				complete: function () {
                    $('#preloader').hide();
				},
				success: function (data) {
					//alert(JSON.stringify(data));
					$("#DIV").html('');
					$.each(data.result["data"], function (i, item) {
						var harga = "GRATIS";

						if (item.price != 0) {
							var harga = "Rp " + item.price;
						}

						$("#judul").append("<div class='col-12'><label style='margin-top:20px;'><h4>" + $.format.date(item.start_date, "dd MMMM yyyy") + "</br><strong>" + item.title + "</strong></h4></label></br ></div>");
						$("#gambarUtama").append("<img src='" + item.picture + "' style='width:480px;float:left;' />");
						$("#isiKonten").append(item.description +
							"<div><p><strong>Tanggal<strong></br>" + $.format.date(item.start_date, "ddd, dd MMMM yyyy") + "</br>" + $.format.date(item.time_start, "hh:mm a") + " - " + $.format.date(item.time_end, "hh:mm a") + "</p></div>" +
                            "<div><p><strong>Lokasi<strong></br>" + item.tenantName + "</br>" + item.location + "</br><a href='#' onclick='openMap()' id='lihat-peta'>Lihat Peta</a></p></div>" +
							"<div><p><strong>Harga<strong></br>" + harga + "</p></div>" +

							"<div>" +
							"<a class='button-daftar-event' href='#' onclick='daftar()' id='button-daftar'>Daftar</a>" +
							"<a class='button-daftar-event' href='#' id='button-attend'>Anda sudah terdaftar</a>" +
							"</div>");

                        initMapModal(item.lat, item.lon,item.location);
                        var membercodes = $('#membercode').val();
                        if (membercodes === "") {
                        	$("#button-attend").hide();
                        	
                        } else {
                        	$.each(item.participantData, function (x, content) {
                        		if (membercodes === content.account_id) {
                        			$("#button-daftar").hide();
                        			$("#button-attend").show();
                        		}
                        		else {
                        			$("#button-daftar").show();
                        			$("#button-attend").hide();
                        		}
                        	});
                        }
					}); //End of foreach Loop
				}, //End of AJAX Success function

				failure: function (data) {
				}, //End of AJAX failure function
				error: function (data) {
				} //End of AJAX error function

			});
    });
		
});
//function cekEvent(id,code) {
//	$.ajax({
//		type: "GET",
//		url: "http://web-api-dilo-web.apps.playcourt.id/api/services/app/API/GetEvent?eventId=" + id + "",
//		contentType: "application/json;",
//		dataType: "json",
//		success: function (data) {
//			//alert(JSON.stringify(data));
//			$("#DIV").html('');
//			$.each(data.result["data"], function (i, item) {
				
//			}); //End of foreach Loop
//		}, //End of AJAX Success function

//		failure: function (data) {
//		}, //End of AJAX failure function
//		error: function (data) {
//		} //End of AJAX error function

//	});
//}
function daftar() {
  
		var membercode = $('#membercode').val();
		var firstname = $('#firstname').val();
		var lastname = $('#lastname').val();
		var email = $('#email').val();

		var username = "admin";
		var password = "123qwe";
		var auth = {
			userNameOrEmailAddress: username,
			password: password,
			rememberClient: true
		};
		var url = window.location.pathname;
		var id = url.substring(url.lastIndexOf('/') + 1);
		var data = {
			event_id: id,
			first_name: firstname,
			last_name: lastname,
			email: email,
			has_arrived: false,
			arrival_time: null,
			account_id: membercode
		};
		if (membercode === "") {
			$('#EventFail').show();
		}
		else {
			$.ajax({
				type: "POST",
				url: "http://web-api-dilo-web.apps.playcourt.id/api/TokenAuth/Authenticate",
				async: true,
				cache: false,
				crossDomain: true,
				data: JSON.stringify(auth),
				contentType: "application/json; charset=utf-8",
				dataType: "json",
				success: function (responseData, textStatus, jqXHR) {
					//alert(responseData.result.accessToken);
					$('#preloader').show();

					PostEvent(responseData.result.accessToken,data);
					//Tester(responseData.result.accessToken);
					//All_news(responseData.result.accessToken);
					//$("#flat").flipster({
					//    style: 'flat',
					//    spacing: -0.25
					//});

				},
				error: function (responseData, textStatus, errorThrown) {
					//urls = "/Home/Error";
					//$(location).attr("href", urls);
				}
			});
			
			
		}
	}
	function PostEvent(token,data) {
		$.ajax({
				type: "POST",
				url: "http://web-api-dilo-web.apps.playcourt.id/api/services/app/AttendeesService/CreateAttendees",
			beforeSend: function (xhr) { xhr.setRequestHeader('Authorization', 'Bearer ' + token); },
			async: true,
			cache: false,
			crossDomain: true,
			data: JSON.stringify(data),
				contentType: "application/json; charset=utf-8",
				dataType: "json",
            success: function (response) {
                $('#preloader').hide();
					$('#EventSuccess').show();
					$('#button-daftar').text('Anda sudah terdaftar').prop("onclick", null).off("click");
					$('#button-daftar').hide();
					$('#button-attend').show();
				},
				error: function (response) {
					$('#EventFailed').show();
				}
				});
}
function openMap() {
    document.getElementById('map-modal').style.display = 'block';
}
function initMapModal(latitude, longitude,location) {
    var intLat = parseInt(latitude);
    var intLong = parseInt(longitude);
    var myLatLng = { lat: intLat, lng: intLong };

    var map = new google.maps.Map(document.getElementById('mapin-modal'), {
        zoom: 17,
        center: myLatLng
    });

    var marker = new google.maps.Marker({
        position: myLatLng,
        map: map,
        title: location
    });
}
$(document).on('click', function (event) {
    if (!$(event.target).closest('#map-modal,#lihat-peta').length) {
        $('#map-modal').hide();
        //alert("ok");
    }
});
