import React from 'react';
import './menu.css';
import { Link } from 'react-router-dom'

function App() {
  return (
    <div >
      <header >
          <h1> Ver lista negra</h1>

          <div>
            
            <h2> <Link to="/cadastrar"> cadastrar</Link> </h2>
          
          </div>

          <div>

            <h2> <Link to="/consultar">consultar</Link>  </h2>
          </div>
          

      </header>
    </div>
  );
}

export default App;
