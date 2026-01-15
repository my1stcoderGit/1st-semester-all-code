/*
   Task 1: Basic Calculator 
Create a simple calculator that takes two numbers as input from prompt boxes, performs a basic arithmetic operation (addition, subtraction, multiplication, or division), and displays the result using an alert box. 
*/

//                        Take inputs from user line by line
//
// let num1 = parseFloat(prompt("Enter first number:"));
// let num2 = parseFloat(prompt("Enter second number:"));

//                        Take both numbers in a single prompt

let input = prompt("Enter two numbers separated by a space (e.g., 5 10):");

// Split the input into two parts
let parts = input.split(" ");

// Convert to numbers
let num1 = parseFloat(parts[0]);
let num2 = parseFloat(parts[1]);



//                       Take everything in one prompt including operator
//
// let input = prompt("Enter an expression (example: 5 + 10):");
// Split into parts: num1, operator, num2
// let parts = input.split(" ");
// let num1 = parseFloat(parts[0]);
// let operator = parts[1];
// let num2 = parseFloat(parts[2]);




// Perform all operations
let addition = num1 + num2;
let subtraction = num1 - num2;
let multiplication = num1 * num2;

//             Division with zero check by (ternary operator) 

let division = (num2 === 0)
    ? "Cannot divide by zero!"
    : (num1 / num2);


//              Division with zero check by if else
// let division;
// if (num2 === 0) {
//     division = "Cannot divide by zero!";
// } else {
//     division = num1 / num2;
// }



// Show all results in a single alert box by using string concatenation
alert(
    "Results:\n" +
    "Addition: " + addition + "\n" +
    "Subtraction: " + subtraction + "\n" +
    "Multiplication: " + multiplication + "\n" +
    "Division: " + division
);

// Also showing all results in a single alert box by using template literals or string interpolation


alert(`
Results:
Addition: ${addition}
Subtraction: ${subtraction}
Multiplication: ${multiplication}
Division: ${division}
`);




