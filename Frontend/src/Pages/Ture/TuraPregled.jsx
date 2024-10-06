import { useEffect, useState } from "react";
import { Button, Container, Table } from "react-bootstrap";
import { IoIosAdd } from "react-icons/io";
import { FaEdit, FaTrash } from "react-icons/fa";
import { Link } from "react-router-dom";
import { useNavigate } from "react-router-dom";

import Service from "../../services/TuraService"; // primjetite promjenu naziva
import { RoutesNames } from "../../constants";

export default function TurePregled(){
    const [ture,setTure] = useState();
    let navigate = useNavigate(); 

    async function dohvatiTure(){
        await Service.get()
        .then((odgovor)=>{
            //console.log(odgovor);
            setGrupe(odgovor);
        })
        .catch((e)=>{console.log(e)});
    }

    async function obrisiTuru(tura_id) {
        const odgovor = await Service.obrisi(tura_id);
        //console.log(odgovor);
        if(odgovor.greska){
            alert(odgovor.poruka);
            return;
        }
        dohvatiTure();
    }

    useEffect(()=>{
        dohvatiTure();
        // eslint-disable-next-line react-hooks/exhaustive-deps
    },[]);


    return (

        <Container>
            <Link to={RoutesNames.TURA_NOVI} className="btn btn-success siroko">
                <IoIosAdd
                size={25}
                /> Dodaj
            </Link>
            <Table striped bordered hover responsive>
                <thead>
                    <tr>
                        <th>Relacija</th>
                        <th>Udaljenost</th>
                        <th>Prijeđeni kilometri</th>
                        <th>Kamion</th>
                        <th>Vozač</th>
                        <th>Početak datum</th>
                        <th>Završetak datum</th>
                    </tr>
                </thead>
                <tbody>
                    {Ture && Ture.map((entitet,index)=>(
                        <tr key={index}>
                            <td>{entitet.}</td>
                            <td>{entitet.smjerNaziv}</td>
                            <td>{entitet.predavac}</td>
                            <td>{entitet.maksimalnoPolaznika}</td>
                            <td className="sredina">
                                    <Button
                                        variant='primary'
                                        onClick={()=>{navigate(`/grupe/${entitet.sifra}`)}}
                                    >
                                        <FaEdit 
                                    size={25}
                                    />
                                    </Button>
                               
                                
                                    &nbsp;&nbsp;&nbsp;
                                    <Button
                                        variant='danger'
                                        onClick={() => obrisiGrupu(entitet.sifra)}
                                    >
                                        <FaTrash
                                        size={25}/>
                                    </Button>

                            </td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </Container>

    );

}