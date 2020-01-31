using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Dominio.Interfaces
{
    public interface IPacoteRepositorio
    {
        List<PacoteDominio> Listar(bool? todos = null);

        PacoteDominio BuscarPorId(int id);

        PacoteDominio Cadastrar(PacoteDominio pacote);

    }
}
