import axios from "axios";
import { BACKEND_URL } from "../constans";


export const HttpService = axios.create({
    baseURL: BACKEND_URL,
    headers: {
        'Content-Type': 'application/json'
    }
});