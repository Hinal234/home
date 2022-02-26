function getAge(){
    var userdateinput = document.getElementById("birthdate").value;
    console.log(userdateinput);
    
    var birthdate = new Date(userdateinput);
    //console.log(birthdate);

    var currentDate = new Date();
    //console.log(currentDate);

    var year = currentDate.getFullYear() - birthdate.getFullYear();
    console.log(year);
        
}