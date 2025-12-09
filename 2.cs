using System;
class programs
{
    static void Main()
    {
        //TODO1
        Console.WriteLine("Chuong trinh xep loai sinh vien");
        string HovaTen = "Tran Duy Tuan";
        double diem = 9.75;
        //Todo2:
        Console.WriteLine($"Ho va ten: {HovaTen}");
        Console.WriteLine($"Diem: {diem}");
        //TODO3:
        if(diem>= 8.5)
            Console.WriteLine("Gioi");
        else if(diem>=7)
            Console.WriteLine("Kha");
        else if(diem>=5.5)
            Console.WriteLine("Trung Binh");
        else 
            Console.WriteLine("Yeu");
        //Todo4:
        string[] tensv =  {"Tran Duy A","Tran Duy B","Tran Duy C"}; 
        double[] Diem = {9, 4, 7};
        Console.WriteLine("Bang Diem");
        for(int i = 0; i < tensv.Length; i++)
        {
            //todo5:
            Console.WriteLine("Ho va ten: "+tensv[i]);
            Console.WriteLine("Diem: "+Diem[i]);
            if(Diem[i]>= 8.5)
                Console.WriteLine("Gioi");
            else if(Diem[i]>=7)
                Console.WriteLine("Kha");
            else if(Diem[i]>=5.5)
                Console.WriteLine("Trung Binh");
            else 
                Console.WriteLine("Yeu");
        }
        //todo6:
        double tongdiem = 0;
        int j=0;
        while (j < Diem.Length)
        {
            tongdiem+=Diem[j];
            j++;
        }
        Console.WriteLine("Tong diem: "+tongdiem);
        Console.WriteLine("Diem trung binh: "+(tongdiem/Diem.Length));
    }
}