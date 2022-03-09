﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OP.PortalOncoprod.Domain.Entities
{
   public class ImportExcel
    {
        [Required(ErrorMessage = "Por favor selecione um  arquivo!")]
        [FileExt(Allow = ".xls,.xlsx", ErrorMessage = "Nenhum arquivo selecionado")]
        public HttpPostedFileBase file { get; set; }
    }

    public class FileExt : ValidationAttribute
    {
        public string Allow;
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string extension = ((System.Web.HttpPostedFileBase)value).FileName.Split('.')[1];
                if (Allow.Contains(extension))
                    return ValidationResult.Success;
                else
                    return new ValidationResult(ErrorMessage);
            }
            else
                return ValidationResult.Success;
        }
    }
}
