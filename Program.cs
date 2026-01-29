// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;

const string path = "data3.csv";
if (!File.Exists(path))
{
    Console.WriteLine(path + "が見つかりません");
    return;
}
using StreamReader sr = new(path);
int preDate = 0;
string[] you = ["日", "月", "火", "水", "木", "金", "土"];
while (sr.Peek() >= 0)
{
    string? line = sr.ReadLine();
    if (line == null) break;
    string[] values = line.Split(',');
    int nengappi = int.Parse(values[0]);
    int year = int.Parse(values[1]);
    int month = int.Parse(values[2]);
    int date = int.Parse(values[3]);
    int youbi = int.Parse(values[4]);
    int kyuMonth = int.Parse(values[5]);
    int kyuDate = int.Parse(values[6]);
    if (date != preDate)
    {
        preDate = date;
        int sio = kyuDate % 15;
        if (sio == 0) sio = 15;
        Console.WriteLine($"{year},{month},{date},{you[youbi]},{kyuMonth},{kyuDate},{sio}");
    }
}
