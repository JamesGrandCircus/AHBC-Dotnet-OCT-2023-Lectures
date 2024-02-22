export interface Book {
    id: number,
    author: string,
    title: string,
    pages: number,
    checkedOut: boolean
}

export interface PostBook {
    title: string;
    author: string;
    pages: number;
    checkedOut: boolean;
}