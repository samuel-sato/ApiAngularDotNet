using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DocumentoSerivce
    {
        private List<DocumentoCarro> DocumentosCarros;
        private List<Permissao> Permissoes; // person, doc

        public DocumentoSerivce()
        {
            this.DocumentosCarros = new List<DocumentoCarro>();
            this.Permissoes = new List<Permissao>();
        }

        public bool DarPermissaoVisualizacao(DocumentoCarro documento, PersonModel proprietario,
            PersonModel pessoa)
        {
            if (documento.Proprietario.Id != proprietario.Id)
                return false;

            var permissao = new Permissao(new Guid(), documento.Id, pessoa.Id);
            this.Permissoes.Add(permissao);
            return true;
        }

        public bool PossuiPermissaoVisualizar(DocumentoCarro documento, PersonModel pessoa)
        {
            var permissao = Permissoes.FirstOrDefault(p => p.IdPessoa == pessoa.Id
                && p.IdDocumento == documento.Id);
            if (permissao != null)
                return true;
            return false;
        }
    }

    public class Permissao
    {
        public Guid Id { get; set; } 
        public Guid IdDocumento { get; set; }
        public Guid IdPessoa { get; set; }
        public Permissao(Guid id, Guid idDocumento, Guid idPessoa)
        {
            Id = id;
            IdDocumento = idDocumento;
            IdPessoa = idPessoa;
        }
    }
}
