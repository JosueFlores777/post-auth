﻿using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Especificaciones
{
    public class BuscarImportadorPorCorreoIdentificador : ISpecification<Cliente>
    {
        private readonly string correo;
        private readonly string identificador;

        public BuscarImportadorPorCorreoIdentificador(string correo, string identificador)
        {
            this.correo = correo;
            this.identificador = identificador;
        }

        public Func<Cliente, bool> Traer()
        {
        return new Func<Cliente, bool>(c => c.Correo.ToLower().Trim() == correo.ToLower().Trim() && c.Identificador.Replace("-", "").Trim() == identificador.Replace("-", "").Trim());

        }
    }
}
