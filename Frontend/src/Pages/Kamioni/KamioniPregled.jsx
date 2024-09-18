import KamionService from "../../services/KamionService";
import { useEffect, useState } from "react";
import { Button, Container, Table } from "react-bootstrap";
import moment from "moment";
import { RoutesNames } from "../../constans";
import { Link, useNavigate } from "react-router-dom";


export default function KamioniPregled()
{
    const [kamioni, setKamioni] = useState();

    const navigate = useNavigate();

    async function dohvatiKamione() {
        await KamionService.get()
            .then((odgovor) => {
                setKamioni(odgovor)
            })
            .catch((e) => {console.log(e)});
            
    }
    async function obrisiAsync(sifra) {
        const odgovor = await KamionService.obrisi(sifra);
        if(odgovor.greska)
        {
            alert(odgovor.poruka);
            return;
        }
        dohvatiKamione();
    }

    function obrisi(sifra)
    {
       obrisiAsync(sifra);
    }

    useEffect(() => { dohvatiKamione() }, []);

    function formatirajDatum(datum){
        if(datum==null){
            return 'Nije definirano'
        }
        return moment.utc(datum).format('DD.MM.YYYY.');
    }

    return (
        <Container>
            <Link to={RoutesNames.KAMION_NOVI}>Dodaj novi kamion</Link>
            <Table striped bordered hover responsive>
                <thead>
                    <tr>
                        <th>Registarska oznaka</th>
                        <th>Marka</th>
                        <th>Godina proizvodnje</th>
                        <th>Istek registracije</th>
                        <th>Prosječna potrošnja goriva</th>
                        <th>Akcija</th>
                    </tr>
                </thead>
                <tbody>
                    {kamioni && kamioni.map((kamion, index) => (
                        <tr key={index}>
                            <td>{kamion.reg_oznaka}</td>
                            <td>{kamion.marka}</td>
                            <td className={'desno'}>
                                {kamion.godina_proizvodnje}</td>
                            <td className={'sredina'}>
                            {formatirajDatum(kamion.istek_registracije)}</td>
                            <td className='desno'>{kamion.prosjecna_potrosnja_goriva}</td>
                            <td>
                            <Button
                                variant="primary"
                                onClick={()=>navigate(`/Kamioni/${kamion.sifra}`)}>
                                    Promjeni
                                </Button>
                                &nbsp;&nbsp;&nbsp;
                                <Button
                                variant="danger"
                                onClick={()=>obrisi(kamion.sifra)}>
                                    Obriši
                                </Button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </Container>
    ); 



}