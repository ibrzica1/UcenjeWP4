import { HttpService } from "./HttpService"

async function getBySifra(vozac_id){
    return await HttpService.get('/vozac/' + vozac_id)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        return {greska: true, poruka: 'Ne postoji vozać!'}
    })
}

async function get() {
    return await HttpService.get('/vozac')
        .then((odgovor) => {
            return odgovor.data;
        })
        .catch((e)=>{console.error(e)})
}

async function obrisi(vozac_id) {
    return await HttpService.delete('/vozac/' + vozac_id)
    .then((odgovor)=>{
        return{greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        return{greska: true, poruka: 'Vozač se ne može obrisati'}
    })
}

async function dodaj(vozac) { 
    return await HttpService.post('/vozac', vozac)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        return {greska: true, poruka: 'Vozač se ne može dodati'}
    })
}

async function promjena(vozac_id,vozac) {
    return await HttpService.put('/vozac/' + vozac_id,vozac)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        return {greska: true, poruka: 'Vozač se ne može promjeniti!'}
    })
}

export default {
    get,
    obrisi,
    getBySifra,
    promjena,
    dodaj
}