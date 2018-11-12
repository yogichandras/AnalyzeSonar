var username = "admin";
var password = "123qwe";
var get_url = "http://web-api-dilo-web.apps.playcourt.id";
var auth = {
    userNameOrEmailAddress: username,
    password: password,
    rememberClient: true
};

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

        GetSkillParent(responseData.result.accessToken);
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



function GetSkillParent(token) {
    //alert('token ='+token);
    $.ajax({
        type: "GET",
        url: get_url + "/api/services/app/ApiSkill/GetParentAll",
        beforeSend: function (xhr) { xhr.setRequestHeader('Authorization', 'Bearer ' + token); },
        async: true,
        cache: false,
        crossDomain: true,
        //data: JSON.stringify(auth),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (responseData, textStatus, jqXHR) {

            var data = responseData.result.data;
            $.each(data, function (i, item) {
                //console.log(item.name);
                $('#keahlian1').append('<option value='+item.id+'>'+item.name+'</option>');
            });
            //Tester(responseData.result.accessToken);
        },
        error: function (responseData, textStatus, errorThrown) {
            //urls = "/Home/Error";
            //$(location).attr("href", urls);
        }
    });
}

$('#keahlian1').on("change", function () {
    $('#keahlian2').empty();
    var idSkill = $("#keahlian1").val();

    //$("#loadingcity").show();
    //$('#City').removeAttr("disabled");
    //$('#City').empty();
    $.ajax({
        type: "GET",
        url: get_url + "/api/services/app/ApiSkill/GetChildByParentId?id="+idSkill+"",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            //alert(JSON.stringify(data));
            $.each(data.result.data, function (i, item) {
                $('#keahlian2').append('<option value=' + item.id + '>' + item.name + '</option>');

            });
        }, //End of AJAX Success function

        failure: function (data) {
            alert("Select The Right Option");
        }, //End of AJAX failure function
        error: function (data) {
            alert("Select The Right Option");
        } //End of AJAX error function

    });

});

