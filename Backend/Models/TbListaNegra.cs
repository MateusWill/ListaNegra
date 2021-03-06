﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    [Table("tb_lista_negra")]
    public partial class TbListaNegra
    {
        [Key]
        [Column("id_LN")]
        public int IdLn { get; set; }
        [Column("nm_pessoa", TypeName = "varchar(100)")]
        public string NmPessoa { get; set; }
        [Column("ds_motivo", TypeName = "varchar(50)")]
        public string DsMotivo { get; set; }
        [Column("dt_inclusão", TypeName = "datetime")]
        public DateTime? DtInclusão { get; set; }
    }
}
