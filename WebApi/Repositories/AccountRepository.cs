using ClassLibrary;
using Dapper;
using System.Data;
using WebApi.DBManager;
using WebApi.IRepositories;

namespace WebApi.Repositories
{
    public class AccountRepository:IAccountRepository
    {

        private readonly IDapper _dapper;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public AccountRepository(IDapper dapper, IWebHostEnvironment hostingEnvironment)
        {
            _dapper = dapper;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<Register> RegisterUser(Register formData)
        {
            try
            {
               
                
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Firstname", formData.Firstname, DbType.String, ParameterDirection.Input);
                parameters.Add("@Lastname", formData.Lastname, DbType.String, ParameterDirection.Input);
                parameters.Add("@Username", formData.Username, DbType.String, ParameterDirection.Input);
                parameters.Add("@Email", formData.Email, DbType.String, ParameterDirection.Input);
                parameters.Add("@Password", formData.Password, DbType.String, ParameterDirection.Input);
                parameters.Add("@RePassword", formData.RePassword, DbType.String, ParameterDirection.Input);
                parameters.Add("@ContactNo", formData.ContactNo, DbType.String, ParameterDirection.Input);
                parameters.Add("@Address", formData.Address, DbType.String, ParameterDirection.Input);
                parameters.Add("@DateofBirth", formData.DateofBirth, DbType.Date, ParameterDirection.Input);
                parameters.Add("@Country", formData.Country, DbType.String, ParameterDirection.Input);
                parameters.Add("@City", formData.City, DbType.String, ParameterDirection.Input);
                parameters.Add("@Province", formData.Province, DbType.String, ParameterDirection.Input);
                parameters.Add("@FaceBook", formData.FaceBook, DbType.String, ParameterDirection.Input);
                parameters.Add("@Insta", formData.Insta, DbType.String, ParameterDirection.Input);
                parameters.Add("@Twitter", formData.Twitter, DbType.String, ParameterDirection.Input);
                parameters.Add("@IsActive", formData.IsActive, DbType.Boolean, ParameterDirection.Input);
                //parameters.Add("@RoleId", formData.RoleId, DbType.Int32, ParameterDirection.Input);

                //parameters.Add("@Firstname", formData.UserId, DbType.String, ParameterDirection.Input);
                //parameters.Add("@Firstname", formData.Firstname, DbType.String, ParameterDirection.Input);
                //parameters.Add("@Lastname", formData.Lastname, DbType.String, ParameterDirection.Input);
                //parameters.Add("@Username", formData.Username, DbType.String, ParameterDirection.Input);
                //parameters.Add("@Email", formData.Email, DbType.String, ParameterDirection.Input);
                //parameters.Add("@Password", formData.Password, DbType.String, ParameterDirection.Input);
                //parameters.Add("@ContactNo", formData.ContactNo, DbType.String, ParameterDirection.Input);
                //parameters.Add("@Address", formData.Address, DbType.String, ParameterDirection.Input);


                //parameters.Add("@RoleId", formData.RoleId, DbType.Int32, ParameterDirection.Input);


                //parameters.Add("@Country", formData.Country, DbType.String, ParameterDirection.Input);
                //parameters.Add("@City", formData.City, DbType.String, ParameterDirection.Input);
                //parameters.Add("@province", formData.Province, DbType.String, ParameterDirection.Input);
                //parameters.Add("@DateofBirth", formData.DateofBirth, DbType.Date, ParameterDirection.Input);
                //parameters.Add("@FaceBook", formData.FaceBook, DbType.String, ParameterDirection.Input);
                //parameters.Add("@Insta", formData.Insta, DbType.String, ParameterDirection.Input);
                //parameters.Add("@Twitter", formData.Twitter, DbType.String, ParameterDirection.Input);


                var data = _dapper.Insert<Register>(@"RegisterUser", parameters);
                return data;
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                Console.WriteLine("Error in RegisterUser: " + ex.Message);
                throw; // Rethrow the exception to notify the caller about the error
            }
        }
        public Register Authenticate(Register obj)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Email", obj.Email, DbType.String, ParameterDirection.Input);
            parameters.Add("@Password", obj.Password, DbType.String, ParameterDirection.Input);

            var data = _dapper.Insert<Register>(@"LoginUser", parameters);
            return data;
            // Ensure the result is properly casted or destructured
            //var registerList = (IEnumerable<Register>)data;

            //return registerList.FirstOrDefault(); // Return the first Register object or null
        }

                                                                                                                                                                                                                                                




    }
}
