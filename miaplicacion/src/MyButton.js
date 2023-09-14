import { useState } from 'react'

function MyButton () {
  const [count, setCount] = useState(10)
  const [buttonText, setButtonText] = useState(
    'Te quedan ' + count + ' pulsaciones!'
  )
  const [buttonStyle, setButtonStyle] = useState({
    backgroundColor: 'green'
  })
  function HandleClick () {
    if (count !== 0) {
      setCount(count - 1)
      setButtonText('Te quedan ' + count + ' pulsaciones!')
    } else {
      setButtonText('Has pulsado el botón el máximo número de veces...😡')
      setButtonStyle({ backgroundColor: 'red' })
    }

    // alert('¡Me hiciste clic! Primer componente creado 😚!')
  }

  return (
    <button onClick={HandleClick} style={buttonStyle}>
      {buttonText}
    </button>
  )
}
export default MyButton
