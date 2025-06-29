window.showToastr = function (type, messsage){
    if (type == 'success'){
        toastr.success(messsage);
    }
    if (type == 'error'){
        toastr.error(messsage);
    }
}

window.showSweetToastr = function (type, message){
    if(type == 'success'){
        Swal.fire({
            title: "Good job!",
            text: message,
            icon: "success"
        });
    }
    if(type == 'error'){
        Swal.fire({
            title: "Good job!",
            text: message,
            icon: "error"
        });   
    }
}