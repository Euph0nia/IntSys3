using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IntSys3
{
    public partial class Form2 : Form
    {
        string checkWord;
        private Dictionary<string, List<int>> wordIndices = new Dictionary<string, List<int>>();

        #region Тексты для вывода информации
        // Текст
        private string[] arrText = new string[5]
        {
            // Сведения о системе -- 0 lvl
            $"Имя ОС\tМайкрософт Windows 10 Домашняя для одного языка\r\n" +
            $"Версия\t10.0.19045 Сборка 19045\r\nДополнительное описание ОС \tНедоступно\r\n" +
            $"Изготовитель ОС\tMicrosoft Corporation\r\nИмя системы\tDESKTOP-SEMENOV\r\n" +
            $"Изготовитель\tSystem manufacturer\r\nМодель\tSystem Product Name\r\n" +
            $"Тип\tКомпьютер на базе x64\r\nSKU системы\tSKU\r\n" +
            $"Процессор\tAMD Ryzen 5 5600 6-Core Processor, 3501 МГц, ядер: 6, логических процессоров: 12\r\n" +
            $"Версия BIOS\tAmerican Megatrends Inc. 4401, 04.09.2023\r\nВерсия SMBIOS\t3.3\r\n" +
            $"Версия встроенного контроллера\t255.255\r\nРежим BIOS\tUEFI\r\nИзготовитель основной платы\tASUSTeK COMPUTER INC.\r\n" +
            $"Модель основной платы\tPRIME B450M-A\r\nВерсия основной платы\tRev X.0x\r\nРоль платформы\tРабочий стол\r\n" +
            $"Состояние безопасной загрузки\tОткл.\r\nКонфигурация PCR7\tДля просмотра требуется повышение прав\r\n" +
            $"Папка Windows\tC:\\WINDOWS\r\nСистемная папка\tC:\\WINDOWS\\system32\r\nУстройство загрузки\t\\Device\\HarddiskVolume2\r\n" +
            $"Язык системы\tРоссия\r\nАппаратно-зависимый уровень (HAL)\tВерсия = \"10.0.19041.3636\"\r\n" +
            $"Имя пользователя\tDESKTOP-SEMENOV\\Sasha\r\nЧасовой пояс\tRTZ 2 (зима)\r\nУстановленная оперативная память (RAM)\t24,0 ГБ\r\n" +
            $"Полный объем физической памяти\t23,9 ГБ\r\nДоступно физической памяти\t13,4 ГБ\r\nВсего виртуальной памяти\t27,4 ГБ\r\n" +
            $"Доступно виртуальной памяти\t12,6 ГБ\r\nРазмер файла подкачки\t3,50 ГБ\r\nФайл подкачки\tC:\\pagefile.sys\r\n" +
            $"Защита DMA ядра\tОткл.\r\nБезопасность на основе виртуализации\tНе включено\r\n" +
            $"Поддержка шифрования устройства\tДля просмотра требуется повышение прав\r\n" +
            $"Hyper-V — расширения режима мониторинга виртуальной машины\tДа\r\n" +
            $"Hyper-V — расширения для преобразования адресов второго уровня\tДа\r\n" +
            $"Hyper-V — виртуализация включена во встроенном ПО\tНет\r\nHyper-V — предотвращение выполнения данных\tДа\r\n",

            // Конфликты и общий доступ -- 2 lvl
            $"Порт ввода/вывода 0x00000000-0x000003AF\tPCI Express Root Complex\r\n" +
            $"Порт ввода/вывода 0x00000000-0x000003AF\tКонтроллер прямого доступа к памяти\r\n\t\r\n" +
            $"Адрес памяти 0xF6500000-0xF65FFFFF\tМост PCI–PCI\r\nАдрес памяти 0xF6500000-0xF65FFFFF\tМост PCI–PCI\r\n" +
            $"Адрес памяти 0xF6500000-0xF65FFFFF\tМост PCI–PCI\r\nАдрес памяти 0xF6500000-0xF65FFFFF\tRealtek PCIe GbE Family Controller #3\r\n\t\r\n" +
            $"Порт ввода/вывода 0x000003C0-0x000003DF\tМост PCI–PCI\r\nПорт ввода/вывода 0x000003C0-0x000003DF\tNVIDIA GeForce RTX 3050\r\n\t\r\n" +
            $"Адрес памяти 0xF6200000-0xF64FFFFF\tМост PCI–PCI\r\nАдрес памяти 0xF6200000-0xF64FFFFF\tРасширяемый хост-контроллер AMD USB 3.10 — 1.10 (Майкрософт)\r\n\t\r\n" +
            $"Порт ввода/вывода 0x0000F000-0x0000FFFF\tМост PCI–PCI\r\nПорт ввода/вывода 0x0000F000-0x0000FFFF\tМост PCI–PCI\r\n" +
            $"Порт ввода/вывода 0x0000F000-0x0000FFFF\tМост PCI–PCI\r\nПорт ввода/вывода 0x0000F000-0x0000FFFF\tRealtek PCIe GbE Family Controller #3\r\n\t\r\n" +
            $"IRQ 55\tКонтроллер High Definition Audio (Microsoft)\r\nIRQ 55\tMicrosoft ACPI-совместимая система\r\n\t\r\n" +
            $"Порт ввода/вывода 0x0000E000-0x0000EFFF\tМост PCI–PCI\r\nПорт ввода/вывода 0x0000E000-0x0000EFFF\tNVIDIA GeForce RTX 3050\r\n\t\r\n" +
            $"Адрес памяти 0xFEE00000-0xFFFFFFFF\tPCI Express Root Complex\r\nАдрес памяти 0xFEE00000-0xFFFFFFFF\tРесурсы системной платы\r\n\t\r\n" +
            $"Адрес памяти 0xE0000000-0xF1FFFFFF\tМост PCI–PCI\r\nАдрес памяти 0xE0000000-0xF1FFFFFF\tNVIDIA GeForce RTX 3050\r\n\t\r\n" +
            $"Адрес памяти 0xA0000-0xBFFFF\tМост PCI–PCI\r\nАдрес памяти 0xA0000-0xBFFFF\tPCI Express Root Complex\r\nАдрес памяти 0xA0000-0xBFFFF\tNVIDIA GeForce RTX 3050\r\n\t\r\n" +
            $"Адрес памяти 0xF5000000-0xF60FFFFF\tМост PCI–PCI\r\nАдрес памяти 0xF5000000-0xF60FFFFF\tNVIDIA GeForce RTX 3050\r\n\t\r\n" +
            $"Порт ввода/вывода 0x000003B0-0x000003BB\tМост PCI–PCI\r\nПорт ввода/вывода 0x000003B0-0x000003BB\tPCI Express Root Complex\r\n" +
            $"Порт ввода/вывода 0x000003B0-0x000003BB\tNVIDIA GeForce RTX 3050\r\n\t\r\n" +
            $"Адрес памяти 0xF6700000-0xF6703FFF\tСтандартный контроллер NVM Express\r\nАдрес памяти 0xF6700000-0xF6703FFF\tМост PCI–PCI\r\n\t\r\n" +
            $"IRQ 0\tСистемный таймер\r\nIRQ 0\tВысокоточный таймер событий\r\n",
            
            // Клавиатура
            $"Описание\tКлавиатура HID\r\nИмя\tРасширенная клавиатура (101 или 102 клавиши)\r\nРаскладка\t00000419\r\n" +
            $"ID PNP-устройства\tHID\\VID_0416&PID_B23C&MI_01&COL03\\8&36ED5A0D&0&0002\r\nЧисло функциональных клавиш\t12\r\n" +
            $"Драйвер\tC:\\WINDOWS\\SYSTEM32\\DRIVERS\\KBDHID.SYS (10.0.19041.1, 45,50 КБ (46 592 байт), 07.12.2019 12:07)\r\n\t\r\n" +
            $"Описание\tUSB-устройство ввода\r\nИмя\tРасширенная клавиатура (101 или 102 клавиши)\r\nРаскладка\t00000419\r\n" +
            $"ID PNP-устройства\tUSB\\VID_046D&PID_C53F&MI_00\\7&257A7798&0&0000\r\nЧисло функциональных клавиш\t12\r\n" +
            $"Драйвер\tC:\\WINDOWS\\SYSTEM32\\DRIVERS\\HIDUSB.SYS (10.0.19041.3636, 43,00 КБ (44 032 байт), 17.11.2023 18:32)\r\n\t\r\n" +
            $"Описание\tUSB-устройство ввода\r\nИмя\tРасширенная клавиатура (101 или 102 клавиши)\r\nРаскладка\t00000419\r\n" +
            $"ID PNP-устройства\tUSB\\VID_0416&PID_B23C&MI_00\\7&1BE42EE7&0&0000\r\nЧисло функциональных клавиш\t12\r\n" +
            $"Драйвер\tC:\\WINDOWS\\SYSTEM32\\DRIVERS\\HIDUSB.SYS (10.0.19041.3636, 43,00 КБ (44 032 байт), 17.11.2023 18:32)\r\n",

            // Указывающее устройство 
            $"Аппаратный тип\tHID-совместимая мышь\r\nЧисло кнопок\t0\r\nСостояние\tOK\r\n" +
            $"ID PNP-устройства\tHID\\VID_046D&PID_C53F&MI_01&COL01\\8&10E0ECDA&0&0000\r\n" +
            $"Поддержка управления питанием\tНет\r\nПорог двойного щелчка\tНедоступно\r\n" +
            $"Расположение кнопок\tНедоступно\r\n" +
            $"Драйвер\tC:\\WINDOWS\\SYSTEM32\\DRIVERS\\MOUHID.SYS (10.0.19041.1, 34,50 КБ (35 328 байт), 07.12.2019 12:07)\r\n\t\r\n" +
            $"Аппаратный тип\tHID-совместимая мышь\r\nЧисло кнопок\t0\r\n" +
            $"Состояние\tOK\r\nID PNP-устройства\tHID\\VID_0416&PID_B23C&MI_01&COL04\\8&36ED5A0D&0&0003\r\n" +
            $"Поддержка управления питанием\tНет\r\nПорог двойного щелчка\tНедоступно\r\nРасположение кнопок\tНедоступно\r\n" +
            $"Драйвер\tC:\\WINDOWS\\SYSTEM32\\DRIVERS\\MOUHID.SYS (10.0.19041.1, 34,50 КБ (35 328 байт), 07.12.2019 12:07)\r\n",

            // Переменные среды
            $"ComSpec\t%SystemRoot%\\system32\\cmd.exe\t<SYSTEM>\r\nDriverData\tC:\\Windows\\System32\\Drivers\\DriverData\t<SYSTEM>\r\n" +
            $"MSMPI_BENCHMARKS\tC:\\Program Files\\Microsoft MPI\\Benchmarks\\\t<SYSTEM>\r\n" +
            $"MSMPI_BIN\tC:\\Program Files\\Microsoft MPI\\Bin\\\t<SYSTEM>\r\n" +
            $"MSMPI_INC\tC:\\Program Files (x86)\\Microsoft SDKs\\MPI\\Include\\\t<SYSTEM>\r\n" +
            $"MSMPI_LIB32\tC:\\Program Files (x86)\\Microsoft SDKs\\MPI\\Lib\\x86\\\t<SYSTEM>\r\n" +
            $"MSMPI_LIB64\tC:\\Program Files (x86)\\Microsoft SDKs\\MPI\\Lib\\x64\\\t<SYSTEM>\r\n" +
            $"NUMBER_OF_PROCESSORS\t12\t<SYSTEM>\r\nOneDrive\tC:\\Users\\Sasha\\OneDrive\tDESKTOP-SEMENOV\\Sasha\r\n" +
            $"OneDriveConsumer\tC:\\Users\\Sasha\\OneDrive\tDESKTOP-SEMENOV\\Sasha\r\nOS\tWindows_NT\t<SYSTEM>\r\n" +
            $"Path\tC:\\Program Files (x86)\\Common Files\\Oracle\\Java\\javapath;C:\\Program Files\\Microsoft MPI\\Bin\\Common\t<SYSTEM>\r\n" +
            $"Path\t%USERPROFILE%\\AppData\\Local\\Microsoft\\WindowsApps;\tNT AUTHORITY\\СИСТЕМА\r\n" +
            $"Path\tC:\\Users\\Sasha\\AppData\\Local\\Microsoft\\WindowsApps;C:\\Users\\Sasha\\.dotnet\\tools;C:\\Users\r\n" +
            $"PATHEXT\t.COM;.EXE;.BAT;.CMD;.VBS;.VBE;.JS;.JSE;.WSF;.WSH;.MSC\t<SYSTEM>\r\n" +
            $"PROCESSOR_ARCHITECTURE\tAMD64\t<SYSTEM>\r\nPROCESSOR_IDENTIFIER\tAMD64 Family 25 Model 33 Stepping 0, AuthenticAMD\t<SYSTEM>\r\n" +
            $"PROCESSOR_LEVEL\t25\t<SYSTEM>\r\nPROCESSOR_REVISION\t2100\t<SYSTEM>\r\n" +
            $"PSModulePath\t%ProgramFiles%\\WindowsPowerShell\\v1.0\\Modules;C:\\Program Files (x86)\\PowerShell\\Modules\\\t<SYSTEM>\r\n" +
            $"TEMP\t%SystemRoot%\\TEMP\t<SYSTEM>\r\nTEMP\t%USERPROFILE%\\AppData\\Local\\Temp\tNT AUTHORITY\\СИСТЕМА\r\n" +
            $"TEMP\t%USERPROFILE%\\AppData\\Local\\Temp\tDESKTOP-SEMENOV\\Sasha\r\nTMP\t%SystemRoot%\\TEMP\t<SYSTEM>\r\n" +
            $"TMP\t%USERPROFILE%\\AppData\\Local\\Temp\tNT AUTHORITY\\СИСТЕМА\r\n" +
            $"TMP\t%USERPROFILE%\\AppData\\Local\\Temp\tDESKTOP-SEMENOV\\Sasha\r\n" +
            $"USERNAME\tSYSTEM\t<SYSTEM>\r\nVBOX_MSI_INSTALL_PATH\tC:\\Program Files\\Oracle\\VirtualBox\\\t<SYSTEM>\r\n" +
            $"windir\t%SystemRoot%\t<SYSTEM>\r\n"

        };
        #endregion

        public Form2()
        {
            InitializeComponent();
        }

        // Обработка нажатий на treeview
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null) 
            {
                if (e.Node.Name == "Start")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text += arrText[0];
                }
                else if (e.Node.Name == "fst" || e.Node.Name == "snd" || e.Node.Name == "thr" || e.Node.Name == "tv_2_3")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text += $"Выберите подкатегорию";
                }
                else if (e.Node.Name == "tv_1_1")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text += arrText[1];
                }
                else if (e.Node.Name == "tv_2_3_1")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text += arrText[2];
                }
                else if (e.Node.Name == "tv_2_3_2")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text += arrText[3];
                }
                else if (e.Node.Name == "tv_3_1")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text += arrText[4];
                }
                else if (e.Node.Name == "url1")
                {
                    richTextBox1.Clear();
                    System.Diagnostics.Process.Start("https://learn.microsoft.com/ru-ru/dotnet/csharp/");
                }
                else if (e.Node.Name == "url2")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text += $"Ссылка на документацию по VS2022 : \n https://learn.microsoft.com/ru-ru/visualstudio/windows/?view=vs-2022";
                }
                else
                { 
                    richTextBox1.Clear();
                    richTextBox1.Text += $"Данный пункт справочника находится в разработке.";
                }
            }
        }

        // Поиск по шаблону
        private void FindAndHighlight(string word, Color color)
        {
            string pattern = "\\b" + Regex.Escape(word) + "\\b"; 
            MatchCollection matches = Regex.Matches(richTextBox1.Text, pattern);
            foreach (Match match in matches)
            {
                richTextBox1.SelectionStart = match.Index;
                richTextBox1.SelectionLength = match.Length;
                richTextBox1.SelectionColor = color;
            }
        }

        // Закидываем слова в combobox
        private void FindWordsAndPopulateComboBox(string requiredChars)
        {
            wordIndices.Clear();
            comboBox1.Items.Clear(); 
            string text = richTextBox1.Text;
            string pattern = @"\b\w+\b"; 
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                string word = match.Value.ToLower();
                if (ContainsSubstring(word, requiredChars))
                {
                    if (!wordIndices.ContainsKey(word))
                    {
                        wordIndices[word] = new List<int>();
                        comboBox1.Items.Add(word);
                    }
                    wordIndices[word].Add(match.Index);
                }
            }
        }

        // Находим вхождение сивмволов в слове
        static bool ContainsSubstring(string word, string requiredChars)
        {
            return word.Contains(requiredChars.ToLower());
        }

        // Подкрашиваем слово
        private void HighlightWord(string word)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.TextLength;
            richTextBox1.SelectionColor = Color.Black;

            if (wordIndices.ContainsKey(word))
            {
                foreach (int index in wordIndices[word])
                {
                    richTextBox1.Select(index, word.Length);
                    richTextBox1.SelectionColor = Color.Red;
                }
            }
        }

        // Слово, которое нужно подкрасить
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWord = comboBox1.SelectedItem.ToString();
            HighlightWord(selectedWord);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkWord = textBox1.Text;
                FindWordsAndPopulateComboBox(checkWord);
            }
            else 
            {
                checkWord = textBox1.Text;
                richTextBox1.SelectionStart = 0;
                richTextBox1.SelectionLength = richTextBox1.TextLength;
                richTextBox1.SelectionColor = Color.Black;

                Color highlightColor = Color.Red; 

                FindAndHighlight(checkWord, highlightColor);
            }
        }

        
    }
}
