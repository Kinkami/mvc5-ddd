using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    class ProdutoRepository : RepositoryBase<Produto>, IprodutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
           return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
