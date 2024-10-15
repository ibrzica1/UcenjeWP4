import { useEffect, useState } from "react";
import { Button, Container, Table } from "react-bootstrap";
import VozacService from "../../services/VozacService";
import moment from "moment";
import { Link } from "react-router-dom";
import { RoutesNames } from "../../constans";
import { useNavigate } from "react-router-dom";
import useLoading from "../../Hooks/useLoading";

export default function VozaciPregled() {

    const [vozaci, setVozaci] = useState();

    const navigate = useNavigate();
    const { showLoading, hideLoading } = useLoading();

    async function dohvatiVozace() {
        await VozacService.get()
            .then((odgovor) => {
                setVozaci(odgovor);
            })
            .catch((e) => { console.log(e) });

    }

    useEffect(() => {
        showLoading(); 
        dohvatiVozace();
        hideLoading();
    }, []);

    function formatirajDatum(datum) {
        if (datum == null) {
            return 'Nije definirano';
        }
        return moment.utc(datum).format('DD.MM.YYYY.');
    }

    async function obrisiAsync(vozac_id) {
        showLoading();
        const odgovor = await VozacService.obrisi(vozac_id);
        hideLoading();
        if (odgovor.greska) {
            alert(odgovor.poruka);
            return;
        }
        dohvatiVozace();
    }

    function obrisi(vozac_id) {
        obrisiAsync(vozac_id);
    }

    return (

        <Container>
            <Link to={RoutesNames.VOZAC_NOVI}>Dodaj novog vozača</Link>
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
                            <td>
                                <Button
                                    variant="primary"
                                    onClick={() => navigate(`/Vozaci/${vozac.vozac_id}`)}>
                                    Promjeni
                                </Button>
                                &nbsp;&nbsp;&nbsp;
                                <Button
                                    variant="danger"
                                    onClick={() => obrisi(vozac.vozac_id)}>
                                    Obriši
                                </Button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </Table>

        </Container>
    )
}