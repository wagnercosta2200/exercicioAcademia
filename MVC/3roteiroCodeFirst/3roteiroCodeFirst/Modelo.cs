﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3roteiroCodeFirst
{
  
        [Table("Modelos")] //fique ligado nessa notação
        public class Modelo
        {
             [Key()] //forçando que Id é a chave primária
            public int Id { get; set; }
            public string Nome { get; set; }

        public void Salvar()
        {
            var db = new BaseContext();
            db.Modelos.Add(this);//this é a representação de todos os veiculos
            db.SaveChanges();// salvar no banco
        }
        // tras todos os modelos em forma de lista
        public static List<Modelo> Todos()
        {
            var db = new BaseContext();
            return db.Modelos.ToList();
        }

        public void Remover()
        {
            var db = new BaseContext();
            db.Modelos.Remove(this);//this é a representação de todos os veiculos
            db.SaveChanges();// remove no banco
        }
       

    }

    


}

