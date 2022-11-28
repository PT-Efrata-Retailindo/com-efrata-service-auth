using Com.Efrata.Service.Auth.Lib.BusinessLogic.Interfaces;
using Com.Efrata.Service.Auth.Lib.Models;
using Com.Efrata.Service.Auth.Lib.ViewModels;
using Com.Efrata.Service.Auth.Test.Utils;
using Com.Efrata.Service.Auth.WebApi.Controllers.v1;

namespace Com.Efrata.Service.Auth.Test.Controllers
{
    public class AccountsControllerTest : BaseControllerTest<AccountsController, Account, AccountViewModel, IAccountService>
    {
    }
}
