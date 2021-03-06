﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using FitnessDatabase;

namespace FitnessDatabase.DatabaseStructure
{
    [Table("clients")]
    public class Client:ITable
    {
        //Поля для обратной связи(Они не создаются)
        //public Gym gym { get; set; }
        //public Status status { get; set; }
        //public AccountAmo amocmr { get; set; }
        //
        [Column("id")]
        public Int32 Id { get; set; }

        [Column("gym_id")]
        public Int32 GymID { get; set; }

        [Column("name"), StringLength(255)]
        public String Name { get; set; }

        [Column("amocrm_id")]
        public Int32? AmocrmID { get; set; }

        [Column("qr_code_path"), StringLength(255)]
        public String QRcodePath { get; set; }

        [Column("status_id")]
        public Int32 StatusID { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
