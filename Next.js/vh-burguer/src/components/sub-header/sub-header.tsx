import styles from "./sub-header.module.css"
import Link from "next/link"

const SubHeader = () => {
    return (
        <header className={styles.header}>
            <div className="layout_guide" id={styles.container}>
                <img src="../imgs/Logo_footer.svg" alt="Logotipo do VH Burguer" id={styles.logo}/>

                <Link href="home#cardapio" id={styles.voltar}>Voltar</Link>
            </div>
        </header>
    )
}
    
export default SubHeader