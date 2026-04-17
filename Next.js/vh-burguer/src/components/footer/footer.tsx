import styles from "./footer.module.css";

const Footer = () => {
    return (
        <footer id={styles.footer_home}>
            <div id={styles.container} className="Layout_guide">
                <div id={styles.footer_icons}>
                    <img src="../imgs/Logo_footer.svg" alt="Logo do VH Burguer que contém um hamburguer como plano de fundo"
                        className={styles.logo_vhburguer_footer} />
                    <nav id={styles.icons}>
                        <a href="">
                            <img src="../imgs/tiktok.png" alt="Ícone para acessar o Tik Tok do VH Burguer" />
                        </a>
                        <a href="">
                            <img src="../imgs/face.png" alt="Ícone para acessar o Facebook do VH Burguer" />
                        </a>
                        <a href="">
                            <img src="../imgs/insta.png" alt="Ícone para acessar o Instagram do VH Burguer" />
                        </a>
                        <a href="">
                            <img src="../imgs/youtube.png" alt="Ícone para acessar o canal do Youtube do VH Burguer" />
                        </a>
                    </nav>
                </div>
                <hr id={styles.linha}></hr>
                <p>Copyright © 2026 VH Burguer | Todos os direitos reservados</p>
            </div>
        </footer>
    )
}

export default Footer;