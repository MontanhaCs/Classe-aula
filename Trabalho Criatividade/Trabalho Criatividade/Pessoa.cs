﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Criatividade
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private double altura;
        private string sexo;
        public Pessoa() 
        {
            this.nome = null;
            this.idade = 0;
            this.altura = 0.0;
            Sexo = null;
        }
        public Pessoa(string nome, int idade, double altura, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            Sexo = sexo.ToString();
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }

        }
        public double Altura 
        {
            get { return altura; }
            set { altura = value; }

        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value.ToUpper()=="M" ? "Masculino" : "Feminino"; }

        }
        public double calcularPesoIdeal()
        {
            if (sexo.Equals("MASCULINO"))
                return (72.7 * altura) - 58;
            else
                return (62.1 * altura) - 44.7;
        }
        public override string ToString()
        {
            return (String.Format("Nome:{0} \n  Idade:{1} \n  Altura:{2} \n Sexo:{3} \n", nome, idade, altura, sexo));
        }
    }
}
