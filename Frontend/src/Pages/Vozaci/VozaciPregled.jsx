import { useEffect } from "react";
import { Container, Table } from "react-bootstrap";

export default function VozaciPregled()
{

async function dohvatiVozace(){
    await VozacService.get();
}

useEffect(()=>{dohvatiVozace()},[]);

    return(
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
           </Table>
        </Container>
    )
}