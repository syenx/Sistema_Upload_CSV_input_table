﻿using OP.PortalOncoprod.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace OP.PortalOncoprod.Infra.Data.EntityConfig
{
    public class TabelaPrecoOncoprodConfig : EntityTypeConfiguration<TabelaPrecoOncoprod>
    {
        //public TabelaPrecoOncoprodConfig()
        //{
        //    HasKey(t => t.Id);

        //    Property(t => t.descricao)
        //        .IsRequired()
        //        .HasMaxLength(150);

        //    Property(t => t.nomeQuimico)
        //        .IsRequired()
        //        .HasMaxLength(100);

        //    Property(t => t.laboratorio)
        //        .IsRequired()
        //        .HasMaxLength(100);

        //    ToTable("ksTabelaPrecoOncoprod");
        //}
    }
}
