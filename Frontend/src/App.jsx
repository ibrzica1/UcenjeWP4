
import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import NavBarEfikasnost from './components/NavBarEfikasnost';
import { Route, Routes } from 'react-router-dom'
import { RoutesNames } from './constans'
import Pocetna from './Pages/Pocetna'
import VozaciPregled from './Pages/Vozaci/VozaciPregled';
import KamioniPregled from './Pages/Kamioni/KamioniPregled';
import CiklicnaPregled from './Pages/Ciklicna/CiklicnaPregled';

function App() {



  return (
    <>
      <NavBarEfikasnost />
      <Routes>
        <Route path={RoutesNames.HOME} element={<Pocetna />} />
        <Route path={RoutesNames.VOZAC_PREGLED} element={<VozaciPregled />} />
        <Route path={RoutesNames.KAMION_PREGLED} element={<KamioniPregled />} />
        <Route path={RoutesNames.CIKLICNA_PREGLED} element={<CiklicnaPregled />} />
      </Routes>
    </>
  )
}

export default App
