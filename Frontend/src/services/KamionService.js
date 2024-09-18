import { HttpService } from "./HttpService"

async function getBySifra(sifra){
    return await HttpService.get('/Kamion/' + sifra)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        return {greska: true, poruka: 'Ne postoji kamion!'}
    })
}

async function get() {
    return await HttpService.get('/kamion')
        .then((odgovor) => {
            return odgovor.data;
        })
        .catch((e)=>{console.error(e)})
}

async function obrisi(sifra) { 
    return await HttpService.delete('/Kamion/' + sifra)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        return {greska: true, poruka: 'Kamion se ne može obrisati'}
    })
}

async function dodaj(kamion) { 
    return await HttpService.post('/Kamion', kamion)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        return {greska: true, poruka: 'Kamion se ne može dodati'}
    })
}

async function promjena(sifra,kamion) {
    return await HttpService.put('/Kamion/' + sifra,kamion)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        return {greska: true, poruka: 'Kamion se ne može promjeniti!'}
    })
}

export default {
    get,
    obrisi,
    getBySifra,
    promjena,
    dodaj
}