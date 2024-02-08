import './style.css';
import typescriptLogo from './typescript.svg';
import viteLogo from '/vite.svg';
import { setupCounter } from './counter';
import { loopsLesson } from './loops';
import { Book } from './classes';


// unlike C#, all logic can be written in the "global scope" in javascript / typescript.
// however, even typescript developers will put their code in functions


function javascriptBasics(): void {
  // Typescript does NOT OFFER ANY RUN TIME FUNCTIONALITY, this includes functions!

  // Types!
  // Type annotation, declare the variable followed by it's type
  // string name = "james"  => C# version
  let name: string = "James";
  let age: number = 25;
  let isOldEnough: boolean = true;
  // you do NOT have to explicitly declare the type, TypeScript can infer it
  // I'm only doing this to teach you guys the name of the types


  // arrays
  let names: string[] = ["James", "John", "Jack"];
  // an alternate way of declaring arrays
  let namesTwo: Array<string> = ["James", "John", "Jack"];

  // nullish types
  let nullish: null = null;
  let undefinedish: undefined = undefined;

  // union Types!
  // union types allow you to multiple types into one type
  let nameTwo: string | undefined = "James";

  // union types, you can compose all your types into a new type declaration
  type MaybeString = string | undefined;

  type Primitave = string | number | boolean;
  let normalValue: Primitave = true;

  let nameThree: MaybeString = "James";

  // typescript is very strict about types potentially being null or undefined
  nameTwo.toUpperCase();

  // in type script, you can use if statements to drill down on your SPECIFIC TYPE!
  // this is called a type guard
  if (nameTwo !== undefined) {
    console.log(nameTwo.toUpperCase());
  }

  // in javascript / typescript, all Types are considered "Truthy" or "Falsy"
  // all types in javascript can be converted to a boolean

  // undefined and null are considered "Falsy"

  // this works because if nameTwo is undefined, it will be converted to false
  // otherwise, it's a string, it will be converted to true
  if (nameTwo) {
    console.log(nameTwo.toUpperCase());
  }


  // default falsye truty values
  let x = 0 // falsy
  let emptyString = ''; // falsy
  let isFalse = false; // falsy

  // any other values for the above would be considered "truthy"
}

// functions
//                     input         input     output
function addTwoNumbers(x: number, y: number): number {
  return x + y;
}

function classLesson() {

  // in typescript, as long as your objects LOOK and BEHAVE like the interface
  // that it asks, then it will work, we call this duck typing
  // "if it looks like a duck, and quacks like a duck, then it's a duck"
  let book = new Book(
    {
      log() { }
    },
    {}
  );
}

// loopsLesson();

function runApp() {
  // literally storing a reference to my button element
  const incrementorButton = document.getElementById('incrementor');

  // if your type can potentiall be null or undefined, IF you end your
  // satement with an '!', you are telling typescript that you are 100% sure
  // that it is not null or undefined
  // USE THIS SPARINGLY, IF YOU ARE WRONG, YOUR CODE WILL CRASH
  const counterElement = document.getElementById('counter')!;

  // just like in c#, you can parse your strings into numbers
  // the "+" sign is the same as calling parseInt
  let value = +counterElement.innerHTML;

  // checking if that button actually exist 
  if (incrementorButton) {
    // if it exists, ANYTIME the user clicks on this BUTTON,
    // the function will be called
    incrementorButton.addEventListener('click', () => {
      console.log(incrementorButton);
      value++;
      counterElement.innerHTML = value.toString();
    })
  }

}

runApp();

// document.querySelector<HTMLDivElement>('#app')!.innerHTML = `
//   <div>
//     <a href="https://vitejs.dev" target="_blank">
//       <img src="${viteLogo}" class="logo" alt="Vite logo" />
//     </a>
//     <a href="https://www.typescriptlang.org/" target="_blank">
//       <img src="${typescriptLogo}" class="logo vanilla" alt="TypeScript logo" />
//     </a>
//     <h1>Vite + TypeScript</h1>
//     <div class="card">
//       <button id="counter" type="button"></button>
//     </div>
//     <p class="read-the-docs">
//       Click on the Vite and TypeScript logos to learn more
//     </p>
//   </div>
// `

setupCounter(document.querySelector<HTMLButtonElement>('#counter')!)
