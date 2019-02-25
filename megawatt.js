// JavaScript source code
window.onload = function () {
    var x = document.getElementById("submit");

    if (x.addEventListener) {
        x.addEventListener("click", myFunction);
    }

    else if (x.attachEvent) {
        x.attachEvent("onclick", myFunction);
    }
    //global variables
    var first;
    var last;
    var phoneNo;
    var panels;
    var express;
    var deposit;


    function Validate() {
        if (checkFName() && checkLName() && checkPhoneNumber() && checkInpNumber() && checkMoney()) {
            return true;
        } else {
            return false;
        }
    }
    //validate first
    function checkFName() {
        alert("checking first");
        first = document.forms["form"]["fName"].value;
        var regex = /^[A-Za-z]+$/;
        if (!first.match(regex)) {
            document.getElementById("fNameErr").innerHTML = ("Must Input String");
            return false;
        }
        else {
            return true;
        }
    }
    //validate last
    function checkLName() {
        alert("checking last");
        last = document.forms["form"]["lName"].value;

        var regex = /^[A-Za-z]+$/;
        if (!last.match(regex)) {
            document.getElementById("lNameErr").innerHTML = ("Must Input String");
            return false;
        }
        else {
            return true;
        }
    }
    //validate number
    function checkInpNumber() {
        alert("checking num");
        panels = documents.forms["form"]["number"].value;
        var regex = /^[0-9]+$/;

        if (!panels.match(regex)) {
            document.getElementById("numberErr").innerHTML = ("Must Input Number");
            return false;
        }
        else {
            return true;
        }
    }
    //validate phone number
    function checkPhoneNumber() {
        alert("checking phone");
        phoneNo = parseInt(document.forms["form"]["phone"].value);
        phoneNo = 1111111111;
        var regex = /^[(]{0,1}[0-9]{3}[)]{0,1}[-\s\.]{0,1}[0-9]{3}[-\s\.]{0,1}[0-9]{4}$/;
        if (!(regex.test(phoneNo.value))) {
            document.getElementById("phoneErr").innerHTML = ("Must Input Phone Format");
            return false;
        }
        else {
            return true;
        }
    }
    //validate money
    function checkMoney() {
        alert("checking money");
        deposit = documents.forms["form"]["deposit"].value;
        var regex = /(?=.)^\$?(([1-9][0-9]{0,2}(,[0-9]{3})*)|0)?(\.[0-9]{1,2})?$/;
        if (!deposit.match(regex)) {
            document.getElementById("depositErr").innerHTML = ("Must input currency format");
            return false;
        }
        else {
            return true;
        }
    }
    function myFunction() {
        if (Validate()) {
            var due;
            var additional = (parseInt(panels) - 2) * 300;
            var baseInstall = 2000;
               
            if (express === true) {
                due = 1.05 * (baseInstall + additional);
            }
            else {
                due = (baseInstall + additional);
            }

            document.writeln("Hello, " + first + " " + last);
            document.writeln("Base Charge: " + baseInstall.toLocaleString('en-US', { style: 'currency', currency: 'USD' }));
            document.writeln("Additional Panels: " + additional.toLocaleString('en-US', { style: 'currency', currency: 'USD' }));
            document.writeln("Total cost: " + due.toLocaleString('en-US', { style: 'currency', currency: 'USD' }));
            document.writeln("Deposit amount: " + deposit.toLocaleString('en-US', { style: 'currency', currency: 'USD' }))
            due -= deposit;
            document.writeln("Balance due: " + due.toLocaleString('en-US', { style: 'currency', currency: 'USD' }));
        } else {
            alert("bad");
        }
    }
}
