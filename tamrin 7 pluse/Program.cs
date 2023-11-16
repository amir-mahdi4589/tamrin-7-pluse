//tamrin 7 plus
//amir mahdi hosein njad
List<student> students = new List<student>();
StreamReader sr = new StreamReader(@"D:\Workshop\tamrin7name.txt");

while (!sr.EndOfStream)
{ 
    string line = sr.ReadLine();
    student student = new student();

   student.FIRSTname = line.Split(',')[0];
   student.LASTname = line.Split(',')[1];
   student.pishrafte1 = Convert.ToDouble(line.Split(',')[2]);
   student.tafsir = Convert.ToDouble(line.Split(',')[3]);
   student.riazi = Convert.ToDouble(line.Split(',')[4]);
   student.kargah = Convert.ToDouble(line.Split(',')[5]);
   student.zaban = Convert.ToDouble(line.Split(',')[6]);
   student.pishrafte2 = Convert.ToDouble(line.Split(',')[7]);
   student.sheygaraee = Convert.ToDouble(line.Split(',')[8]);
   student.tarbiatBadani = Convert.ToDouble(line.Split(',')[9]);
   student.sistemAmel = Convert.ToDouble(line.Split(',')[10]);
   student.algoritm = Convert.ToDouble(line.Split(',')[11]);

   students.Add(student);
}

Console.WriteLine("adad moored nazar ra jahat anjam amaliat vard konid");
Console.Write("1-namayesh list-->");
 Console.Write("2-namayesh miangin kol-->");
Console.Write("3-namayesh miangin kol ba zarib-->");
Console.Write("4- namayesh miangin doroos **-->");
Console.Write("5-namayesh miangin doroos *--> ");
Console.Write("6-namayehs adad aval nomarat-->");
Console.Write("7-namyesh ba asas sort-->");
Console.WriteLine("8-namaehsh be soorat grad bandi");
Console.WriteLine();
Console.WriteLine("adad mored nazar ra vared konid");


do
{
    double n = Convert.ToInt64(Console.ReadLine());

    if (n == 1)
    {
        Console.WriteLine(sr.ReadLine());
    }
    else if (n == 2)
    {
        foreach (var student in students)
        {
            Console.WriteLine("name:" + student.LASTname + "= " + student.totalAverage());

        }

    }
    else if (n == 3)
    {
        foreach (var student in students)
        {
            Console.WriteLine("name:" + student.LASTname + "= " + student.average());
        }
    }
    else if (n == 4)
    {
        foreach (var student in students)
        {
            Console.WriteLine("name:" + student.LASTname + "= " + student.average1());

        }
    }
    else if (n == 5)
    {
        foreach (var student in students)
        {
            Console.WriteLine("name:" + student.LASTname + "= " + student.average2());

        }
    }

    else if (n == 6)
    {
        foreach (var student in students)
        {

            if (student.aval(student.pishrafte1) = true)
             Console.WriteLine("pishrafte1" + "= " + student.pishrafte1); 
            if (student.aval(student.tafsir) = true)
                Console.WriteLine("tafsir" + " " + student.tafsir);
             if (student.aval(student.riazi) = true)
                Console.WriteLine("riazi" + "= " + student.riazi);
             if (student.aval(student.kargah) = true)
                Console.WriteLine("kargah" + "= " + student.kargah);
             if (student.aval(student.zaban) = true)
                Console.WriteLine("zaban" + "= " + student.zaban);
             if (student.aval(student.pishrafte2) = true)
                Console.WriteLine("pishrafte2" + " " + student.pishrafte2);
             if (student.aval(student.sheygaraee) = true)
                Console.WriteLine("sheygaraee" + "= " + student.sheygaraee);
            if (student.aval(student.tarbiat) = true)
                Console.WriteLine("tarbiatBadani" + "= " + student.tarbiatBadani);
             if (student.aval(student.sistemAmel) = true)
                Console.WriteLine("sistemAmel" + "= " + student.sistemAmel);
            else if (student.aval(student.algoritm) = true)
                Console.WriteLine("algoritm" + "= " + student.algoritm);

        }

    }

   
    else if (n == 8)
    {
        foreach (var student in students)
        {
            
            double x = student.totalAverage();
            student.GradeExp(x);
        }
    }
} while (true);




 public class student
{
    public string FIRSTname { get; set; }
    public string LASTname { get; set; }
    public double pishrafte1 { get; set; }
    public double tafsir { get; set; }
    public double riazi { get; set; }
    public double kargah { get; set; }
    public double zaban { get; set; }
    public double pishrafte2 { get; set; }
    public double sheygaraee { get; set; }
    public double tarbiatBadani { get; set; }
    public double sistemAmel { get; set; }
    public double algoritm { get; set; }

public double totalAverage()
    {

        return (( pishrafte1 ) + ( tafsir ) + ( riazi ) + ( kargah ) + ( zaban ) + ( pishrafte2 ) + ( sheygaraee ) + ( tarbiatBadani ) + ( sistemAmel  ) + (algoritm )) / 10;
    }
    public double average()
    {
        return ( (pishrafte1*3) + (tafsir*1) + ( riazi*2) + ( kargah*1) + ( zaban*2) + ( pishrafte2*3) +  ( sheygaraee*3) + ( tarbiatBadani*1) + ( sistemAmel*3) +(algoritm * 3)    )/22;
    }
    
    public double average1()
    {
        return (pishrafte1 * 3 + pishrafte2 * 3 + sheygaraee * 3) / 9;
    }
    public double average2()
    {
        return ( sistemAmel*3 + algoritm * 3 ) / 6;
    }

    public void aval(double num)
    {
        int sum = 0;

        
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + 1;
                }
            }
          
        }
    public char GradeExp(double average) => average switch
    {
        double n when (n > 20 || n < 0) => throw new ArgumentOutOfRangeException(),
        >= 17 => 'A',
        >= 15 => 'B',
        >= 13 => 'C',
        >= 10 => 'D',
        >= 7 => 'E',
        >= 3 => 'F',
        >= 0 => 'G',
        _ => throw new ArgumentOutOfRangeException()
    }

    }

