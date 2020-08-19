using System;
using System.Data.SqlClient;

namespace Arquitetura.CleanCode
{
    /// <summary>
    /// Classe que faz registro de compra
    /// </summary>
    public class REG01
    {
        /// <summary>
        /// Faz a compra para o cliente
        /// </summary>
        /// <param name="Prod">Produto</param>
        /// <param name="Valor">Valor</param>
        /// <param name="Cat">Categoria</param>
        /// <param name="Desc">Desconto</param>
        /// <param name="ValorDesc">Valor desconto</param>
        /// <param name="Cli">Codigo cliente</param>
        /// <returns></returns>
        public bool Compra(string Prod, double Valor, int Cat, bool Desc, double ValorDesc, int Cli)
        {
            //calcula o desconto para o produto, caso haja desconto
            if (Desc){
                Valor = Valor - ValorDesc;}
            
            //retorno do cliente
            SqlDataReader cliente;

            //encontrando o cliente
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT * FROM CLIENTES WHERE CODCLI = "+Cli;

                cn.Open();
                cliente = cmd.ExecuteReader();
            }

            //se o cliente for ativo realiza a compra
            if (Convert.ToBoolean(cliente["Ativo"]))
            {
                // realiza a compra

                // Não implementar o LOG
                // Log.GravaLog(Cli, Prod, Valor);
            }
            else
            {
                // Retorna falso, significa que o cliente nao conseguiu comprar
                return false;
            }

            return true;
        }
    }
}