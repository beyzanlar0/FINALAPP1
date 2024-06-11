namespace FINALAPP1
{

    
        internal class Program
        {
            static void Main(string[] args)
            {
                string klasoradi = @"c:\22380101058_odevi";
                System.IO.Directory.CreateDirectory(klasoradi);
                string dosyaAdi = "finallAPP.txt";
                string dosyaYolu = @"C:\22380101058_odevi";
                string hedefYol = System.IO.Path.Combine(dosyaYolu, dosyaAdi);
                Console.WriteLine("Dosya varlığı kontrol ediliyor.");
                if (System.IO.File.Exists(hedefYol))
                {
                    Console.WriteLine("Gerekli Dosya Bilgisayarınızda mecvuttur.");
                }
                else
                {
                    System.IO.File.Create(hedefYol);
                    Console.WriteLine("Dosya Bulunamadı.");
                    Console.WriteLine("Gerekli Dosya Bilgisayarınızda oluşturuldu.");
                }
                bool DevamEt = true;
                while (DevamEt)
                {

                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:(Kayıtlı ev bilgilerini getir[1]/Yeni ev kaydı oluştur[2])");

                    while (true)
                    {
                        string islem = Console.ReadLine();
                        if (islem == "1")
                        {
                            Console.WriteLine("Kayıtlı ev bilgileri getiriliyor");
                            Console.WriteLine($"Kayıtlı ev sayısı {Ev.Sayac}");
                            if (Ev.Sayac == 0)
                            {
                                Console.WriteLine("Henüz Bir Ev Kaydı Oluşturulmamıştır.");
                            }
                            else
                            {
                                string[] bilgiler = File.ReadAllLines(dosyaYolu);
                                foreach (string bilgi in bilgiler)
                                {
                                    Console.WriteLine(bilgi);
                                }
                            }
                            break;
                        }
                        else if (islem == "2")
                        {



                            Console.WriteLine("Lütfen ev tipi seçiniz(S/K)");
                            string yanit = Console.ReadLine().ToUpper();
                            if (yanit == "S")
                            {
                                SatilikEv evler = new SatilikEv();
                                Console.WriteLine("Satılık ev bilgilerini giriniz");
                                Console.WriteLine("Oda sayisini giriniz");
                                int odasayisi = int.Parse(Console.ReadLine());
                                Console.WriteLine("Katno Giriniz");
                                int katno = int.Parse(Console.ReadLine());
                                Console.WriteLine("Alanı giriniz");
                                double alan = double.Parse(Console.ReadLine());
                                Console.WriteLine("Semt giriniz");
                                string semt = Console.ReadLine();
                                Console.WriteLine("Fiyat giriniz");
                                int fiyat = int.Parse(Console.ReadLine());

                                break;
                            }

                            else if (yanit == "K")
                            {
                                KiralikEv evler = new KiralikEv();
                                Console.WriteLine("kiralik ev bilgilerini giriniz");
                                Console.WriteLine("oda sayisini giriniz");
                                int odasayisi = int.Parse(Console.ReadLine());
                                Console.WriteLine("katno giriniz");
                                int katno = int.Parse(Console.ReadLine());
                                Console.WriteLine("alan giriniz");
                                double alan = double.Parse(Console.ReadLine());
                                Console.WriteLine("Semt giriniz");
                                string semt = Console.ReadLine();
                                Console.WriteLine("Kira giriniz");
                                int kira = int.Parse(Console.ReadLine());
                                Console.WriteLine("Depozito giriniz");
                                int depozito = int.Parse(Console.ReadLine());

                                break;
                            }

                            else
                            {
                                Console.WriteLine("Lütfen geçerli bir işlem giriniz");
                            }
                        }



                    }
                }
                Console.WriteLine("İşleme devam etmek istiyor musunuz?(Evet/Hayır):");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    Console.WriteLine("İşleme devam ediliyor");
                }
                else
                {
                    Console.WriteLine("İşleminiz iptal edildi");


                }
            }
        }

    

}
