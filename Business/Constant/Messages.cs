using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constant
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvaled = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductListed ="Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameAlreadyExists = "Böyle bir isim kullanılıyor";
        public static string CategoryLimitExceded = "Kategori limit aşıldı";

        public static string AuthorizationDenied = "Yetki reddedildi";

        public static string UserRegistered { get; internal set; }
        public static User UserNotFound { get; internal set; }
        public static User PasswordError { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
        public static string ProductDeleted { get; internal set; }
        public static string CategoryAdded { get; internal set; }
        public static string CategoryDeleted { get; internal set; }
        public static string CategoryUpdated { get; internal set; }
        public static string ProductsListed { get; internal set; }
    }
}

