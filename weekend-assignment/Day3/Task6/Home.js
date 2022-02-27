function contact(){
    var firstname = document.getElementById("firstname").value;

    var lastname = document.getElementById("lastname").value;
    var email = document.getElementById("email").value;
    var subject = document.getElementById("details").value;
    console.log(firstname);
    console.log(lastname);
    console.log(email);
    console.log(subject);

    var count=0;
function cart(){
    count++;
    console.log(count);
    document.getElementById("cart").innerHTML=count;
}

}