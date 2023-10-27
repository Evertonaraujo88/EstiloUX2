import Title from './Components/Titles/Title';
import CardEvento from './Components/Titles/CardEventos/CardEvento';
import Container from './Components/Titles/Container/Container';

import './App.css';


function App() {
  return (
    <div className="App">

      <h1>Hello World React!!!</h1>

      <Title nome="Everton" sobrenome="Araujo" />

      <br /><br />

      <Container>

        <CardEvento
          titulo="React"
          descricao="Evento de react com o professor Edu"
          botao="Inscreva-se"
        />

        <CardEvento
          titulo="JavaScript"
          descricao="Evento de javaScript com o professor Edu"
          botao="Inscreva-se"
        />

        <CardEvento
          titulo="Props"
          descricao="Evento de props com o professor Edu"
          botao="Inscreva-se"
        />
        
      </Container>

    </div>
  );
}

export default App;
