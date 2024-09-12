
import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import NavBarEfikasnost from './components/NavBarEfikasnost';
import { Route, Routes } from 'react-router-dom'
import { RoutesNames } from './constans'
import Pocetna from './Pages/Pocetna'
import VozaciPregled from './Pages/Vozaci/VozaciPregled';

function App() {
  


  return (
    <>
     <NavBarEfikasnost />
     <Routes>
      <Route path={RoutesNames.HOME} element={<Pocetna/>}/>
      <Route path={RoutesNames.VOZAC_PREGLED} element={<VozaciPregled/>}/>
     </Routes>
    </>
  )
}

export default App
