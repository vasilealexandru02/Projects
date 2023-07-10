var generatedNumber;
var letters = ["X", "0"];
var letterSelected;
function playGame() {
  debugger;
  var gameboards = document.getElementsByClassName("gameboard");
  for (var i = 0; i < gameboards.length; i++) {
    gameboards[i].innerHTML = "";
  }
  generateLetter();
  document.getElementById(
    "gameText"
  ).innerHTML = `${letterSelected} is starting!`;
}

function generateLetter() {
  let generatedNumber = Math.floor(Math.random() * 2);
  letterSelected = letters[generatedNumber];
}

function switchLetter() {
  debugger;
  if (letterSelected == letters[0]) {
    letterSelected = letters[1];
  } else {
    letterSelected = letters[0];
  }
}

function clickedSquare(e) {
    var clickedSquare = document.getElementById(e.target.id);
  // // Apply disabled style
  // clickedSquare.style.opacity = "0.5"; // For visual indication (optional)
  // clickedSquare.style.pointerEvents = "none"; // Disable pointer events (op
  if (clickedSquare.innerHTML == "") {
    if (letterSelected != undefined) {
      clickedSquare.innerHTML = `<p class="text-center fs-1 align-middle"  id="${e.target.id}}-text">${letterSelected}</p>`;
      clickedSquare.disabled = true; // Set the disabled attribute to true
    }
    switchLetter();
  }
}
