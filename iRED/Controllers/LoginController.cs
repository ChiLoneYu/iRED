﻿using Microsoft.AspNetCore.Mvc;
using System.Web;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Mvc;
using iRED.ViewModel.HomeVMs;

namespace iRED.Controllers
{
    [Public]
    public class LoginController : BaseController
    {
        [ActionDescription("登录")]
        public IActionResult Login()
        {
            LoginVM vm = CreateVM<LoginVM>();
            vm.Redirect = HttpContext.Request.Query["rd"];
            return View(vm);
        }

        [HttpPost]
        public ActionResult Login(LoginVM vm)
        {
            if (ConfigInfo.IsQuickDebug == false)
            {
                var verifyCode = HttpContext.Session.Get<string>("verify_code");
                if (string.IsNullOrEmpty(verifyCode) || verifyCode.ToLower() != vm.VerifyCode.ToLower())
                {
                    vm.MSD.AddModelError("", "验证码不正确");
                    return View(vm);
                }
            }

            var user = vm.DoLogin();
            if (user == null)
            {
                return View(vm);
            }
            else
            {
                LoginUserInfo = user;
                string url = "";
                if (!string.IsNullOrEmpty(vm.Redirect))
                {
                    url = vm.Redirect;
                }
                else
                {
                    url = "/";
                }
                return Redirect(HttpUtility.UrlDecode(url));
            }
        }

        [ActionDescription("登出")]
        public ActionResult Logout()
        {
            LoginUserInfo = null;
            HttpContext.Session.Clear();
            return Redirect("/Login/Login?rd=");
        }

        [AllRights]
        [ActionDescription("修改密码")]
        public ActionResult ChangePassword()
        {
            var vm = CreateVM<ChangePasswordVM>();
            vm.ITCode = LoginUserInfo.ITCode;
            return PartialView(vm);
        }

        [HttpPost]
        [ActionDescription("修改密码")]
        public ActionResult ChangePassword(ChangePasswordVM vm)
        {
            if (!ModelState.IsValid)
            {
                return PartialView(vm);
            }
            else
            {
                vm.DoChange();
                return FFResult().CloseDialog().Alert("密码修改成功，下次请使用新密码登录。");
            }
        }

    }
}
