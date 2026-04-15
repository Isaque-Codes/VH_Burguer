import { Fragment } from "react/jsx-runtime";
import styles from "./login.module.css"

const Login = () => {
    return (
        <>
            <main>
                <img src="../imgs/hamburguer_login.png" alt="Imagem de hambúrguer com ingredientes caindo verticalmente alinhados" />
                <div id={styles.campo_login}>
                    <h1>Login</h1>
                    <form id={styles.formulario}>
                        <div className={styles.campo_form}>
                            <label htmlFor="email"></label>
                            <input type="text" name="email" placeholder="email@exemplo.com" required />
                        </div>
                        <div className={styles.campo_form}>
                            <label htmlFor="senha"></label>
                            <input type="password" name="senha" placeholder="*********" required />
                        </div>
                        <a href="">Esqueceu sua senha?</a>
                        <button>Entrar</button>
                    </form>
                </div>
            </main>
        </>
    )
}

export default Login;