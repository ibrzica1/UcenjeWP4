import { HttpService } from "./HttpService"


async function get() {
    await HttpService.get('/Vozaci')
    .then((odgovor)=>{
        console.log(odgovor);
    })
}

export default{
    get
}