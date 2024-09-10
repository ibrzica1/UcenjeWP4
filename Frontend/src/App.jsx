import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { useState } from 'react'
import NavBarEdunova from './components/NavBarEdunova';

function App() {
 
  const[x,setx] = useState(0);

  return (
    <>
     <NavBarEdunova></NavBarEdunova>
    </>
  )
}

export default App
