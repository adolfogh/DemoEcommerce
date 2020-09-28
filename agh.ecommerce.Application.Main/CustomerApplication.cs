using agh.ecommerce.Application.DTO;
using agh.ecommerce.Application.Interface;
using agh.ecommerce.Domain.Entity;
using agh.ecommerce.Domain.Interface;
using agh.ecommerce.Util.Common;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace agh.ecommerce.Application.Main
{
    public class CustomerApplication : ICustomerApplication
    {
        private readonly ICustomersDomain _customerDomain;
        private readonly IMapper _mapper;

        public CustomerApplication(ICustomersDomain customerDomain, IMapper mapper)
        {
            _customerDomain = customerDomain;
            _mapper = mapper;
        }



        #region Síncronos

        public Response<bool> Insert(CustomersDTO customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDto);
                response.Data = _customerDomain.Insert(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso.";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }


        public Response<bool> Update(CustomersDTO customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDto);
                response.Data = _customerDomain.Update(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa.";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<bool> Delete(string customerId)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _customerDomain.Delete(customerId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Borrado Exitoso.";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<CustomersDTO> Get(string customerId)
        {
            throw new System.NotImplementedException();
        }

        public Response<IEnumerable<CustomersDTO>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        #endregion


        #region Asíncronos

        public Task<Response<bool>> InsertAsync(CustomersDTO customer)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<bool>> UpdateAsync(CustomersDTO customer)
        {
            throw new System.NotImplementedException();
        }


        public Task<Response<bool>> DeleteAsync(string customerId)
        {
            throw new System.NotImplementedException();
        }


        public Task<Response<CustomersDTO>> GetAsync(string customerId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<IEnumerable<CustomersDTO>>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        } 

        #endregion


    }
}
