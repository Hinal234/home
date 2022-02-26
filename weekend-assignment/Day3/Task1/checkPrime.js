function checkPrime(){
    var picknum = document.getElementById("readnum").value;
    let isPrime = true;

    if(picknum ==1){
        console.log("1 is neither prime nor composite");
    }
    else if(picknum > 1){
        for(let i=2;i<picknum;i++){
            if(picknum % i ==0){
                isPrime = false;
                break;
            }
        }
        if(isPrime){
            //console.log("number is prime");
            document.write("number is Prime");

        }else{
            //console.log("number is not Prime");
            document.write("number is not Prime");
        }
    }

}