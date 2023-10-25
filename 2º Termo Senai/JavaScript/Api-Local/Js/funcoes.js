const urlViaCep = "https://viacep.com.br/ws";
const urlProfessor = "http://172.16.35.155:3000/myceps";

async function cadastrar(e) {
    e.preventDefault();
    /*  alert("Cadastrar..."); */

        //pegar os valor dos campos digitados
    const nome = document.getElementById("nome").value.trim();
    const email = document.getElementById("email").value.trim();
    const cep = document.getElementById("cep").value;
    const endereco = document.getElementById("endereco").value;
    const numero = document.getElementById("numero").value.trim();
    const cidade = document.getElementById("cidade").value.trim();
    const estado = document.getElementById("estado").value.trim();
    
    //extra - crie um funcao(return true ou false(bool))
/*     if (!validaFor) {
        
    } */

    const promise = await fetch();
    const dados = await promise.json()

}

/* function validaForm(nome, endereco, cep) {
    if (nome.lenght == 0 || endereco.lenght == 0 || cep.lenght < 8) {
        
    } else {
        
    }
} */



async function buscarEndereco(cep) {
    /* complemento do endereco da api */
    const resource = `/${cep}/json/`;

    try {

        //const promise = await fetch(urlViaCep + resource);
        const promise = await fetch(`${urlProfessor}/${cep}`);

        /* transformo o json retornado em objeto oui array */
        const endereco = await promise.json();
        console.log(endereco);
        
        //preencher formualario
        preencherCampos({
            logradouro: endereco.logradouro,
            localidade: endereco.localidade,
            uf: endereco.uf
        })

        /* resetar o span de cep inválido */
        document.getElementById("not-found").innerText = "";
    } catch (error) {

        document.getElementById("not-found").innerText = "CEP Inválido";
    }


}

function preencherCampos(endereco) {
    /* acessa os dados o bjeto endereço(viacep) e tras os values(valores) do objeto para o form de acordo com os ids definidos nos inputs  */
    document.getElementById("endereco").value = endereco.logradouro;
    document.getElementById("cidade").value = endereco.localidade;
    document.getElementById("estado").value = endereco.uf;
}