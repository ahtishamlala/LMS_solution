using ClassLibrary;
using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using WebApi.IRepositories;
using WebApi.Utility;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Account : ControllerBase
    {
        private readonly IAccountRepository _repository;
        //private readonly IPackagesRepository _repositoryPkg;
        private readonly IConfiguration _configuration;

        public Account(IAccountRepository accountRepository)
        {
                _repository=accountRepository;
        }


        [HttpPost("Authenticate")]
        public Response Authenticate([FromBody] Register obj)
        {
            Response response = new Response();
            Register claimDTO = null;
            try
            {

                claimDTO = _repository.Authenticate(obj);

                if (claimDTO == null) return CustomStatusResponse.GetResponse(320);
                else
                {


                    response = CustomStatusResponse.GetResponse(200);
                    //response.Token = TokenManager.GenerateToken(claimDTO);
                    response.Data = new
                    {
                        dataObj = claimDTO,
                    };
                    return response;
                }
            }
            catch (DbException ex)
            {
                response = CustomStatusResponse.GetResponse(600);
                response.ResponseMsg = ex.Message;
                return response;
            }
            catch (Exception ex)
            {
                response = CustomStatusResponse.GetResponse(500);
                response.ResponseMsg = ex.Message;
                return response;
            }
        }


        [HttpPost("RegisterUser")]
        public async Task<Response> RegisterUser([FromBody] Register formData)
        {
            Response response = new Response();

            try
            {
                var res = await _repository.RegisterUser(formData);

                if (res != null)
                {
                    //// Create a new user package
                    //UserPackages userPkg = new UserPackages
                    //{
                    //    UserID = res.UserId,
                    //    PackageID = 1,
                    //    SubscriptionDate = DateTime.Now,
                    //    ExpiryDate = DateTime.Now.AddDays(365), // Calculate expiry date by adding 365 days
                    //    RemainingListings = 999,
                    //    IsActive = true,
                    //    IsExpired = false
                    //};

                    //// Buy the package
                    //var respKG = _repositoryPkg.BuyPackage(userPkg);

                    // Prepare the response
                    response = CustomStatusResponse.GetResponse(200);
                    response.Token = null;
                    response.Data = res;
                    response.ResponseMsg = "Congratulations! Your registration was successful.";
                }
                else
                {
                    response = CustomStatusResponse.GetResponse(500);
                    response.Token = null;
                    response.ResponseMsg = "Failed to register user."; // Handle the case where res is null
                }
            }
            catch (DbException ex)
            {
                response = CustomStatusResponse.GetResponse(600);
                response.Token = null;
                response.ResponseMsg = ex.Message;
            }
            catch (Exception ex)
            {
                response = CustomStatusResponse.GetResponse(500);
                response.Token = null;
                response.ResponseMsg = ex.Message;

            }

            return response;
        }


    }
}
