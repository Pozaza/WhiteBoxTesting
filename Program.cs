Console.Title = "Тестирование \"белым ящиком\"";

while (true) {
	Console.Clear();
	Console.WriteLine("A | B | C | Ожидаемый результат				| Объект проверки" +
"\r\n---------------------------------------------------------------------------------\r\n" +
"3 | 4 | 5 | Разносторонний, тупоугольный треугольник	| Тип треугольника\r\n" +
"5 | 5 | 5 | Равносторонний, тупоугольный треугольник	| Тип треугольника\r\n" +
"6 | 6 | 3 | Равносторонний, тупоугольный треугольник	| Тип треугольника\r\n" +
"0 | 5 | 5 | Не треугольник				| Значение стороны A равно 0\r\n" +
"-1| 5 | 5 | Не треугольник				| Значение стороны A меньше 0\r\n" +
"3 | 1 | 1 | Не треугольник				| Сумма сторон B и C меньше A (невыполнение неравенства треугольника)\n\n");

	Console.Write("Введите длину стороны A треугольника: ");
	double a = double.Parse(Console.ReadLine());

	Console.Write("Введите длину стороны B треугольника: ");
	double b = double.Parse(Console.ReadLine());

	Console.Write("Введите длину стороны C треугольника: ");
	double c = double.Parse(Console.ReadLine());

	if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a) {
		Console.WriteLine("Введенные значения не могут быть сторонами треугольника.\n\n\n");

		ConsoleKeyInfo k = Console.ReadKey();

		if (k.Key == ConsoleKey.Escape)
			break;
		else
			continue;
	} else {
		string type = "Разносторонний";
		string type2 = "тупоугольный треугольник";

		if (a == b && b == c) {
			type = "Равносторонний";
		} else if (a == b || a == c || b == c) {
			type = "Равнобедренный";
		}

		if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b) {
			type = "прямоугольный треугольник";
		} else if (a * a < b * b + c * c && b * b < a * a + c * c && c * c < a * a + b * b) {
			type = "остроугольный треугольник";
		}

		double p = (a + b + c) / 2; // полупериметр
		double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // площадь по формуле Герона

		Console.WriteLine("\nТип треугольника: " + type + ", " + type2);
		Console.WriteLine("Площадь треугольника: " + area + "\n\n\n");
	}

	ConsoleKeyInfo key = Console.ReadKey();

	if (key.Key == ConsoleKey.Escape)
		break;
}