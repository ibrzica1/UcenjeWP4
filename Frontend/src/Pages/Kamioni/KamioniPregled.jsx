import KamionService from "../../services/KamionService";
import { useEffect, useState } from "react";
import { Container, Table } from "react-bootstrap";
import moment from "moment";


export default function KamioniPregled()
{
    const [kamioni, setKamioni] = useState();

    async function dohvatiKamione() {
        await KamionService.get()
            .then((odgovor) => {
                setKamioni(odgovor)
            })
            .catch((e) => {console.log(e)});
            
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
                            <td>{kamion.sifra}</td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </Container>
    );



}