// Variables!

// var name = "James";
// in C#, you use the var keyword, in javascript we use let.
let myName = "James";

// in C# we have Console.WriteLine()
console.log(myName); // "James";


// javascript has 5 primitive data types (string, number, boolean, null, undefined)

// string types
let myString = "This is a string";
let otherString = 'This is also a string';

// NO char type in javascript, all strings

// number types.... no floats, no integers... just numbers... ONLY NUMBERS.. thats it
let x = 5;
let y = 3.2;

// boolean, just like c# true or false
let isTrue = true;
let isFalse = false;

// complex types, arrays
let myArray = [1, 2, 3, 4, 5]; // arrays are like lists in C#, a statically sized array does NOT EXIST in javascript
console.log(myArray);

// var numbers = new List<int> {1, 2, 3, 4, 5}
// Console.WriteLine(numbers)  [system.collections.generic.list`1[System.Int32]]
// USE YOUR CONSOLE TO DEBUG YOUR CODE IN JAVASCRIPT!! ITS ONE OF YOUR BEST TOOLS!!!

// nulls and undefined
let arrayOfNames = null;

// oh, you declared a variable? cool man, maybe you will do something with later,
// but I don't know ahead of time, so I will just set it to undefined
let things;

// undfined means that Variable does NOT EXIST!!!!
console.log("Below is the value of things");
console.log(things);
// console.log(potatoes); --> this will break ONCE the interpreter gets to this line of code,
// because potatoes does not exist, it is SUPER DUPER undefined

// logical and comparison operators
// &&, ||, !, <, >, <=, >=

// weak comparison operator ==

// strict comparison operator ===   <-- ONLY EVER USE THIS ONE!!!!


let numberString = "2";
let actualNumber = 2;

// weak comparison operator ==, IGNORES type, ONLY compares value
if (numberString == actualNumber) {
	console.log("This is true");
}

if (numberString === actualNumber) {
	console.log("This is true");
} else {
	console.log("yep, this makes more sense, this is indeed false");
}

// functions

function add(x, y) {
	return x + y;
}

function doThing() {
	console.log("Im doing a thing");
}

let result = add(2, 3)
	console.log(result);

// javascript does NOT have out parameters!

// Document Object Model
// the DOM is just your Document in Object form, represented as the Model of your html
// javascript needs to be aware of the HTML, this is where the DOM comes in!
// why does it need to aware?
// so the javascript can create html on the fly!
// react to a button click
// animate existing html
// change css classes on the fly!

let div = document.createElement("div");
div.style.backgroundColor = "red";
div.style.width = "200px";
div.style.height = "200px";

let body = document.getElementsByTagName("body")[0];

body.appendChild(div);

// very similar to C# Console.ReadLine(), excpet it prompts on the browser
let userInput = prompt("Can I have your name please?");

// just like C# string interpolation
// var fullName =        $"hello {userInput}";
// this is the modern to combines strings.
let otherHellowWIthUserInput =  'hello ' + userInput;
let hellerWithUserInput = `hello ${userInput}`;

console.log(userInput);


