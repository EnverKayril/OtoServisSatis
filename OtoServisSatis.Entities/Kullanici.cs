﻿using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Display(Name = "Ad"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [StringLength(50)]
        [Display(Name = "Soyad"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Soyadi { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email { get; set; }
        [StringLength(15)]
        public string? Telefon { get; set; }
        [Display(Name = "Kullanıcı Adı"), StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string? KullaniciAdi { get; set; }
        [Display(Name = "Şifre"), StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? EklenmeTarihi { get; set; } = DateTime.Now;
        [Display(Name = "Kullanıcı Rolü"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int RolId { get; set; }
        [Display(Name = "Kullanıcı Rolü")]
        public virtual Rol? Rol { get; set; }
        public Guid? UserGuid { get; set; } = Guid.NewGuid();
    }
}
