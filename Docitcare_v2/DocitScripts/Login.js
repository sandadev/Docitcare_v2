$(document).ready(function () {
    checkLogin();
});

function checkLogin() {
    $("#btnLogin").click(function () {
        var UserCredentials = {
            MobileNumber: $('#txtMobileNumber').val(),
            Password: $('#txtPassword').val(),
        }
        $.ajax({
            cache: false,
            type: "POST",
            url: LoginUrl,
            dataType: "json",
            data: { UserCredentials: UserCredentials },
            success: function (data) {

            },
            error: function (errMsg) {
                console.log("error");
            },
            failure: function (errMsg) {
                console.log("failure");
            }
        });
    });
}