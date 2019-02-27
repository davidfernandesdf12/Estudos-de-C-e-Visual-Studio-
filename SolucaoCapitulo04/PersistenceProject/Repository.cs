using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;

namespace PersistenceProject
{
    public class Repository
    {
        private IList<Fornecedor> fornecedores = new List<Fornecedor>();
        private IList<Produto> produtos = new List<Produto>();
        private IList<NotaEntrada> notaEntradas = new List<NotaEntrada>();

        #region Métodos - Fornecedor 
        //Método responsavel por inserir um novo fornecedor
        public Fornecedor InserirFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Add(fornecedor);
            return fornecedor;
        }
        //Método responsavel por remover um fornecedor
        public void RemoveFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Remove(fornecedor);
        }
        //Método responsavel por trazer todos os fornecedores
        public IList<Fornecedor> GetAllFornecedores()
        {
            return this.fornecedores;
        }
        //Método responsavel de atualizar o fornecedor
        public Fornecedor UpdateFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores[this.fornecedores.IndexOf(fornecedor)] = fornecedor;
            return fornecedor;
        }
        #endregion

        #region Métodos - Produtos
        //Método responsavel por inserir um novo produto
        public Produto InserirProduto(Produto produto)
        {
            this.produtos.Add(produto);
            return produto;
        }
        //Método responsavel por remover um produto
        public void RemoveProduto(Produto produto)
        {
            this.produtos.Remove(produto);
        }
        //Método responsavel por trazer todos os produtos
        public IList<Produto> GetAllProdutos()
        {
            return this.produtos;
        }
        //Método responsavel de atualizar o produto
        public Produto UpdateProduto(Produto produto)
        {
            this.produtos[this.produtos.IndexOf(produto)] = produto;
            return produto;
        }
        #endregion



    }
}
