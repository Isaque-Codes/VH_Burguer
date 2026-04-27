import axios from "axios";

const apiLocal = "http://localhost:3000/api/";

const apiRemota = "";

// Endereco da API
export const api = axios.create({
    baseURL: apiLocal
})