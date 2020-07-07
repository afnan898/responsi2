using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("Pilih Menu ");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan customer dalam collection
            Console.WriteLine();
            Console.WriteLine("Tambah Data Customer\n");
            Customer Customer = new Customer();
            Console.Write("Kode Customer : ");
            Customer.kd_customer = Console.ReadLine();
            Console.Write("Nama Customer : ");
            Customer.nama_customer = Console.ReadLine();
            Console.Write("Total Utang  : ");
            Customer.total_utang = Convert.ToDouble(Console.ReadLine());
          
            daftarCustomer.Add(Customer);
            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus customer dari dalam collection

            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Customer\n");
            Console.Write("Kode Customer : ");
            string kd = Console.ReadLine();
            foreach (Customer Customer in daftarCustomer)
            {
                no++;
                if (Customer.kd_customer == kd)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarCustomer.RemoveAt(hapus);
                Console.WriteLine("\nData Customer Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nKode Customer tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar customer yang ada di dalam collection

            int noUrut = 0;
            Console.WriteLine("Data Customer\n");
            foreach (Customer Customer in daftarCustomer)
            {
                noUrut++;
                Console.WriteLine("{0}. {1}, {2}, {3:N0},", noUrut, Customer.kd_customer, Customer.nama_customer, Customer.total_utang);
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Customer Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
