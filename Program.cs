ChangeXYZ(10, 20, 30);

void ChangeXYZ(int x, int y, int z)
{
    x = x * y * z;
    z = x / y / z;
    y = x / y / z;
    x = x / y / z;
    Console.WriteLine($"X:{x},Y:{y},Z:{z}");
}