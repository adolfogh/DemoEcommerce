using agh.ecommerce.Application.DTO;
using agh.ecommerce.Util.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace agh.ecommerce.Application.Interface
{
    public interface ICustomerApplication
    {


        #region "Métodos Síncronos"

        Response<bool> Insert(CustomersDTO customerDto);
        Response<bool> Update(CustomersDTO customerDto);
        Response<bool> Delete(string customerId);
        Response<CustomersDTO> Get(string customerId);
        Response<IEnumerable<CustomersDTO>> GetAll();

        #endregion

        #region "Metodos Asíncronos"

        Task<Response<bool>> InsertAsync(CustomersDTO customerDto);
        Task<Response<bool>> UpdateAsync(CustomersDTO customerDto);
        Task<Response<bool>> DeleteAsync(string customerId);
        Task<Response<CustomersDTO>> GetAsync(string customerId);
        Task<Response<IEnumerable<CustomersDTO>>> GetAllAsync();

        #endregion


    }
}
