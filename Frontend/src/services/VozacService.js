import { HttpService } from "./HttpService"


async function get() {
    return await HttpService.get('/vozac')
        .then((odgovor) => {
            return odgovor.data;
        })
        .catch((e)=>{console.error(e)})
}

async function obrisi(sifra) {
    return await HttpService.delete('/Vozac/' + sifra)
    .then((odgovor)=>{
        return{greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        return{greska: true, poruka: 'Vozač se ne može obrisati'}
    })
}

async function dodaj(vozac) { 
    return await HttpService.post('/Vozac', vozac)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        return {greska: true, poruka: 'Vozač se ne može dodati'}
    })
}

export default {
    get,
    obrisi,
    dodaj
}