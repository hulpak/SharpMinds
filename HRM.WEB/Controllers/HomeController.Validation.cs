using HRM.DAL.Models;
using HRM.Web.ViewModel;
using System;
using System.Net.Mail;

namespace HRM.Web.Controllers
{
	public partial class HomeController
	{
		private bool ValidateCredentials(UserCredentialsVM userCredentialsVM)
		{
			bool isValid = true;

			try
			{
				MailAddress email = new MailAddress(userCredentialsVM.Email);
			}
			catch (Exception)
			{
				isValid = false;
			}
			if (string.IsNullOrWhiteSpace(userCredentialsVM.Password))
			{
				isValid = false;
			}
			return isValid;
		}

		

		private bool ValidateChangeData(UserVM userVM, User userBase)
		{
			bool isValid = true;

			try
			{
				MailAddress email = new MailAddress(userVM.Email);
			}
			catch (Exception)
			{
				isValid = false;
			}
			if (
				(string.IsNullOrWhiteSpace(userVM.Password)
					&& string.IsNullOrWhiteSpace(userVM.NewPassword)
					&& string.IsNullOrWhiteSpace(userVM.ConfirmNewPassword)
				)
				|| (!string.IsNullOrWhiteSpace(userVM.Password)
					&& userVM.Password == userBase.Password
					&& userVM.NewPassword == userVM.ConfirmNewPassword
				)
			)
			{
				isValid = true;
			}
			else
				isValid = false;
			return isValid;
		}
	}
}