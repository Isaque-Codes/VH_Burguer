import { Fragment } from "react/jsx-runtime";

const Login = () => {
    return (
        <>
            <main>
                <aside>
                    <h1>Login
                        <form action="">
                            <div className="campo_form">
                                <label htmlFor="email"></label>
                                <input type="text" name="email" placeholder="email@exemplo.com" required />
                            </div>
                            <div className="campo_form">
                                <label htmlFor="senha"></label>
                                <input type="password" name="senha" placeholder="*********" required />
                            </div>
                            <a href="">Esqueceu sua senha?</a>
                            <button>Entrar</button>
                        </form>
                    </h1>
                </aside>
            </main>
        </>
    )
}

export default Login;