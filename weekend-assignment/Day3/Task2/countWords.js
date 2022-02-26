function countWords(){
    var name = document.getElementById("readtext").value;
    let count = 0;

    for(let i=0;i<name.length;i++){
        count++;
    }
    console.log(count);
    document.write(count);


}