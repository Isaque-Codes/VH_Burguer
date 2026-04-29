import { api } from "./api";

type Produto = {
    nome: string,
    descricao: string,
    preco: string,
    imagem: File | null,
    categoriasId: number[]
}

function cadastrarProduto(dados: Produto) {
    try {
        const formData = new FormData();

        formData.append("nome", dados.nome);
        formData.append("descricao", dados.descricao);
        formData.append("preco", dados.preco);
        if (dados.imagem)
            formData.append("imagem", dados.imagem);
        // formData.append("categoriaIds", dados.categoriaIds);
        dados.categoriasId.forEach((id) => {
            formData.append("categoriaIds", id.toString())
        })

    } catch (e: any) {
        throw new Error(e.message);
    }
}