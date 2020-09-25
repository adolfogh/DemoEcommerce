using Dapper;
using agh.ecommerce.Infraestrucutra.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using agh.ecommerce.Util.Common;
using System.Threading.Tasks;
using agh.ecommerce.Domain.Entity;
using System.Data;

namespace agh.ecommerce.Infraestrucutra.Repository
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public CustomerRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region "Métodos Síncronos"

        public bool Insert(Customers customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CustomerId);
                parameters.Add("ConctacName", customer.CustomerId);
                parameters.Add("ContactTitle", customer.CustomerId);
                parameters.Add("Address", customer.CustomerId);
                parameters.Add("City", customer.CustomerId);
                parameters.Add("Region", customer.CustomerId);
                parameters.Add("PostalCode", customer.CustomerId);
                parameters.Add("Country", customer.CustomerId);
                parameters.Add("Phone", customer.CustomerId);
                parameters.Add("Fax", customer.CustomerId);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public bool Update(Customers customer)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string customerId)
        {
            throw new NotImplementedException();
        }

        public Customers Get(string customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customers> GetAll()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region "Métodos Asíncronos"

        public Task<bool> InsertAsync(Customers customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Customers customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<Customers> GetAsync(string customerId)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Customers>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
