using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Data.Configuration
{
    public class TaskConfiguration : IEntityTypeConfiguration<Tasks>
    {
        //Requisitos de cada propiedad de la clase Task

        public void Configure(EntityTypeBuilder<Tasks> builder)
        {
            builder.Property(t => t.Titulo).IsRequired().HasMaxLength(20);
            builder.Property(t => t.Tarea).IsRequired().HasMaxLength(200);
            builder.Property(t => t.Date).IsRequired();
            builder.Property(t => t.Status).IsRequired();
        }
    }
}
