var name = "James";
var numberone = 1;
var verify = true;

var numbertwo = 2;
//var sum = numberone + numbertwo;
//var mul = numberone * numbertwo;

//ES 6 let

let fname="Thomas";


//Object

const student = {name:"James", Age:20};

//document.getElementById("valobject").innerHTML = student.name + "  "+ student.Age;


function displayobject(){
    //document.getElementById("valobject").innerHTML = this.student.name + this.student.Age;
    console.log(student.name + student.Age);
}


function addition(){

    var sum = numberone + numbertwo;
    var mul = numberone * numbertwo;

    document.getElementById("newone").innerHTML="Author";
    document.getElementById("newtwo").innerHTML=sum;
    document.getElementById("newthree").innerHTML=mul;

    console.log(sum);
    console.log(mul);

    return sum;
}



function checkEven(){
    var picknumb = document.getElementById("readnum").value;
    
    if(picknumb%2 ==0){
        console.log("Even");
    }else{
        console.log("Odd");
    }
}

var numberarr = [1,2,3,4,4];
for(let i=0;i<numberarr.length;i++){
    console.log(numberarr[i]);
}

var date = new Date();
console.log(date);