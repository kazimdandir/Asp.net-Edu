﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<UrunContext>
    {
        // test verileri 
        // entity framework initializer

        protected override void Seed(UrunContext context)
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori{KategoriAdi = "Telefon"},
                new Kategori{KategoriAdi = "Bilgisayar"},
                new Kategori{KategoriAdi = "Laptop"},
                new Kategori{KategoriAdi = "Beyaz Eşya"},
                new Kategori{KategoriAdi = "Kozmetik"}
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }

            context.SaveChanges();

            List<Urun> urunler = new List<Urun>()
            {
                new Urun{UrunAdi = "Samsung S5", IkinciElMi = true,Fiyat = 1000, StokAdeti = 100, KategoriId = 1},
                new Urun{UrunAdi = "Samsung S6", IkinciElMi = false, Fiyat = 2000, StokAdeti = 0, KategoriId = 1},
                new Urun{UrunAdi = "Samsung S7", IkinciElMi = true, Fiyat = 3000, StokAdeti = 200, KategoriId = 1},
                new Urun{UrunAdi = "Samsung S8", IkinciElMi = true, Fiyat = 4000, StokAdeti = 100, KategoriId = 1},
                new Urun{UrunAdi = "Samsung S9", IkinciElMi = false, Fiyat = 5000, StokAdeti = 0, KategoriId = 1},
                new Urun{UrunAdi = "Samsung S10", IkinciElMi = false, Fiyat = 7000, StokAdeti = 100, KategoriId = 1},
                new Urun{UrunAdi = "Macbook Air M1", IkinciElMi = true,Fiyat = 6000, StokAdeti = 100, KategoriId = 2},
                new Urun{UrunAdi = "Macbook Air M2", IkinciElMi = false, Fiyat = 8000, StokAdeti = 0, KategoriId = 2},
                new Urun{UrunAdi = "Macbook Pro M1", IkinciElMi = true, Fiyat = 9000, StokAdeti = 200, KategoriId = 2},
                new Urun{UrunAdi = "Macbook Pro M2", IkinciElMi = true, Fiyat = 12000, StokAdeti = 100, KategoriId = 2},
                new Urun{UrunAdi = "HP Elitebook", IkinciElMi = false, Fiyat = 5000, StokAdeti = 0, KategoriId = 2},
                new Urun{UrunAdi = "HP Probook", IkinciElMi = false, Fiyat = 7000, StokAdeti = 100, KategoriId = 2}
            };

            foreach (var item in urunler)
            {
                context.Urunler.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
