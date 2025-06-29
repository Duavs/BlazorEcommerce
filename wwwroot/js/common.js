window.showToastr = function (type, messsage){
    if (type == 'success'){
        toastr.success(messsage);
    }
    if (type == 'error'){
        toastr.error(messsage);
    }
}