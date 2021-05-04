using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
	public class Messages
	{
		public static string ProductAdded = "Ürün Eklendi";
		public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
		public static string MaintenanceTime = "Sistem Bakımda";
		public static string ProductsListed = "Ürünler Listelendi";
		public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 Ürün Olabilir";
		public static string ProductNameAlreadyExists = "Aynı İsimde Ürün Olamaz";
		public static string CategoryLimitExceded = "Kategory Sınırı Aşıldı";
		public static string AuthorizationDenied = "Yetkiniz Yok";
		public static string UserRegistered= "Hata Var";
		public static string UserNotFound= "Hata Var";
		public static string PasswordError= "Hata Var";
		public static string SuccessfulLogin= "Hata Var";
		public static string UserAlreadyExists="Kullanıcı Mevcut";
		public static string AccessTokenCreated="Hata Var";
	}
}