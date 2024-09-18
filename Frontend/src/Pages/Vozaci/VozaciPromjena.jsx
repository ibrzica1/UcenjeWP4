import { Button, Col, Container, Form, FormLabel, Row } from "react-bootstrap";
import { Link, useNavigate, useParams } from "react-router-dom";
import { RoutesNames } from "../../constans";
import moment from "moment";
import VozacService from "../../services/VozacService";
import { useEffect, useState } from "react";

export default function VozaciPromjena() {
    const navigate = useNavigate();
    const routeParams = useParams();
    const { vozac, setVozac } = useState({});

    async function dohvatiVozace() {
        const odgovor = await VozacService.getBySifra(routeParams.sifra);
        if (odgovor.greska) {
            alert(odgovor.poruka);
            return;
        }
        odgovor.poruka.datum_rodenja = moment.utc(odgovor.poruka.datum_rodenja).format('yyyy-MM-DD');
        odgovor.istek_ugovora = moment.utc(odgovor.poruka.istek_ugovora).format('yyyy-MM-DD');
        setVozac(odgovor.poruka);

        useEffect(() => {
            dohvatiVozace();
        });

        async function promjena(vozac) {
            const odgovor = await VozacService.promjena(routeParams.sifra, vozac);
            if (odgovor.greska) {
                alert(odgovor.poruka);
                return;
            }
            navigate(RoutesNames.VOZAC_PREGLED);
        }

        function obradiSubmit(e) {
            e.preventDefault();

            const podaci = new FormData(e.target);

            promjena({
                ime: podaci.get('ime'),
                prezime: podaci.get('prezime'),
                datum_rodenja: moment.utc(podaci.get('datum_rodenja')),
                istek_ugovora: moment.utc(podaci.get('istek_ugovora'))

            });

        }
        return (
            <Container>
                Promjena vozaca

                <Form onSubmit={obradiSubmit}>
                    <Form.Group controlId="ime">
                        <FormLabel>Ime</FormLabel>
                        <Form.Control type="text" name="ime" />
                    </Form.Group>

                    <Form.Group controlId="prezime">
                        <FormLabel>Prezime</FormLabel>
                        <Form.Control type="text" name="prezime" />
                    </Form.Group>


                    <Form.Group controlId="datum_rodenja">
                        <FormLabel>Datum rodenja</FormLabel>
                        <Form.Control type="date" name="datum_rodenja" />
                    </Form.Group>

                    <Form.Group controlId="istek_ugovora">
                        <FormLabel>Istek ugovora</FormLabel>
                        <Form.Control type="date" name="istek_ugovora" />
                    </Form.Group>

                    <hr />
                    <Row>
                        <Col xs={6} sm={6} md={3} lg={6} xl={6} xxl={6}>
                            <Link to={RoutesNames.VOZAC_PREGLED}
                                className="btn btn-danger siroko">
                                Odustani
                            </Link>
                        </Col>
                        <Col xs={6} sm={6} md={9} lg={6} xl={6} xxl={6}>
                            <Button variant="primary" type="submit" className="siroko">
                                Promjena vozača
                            </Button>
                        </Col>
                    </Row>
                </Form>
            </Container>
        )
    }
}