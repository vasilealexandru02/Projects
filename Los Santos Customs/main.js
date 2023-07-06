var cars;

document.getElementById("pdfButton").addEventListener("click", downloadPDF);
function fetchCars() {
  var carListDiv = document.getElementById("carsList");
  carListDiv.innerText = "";
  if (JSON.parse(localStorage.getItem("cars")).length > 0) {
    cars = JSON.parse(localStorage.getItem("cars"));
        document.getElementById('pdfButton').style.display = 'inline-block';
        
    for (var i = 0; i < cars.length; i++) {
      carListDiv.innerHTML += `<div class="well">
            <p>Brand:${cars[i].brand}</p>
            <p>Model: ${cars[i].model}</p>
            <p>Year: ${cars[i].year}</p>
            <p>Color: <span style="background-color:${cars[i].color}">&nbsp&nbsp&nbsp&nbsp</span></p>
            <p>Registration: ${cars[i].registration}</p>
            <button class="btn btn-danger" onclick="deleteCar('${cars[i].id}')">Delete car</button>
            </div>`;
    }
  } else {
    document.getElementById('pdfButton').style.display = 'none';
    carListDiv.innerHTML += `<div class="well">
            <p>No cars created! :(
            </div>`;
  }
}

document.getElementById("carForm").addEventListener("submit", saveCar);

// Function that saves the car into the local storage
function saveCar(e) {
  var carId = chance.guid();
  let carBrand = document.getElementById("carBrand").value;
  let carModel = document.getElementById("carModel").value;
  let carYear = document.getElementById("carYear").value;
  let carColor = document.getElementById("carColor").value;
  let carRegistration = document.getElementById("carRegistration").value;

  var car = {
    id: carId,
    brand: carBrand,
    model: carModel,
    year: carYear,
    color: carColor,
    registration: carRegistration,
  };
  if (localStorage.getItem("cars") === null) {
    cars = [];
    cars.push(car);
    localStorage.setItem("cars", JSON.stringify(cars));
  } else {
    cars = JSON.parse(localStorage.getItem("cars"));
    cars.push(car);
    localStorage.setItem("cars", JSON.stringify(cars));
  }
  document.getElementById("carForm").reset();
  fetchCars();
  e.preventDefault();
}

// Function that deletes the car from the local storage

function deleteCar(guid) {
  let listToPrint = document.getElementById("issuesList");
  let filteredCarList = cars.filter((element) => {
    return element.id != guid;
  });
  localStorage.setItem("cars", JSON.stringify(filteredCarList));
  fetchCars();
}

// Function that downloads the pdf of the car's list
function downloadPDF() {
  window.jsPDF = window.jspdf.jsPDF;
  var doc = new jsPDF();
  let listToPrint = document.getElementById("carsList");
  // Obtener el tamaño del documento
  var pageSize = doc.internal.pageSize;
  var pageWidth = pageSize.width;

  // Cargar la imagen
  var imgData = "./img/lscustoms.png"; // Reemplaza con la ruta de tu imagen
  var imgWidth = 40; // Ancho de la imagen en unidades de píxeles
  var imgHeight = 27.5; // Alto de la imagen en unidades de píxeles

  // Calcular la posición X para centrar la imagen horizontalmente
  var imgX = (pageWidth - imgWidth) / 2;

  // Agregar la imagen al PDF
  doc.addImage(imgData, "PNG", imgX, 10, imgWidth, imgHeight);
  // Obtain the local data
  let cars = JSON.parse(localStorage.getItem("cars"));
  let posY = 50;
  
  for (var i = 0; i < cars.length; i++) {
    doc.setFont("Helvetica","bold");
    doc.text("Car number " + (i + 1), 10, posY);
    posY += 10;
    doc.setFont("Helvetica","regular");
    let brandText = "Brand: " + cars[i].brand;
    doc.text(brandText, 10, posY);
    posY += 10;
    let modelText = "Model: " + cars[i].model;
    doc.text(modelText, 10, posY);
    posY += 10;
    let yearText = "Year: " + cars[i].year;
    doc.text(yearText, 10, posY);
    posY += 10;
    let colorText = "Color: " + cars[i].color;
    doc.text(colorText, 10, posY);
    posY += 10;
    let registrationText = "Registration: " + cars[i].registration;
    doc.text(registrationText, 10, posY);
    posY += 10;
    doc.text("-----------------------------------", 10, posY);
    posY += 10;
  }
  doc.save("cars.pdf");
}
