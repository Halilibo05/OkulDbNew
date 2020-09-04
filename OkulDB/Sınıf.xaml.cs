using OkulDB.BLL;
using OkulDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OkulDB
{
    /// <summary>
    /// Sınıf.xaml etkileşim mantığı
    /// </summary>
    public partial class Sınıf : Window
    {
        ExceptionBL exception = new ExceptionBL();
        public Sınıf()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sınıf kaydeden method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsnfkaydet_Click(object sender, RoutedEventArgs e)
        {
          
            try
            {
                Sınıflar sınıf = new Sınıflar();
                SınıfBL sınıfBL = new SınıfBL();

                MessageBox.Show(sınıfBL.SnfKaydet(new Sınıflar
                {
                    SınıfAd = txtSınıfad.Text.Trim(),
                    Kontenjan=int.Parse(txtkontenjan.Text.Trim())


                }) ? "Ekleme Başaralı!" : "Ekleme Başarasız") ;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Programcınızı Arayınız");
                exception.ExceptionEkle(new Exceptions {
                Message=ex.Message,
                StackTrace=ex.StackTrace,
                Date=DateTime.Now
                });


                
            }



        }
    }
}
