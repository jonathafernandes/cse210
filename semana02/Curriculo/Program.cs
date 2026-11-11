using System;

class Program
{
    static void Main(string[] args)
    {
        Emprego emprego1 = new Emprego();
        emprego1._empresa = "Microsoft";
        emprego1._cargo = "Dev";
        emprego1._anoInicio = 2015;
        emprego1._anoFim = 2023;

        Emprego emprego2 = new Emprego();
        emprego2._empresa = "Apple";
        emprego2._cargo = "Dev";
        emprego2._anoInicio = 2016;
        emprego2._anoFim = 2021;

        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._nomePessoa = "Jonatha Fernandes";
        meuCurriculo._empregos.Add(emprego1);
        meuCurriculo._empregos.Add(emprego2);

        meuCurriculo.ExibirDetalhesCurriculo();
    }
}