export function learnObjects() {
	// this is a javacript object!
	let bookOne = {
		title: "The Hobbit",
		author: "J.R.R. Tolkien",
		pages: 295,
		isCheckedOut: false
	}

	// just like C#, javascript allows you to access properties using
	// dot notation
	console.log(bookOne.author)

	// also access members using bracket notation
	console.log(bookOne["author"])
	// just like a Dictionary in C#....... spoilers.... javascript...
	// are literally just dictionaries.... with better type safety


	// because this is Typescript, that object you create "willy nilly"
	// is typed by default
	// bookOne.owner = "Frank"; typescript will now allow you to access this property
	// because the object defined on above does not contain owner

	let library: Library = {
		name: "The Library",
		address: "1432 Main St"
	}

	console.log(library.name);
	console.log(library["name"]);

	// I recommend using dot notation UNLESS you are accessing your property
	// dynamically with a variable
}


// in C#, we use Interfaces to describe a what a class will do
// publicly, in Typescript, interfaces are simply Schemas for an object
// think of them as "MODELS"
interface Library {
	name: string;
	address: string;
}