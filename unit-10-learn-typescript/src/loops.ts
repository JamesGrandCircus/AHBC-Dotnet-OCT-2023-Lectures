// the export keyword makes the function available to other files
// it publicly exposes the function
// export works on variables as well.
export function loopsLesson(): void {
	// loops in javascript
	let numbers: number[] = [1, 2, 3, 4, 5];

	// for loop
	// you will RARELY USE A FOR LOOP IN JAVASCRIPT
	// they work EXACTLY the same as C# for loops
	for (let i = 0; i < numbers.length; i++) {
		console.log(numbers[i]);
	}
	// functional forEach Loop
	// for each element in your array, for each will call the function you pass in
	numbers.forEach((z) => console.log(z))

	// map is EXACLTY like Select in C# linq
	let poweredNumbers = numbers.map((z) => z * z);

	// filter is EXACTLY like Where in C# linq
	let evenNumbers = numbers.filter((z) => z % 2 === 0);

	// filter, foreach, and map are methods that exist on the array type.
	// Iterables are just IEnumerables in C#, Iterables are still being developed, more on that after your career starts

	// now the loop you will use the most in javascript, it's like the c# foreach loop
	// for-of loop
	// number will be the placeholder for each element in the array
	for (let number of numbers) {
		console.log(number);
	}

}

export function whileLoopLesson() {
	
	// while loop
	// While loops work EXACTLY THE SAME AS C# while loops
	let j = 0;
	while (j < 5) {
		console.log(j)
		j++;
	}

	// do while loop
	// do while loops work EXACTLY THE SAME AS C# do while loops
	j = 0;
	do {
		console.log(j);
		j++;
	} while (j < 5);

}