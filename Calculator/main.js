document.addEventListener("click", (event) => {
  if (
    event.target.id != "" &&
    event.target.id != "calculator" &&
    event.target.id != "input"
  ) {
    let calculatorInput = document.getElementById("input");
    // Clean zero variable when number button is clicked

    // Displays into the input element the pressed button
    calculatorInput.innerHTML += event.target.innerHTML;
    clearButton(event.target.innerHTML);
    calculateResult(event.target.id);
  }
});

// Clears user's input
const clearButton = (clickedButton) => {
  if (clickedButton == "C") {
    document.getElementById("input").innerText = "0";
  }
};

// Method that calculates the result when the equal button is clicked
const calculateResult = (clickedButton) => {
  try {
    if (clickedButton == "equal-button") {
      let calculatorInput = document.getElementById("input").innerText;

      const input = calculatorInput.substring(0, calculatorInput.length - 1);
      console.log(input);
      document.getElementById("input").innerText = eval(input).toFixed(2);
    }
  } catch (error) {
    document.getElementById("input").innerText = "";
    alert("Invalid input!");
  }
};
