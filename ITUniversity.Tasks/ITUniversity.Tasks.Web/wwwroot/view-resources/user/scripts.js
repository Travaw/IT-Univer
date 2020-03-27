var user = user || {};

user.block = function (id, invoker) {
    $.ajax({
        url: "/api/services/user/block",
        dataType: "json",
        method: "POST",
        data: { "id": id },
        success: function () {
            invoker.closest('tr').remove();
        }
    });
}



user.update = function (formId, returnUrl) {
    debugger;
    var postData = objectifyForm(formId);
    $.ajax({
        url: "/api/services/user/update",
        dataType: "json",
        method: "POST",
        data: JSON.stringify(postData),
        success: function (data) {
            debugger;
            window.location.href = returnUrl;
        }
    });
}