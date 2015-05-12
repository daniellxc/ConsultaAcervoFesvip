using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Consulta.Dominio.Entidades
{
    [Table("tb_teste")]
    public class Teste
    {
      
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cod_test")]
        public int Cod_teste { get; set; }
        [Column("dados")]
        public string Dados { get; set; }

        public Teste() { }
    }
}