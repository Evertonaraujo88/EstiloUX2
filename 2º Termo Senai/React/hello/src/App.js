import Title from './Components/Titles/Title';
import CardEvento from './Components/CardEventos/CardEvento';
import Container from './Components/Container/Container';
import Contador from './Components/Contador/Contador';

import './App.css';
import Rotas from './Routes.js/Routes';

//import context
import { ThemeContext } from './Context/ThemeContext';
import { useEffect, useState } from 'react';


//verifica se o tema esta no localStorage ou assume o tema light
/* function getThemeLocalStorage() {
  setTheme(
    localStorage.getItem("theme") !== null
      ? localStorage.getItem("theme")
      : "light")
} */

/*   useState( () => {
      const tm= getThemeLs() === null ? "light" : getThemeLs() ; setTheme(tm)
  }, []);
*/

function App() {



  const [theme, setTheme] = useState("light");

  const nome = "Everton";
  const sobrenome = "Araujo";
  const produtos = [
    { idProduto: Math.random(), descricao: "Picanha Bassi", preco: 129.90, promo: false },
    { idProduto: Math.random(), descricao: "Picanha Minerva Angus", preco: 159.90, promo: false },
    { idProduto: Math.random(), descricao: "Bife de Chorizo", preco: 129.90, promo: true },
    { idProduto: Math.random(), descricao: "Bife Ancho", preco: 75.90, promo: false },
    { idProduto: Math.random(), descricao: "Fraldinha Bassi", preco: 79.90, promo: true }
  ];

  useEffect(() => {
    
    const tm = localStorage.getItem("theme");

    if (tm !== null) {
      setTheme(tm)
    } else {
      setTheme("light")
    }
  }, []);

  return (
    <ThemeContext.Provider value={{ theme, setTheme, nome, sobrenome, produtos }}>

      <div className={`App ${theme === "dark" ? "App-dark" : "light"}`}>

        <Rotas />



      </div>

    </ThemeContext.Provider>

  );
}

export default App;
