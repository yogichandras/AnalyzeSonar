$(document).ready(function () {

    var username = "admin";
    var password = "123qwe";
    var get_url = "http://web-api-dilo-web.apps.playcourt.id";
    var tentangkami = $('#tentangkami');
    var tentangdilo = $('#tentangdilo');
    var member = $('#member');
    var idtenant = $('#tenantid').val();
    var auth = {
        userNameOrEmailAddress: username,
        password: password,
        rememberClient: true
    };

    $('#preloader').show();
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
        $.ajax({
            type: "GET",
            url: get_url + "/api/services/app/HomeServices/GetHomeServices?TenantId=" + idtenant + "",
            beforeSend: function (xhr) { xhr.setRequestHeader('Authorization', 'Bearer ' + token); },
            async: true,
            cache: false,
            crossDomain: true,
            //data: JSON.stringify(auth),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (responseData, textStatus, jqXHR) {
                var data = responseData.result;

                tentangdilo.append("<p>" + data.tentangDilo.tentangDilo + "</p>");
                tentangkami.append("<p>" + data.tentangKami.tentangKami + "</p>");
                member.text(data.tentangKami.jumlahMember);
             
                $.each(data.facility, function (i, item) {
                    var rows_facility = "<div class='box wow fadeInRight fasilitas-box'>" +
                        "<div class='icon'><img style='width:100px;' src='https://dilo-image.apps.playcourt.id/facility/"+item.picture+"' /></div>" +
                        "<h4 class='title'><a href='#'>"+item.name+"</a></h4>" +
                        "<p class='description'>"+item.description+"</p>" +
                        "</div>";
                    $('#contentfacility').append(rows_facility);
                });
                $.each(data.client, function (i, item) {
                    var rows_facility = "<a href='" + item.url + "' style='display:block;float:left;'><img style='width: 90px;' src='https://dilo-image.apps.playcourt.id/client/" + item.icon + "'></a>";
                    $('#contentclient').append(rows_facility);
                });

                $('#preloader').hide();

                    
                //Tester(responseData.result.accessToken);
            },
            error: function (responseData, textStatus, errorThrown) {
                //alert("error");
            }
        });
    }





});

