const urlViaCep ="https://viacep.com.br/ws";
const urlViaCepProfessor ="http://172.16.35.155:3000/myceps";

function cadastrar(e) {
    e.preventDefault();
    alert("Cadastrar...")
}

async function buscarEndereco(cep){
    const resource = `/${cep}/json/`;
console.log(`CEP: ${cep}`);

try {
    //const promise = await fetch(urlViaCep+resource);
    const promise = await fetch(`${urlViaCepProfessor}/${cep}`);
    const endereco = await promise.json();//transformo o json em um objeto array
    console.log(endereco);

    document.getElementById("Endereço").value = endereco.logradouro;
    document.getElementById("cidade").value = endereco.localidade;
    document.getElementById("estado").value = endereco.uf;
   
  


    // document.getElementById("not-found").innerText ="";
} catch (error) {
    alert(error);

    // document.getElementById("not-found").innerText ="cep invalido";
}

}