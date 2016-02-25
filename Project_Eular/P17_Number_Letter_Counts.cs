using System;

namespace Project_Eular
{
	public class P17_Number_Letter_Counts
	{
		public P17_Number_Letter_Counts()
		{
			int sum = 0;
			string number = "";
			for (int i = 1; i <= 1000; i++) {
				number = numberInWords (i);
				sum += number.Length;
				Console.WriteLine (number);
			}
			Console.WriteLine (sum);
		}

		public static string numberInWords(int numb)
		{
			int number = numb;
			string num = "";
			int temp = 0;
			if (number / 1000 > 0) {
				num += "onethousand";
			}
			number %= 1000;

			if (number / 100 > 0) {
				temp = number / 100;
				num += singleDigitRevParse (temp);
				num += "hundred";
			}
			number %= 100;

			if (numb > 100 && (number / 10 > 0 || number % 10 > 0)) {
				num += "and";
			}

			if (number / 10 > 0) {
				temp = number / 10;
				if (temp == 1) {
					num += teensReverseParse (number);
					return num;
				} else {
					num += twentiesToNinetiesRevParse (temp);
				}
			}
			number %= 10;

			if (number / 1 > 0) {
				num += singleDigitRevParse (number);
			}


			return num;
		}

		public static string singleDigitRevParse(int tmp)
		{
			string digitString = "";
			switch (tmp) {
			case 1: digitString = "one";
						break;
			case 2: digitString = "two";
				break;
			case 3: digitString = "three";
				break;
			case 4: digitString = "four";
				break;
			case 5: digitString = "five";
				break;
			case 6: digitString = "six";
				break;
			case 7: digitString = "seven";
				break;
			case 8: digitString = "eight";
				break;
			case 9: digitString = "nine";
				break;
			}
			return digitString;
		}

		public static string teensReverseParse (int number)
		{
			string digitString = "";
			switch (number) {
			case 10:
				digitString = "ten";
				break;
			case 11:
				digitString = "eleven";
				break;
			case 12:
				digitString = "twelve";
				break;
			case 13:
				digitString = "thirteen";
				break;
			case 14:
				digitString = "fourteen";
				break;
			case 15:
				digitString = "fifteen";
				break;
			case 16:
				digitString = "sixteen";
				break;
			case 17:
				digitString = "seventeen";
				break;
			case 18:
				digitString = "eighteen";
				break;
			case 19:
				digitString = "nineteen";
				break;
			}
			return digitString;
		}

		public static string twentiesToNinetiesRevParse (int number)
		{
			string digitString = "";
			switch (number) {
			case 2:
				digitString = "twenty";
				break;
			case 3:
				digitString = "thirty";
				break;
			case 4:
				digitString = "forty";
				break;
			case 5:
				digitString = "fifty";
				break;
			case 6:
				digitString = "sixty";
				break;
			case 7:
				digitString = "seventy";
				break;
			case 8:
				digitString = "eighty";
				break;
			case 9:
				digitString = "ninety";
				break;
			}
			return digitString;
		}
	}

}
