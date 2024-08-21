using ControleContatos.Data;
using ControleContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        public ContatoModel Adicionar(ContatoModel contato)
        {
            throw new NotImplementedException();
        }
    }

    private readonly BancoContext _bancoContext;
        
        public ContatoRepositorio(BancoContext bancoContext)
        {
        _bancoContext.Contatos.Add(contato);
        return ContatoRepositorio;
        }


    }
}
