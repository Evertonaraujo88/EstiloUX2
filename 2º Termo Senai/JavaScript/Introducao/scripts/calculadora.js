
function Calcular() {

   event.preventDefault();//para o submit do formulario

    //criar uma variavel para cada numero
    let n1 = parseFloat(document.getElementById("n1").value);
    let n2 = parseFloat(document.getElementById("n2").value);
    
    let op = document.getElementById('operacao').value;
    let resultado;

    if (isNaN(n1) || isNaN(n2)) {

        alert("É necessário digitar um número!!!");

        return;
    }

    if (op == '+') {

        resultado = somar(n1, n2);

    } else if (op == '-') {

        resultado = subtrair(n1, n2);

    } else if (op == '*') {

        resultado = multiplicar(n1, n2)

    } else if (op == '/') {

        if (n2 == 0) {
            return "Não é um número!!"
        }

        resultado = dividir(n1, n2)

    } else if (op == 0) {

        alert('Selecione uma operação!!!')
    }

    /* if (op != 0) {
        //exibir o resultado em uma alert - ultilidade interpolacao
        alert(`o resultado é: ${resultado}`);

    } */

        //inserindo o resultado html (DOM)..pegado o ID do <p>..entrando no innerText dele(campo de digitar dentro da tag) e atribui a variavel resultado para exibir.
        document.getElementById('result').innerText = resultado;
}   


    function subtrair(n1, n2) {

        return n1 - n2;
    }

    function somar(n1, n2) {
        return n1 + n2;
    }

    function multiplicar(n1, n2) {
        return n1 * n2;
    }
    function dividir(n1, n2) {
        return n1 / n2;
    }











