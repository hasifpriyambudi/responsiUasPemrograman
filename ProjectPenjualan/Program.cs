using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan{
    class Program{
        // deklarasi objek collection untuk menampung objek penjualan

        Penjualan penjualan = new Penjualan();
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args){
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true){
                TampilMenu();

                Console.Write("\nPilih Menu Aplikasi");
                Console.Write("\n");
                Console.Write("\n1. Tambah Penjualan");
                Console.Write("\n2. Hapus Penjualan");
                Console.Write("\n3. Tampilkan Penjualan");
                Console.Write("\n4. Keluar");

                Console.Write("\nNomor Menu [1..4]: ");

                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4:
                        System.Environment.Exit(0);
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu(){
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan(){
            Console.Clear();
            
            Penjualan penjualan = new Penjualan();

            Console.Write("\nNota: ");
            penjualan.nota = Console.ReadLine();
            Console.Write("\nTanggal: ");
            penjualan.tanggal = Console.ReadLine();
            Console.Write("\nCustomer : ");
            penjualan.nama = Console.ReadLine();
            Console.Write("\nJenis[T/k] : ");
            penjualan.jenis = Console.ReadLine();
            Console.Write("\nTotal : ");
            penjualan.total = Console.ReadLine();

          
            daftarPenjualan.Add(penjualan);
            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan(){
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan(){
            Console.Clear();
            Console.WriteLine("\nData Penjualan");
            foreach(Penjualan penjual in daftarPenjualan){
                string jenisAkhir;
                Console.WriteLine("1. {0}, {1}, {2}, {3}, {4}",penjual.nota,penjual.tanggal,penjual.nama,jenisPenjual,penjual.total);
                Console.WriteLine("\n");
            }

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
