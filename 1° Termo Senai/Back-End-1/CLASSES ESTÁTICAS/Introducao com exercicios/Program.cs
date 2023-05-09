using CLASSES_ESTÁTICAS;


Console.WriteLine(ConversorTemperatura.CelsiusParaFahreunheit(30) + " ºF");


Console.WriteLine(ConversorTemperatura.FahreinheitParaCelsius(100) + " ºC");

//para invocar o metodo estatico aqui na program.cs precisamos apenas
//chamar o nome da classe e a funcao, nao sendo necessario instanciar objetos
//ConversorTemperatura.CelsiusParaFahrenheit()
//ConversorTemperatura.FahrenheitParaCelsius()