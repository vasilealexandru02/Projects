document.addEventListener("click", (event) => {
  console.log(event.target.id);

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
    // console.log(event.target.innerHTML);
    calculateResult(event.target.id);
  }
});

const clearButton = (clickedButton) => {
  console.log("clickedButton", clickedButton);
  if (clickedButton == "C") {
    document.getElementById("input").innerText = "0";
  }
};

const calculateResult = (clickedButton) => {
  try {
    if (clickedButton == "equal-button") {
      let calculatorInput = document.getElementById("input").innerText;

      const prueba = calculatorInput.substring(0, calculatorInput.length - 1);
      console.log(prueba);
      document.getElementById("input").innerText = eval(prueba).toFixed(2);

      // console.log(eval(prueba));
    }
  } catch (error) {
    document.getElementById("input").innerText = "";
    alert("Invalid input!");
  }
};
