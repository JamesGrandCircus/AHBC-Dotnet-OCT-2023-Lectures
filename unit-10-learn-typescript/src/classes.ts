interface ILogger {
	log(message: string): void;
}

interface LibraryContext {

}

class BaseBook {
	title: string = '';
}

interface IRead {
	readBook(): void;
}
// just like in C#, classes can ONLY extend (inherit) from one class,
// but can implement MULTIPLE interfaces
export class Book extends BaseBook implements IRead {
	
	// if you have fields that are only populated through the constructor,
	// you can use the access modifier in the constructor to automatically
	// create the field for you
	// SPOILERS! this is how we will do dependency injection in Angular
	constructor(
		private logger: ILogger, 
		private context: LibraryContext) { 
			// super is just like calling "base" in C#.
			// super refers to the parent class. in javascript, IF
			// your class in inheriting from another class, you MUST call
			// super in the constructor.
			// you HAVE to call super even if you the base class does not 
			// have a constructor, because javascript is an interpreted language,
			// and otherwise, javascript would NOT KNOW it has a parent class
			super();
		}


	readBook(): void {
		// in typescript, IF you want to access ANY field or method
		// in your class, you MUST use the "this" keyword
		this.logger.log("reading book");
	}
}