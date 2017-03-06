// Index

$(function () {
    $("#GetPlayerHistory").submit(function (event) {
        event.preventDefault();
        $.ajax({
            type: "POST",
            url: '/Home/GetPlayerHistory/',
            data: $(this).serialize(),
            datatype: 'json',
            success: function (response) {
                $("#gameHistoryResponse").html(response);
            }
        });
    });
});