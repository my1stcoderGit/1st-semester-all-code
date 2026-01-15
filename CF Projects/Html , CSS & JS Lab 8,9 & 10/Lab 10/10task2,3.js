/*
▪	Task 2: Voting System 
Implement a voting system where the user is prompted to enter their age using a prompt box. If the user is 18 or older, display an alert allowing them to vote. If not, inform them that they are not eligible to vote. 
 */


/*
let age = parseInt(prompt("Please enter your age:"));
age >= 18 ? alert(`You are allowed to vote.`) : alert(`You are not allowed to vote.`)      // Ternary operator // Remember => is a reserved symbol for arrow function so we use >= for greater than or equal to.
 */
//=======================================================================================================






/*
▪	Task 3: Quiz Game 
Develop a quiz game using confirm boxes. Ask a series of questions, and based on the user's responses, provide feedback on their performance at the end using an alert box. For example, "You scored 3 out of 5. Good effort!"  
*/

let score = 0;

if (confirm("Q1: Is the Earth round? (OK = Yes, Cancel = No)")) {
    score++;
}
if (!confirm("Q2: Is 2 + 2 equal to 5? (OK = Yes, Cancel = No)")) {
    // correct answer is 'No'
    score++;
}
if (confirm("Q3: Is JavaScript a programming language? (OK = Yes, Cancel = No)")) {
    score++;
}
if (!confirm("Q4: Is the sun a planet? (OK = Yes, Cancel = No)")) {
    // correct answer is 'No'
    score++;
}
if (confirm("Q5: Does water boil at 100°C? (OK = Yes, Cancel = No)")) {
    score++;
}
// Give final result
alert(`You scored ${score} out of 5. Good effort!`);









