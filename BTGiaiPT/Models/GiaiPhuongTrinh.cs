namespace BTGiaiPT.Models;
public class GiaiPhuongTrinh{
    public static string GiaiPhuongTrinhBacNhat(string heSoA, string heSoB)
    {
        double a,b,x;
        string ThongBao = "";
        a = Convert.ToDouble(heSoA);
        b = Convert.ToDouble(heSoB);
        if(a==0){
            if(b!=0){
                ThongBao = "Phương trình vô nghiệm!";
            }
            else{
                ThongBao = "Phương trình vô số nghiệm!";
            }
        }else{
            x = -b/a;
            ThongBao = "Phương trình có nghiệm x = "+x;
        }
        return ThongBao;
    }
    public static string GiaiPhuongTrinhBacHai(string heSoA, string heSoB, string heSoC){
        double a,b,c,x1,x2,x3,delta;
        string ThongBao = "";
        a = Convert.ToDouble(heSoA);
        b = Convert.ToDouble(heSoB);
        c = Convert.ToDouble(heSoC);
        delta = b*b - 4*a*c;  
        {
        if (a == 0){
            if (b == 0){
                ThongBao = "Phuong trinh vo nghiem";
            }else
            {
                ThongBao = $"Phuong trinh co 1 nghiem: x = {-c/b}";
            }
        }
        if(delta > 0){
             x1 = ((-b + Math.Sqrt(delta))/(2*a));
            x2 = ((-b - Math.Sqrt(delta))/(2*a));
            ThongBao = "Phuong trinh co 2 nghiem la: x1 = {x1}, x2 = {x2}";
        }else if(a == 0){
            x3 = (-b / (2*a));
            ThongBao = $"Phuong trinh co 1 nghiem kep: x1 = x2 = {x3}";
        }else{
            ThongBao = "Phuong trinh vo nghiem";
             }
        }return ThongBao;
    }
    
}