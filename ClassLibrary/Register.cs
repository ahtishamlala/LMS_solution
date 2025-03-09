using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ForgotPassword
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? VerificationCode { get; set; }
        public string? Password { get; set; }
    }
    public class Register 
    {
        public int UserId { get; set; }
        public string? RoleIds { get; set; }
        public string? Roles { get; set; }
        public string? RoleId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? RePassword { get; set; }

        public string? ContactNo { get; set; }
        public string? Address { get; set; }


        public DateTime? DateofBirth { get; set; }

        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }

        public string? FaceBook { get; set; }
        public string? Insta { get; set; }
        public string? Twitter { get; set; }

        public string? IsActive { get; set; }

        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
       //  public List<RoleScreenPermission>? RoleScreenPermission { get; set; }


    }


    public class Roles
    {

        public int Id { get; set; }

        public string Role { get; set; }
    }

    public class UsersDTO
    {


        public Register Register { get; set; }

        public List<Roles> Roles { get; set; }


    }




    public class ListUsersDTO
    {

        public List<Register> Register { get; set; }

        public List<Roles> Roles { get; set; }

    }

    public class userRolesUpdate
    {

        public int UserId { get; set; }


        public string RolesIds { get; set; }

    }


    public class DataObj
    {
        public Register? dataObj { get; set; }
    }

    public class RoleScreenPermission
    {
        public string? RoleIds { get; set; }
        public int ScreenId { get; set; }
        public string? ScreenName { get; set; }
    }

    public class ScreenPermission
    {
        public int? RoleId { get; set; }
        public string? ScreenIds { get; set; }
        public int UserId { get; set; }
    }



    public class PermissionScreens
    {
        public int ScreenId { get; set; }
        public string? ScreenName { get; set; }
    }
    public class DTORoleScreenPermission
    {
        public int? RoleId { get; set; }
        public string? Role { get; set; }
        public string? ScreenName { get; set; }
        public string? ScreenIds { get; set; }
    }


}
