import styles from "./produto.module.css";
import Footer from "@/components/footer/footer";
import SubHeader from "@/components/sub-header/sub-header";

const Produto = () => {
    return (
        <>
            <SubHeader />
            <main id={styles.main}>
                <article id={styles.article}>
                    <h1 id={styles.h1}>CRIAR PRODUTO</h1>
                    <form id={styles.formulario}>
                        <div className={styles.campo_form}>
                            <label className={styles.label} htmlFor="produto">Nome do produto</label>
                            <input type="text" name="produto" placeholder="BBQ Especial" required />
                        </div>
                        <div className={styles.campo_form}>
                            <label className={styles.label} htmlFor="descricao">Descrição</label>
                            <input type="text" name="descricao" placeholder="Hamburguer com molho barbecue defumado com cebola caramelizada" required />
                        </div>
                        <div className={styles.campo_form}>
                            <label className={styles.label} htmlFor="preco">Preço (R$)</label>
                            <input type="number" step={1.01} name="preco" placeholder="40,00" required />
                        </div>
                        <div className={styles.campo_form}>
                            <label className={styles.label} htmlFor="categoria">Categoria</label>
                            <input type="text" name="categoria" placeholder="Selecione a categoria" required />
                        </div>
                        <a id={styles.adc_categ} href="">Adicionar categoria</a>
                        <div className={styles.campo_form}>
                            <label className={styles.label} htmlFor="url">URL da imagem</label>
                            <input type="url" name="url" placeholder="https://unplash.com/pt-br/fotografias/cheseburger..." required />
                        </div>
                    </form>
                    <button>Salvar</button>
                </article>
            </main>
            <Footer />
        </>
    )
}

export default Produto