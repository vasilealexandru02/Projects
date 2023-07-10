var generatedNumber;
var letters = ["X", "0"];
var letterSelected;
var gameboard;
function playGame() {
  gameboard = [
    ["Z", "Z", "Z"],
    ["Z", "Z", "Z"],
    ["Z", "Z", "Z"],
  ];
  // debugger;
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
  // debugger;
  if (letterSelected == letters[0]) {
    letterSelected = letters[1];
  } else {
    letterSelected = letters[0];
  }
  document.getElementById(
    "gameText"
  ).innerHTML = `${letterSelected} player turn!`;
}

function clickedSquare(e) {
  let clickedSquare = document.getElementById(e.target.id);

  // // Apply disabled style
  // clickedSquare.style.opacity = "0.5"; // For visual indication (optional)
  // clickedSquare.style.pointerEvents = "none"; // Disable pointer events (op
  if (clickedSquare.innerHTML == "") {
    if (letterSelected != undefined) {
      clickedSquare.innerHTML = `<p class="text-center fs-1 align-middle"  id="${e.target.id}}-text">${letterSelected}</p>`;
      clickedSquare.disabled = true; // Set the disabled attribute to true
      let clickedSquareId = e.target.id;
      insertIntoGameboard(clickedSquareId);
      checkBoard(letterSelected);
    }
    console.log(gameboard);
    switchLetter();
  }
}

function insertIntoGameboard(position) {
  switch (position) {
    case "0":
      gameboard[0][0] = letterSelected;
      break;
    case "1":
      gameboard[0][1] = letterSelected;
      break;
    case "2":
      gameboard[0][2] = letterSelected;
      break;
    case "3":
      gameboard[1][0] = letterSelected;
      break;
    case "4":
      gameboard[1][1] = letterSelected;
      break;
    case "5":
      gameboard[1][2] = letterSelected;
      break;
    case "6":
      gameboard[2][0] = letterSelected;
      break;
    case "7":
      gameboard[2][1] = letterSelected;
      break;
    case "8":
      gameboard[2][2] = letterSelected;
      break;
  }
}

function checkBoard(lastLetter) {
  // Obtener el número de filas y columnas
  const filas = gameboard.length;
  const columnas = gameboard[0].length;

  // if(matriz[0][0]==letterSelected && matriz[0][1]==letterSelected && matriz[0][2]==letterSelected){
  //   console.log('Player', letterSelected, 'won!')
  // }else if(matriz[1])
  // First iteration over the rows
  for (let i = 0; i < filas; i++) {
    for (let j = 0; j < columnas; j++) {
      if (
        gameboard[i][j] == letterSelected &&
        gameboard[i][j + 1] == letterSelected &&
        gameboard[i][j + 2] == letterSelected
      ) {
        console.log("Player row", letterSelected, "won!");
      }
      j = 3;
    }
  }
  // Second iteration over the columns
  for (let j = 0; j < columnas; j++) {
    for (let i = 0; i < filas; i++) {
      // console.log(gameboard[i][j]);
      // console.log(gameboard[i+1][j]);
      // console.log(gameboard[i+2][j])
      // i=3;
      if (
        gameboard[i][j] == letterSelected &&
        gameboard[i + 1][j] == letterSelected &&
        gameboard[i + 2][j] == letterSelected
      ) {
        console.log("Player column", letterSelected, "won!");
      }
      i = 3;
    }
  }
}
