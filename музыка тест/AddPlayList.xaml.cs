using System;
using System.Collections.Generic;
using System.IO;
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

namespace музыка_тест
{
    /// <summary>
    /// Логика взаимодействия для AddPlayList.xaml
    /// </summary>
    public partial class AddPlayList : Window
    {
        public AddPlayList()
        {
            InitializeComponent();
        }
        string path = @"playlists\";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(namePlayList.Text) == false && namePlayList.Text.Length > 3)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path + namePlayList.Text + ".dat", FileMode.OpenOrCreate)))
                {

                }
                Бесплатная_версия a = new Бесплатная_версия();
                a.Top = this.Top;
                a.Left = this.Left;
                this.Hide();
                a.Show();
            }
            else if(namePlayList.Text.Length <= 3)
                MessageBox.Show("Не корректная длинна!");
            else
            {
                MessageBox.Show("Введите название!");
            }
        }
    }
}
