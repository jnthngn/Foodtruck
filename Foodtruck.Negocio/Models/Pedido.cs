﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Negocio.Models
{


    [Table(name: "Pedidos")]
    public class Pedido
    {
        public long Id { get; set; }
        public DateTime DataCompra { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Lanche> Lanches { get; set; }
        public virtual ICollection<Bebida> Bebidas { get; set; }

        public Pedido()
        {
            this.DataCompra = DateTime.MinValue;
            this.Lanches = new List<Lanche>();
            this.Bebidas = new List<Bebida>();
        }

        public Decimal ValorTotal
        {   
            get
            {
                Decimal totalLanches = this.Lanches.Sum(m => m.Valor);
                Decimal totalBebidas = this.Bebidas.Sum(m => m.Valor);
                Decimal ValorTotal = totalLanches + totalBebidas;
                return ValorTotal;
            }
        }
        public String DadosCliente
        {
            get
            {
                String dadosCliente;
                dadosCliente = this.Cliente.CPF + " - " + this.Cliente.Nome;
                return dadosCliente;
            }
        }
    }
}
