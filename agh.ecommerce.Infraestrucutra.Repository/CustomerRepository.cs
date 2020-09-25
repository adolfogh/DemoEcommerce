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
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerUpdate";
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

        public bool Delete(string customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customerId);


                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public Customers Get(string customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetByID";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customerId);

                var customer = connection.QuerySingle<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return customer;

            }
        }

        public IEnumerable<Customers> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerList";

                var customers = connection.Query<Customers>(query, commandType: CommandType.StoredProcedure);
                return customers;

            }
        }

        #endregion

        #region "Métodos Asíncronos"

        public async Task<bool> InsertAsync(Customers customer)
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

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public async Task<bool> UpdateAsync(Customers customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerUpdate";
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

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public async Task<bool> DeleteAsync(string customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customerId);


                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public async Task<Customers> GetAsync(string customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetByID";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customerId);

                var customer = await connection.QuerySingleAsync<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return customer;

            }
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerList";

                var customers = await connection.QueryAsync<Customers>(query, commandType: CommandType.StoredProcedure);
                return customers;

            }
        }

        #endregion

    }
}
