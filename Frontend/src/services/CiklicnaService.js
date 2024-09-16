import { HttpService } from "./HttpService";

// Define a function to call Metoda2 with parameters a and b
async function getCiklicnaData(a, b) {
    return await HttpService.get(`/Metoda2`, { 
        params: { a: a, b: b } 
    })
    .then((response) => {
        return response.data;  // The list of Ciklicna objects
    })
    .catch((e) => {
        console.error(e);
        throw e;
    });
}

export default {
    getCiklicnaData
};

