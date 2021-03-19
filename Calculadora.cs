class Calculadora
{

    public string Soma(double numero1, double numero2)
    {
        double resultado = numero1 + numero2;
        return ("                      O resultado da sua soma é = " + resultado);
    }
    public string Subtracao(double numero1, double numero2)
    {
        double resultado = numero1 - numero2;
        return ("                    O resultado da sua subtração é = " + resultado);
    }
    public string Divisao(double numero1, double numero2)
    {
        double resultado = numero1 / numero2;
        return ("                      O resultado da sua divisão é = " + resultado);
    }
    public string Multiplicacao(double numero1, double numero2)
    {
        double resultado = numero1 * numero2;
        return ("                   O resultado da sua multiplicação é = " + resultado);
    }

}