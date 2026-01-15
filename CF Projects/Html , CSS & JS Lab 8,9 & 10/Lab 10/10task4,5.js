/*
Task 4: Custom Survey 
Create a custom survey using a combination of alert, confirm, and prompt boxes. Ask users a set of personalized questions and display a summary of their responses at the end using a custom-styled alert box. 
Questions: 
1.	Personal Info: 
         1.	Ask the user for their name using a prompt box. 
2.	Preferences: 
         1.	Use a confirm box to ask if they prefer coffee over tea. 
         2.	If confirmed, ask an additional prompt about their favorite coffee type. If denied, ask about their favorite tea blend. 
3.	Technology: 
         1.	Confirm if they enjoy using technology. 
         2.	If confirmed, ask about their favorite gadget. If denied, inquire about their preferred traditional activities. 
4.	Travel: 
         1.	Ask about their dream travel destination using a prompt box. 
5.	Feedback: 
         1.	Conclude by thanking them for the survey and providing a summary of their responses in a custom-styled alert box. 
*/

// let preference = "";  let techpref = ""; 
// let name = prompt(`Please enter your name:`);
// let coffee = confirm(`Do you prefer coffee over tea?`)
// coffee ? prefrence = prompt(`Please tell me your favourite coffee type`) : preference = prompt(`Please enter your favourite tea blend.`)
// let technology = confirm(`Do you want to enjoy using technology`);
// technology ? techpref = prompt(`Enter your favourite gadget:`) : techpref = prompt (`Please enter your prefered traditional activities:`);
// let travdestination = prompt(`Please enter your dream travel destination:`);


function startSurvey() {
      let summary = "";

      // 1. Personal Info
      let name = prompt("What is your name?");
      summary += "<p><strong>Name:</strong> " + (name || "Not provided") + "</p>";

      // 2. Preferences
      let prefersCoffee = confirm("Do you prefer coffee over tea?");
      if (prefersCoffee) {
        let coffeeType = prompt("What is your favorite coffee type?");
        summary += "<p><strong>Preference:</strong> Coffee</p>";
        summary += "<p><strong>Favorite Coffee:</strong> " + (coffeeType || "Not provided") + "</p>";
      } else {
        let teaBlend = prompt("What is your favorite tea blend?");
        summary += "<p><strong>Preference:</strong> Tea</p>";
        summary += "<p><strong>Favorite Tea:</strong> " + (teaBlend || "Not provided") + "</p>";
      }

      // 3. Technology
      let enjoysTech = confirm("Do you enjoy using technology?");
      if (enjoysTech) {
        let gadget = prompt("What is your favorite gadget?");
        summary += "<p><strong>Enjoys Technology:</strong> Yes</p>";
        summary += "<p><strong>Favorite Gadget:</strong> " + (gadget || "Not provided") + "</p>";
      } else {
        let activity = prompt("What is your preferred traditional activity?");
        summary += "<p><strong>Enjoys Technology:</strong> No</p>";
        summary += "<p><strong>Preferred Activity:</strong> " + (activity || "Not provided") + "</p>";
      }

      // 4. Travel
      let destination = prompt("What is your dream travel destination?");
      summary += "<p><strong>Dream Destination:</strong> " + (destination || "Not provided") + "</p>";

      // 5. Feedback
      summary += "<p><em>Thank you for completing the survey!</em></p>";

      // Show custom alert
      document.getElementById("summary").innerHTML = summary;
      document.getElementById("customAlert").style.display = "flex";
    }

    function closeAlert() {
      document.getElementById("customAlert").style.display = "none";
    }











/*
•	Task 5:  Temperature converter 
Create a temperature converter using JavaScript. Ask user whether he/she wants to convert.  
•	Fahrenheit to Celsius or 
•	Celsius to Fahrenheit  
If a user opts for 1st option then prompt him/her with the message to enter Fahrenheit temperature first. Then apply formula to convert Fahrenheit to Celsius.  
 

Formula:
· Celsius = (Fahrenheit - 32) * 5 / 9;
. Fahrenheit = Celsius * 9 / 5 + 32;
*/

// var temp = 0;
// let choice = prompt(`Enter 1 if you want to convert Fahrenheit to Celcius or enter 2 to convert celcius to Fahrenheit:`)
// if (choice == 1){
//     let Fahrenheit = parseInt(prompt(`Now please enter the temp in fahrenheit:`))
//      temp = (Fahrenheit - 32) * 5/9;
//      alert(`Your temp in celcius is : ${temp}C.`)
// }
// else if (choice == 2){
//     let celcius = parseInt(prompt(`Now please enter temp in celcius:`))
//      temp = celcius * 9/5 + 32 ;
//      alert(`Your temp in fahrenheit is : ${temp}F.`)
// }
// else{alert(`You entered a wrong choice.`)}
