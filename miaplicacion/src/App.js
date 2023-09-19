import logo from './logo.svg'
import './App.css'
import MyButton from './MyButton'
import ButtonTest from './ButtonTest'
import { useState } from 'react'

const self = {
  name: 'Alex',
  age: 21,
  greeting: 'Hello there! 😎'
}

const products = [
  { title: 'Col', id: 1 },
  { title: 'Ajo', id: 2 },
  { title: 'Manzana', id: 3 },
  { title: 'Puerro', id: 4 },
  { title: 'Tomate', id: 5 },
  { title: 'Pepino', id: 6 }
]

const listContent = products.map(product => (
  <li key={product.Id}>{product.title}</li>
))

function App () {
  const [buttonCount, setButtonCount] = useState(0)

  function handleClick () {
    setButtonCount(buttonCount + 1)
  }
  return (
    <div className='App'>
      <header className='App-header'>
        {/* <img src={logo} className='App-logo' alt='logo' /> */}
        <MyButton />
        {/* Mis botones de prueba */}
        <ButtonTest count={buttonCount} onClick={handleClick} />

        <ButtonTest count={buttonCount} onClick={handleClick} />
        <p
          style={{
            color: '#bbd19f',
            backgroundColor: '#000'
          }}
        >
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <p>
          {self.greeting}, my name is {self.name} and I'm{' '}
          {self.age + ' years old!'}
        </p>
        {/* <ul>{listContent}</ul> */}
        <a
          className='App-link'
          href='https://reactjs.org'
          target='_blank'
          rel='noopener noreferrer'
        >
          Learn React
        </a>
      </header>
    </div>
  )
}

export default App
