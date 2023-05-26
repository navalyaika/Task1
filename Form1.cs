using System;
using System.Management;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Data_load(object sender, EventArgs e)
        {
            //Получаем версию ОС
            var VersionOS = "";
            foreach (var mos in new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get())
            {
                VersionOS = (string)mos["Caption"];
            }
            VersionOSValue.Text = VersionOS;

            //Получаем имя ПК
            var PCName = "";
            foreach (var mos in new ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor").Get())
            {
                PCName = (string)mos["SystemName"];
            }
            PCNameValue.Text = PCName;

            //Получаем RAM
            UInt32 RAM = 0;
            foreach (var mos in new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemoryArray").Get())
            {
                RAM = (uint)mos["MaxCapacity"];
            }
            RAM /= 1024; //MB
            RAM /= 1024; //GB
            RAMValue.Text = RAM.ToString() + " GB";

            //Получаем тип процессора
            UInt16 ProcessorType = 0;
            foreach (var mos in new ManagementObjectSearcher("SELECT * FROM Win32_Processor").Get())
            {
                ProcessorType = (UInt16)mos["AddressWidth"];
            }
            ProcessorTypeValue.Text = "x" + ProcessorType.ToString();

            //Получаем разрешение экрана
            UInt32 ScreenHeight = 0;
            UInt32 ScreenWidth = 0;
            foreach (var mos in new ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor").Get())
            {
                ScreenHeight = mos["ScreenHeight"] == null ? 0 : (uint)mos["ScreenHeight"];
                ScreenWidth = mos["ScreenWidth"] == null ? 0 : (uint)mos["ScreenWidth"];
            }
            ScreenResolutionValue.Text = $"{ScreenWidth} X {ScreenHeight}";
                       
        }

        private void File_link(object sender, FormClosingEventArgs e)
        {
            //Начало работы с объектом Excel.Application
            Excel.Application app = new Excel.Application
            {
                Visible = false,
                SheetsInNewWorkbook = 1
            };
            Excel.Workbook workBook = app.Workbooks.Add(Type.Missing);
            app.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Информация о системе";

            //Перенос информации в фаил
            sheet.Cells[1, 1] = "Верси ОС";             sheet.Cells[1, 2] = VersionOSValue.Text;
            sheet.Cells[2, 1] = "Имя ПК";               sheet.Cells[2, 2] = PCNameValue.Text;
            sheet.Cells[3, 1] = "Тип процессора";       sheet.Cells[3, 2] = ProcessorTypeValue.Text;
            sheet.Cells[4, 1] = "объем ОЗУ";            sheet.Cells[4, 2] = RAMValue.Text;
            sheet.Cells[5, 1] = "разрешение экрана";    sheet.Cells[5, 2] = ScreenResolutionValue.Text;

            //Поправить ширину столбцов
            Excel.Range range = sheet.get_Range("A1", "B5");
            range.EntireColumn.ColumnWidth = 28;

            //Сохранение файла
            app.Application.ActiveWorkbook.SaveAs($"{Environment.GetFolderPath( Environment.SpecialFolder.DesktopDirectory )}\\info.xlsx", Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            //Завершение работы с объектом Excel.Application
            app.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);

            //Вывод сообщения с сылкой на фаил
            MessageBox.Show($"фаил с информацией тут: {Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\\info.xlsx");
        }
    }
}
