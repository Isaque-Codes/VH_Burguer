import secureLocalStorage from "react-secure-storage";

export function verificarAutenticacao() {
    const token = secureLocalStorage.getItem("Token");

    // Token passa a ser booleano
    // Caso hajam dados nele, retorna true
    return !!token;
}