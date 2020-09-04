using OkulDB.BLL;
using OkulDB.Models;
using System;
using System.Data.SqlClient;
using System.Windows;


namespace OkulDB
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        ExceptionBL exception = new ExceptionBL();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void kaydetbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OgrenciBL ogrenci = new OgrenciBL();

                Ogrenci ogrenci1 = new Ogrenci();
                MessageBox.Show(ogrenci.kaydet(new Ogrenci
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    Numara = int.Parse(txtnumara.Text.Trim())

                }) ? "Ekleme Başaralı!" : "Ekleme Başarasız");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Programcınızı Arayınız");
 
                exception.ExceptionEkle(new Exceptions
                {
                    Date = DateTime.Now,
                    Message = ex.Message,
                    StackTrace = ex.StackTrace
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Hata");
                exception.ExceptionEkle(new Exceptions
                {
                    Date = DateTime.Now,
                    Message = ex.Message,
                    StackTrace = ex.StackTrace
                });

            }

            //switch (ex.Number)
            //{
            //    case 2627:
            //        MessageBox.Show("Eklenmiş Numara");
            //        ExceptionBL exception = new ExceptionBL();
            //        exception.ExceptionEkle(new Exceptions {
            //        Date=DateTime.Now,
            //        Message=ex.Message,
            //        StackTrace=ex.StackTrace});
            //        break;
            //    default:
            //        MessageBox.Show("Veritabanı Hatası!");
            //        break;

            //}


        }

      
    }
}
