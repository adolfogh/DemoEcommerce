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
            var response = new Response<CustomersDTO>();
            try
            {
                var customer = _customerDomain.Get(customerId);
                response.Data = _mapper.Map<CustomersDTO>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa.";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<IEnumerable<CustomersDTO>> GetAll()
        {
            var response = new Response<IEnumerable<CustomersDTO>>();
            try
            {
                var customers = _customerDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<CustomersDTO>>(customers);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa.";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        #endregion


        #region Asíncronos

        public async Task<Response<bool>> InsertAsync(CustomersDTO customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDto);
                response.Data = await _customerDomain.InsertAsync(customer);
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

        public async Task<Response<bool>> UpdateAsync(CustomersDTO customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDto);
                response.Data = await _customerDomain.UpdateAsync(customer);
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


        public async Task<Response<bool>> DeleteAsync(string customerId)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _customerDomain.DeleteAsync(customerId);
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


        public async Task<Response<CustomersDTO>> GetAsync(string customerId)
        {
            var response = new Response<CustomersDTO>();
            try
            {
                var customer = await _customerDomain.GetAsync(customerId);
                response.Data = _mapper.Map<CustomersDTO>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa.";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<IEnumerable<CustomersDTO>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomersDTO>>();
            try
            {
                var customers = await _customerDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<CustomersDTO>>(customers);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa.";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        } 

        #endregion


    }
}
