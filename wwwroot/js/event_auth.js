$(document).ready(function () {

    var username = "admin";
    var password = "123qwe";
    var get_url = "http://web-api-dilo-web.apps.playcourt.id";
    var nodata = $('#nodata');
    var existdata = $('#existdata');
    var idmember = $('#idmember').val();
    var auth = {
        userNameOrEmailAddress: username,
        password: password,
        rememberClient: true
    };
    nodata.hide();
    existdata.hide();


    $.ajax({
        type: "POST",
        url: get_url + "/api/TokenAuth/Authenticate",
        async: true,
        cache: false,
        crossDomain: true,
        data: JSON.stringify(auth),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (responseData, textStatus, jqXHR) {
            //alert(responseData.result.accessToken);

            GetEvent(responseData.result.accessToken);
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
            //alert("error");
        }
    });



    function GetEvent(token) {
        //alert('token ='+token);
    	$.getScript("/jquery-dateformat.min.js", function () {

    	$.ajax({
            type: "GET",
            url: get_url + "/api/services/app/API/GetUserDetail?userId="+idmember+"",
            beforeSend: function (xhr) { xhr.setRequestHeader('Authorization', 'Bearer ' + token); },
            async: true,
            cache: false,
            crossDomain: true,
            //data: JSON.stringify(auth),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (responseData, textStatus, jqXHR) {

                var data = responseData.result.attendanceHistoryData;

                if (data !== null) {

                  
                    //eventHistoryData
                    $.each(responseData.result.attendanceHistoryData, function (i, item) {
                    	var rows = "<tr><td>" + $.format.date(item.eventHistoryData.start_date, 'dd/MM/yyyy') + "</td>" +
                            "<td>" + item.eventHistoryData.title + "</td>" +
                            "<td>" + item.eventHistoryData.status + "</td>" +
                            "<td><a href='/Event/Detail/" + item.eventHistoryData.id+"' class='btn btn-dark'>Detail</a></td></tr>";
                        $('#contentdata').append(rows);

                    });
                    existdata.show();

                }
                else {
                    nodata.show();
                }
                //Tester(responseData.result.accessToken);
            },
            error: function (responseData, textStatus, errorThrown) {
            }
    	});

    	});
    }

   

  

});

