// Index

$(function () {
    $("#GetPlayerHistory").submit(function (event) {
        $("#matchEvents").html("");
        $("#matchResults").html("");
        $("#gameHistoryResponse").html("<h3>Retrieving...</h3>");
        event.preventDefault();
        $.ajax({
            type: "POST",
            url: '/PlayerMatchHistory/GetPlayerHistory/',
            data: $(this).serialize(),
            datatype: 'html',
            success: function (response) {
                $("#gameHistoryResponse").html(response);
            }
        });
    });
});
