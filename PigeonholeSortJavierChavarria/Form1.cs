using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigeonholeSortJavierChavarria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            string[] input = txtInput.Text.Split(',');  
            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i].Trim());  
            }
          
            PigeonholeSort(arr);

            Ordenamiento.Items.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                Ordenamiento.Items.Add(arr[i]);
            }

        }

        private void PigeonholeSort(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            int range = max - min + 1;

            int[] pigeonholes = new int[range];

            for (int i = 0; i < range; i++)
            {
                pigeonholes[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                pigeonholes[arr[i] - min]++;
            }

            int index = 0;
            for (int i = 0; i < range; i++)
            {
                while (pigeonholes[i] > 0)
                {
                    arr[index++] = i + min;
                    pigeonholes[i]--;
                }
            }
        }

    }
}
