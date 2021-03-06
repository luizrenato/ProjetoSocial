﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSocial.Repository.Pessoa
{
    public interface IPessoa
    {
        void InsertPessoa(Models.Pessoa Pessoa);
        IEnumerable<Models.Pessoa> GetPessoas();
        Models.Pessoa GetPessoaByID(string PessoaId);
        void UpdatePessoa(Models.Pessoa Pessoa);
        void DeletePessoa(string PessoaId);
        void Save();
    }
}