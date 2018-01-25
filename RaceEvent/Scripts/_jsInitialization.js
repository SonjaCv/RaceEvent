$(window).load(function () {
    var jsonData;
    $.ajax({
        type: "GET",
        traditional: true,
        async: false,
        cache: false,
        url: '/JSON/json_test_data.txt',
        context: document.body,
        success: function (data) {

            try {
                jsonData = JSON.parse(data);
                $("body").css({
                    "background": "url(" + jsonData.event.backgroundPhotoUrl + ") no-repeat center center fixed",
                    "background-size": "cover"
                });
                $("#sponsorImg").attr({
                    "src": jsonData.event.sponsorPhotoUrl
                });
                $("#logo").attr({
                    "src": jsonData.event.appLogoPhotoUrl,
                    "width": "150px",
                    "height": "120px"
                });
                $("#eventName").text(jsonData.event.name);
                $("#eventNameCopy").text(jsonData.event.name);
                $("#eventCity").text(jsonData.event.city);
                $("#eventCountry").text(jsonData.event.countryCode);
                $("#eventDate").text(jsonData.event.displayDate);
            }
            catch (e) {
                alert(e);
            }
        },
        error: function (xhr) {
            console.log(xhr.responseText);
            alert("Error has occurred..");
        }
    });
});