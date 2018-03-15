using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SoadLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        public string boxsrav {
            get { return Boxsrav.Text; }
            set { Boxsrav.Text = value; }

        }

        public string boxperec
        {
            get { return BoxPeres.Text; }
            set { BoxPeres.Text = value; }

        }

        //Сортировка пузырьком
        void BubbleSort(List<int> number)
        {
            int prerestanovka = 0, sravnenie = 0;
            int temp;
            for (int i = 0; i < number.Count; i++)
            {
                for (int j = i + 1; j < number.Count; j++)
                {
                    sravnenie++;
                    if (number[i] > number[j])
                    {
                        prerestanovka++;
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }

            BoxPeres.Text = prerestanovka.ToString();
            Boxsrav.Text = sravnenie.ToString();
        }

        void BubbleSort(List<string> strings)
        {
            int prerestanovka = 0, sravnenie = 0;
            string temp;
            for (int i = 0; i < strings.Count; i++)
            {
                for (int j = i + 1; j < strings.Count; j++)
                {
                    sravnenie++;
                    if (String.Compare(strings[i], strings[j]) > 0)
                    {
                        prerestanovka++;
                        temp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = temp;
                    }
                }
            }

            BoxPeres.Text = prerestanovka.ToString();
            Boxsrav.Text = sravnenie.ToString();
        }


        //Гномья сортировка 
        void gnomeSort(List<int> numbers)
        {
            int i = 1;
            int prerestanovka = 0, sravnenie = 0;
            while (i < numbers.Count)
            {
                sravnenie++;
                if (i == 0 || numbers[i - 1] <= numbers[i])
                    i++;
                else
                {
                    prerestanovka++;
                    int temp = numbers[i];
                    numbers[i] = numbers[i - 1];
                    numbers[i - 1] = temp;
                    i--;
                }
            }
            BoxPeres.Text = prerestanovka.ToString();
            Boxsrav.Text = sravnenie.ToString();
        }

        void gnomeSort(List<string> strings)
        {
            int i = 1;
            int prerestanovka = 0, sravnenie = 0;
            while (i < strings.Count)
            {
                sravnenie++;
                if (i == 0 || String.Compare(strings[i - 1],strings[i]) <=0)
                    i++;
                else
                {
                    prerestanovka++;
                    string temp = strings[i];
                    strings[i] = strings[i - 1];
                    strings[i - 1] = temp;
                    i--;
                }
            }
            BoxPeres.Text = prerestanovka.ToString();
            Boxsrav.Text = sravnenie.ToString();
        }


        static int perestanovkapiramida = 0;
        static int add2pyramid(List<int> numbers, int i, int N)
        {
            int imax;
            int buf;
            if ((2 * i + 2) < N)
            {
                if (numbers[2 * i + 1]< numbers[2 * i + 2]) imax = 2 * i + 2;
                else imax = 2 * i + 1;
            }
            else imax = 2 * i + 1;
            if (imax >= N) return i;
            if (numbers[i] < numbers[imax])
            {
                buf = numbers[i];
                numbers[i] = numbers[imax];
                numbers[imax] = buf;
                perestanovkapiramida++;
                if (imax < N / 2) i = imax;
            }
            return i;
        }

        void Pyramid_Sort(List<int> numbers)
        {
            //step 1: building the pyramid
            int prerestanovka = 0, sravnenie = 0;
            for (int i = numbers.Count / 2 - 1; i >= 0; --i)
            {
                sravnenie++;
                long prev_i = i;
                i = add2pyramid(numbers, i, numbers.Count);
                if (prev_i != i) ++i;
            }

            //step 2: sorting
            int buf;
            for (int k = numbers.Count - 1; k > 0; --k)
            {
                buf = numbers[0];
                numbers[0] = numbers[k];
                numbers[k] = buf;
                int i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    sravnenie++;
                    prev_i = i;
                    i = add2pyramid(numbers, i, k);
                }
            }
            BoxPeres.Text = perestanovkapiramida.ToString();
            Boxsrav.Text = sravnenie.ToString();
        }


        static int add2pyramid(List<string> strings, int i, int N)
        {
            int imax;
            string buf;
            if ((2 * i + 2) < N)
            {
                if ( String.Compare(strings[2 * i + 1], strings[2 * i + 2]) < 0 ) imax = 2 * i + 2;
                else imax = 2 * i + 1;
            }
            else imax = 2 * i + 1;
            if (imax >= N) return i;
            if (String.Compare(strings[i], strings[imax])<0)
            {
                buf = strings[i];
                strings[i] = strings[imax];
                strings[imax] = buf;
                perestanovkapiramida++;
                if (imax < N / 2) i = imax;
            }
            return i;
        }

        void Pyramid_Sort(List<string> strings)
        {
            //step 1: building the pyramid
            int prerestanovka = 0, sravnenie = 0;
            for (int i = strings.Count / 2 - 1; i >= 0; --i)
            {
                sravnenie++;
                long prev_i = i;
                i = add2pyramid(strings, i, strings.Count);
                if (prev_i != i) ++i;
            }

            //step 2: sorting
            string buf;
            for (int k = strings.Count - 1; k > 0; --k)
            {
                buf = strings[0];
                strings[0] = strings[k];
                strings[k] = buf;
                int i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    sravnenie++;
                    prev_i = i;
                    i = add2pyramid(numbers, i, k);
                }
            }
            BoxPeres.Text = perestanovkapiramida.ToString();
            Boxsrav.Text = sravnenie.ToString();
        }


        //Сортировка Шелла
        public void shellSort(List<int> numbers)
        {
            int prerestanovka = 0, sravnenie = 0;
            int step = numbers.Count / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < numbers.Count; i++)
                {
                    int value = numbers[i];
                    for (j = i - step; (j >= 0) && (numbers[j] > value); j -= step)
                    {
                        prerestanovka++;
                        numbers[j + step] = numbers[j];
                    }
                    numbers[j + step] = value;
                    sravnenie++;
                }
                step /= 2;
            }

            BoxPeres.Text = prerestanovka.ToString();
            Boxsrav.Text = sravnenie.ToString();
        }

        public void shellSort(List<string> strings)
        {
            int prerestanovka = 0, sravnenie = 0;
            int step = strings.Count / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < strings.Count; i++)
                {
                    string value = strings[i];
                    for (j = i - step; (j >= 0) && (String.Compare(strings[j], value) > 0); j -= step)
                    {
                        prerestanovka++;
                        strings[j + step] = strings[j];
                    }
                    strings[j + step] = value;
                    sravnenie++;
                }
                step /= 2;
            }

            BoxPeres.Text = prerestanovka.ToString();
            Boxsrav.Text = sravnenie.ToString();
        }



        List<int> numbers;
        List<string> strings;
        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textinput.Text = dlg.FileName;
            }
            
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Loader read = new Loader();
            BigText.Clear();
            read.filePath = textinput.Text.ToString();
            if (Number.Checked && !(Strings.Checked)) {
                numbers = new List<int>();
                numbers.Clear();
                read.ReadDataInt(numbers);
                int nn = numbers.Count;
                if (numbers.Count > 1000) nn = 1000;
                for (int i = 0; i < nn; i++)
                    BigText.Text += numbers[i].ToString() + Environment.NewLine;

            }


            if (Strings.Checked && !(Number.Checked)) {
                strings = new List<string>();
                strings.Clear();
                read.ReadDataText(strings);
                int nn = strings.Count;
                if (strings.Count > 1000) nn = 1000;
                for (int i = 0; i < nn; i++)
                    BigText.Text += strings[i] + Environment.NewLine;

            }


            if (!(Number.Checked) && !(Strings.Checked))
                MessageBox.Show("Выберите тип данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (Number.Checked && Strings.Checked)
                MessageBox.Show("Выберите только одну из типов данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            perestanovkapiramida = 0;

            if (BigText.Text == "")
                MessageBox.Show("Загрузите данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                BigText.Clear();
                if (Number.Checked && !(Strings.Checked)){

                    if (lineagevstavki.Checked) {
                        Stopwatch time = new Stopwatch();
                        time.Start();
                        InsertionSort(numbers);
                        time.Stop();
                        Boxtime.Text = time.ElapsedTicks.ToString();

                    }
                    if (binstavki.Checked) {
                        Stopwatch time = new Stopwatch();
                        time.Start();
                        SortBinInsert(numbers);
                        time.Stop();
                        Boxtime.Text = time.ElapsedTicks.ToString();

                    }
                    if (quicksort.Checked) {
                        Stopwatch time = new Stopwatch();
                        time.Start();
                        QuickSort(numbers, 0, numbers.Count - 1);
                        time.Stop();
                        Boxtime.Text = time.ElapsedTicks.ToString();

                    }
                    if (shell.Checked) {
                        Stopwatch time = new Stopwatch();
                        time.Start();
                        SortBinInsert(numbers);
                        time.Stop();
                        Boxtime.Text = time.ElapsedTicks.ToString();

                    }
                    int nn = numbers.Count;
                    if (numbers.Count > 1000) nn = 1000;
                    for (int i = 0; i < nn; i++)
                        BigText.Text += numbers[i].ToString() + Environment.NewLine;

                }
                
                if (Strings.Checked && !(Number.Checked))
                {
                    if (lineagevstavki.Checked) {
                        Stopwatch time = new Stopwatch();
                        time.Start();
                        InsertionSort(strings);
                        time.Stop();
                        Boxtime.Text = time.ElapsedTicks.ToString();

                    }
                    if (binstavki.Checked) {
                        Stopwatch time = new Stopwatch();
                        time.Start();
                        SortBinInsert(strings);
                        time.Stop();
                        Boxtime.Text = time.ElapsedTicks.ToString();

                    }
                    if (quicksort.Checked) {
                        Stopwatch time = new Stopwatch();
                        time.Start();
                        QuickSort(strings, 0, strings.Count - 1);
                        time.Stop();
                        Boxtime.Text = time.ElapsedTicks.ToString();

                    }
                    if (shell.Checked) {
                        Stopwatch time = new Stopwatch();
                        time.Start();
                        SortBinInsert(strings);
                        time.Stop();
                        Boxtime.Text = time.ElapsedTicks.ToString();

                    }
                    int nn = strings.Count;
                    if (strings.Count > 1000) nn = 1000;
                    for (int i = 0; i < nn; i++)
                        BigText.Text += strings[i] + Environment.NewLine;

                }


            }

        }
    }
}
