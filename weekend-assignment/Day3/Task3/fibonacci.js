function fibonacci(){
    var num = document.getElementById("number").value;
    var num1 = 0;
    var num2 = 1;
    var nextterm;
    console.log("fibonacci Series:");

    for(let i=1;i<=num;i++){
        console.log(num1);
        nextterm = num1+num2;
        num1 = num2;
        num2 = nextterm ;
    }

}