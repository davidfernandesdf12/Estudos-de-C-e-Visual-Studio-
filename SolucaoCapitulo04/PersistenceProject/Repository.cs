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
       
        //método para inserir ou atualizar fornecedor(verifica pelo o id)
        public Fornecedor SaveOrUpdateFornecedor(Fornecedor fornecedor)
        {
            if (fornecedor.Id.Equals(null))
            {
                fornecedor.Id = Guid.NewGuid();
                this.fornecedores.Add(fornecedor);
                return fornecedor;
            }
            else
            {
                this.fornecedores[this.fornecedores.IndexOf(fornecedor)] = fornecedor;
                return fornecedor;
            }
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
        
        #endregion

        #region Métodos - Produtos
        //Método responsavel por inserir ou atualizar um produto(verifica pelo o id)
        public Produto SaveOrUpdateProduto(Produto produto)
        {
            if (produto.Id.Equals(null))
            {
                this.produtos.Add(produto);
                return produto;
            }
            else
            {
                this.produtos[this.produtos.IndexOf(produto)] = produto;
                return produto;
            }
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

        #endregion

        #region Métodos - NotaEntrada
        //Método responsavel por inserir ou atualizar nota de entrada(verifica pelo o id)
        public NotaEntrada SaveOrUpdateNotaEntrada(NotaEntrada notaEntrada)
        {
            if (notaEntrada.Id.Equals(null)) { 
            notaEntradas.Add(notaEntrada);
            return notaEntrada;
            }
            else
            {
                this.notaEntradas[this.notaEntradas.IndexOf(notaEntrada)] = notaEntrada;
                return notaEntrada;
            }
        }

        //Método responsavel por exluir uma nota de entrada
        public void RemoverNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notaEntradas.Remove(notaEntrada);
        }
        
        //Método responsavel por trazer todas a notas de entrada
        public IList<NotaEntrada> GetAllNotaEntradas()
        {
            return this.notaEntradas;
        }
        #endregion


    }
}
