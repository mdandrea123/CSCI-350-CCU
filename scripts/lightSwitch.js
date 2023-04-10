var onSwitch = document.getElementById("turnOn");
onSwitch.addEventListener("click", lightOn);

function lightOn() {
    var lightBox = document.getElementById("light");
    console.log("Light turned on.");
    lightBox.className = "lightOn";
}

var offSwitch = document.getElementById("turnOff");
offSwitch.addEventListener("click", lightOff);

function lightOff() {
    var lightBox = document.getElementById("light");
    console.log("Light turned off.");
    lightBox.className = "lightOff";
}

var nameField = document.getElementById("nameInput");
nameField.addEventListener("blur", check);

function check() {
    var theName = nameField.value;
    //console.log("Did you type it correctly?");
    console.log(theName + "? Is that your name?");
}

var greetButton = document.getElementById("greeting");
greetButton.addEventListener("click", greetUser);

function greetUser() {
    var inputField = document.getElementById("nameInput");
    var theName = inputField.value;
    var theGreeting = "Welcome " + theName;
    var paraField = document.getElementById("output");
    paraField.innerHTML = theGreeting;
}