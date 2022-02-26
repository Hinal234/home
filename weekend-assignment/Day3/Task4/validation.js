function validation(){
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;

    var username1 = "abc";
    var password1 = "abc";

    if(username==username1 && password==password1){
        document.write("Welcome");
    }else{
        document.write("invalid username or password");
    }

}