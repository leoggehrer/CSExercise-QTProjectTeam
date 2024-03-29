﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTProjectTeam.Logic.Facades.Account
{
    using TOutModel = Models.Account.User;
    public sealed partial class UsersFacade : ControllerFacade<TOutModel>, Contracts.Account.IUsersAccess<TOutModel>
    {
        public UsersFacade()
            : base(new Controllers.Account.UsersController())
        {
        }
        public UsersFacade(FacadeObject facadeObject)
            : base(new Controllers.Account.UsersController(facadeObject.ControllerObject))
        {

        }
    }
}
#endif
//MdEnd
