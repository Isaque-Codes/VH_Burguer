import styles from "./header.module.css";
import Link from "next/link";

const Header = () => {
    return (
        <header id={styles.header}>
            <div id={styles.container} className="layout_guide">
                <img src="../imgs/logo_VH_Burguer.svg" alt="Logo do VH Burguer que contém um hamburguer como plano de fundo" id={styles.logo}/>
                <nav id={styles.nav_menu}>
                    <a href="#destaques">Destaques</a>
                    <a href="#cardapio">Cardápio</a>
                    <a href="#unidades">Unidades</a>
                    <Link href="/login">Login</Link>
                </nav>
                <button id={styles.btn_icon}>
                    <img src="../imgs/icon_hamburguer.svg" alt="Ícone que representa um hamburguer para acessar o menu lateral" />
                </button>
            </div>
        </header>
    )
}

export default Header;