//function News(token) {
//    //alert('token ='+token);
//    $.ajax({
//        type: "GET",
//        url: get_url + "/api/services/app/NewsService/GetNews?indexPage=1&dataPerPage=5",
//        beforeSend: function (xhr) { xhr.setRequestHeader('Authorization', 'Bearer ' + token); },
//        async: true,
//        cache: false,
//        crossDomain: true,
//        //data: JSON.stringify(auth),
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        success: function (responseData, textStatus, jqXHR) {
//            $.each(responseData.result.news, function (i, item) {
//                elNews.append('\
//<div class="col-sm-3" style="margin-top:3%;" id="tester" class="">\
//                        <img src ="'+ item.picture + '" alt ="" style ="width:100%;" >\
//                    </div >\
//                        <div class="col-sm-9" id="tester_text" style="text-align:justify; text-decoration-color: aliceblue;color:#918e90;margin-top:5%;">\
//                            <text style="font-family:Segoe UI;font-size:33px;">\
//                              '+ item.description + '\
//                        </text>\
//                        </div>');
//                elPop.append('<div class="col-sm-4" style="padding: 0px !important; left: 14px; margin-top:2%;">\
//                        <img src ="'+ item.picture + '" alt = "" style = "width:100%;" >\
//                    </div >\
//                        <div class="col-sm-8" style="text-align:justify; text-decoration-color: aliceblue;color:#918e90;margin-top:2%;">\
//                            <text style="font-family:Segoe UI;font-size:13px;">\
//                               '+ item.description + '\
//                        </text>\
//                        </div>')



//            });


//            //Tester(responseData.result.accessToken);
//        },
//        error: function (responseData, textStatus, errorThrown) {
//            urls = "/Home/Error";
//            $(location).attr("href", urls);
//        }
//    });
//}

//function News_Paging(x, token) {
//    //alert('token ='+token);

//    $.ajax({
//        type: "GET",
//        url: get_url + "/api/services/app/NewsService/GetNews?indexPage=" + x + "&dataPerPage=5",
//        beforeSend: function (xhr) { xhr.setRequestHeader('Authorization', 'Bearer ' + token); },
//        async: true,
//        cache: false,
//        crossDomain: true,
//        //data: JSON.stringify(auth),
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        success: function (responseData, textStatus, jqXHR) {
//            $.each(responseData.result.news, function (i, item) {
//                elNews.append('\
//<div class="col-sm-3" style="margin-top:5%;">\
//                        <img src ="'+ item.picture + '" alt ="" style ="width:100%;" >\
//                    </div >\
//                        <div class="col-sm-9" style="text-align:justify; text-decoration-color: aliceblue;color:#918e90;margin-top:5%;">\
//                            <text style="font-family:Segoe UI;font-size:33px;">\
//                              '+ item.description + '\
//                        </text>\
//                        </div>');


//            });    //Tester(responseData.result.accessToken);
//        },
//        error: function (responseData, textStatus, errorThrown) {
//            urls = "/Home/Error";
//            $(location).attr("href", urls);
//        }
//    });
//}

//function All_news(token) {
//    //alert('token ='+token);
//    $.ajax({
//        type: "GET",
//        url: get_url + "/api/services/app/NewsService/GetNews?dataPerPage=20",
//        beforeSend: function (xhr) { xhr.setRequestHeader('Authorization', 'Bearer ' + token); },
//        async: true,
//        cache: false,
//        crossDomain: true,
//        //data: JSON.stringify(auth),
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        success: function (responseData, textStatus, jqXHR) {
//            $.each(responseData.result.news, function (i, item) {
//                elNews_all.append('\
//<div class="col-sm-3" style="margin-top:3%;" id="tester" class="">\
//                        <img src ="'+ item.picture + '" alt ="" style ="width:100%;" >\
//                    </div >\
//                        <div class="col-sm-9" id="tester_text" style="text-align:justify; text-decoration-color: aliceblue;color:#918e90;margin-top:5%;">\
//                            <text style="font-family:Segoe UI;font-size:33px;">\
//                              '+ item.description + '\
//                        </text>\
//                        </div>');




//            });


//            //Tester(responseData.result.accessToken);
//        },
//        error: function (responseData, textStatus, errorThrown) {
//            urls = "/Home/Error";
//            $(location).attr("href", urls);
//        }
//    });
//}

//function filter(x) {
//    elNews_all.empty();
//    $.ajax({
//        type: "POST",
//        url: get_url + "/api/TokenAuth/Authenticate",
//        async: true,
//        cache: false,
//        crossDomain: true,
//        data: JSON.stringify(auth),
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        success: function (responseData, textStatus, jqXHR) {
//            //alert(responseData.result.accessToken);

//            News_filter(x, responseData.result.accessToken);
//            //$("#flat").flipster({
//            //    style: 'flat',
//            //    spacing: -0.25
//            //});

//        },
//        error: function (responseData, textStatus, errorThrown) {
//            urls = "/Home/Error";
//            $(location).attr("href", urls);
//        }
//    });
//}
//function News_filter(x, token) {
//    //alert('token ='+token);

//    $.ajax({
//        type: "GET",
//        url: get_url + "/api/services/app/NewsService/GetNews?Name=" + x + "",
//        beforeSend: function (xhr) { xhr.setRequestHeader('Authorization', 'Bearer ' + token); },
//        async: true,
//        cache: false,
//        crossDomain: true,
//        //data: JSON.stringify(auth),
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        success: function (responseData, textStatus, jqXHR) {
//            if (responseData.result.news.length == 0) {
//                console.log("No Data dude!");
//            }
//            else {
//                $.each(responseData.result.news, function (i, item) {
//                    elNews_all.append('\
//<div class="col-sm-3" style="margin-top:5%;">\
//                        <img src ="'+ item.picture + '" alt ="" style ="width:100%;" >\
//                    </div >\
//                        <div class="col-sm-9" style="text-align:justify; text-decoration-color: aliceblue;color:#918e90;margin-top:5%;">\
//                            <text style="font-family:Segoe UI;font-size:33px;">\
//                              '+ item.description + '\
//                        </text>\
//                        </div>');


//                });    //Tester(responseData.result.accessToken);
//            }

//        },
//        error: function (responseData, textStatus, errorThrown) {
//            urls = "/Home/Error";
//            $(location).attr("href", urls);
//        }
//    });