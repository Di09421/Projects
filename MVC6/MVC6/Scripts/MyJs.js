function AjaxByGet() {
    $.ajax({
        type: "GET",
        url: "/Home/AjaxCallGet",  
        success: function (response) {
            alert(response);  
        },
        error: function (error) {
            alert("Error: " + error.responseText);
        }
    });
}

function AjaxByPost() {
    let objectData = GetValues();  

    $.ajax({
        type: "POST",
        url: "/Home/AjaxCallPost",  
        data: objectData,
        success: function (response) {
            alert("Post successful: " + response); 
        },
        error: function (error) {
            alert("Error: " + error.responseText);
        }
    });
}
function GetValues() {
    let userName = $('#UserName').val();
    let password = $('#Password').val();
    let obj = {
        UserName: userName,
        Password: password
    }
    return obj;
}

function JsonGet()
{
    $.ajax({
        type: "GET",
        url: "/Home/JsonData",
        success: function (response) {
            let obj = JSON.parse(response);
            let name = obj.Name;
            let age = obj.Age;
            let phone = obj.Phone;
            let ispass = obj.IsPass;

            $('#nameValue').text(name);
            $('#ageValue').text(age);
            $('#phoneValue').text(phone);
            $('#ispassValue').text(ispass);
            alert(response);
        },
        error: function (error) {
            alert(error);
        }
    });
}
