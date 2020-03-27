var task = task || {};

task.delete = function (id, invoker) {
    $.ajax({
        url: "/Task/Delete",
        dataType: "json",
        method: "POST",
        data: { "id": id },
        success: function () {
            invoker.closest('tr').remove();
        }
    });
}

task.create = function (formId, returnUrl) {
    var postData = objectifyForm(formId);
    $.ajax({
        url: "/api/Services/Task/Create",
        dataType: "json",
        contentType: "application/json",
        method: "POST",
        data: JSON.stringify(postData),
        success: function () {
            window.location.href = returnUrl;
        }
    });
}