﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using RPG.Class.Item;

public class Ladrao : Humano
{
    public Ladrao()
    {
        this.Nome = "Ladrão";
        this.PontosdeVida = 2800;
        this.PontosdeMana = 50;
        this.ForcaFisica = 50;
        this.ForcaMagica = 30;
        this.PontoAmrmadura = 40;
        this.ResistenciaMagica = 50;
        this.Agilidade = 100;
        this.NomeImegem = "FtoLadrao.jpg";
        VetItem[0] = new Porrete();
        VetItem[1] = new Intoxicacao();
        VetItem[2] = new Tempestade();
        VetItem[3] = new Cajado();
        VetItem[4] = new Besta();
        VetItem[5] = new EsferadeAtaque();
        this.MenorArma();
    }
}

