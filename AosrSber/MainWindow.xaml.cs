using System;
using System.Collections;
using Win = System.Windows;
using Win32 = Microsoft.Win32;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Forms = System.Windows.Forms;

namespace AosrSber
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Win.Window
    {
        private string filenameSource; //расположение файла источника для полей формы
        private List<Cement> dataFromFile = new List<Cement>();
        Excel.Application appSource = null;
        Excel.Workbook wBookSource = null;
        Excel.Worksheet wSheetSource = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FileBtn_Click(object sender, Win.RoutedEventArgs e)
        {
            Win32.OpenFileDialog opf = new Win32.OpenFileDialog();
            opf.Filter = "Файлы Excel(*.xls;*.xlsx)|*.xls;*.xlsx";
            opf.ShowDialog();
            filenameSource = opf.FileName;
            try
            {
                appSource = new Excel.Application();
                wBookSource = appSource.Workbooks.Open(filenameSource);
                wSheetSource = (Excel.Worksheet)wBookSource.Sheets[1];
            }
            catch (Exception ex)
            {
                Win.MessageBox.Show(ex.Message.ToString(), "An error occured in opening application file: ");
            }
            try
            {
                //downloading data from file to list of entities, add sertificate data
            }
            catch (Exception ex)
            {
                Win.MessageBox.Show(ex.Message.ToString(), "An error occured in getting data from file: ");
            }
        }
    }
}
