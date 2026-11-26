Console.WriteLine("Name: นายดรัณ ทับพิลา");
Console.WriteLine("Course: Advanced Computer Programming");
Console.WriteLine("Instroduction: ผมไอซ์เเองเป็นนักศึกษาวิทยาการคอมพิวเตอร์ชั้นปีที่ 2 จากมหาวิทยาลัยราชภัฏอุดรธานีครับ");
strLine("-", 30);
Console.WriteLine("โปรแกรมแนะนำตัวเอง");
Console.Write("โปรดกรอกชื่อของคุณ: ");
string name = Console.ReadLine();
Console.WriteLine("สวัสดี, " + name + "!");
strLine("-", 30);
Console.WriteLine("ขอบคุณที่ใช้โปรแกรมของผมครับ!");

//ทดสอบสร้าง Funtion 
void strLine(string strInput, int n)
{
    string strOutput = "";
    for (int i = 0; i < n; i++)
    {
        strOutput += strInput;
    }
    Console.WriteLine(strOutput);
}