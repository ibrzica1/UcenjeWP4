import axios from "axios";
import { BACKEND_URL } from "../constans";

// Pozivanje metode Metoda2 u API-ju
const getCiklicna = async (a, b) => {
    try {
        const response = await axios.get(`${BACKEND_URL}/Metoda2`, {
            params: {
                a: a,
                b: b
            }
        });
        console.log(response.data);  // Obradite podatke ako je poziv uspješan
        return response.data;
    } catch (error) {
        console.error("Error while fetching data:", error);
    }
};