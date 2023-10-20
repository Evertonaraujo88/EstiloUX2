const urlViaCep = "https://viacep.com.br/ws";

function cadastrar(e) {
    e.preventDefault();
    /*  alert("Cadastrar..."); */

}

async function buscarEndereco(cep) {
    /* complemento do endereco da api */
    const resource = `/${cep}/json/`;

    try {

        const promise = await fetch(urlViaCep + resource);

        /* transformo o json retornado em objeto oui array */
        const endereco = await promise.json();
        console.log(endereco);

        //preencher formualario
        preencherCampos({
            endereco: endereco.logradouro,
            Localidade: endereco.Localidade,
            uf: endereco.uf
        })

        /* resetar o span de cep inválido */
        document.getElementById("not-found").innerText = "";
    } catch (error) {

        document.getElementById("not-found").innerText = "CEP Inválido";
    }


}

function preencherCampos(endere) {
    /* acessa os dados o bjeto endereço(viacep) e tras os values(valores) do objeto para o form de acordo com os ids definidos nos inputs  */
    document.getElementById("logradouro").value = endereco.logradouro;
    document.getElementById("localidade").value = endereco.localidade;
    document.getElementById("uf").value = endereco.uf;
}