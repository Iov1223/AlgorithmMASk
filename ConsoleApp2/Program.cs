using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmMASk
{
    public class MASK 
	{
		public int[] oktet = new int[4];
		public MASK()
		{
			for (int i = 0; i < 4; i++)
			{
				oktet[i] = 0;
			}
		}
		public string mask = "";
		public string intTOstring = "";
		private string UNIT = "", ZERO = "";
		private bool IsCorrect = true;
		private int count = 0;
		public void input_IP()
        {
            Console.WriteLine("Введите мaску пооктетно (пример маски: 255.255.255.0):");
			for (int i = 0; i < oktet.Length; i++)
			{
				oktet[i] = Convert.ToInt32(Console.ReadLine());
			}
		}
		public void to_String()
        {
			for (int i = 0; i < oktet.Length; i++)
			{
				mask += oktet[i] + ".";
				intTOstring += Convert.ToString(oktet[i], 2);
			}
		}
		public void unit_Record()
        {
			for (int i = 0; i < intTOstring.Length; i++)
			{
				if (intTOstring[i] == '1')
				{
					UNIT += intTOstring[i];
					count++;
				}
				else
					break;
			}
		}
		private bool check_Imput()
        {
			for (int i = count; i < intTOstring.Length; i++)
			{
				ZERO += intTOstring[i];
				if (ZERO.Contains('1'))
				{
					IsCorrect = false;
				}
                else
                {
					IsCorrect = true;
                }
			}
			return IsCorrect;
		}
		public void print_Mask()
        {
			if (check_Imput())
			{
				Console.WriteLine(mask.Remove(mask.Length - 1));
			}
			else
			{
				Console.WriteLine("Неправильный ввод");
			}
		}
	}

    internal class Program
    {
        static void Main(string[] args)
        {
			MASK myMask = new MASK();
            Console.WriteLine(myMask.oktet[0] + "." + myMask.oktet[1] + "." + myMask.oktet[2] + "." + myMask.oktet[3]);
			myMask.input_IP();
			myMask.to_String();
			myMask.unit_Record();
			myMask.print_Mask();

		}
    }
}
