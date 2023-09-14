const imageUrl =
  'https://raw.githubusercontent.com/visualcrossing/WeatherIcons/main/PNG/2nd%20Set%20-%20Monochrome/'

function searchCityWeather () {
  const cityName = document.getElementById('cityName').value
  const cityinfo = fetch(
    `https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/${cityName}?unitGroup=uk&include=days&key=ANAAWVC9KK34JGFSLJVLQNNPG&contentType=json`,
    {
      method: 'GET'
    }
  )
    .then(response => response.json())
    .then(city => {
      document.getElementById('msg').innerHTML = ''
      return city
    })
    .catch(err => {
      document.getElementById('msg').innerHTML =
        'The city introduced is not valid! 😣!'
    })

  const printCity = () => {
    cityinfo.then(a => {
      const resultsContainer = document.getElementById('results')
      resultsContainer.innerHTML += `<div  class="cityName rounded w-33">
          <p class="lightBlue">${a.resolvedAddress.split(',')[0]}</p>
          <p>${a.days[0].temp} ºC</p>
          <img src="${imageUrl}${a.days[0].icon}.png" />
          <p class="lightBlue">${a.days[0].conditions}</p>
        </div>`
    })
  }
  printCity()

  document.getElementById('cityName').value = ''
}
