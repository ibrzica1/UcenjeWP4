import { useEffect, useState } from "react";
import { Container, Table } from "react-bootstrap";
import VozacService from "../../services/VozacService";
import moment from "moment";

export default function VozaciPregled() {

    const [vozaci, setVozaci] = useState();

    async function dohvatiVozace() {
        await VozacService.get()
            .then((odgovor) => {
                setVozaci(odgovor)
            })
            .catch((e) => {console.log(e)});
            
    }

    useEffect(() => { dohvatiVozace() }, []);

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
                        <th>Ime</th>
                        <th>Prezime</th>
                        <th>Datum rođenja</th>
                        <th>Istek ugovora</th>
                        <th>Akcija</th>
                    </tr>
                </thead>
                <tbody>
                    {vozaci && vozaci.map((vozac, index) => (
                        <tr key={index}>
                            <td>{vozac.ime}</td>
                            <td>{vozac.prezime}</td>
                            <td className={'sredina'}>
                                {formatirajDatum(vozac.datum_rodenja)}</td>
                            <td className={'sredina'}>
                            {formatirajDatum(vozac.istek_ugovora)}</td>
                            <td>{vozac.sifra}</td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </Container>
    );
}