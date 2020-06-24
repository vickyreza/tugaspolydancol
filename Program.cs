using System;
using System.Collections.Generic;
using tugaspolydancol.Induk;
using tugaspolydancol.Anak;


namespace tugaspolydancol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas PolymorPhism, abstraction & collection";

            //membuat object untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "123-123-123";
            karyawanTetap.Nama = "Mas Agus";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "123-456-789";
            karyawanHarian.Nama = "Mas Pras";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 15000;

            Sales sales = new Sales();
            sales.Nik = "123-321-231";
            sales.Nama = "Imam jomin";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            //object class collection

            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawanTetap);
            listkaryawan.Add(karyawanHarian);
            listkaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}",
                noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
        }
    }
}
        
