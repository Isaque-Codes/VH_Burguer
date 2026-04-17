import { Fragment } from "react/jsx-runtime";
import Header from "@/components/header/header";
import Footer from "@/components/footer/footer";
import styles from "./home.module.css";

const Home = () => {
    return (
        <>
            <Header />
            <main>
                {/* SECAO BANNER */}
                <section id={styles.banner}>
                    <div id={styles.container_banner} className={styles.layout_guide}>
                        <h1 id={styles.titulo}>BEM-VINDO(A) AO VH BURGUER!</h1>
                        <img id={styles.img_banner} src="../imgs/foto_de_hamburgueres.png" alt="Foto de 3 hamburgueres no banner principal da página" />
                        <div id={styles.botoes_banner}>
                            <button className={styles.btn_banner} id={styles.btn_atendente}>Chamar atendente</button>
                            <button className={styles.btn_banner} id={styles.btn_cardapio}>Ver cardápio</button>
                        </div>
                    </div>
                </section>



                {/* SECAO DESTAQUES */}
                <section id={styles.destaques}></section>



                {/* SECAO CARDAPIO */}
                <section id={styles.cardapio}>
                    {/*<h2>Cardápio</h2>  Componente*/}
                </section>



                {/* SECAO UNIDADES */}
                <section id={styles.unidades}></section>
            </main>
            <Footer />
        </>
    )
}

export default Home;