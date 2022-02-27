let jsondata;
fetch("https://jsonplaceholder.typicode.com/users")
  .then(function (u) {
    return u.json();
  })
  .then(function (json) {
    jsondata = json;
    // console.log(jsondata[0]["id"]);
    // document.getElementById("id1").innerHTML = jsondata[0]["id"];

    let table = document.getElementById("tablebody");
    // console.log(table);
    let num = jsondata.length;
    for (i = 0; i < num; i++) {
      table.innerHTML =
        table.innerHTML +
        "<tr><td>" +
        jsondata[i]["id"] +
        "</td><td>" +
        jsondata[i]["name"] +
        "</td><td>" +
        jsondata[i]["username"] +
        "</td><td>" +
        jsondata[i]["email"]; +
        "</td></tr>"
    }
  });