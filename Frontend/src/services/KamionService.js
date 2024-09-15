import { HttpService } from "./HttpService"


async function get() {
    return await HttpService.get('/kamion')
        .then((odgovor) => {
            //console.log(odgovor.data);
            return odgovor.data;
        })
        .catch((e)=>{console.error(e)})
}

export default {
    get
}