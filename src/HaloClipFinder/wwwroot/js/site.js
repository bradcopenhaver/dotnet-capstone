// Index

$(function () {
    $("#GetPlayerHistory").submit(function (event) {
        event.preventDefault();
        $.ajax({
            type: "POST",
            url: '/PlayerMatchHistory/GetPlayerHistory/',
            data: $(this).serialize(),
            datatype: 'json',
            success: function (response) {
                $("#gameHistoryResponse").html(response);
            }
        });
    });
});