// Alexandra Camarena
// MIS 3013 HW2 Grade Problem

double overGPADbl = 0;

string outMesStr;
string inputMesStr;

// Accounting, Marketing, Econcomics and MIS
// A, B, C, D, F

//accounting
int accCreditHoursInt = 3;
int accPointValDbl = -1;
char accLetterGradCh = 'E';
double accGradeDbl = -1;
outMesStr = "Please input the grade of accounting: ";
Console.Write(outMesStr);
inputMesStr = Console.ReadLine();
accGradeDbl=Convert.ToDouble(inputMesStr);
if (accGradeDbl >= 90 )
{
    accLetterGradCh = 'A';
    accPointValDbl = 4;
}
else if (accGradeDbl>= 80)
{
    accLetterGradCh = 'B';
    accPointValDbl = 3;
}
else if (accGradeDbl >=70)
{
    accLetterGradCh = 'C';
    accPointValDbl = 2;
}
else if (accGradeDbl>=60)
{
    accLetterGradCh = 'D';
    accPointValDbl = 1;
}
else 
{
    accLetterGradCh = 'F';
    accPointValDbl = 0;
}

// Marketing
int markCreditHoursInt = 3;
int markPointValDbl=-1;
char markLetterGradCh = 'E';
double markGradeDbl = -1;
outMesStr = "Please input the grade of marketing:";
Console.Write(outMesStr);
inputMesStr=Console.ReadLine();
markGradeDbl=Convert.ToDouble(inputMesStr);
if (markGradeDbl >= 90)
{
    markLetterGradCh = 'A';
    markPointValDbl = 4;
}
else if (markGradeDbl >= 80)
{
    markLetterGradCh = 'B';
    markPointValDbl = 3;
}
else if (markGradeDbl >= 70)
{
    markLetterGradCh = 'C';
    markPointValDbl = 2;
}
else if (markGradeDbl >= 60)
{
    markLetterGradCh = 'D';
    markPointValDbl = 1;
}
else
{
    markLetterGradCh = 'F';
    markPointValDbl = '0';
}

// Economics
int econCreditHoursInt = 3;
int econPointValDbl = -1;
char econLetterGradCh = 'E';
double econGradeDbl = -1;
outMesStr = "Please input the grade of economics:";
Console.Write(outMesStr);
inputMesStr = Console.ReadLine();
econGradeDbl = Convert.ToDouble(inputMesStr);
if (econGradeDbl >= 90)
{
    econLetterGradCh = 'A';
    econPointValDbl = 4;
}
else if (econGradeDbl >= 80)
{
    econLetterGradCh = 'B';
    econPointValDbl = 3;
}
else if (econGradeDbl >= 70)
{
    econLetterGradCh = 'C';
    econPointValDbl = 2;
}
else if (econGradeDbl >= 60)
{
    econLetterGradCh = 'D';
    econPointValDbl = 1;
}
else
{
    econLetterGradCh = 'F';
    econPointValDbl = '0';
}

// MIS
int misCreditHoursInt = 3;
int misPointValDbl = -1;
char misLetterGradCh = 'E';
double misGradeDbl = -1;
outMesStr = "Please input the grade of MIS:";
Console.Write(outMesStr);
inputMesStr = Console.ReadLine();
misGradeDbl = Convert.ToDouble(inputMesStr);
if (misGradeDbl >= 90)
{
    misLetterGradCh = 'A';
    misPointValDbl = 4;
}
else if (misGradeDbl >= 80)
{
    misLetterGradCh = 'B';
    misPointValDbl = 3;
}
else if (misGradeDbl >= 70)
{
    misLetterGradCh = 'C';
    misPointValDbl = 2;
}
else if (misGradeDbl >= 60)
{
    misLetterGradCh = 'D';
    misPointValDbl = 1;
}
else
{
    misLetterGradCh = 'F';
    misPointValDbl = '0';
}



// overall GPA
overGPADbl = (accPointValDbl * accCreditHoursInt + markPointValDbl * markCreditHoursInt + econPointValDbl * econCreditHoursInt
    + misPointValDbl * misCreditHoursInt)*1.0 / (accCreditHoursInt + markCreditHoursInt + econCreditHoursInt + misCreditHoursInt);
outMesStr = "The letter grades:";
Console.WriteLine("\n");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of Accounting: {accLetterGradCh}");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of Marketing: {markLetterGradCh}");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of Economics: {econLetterGradCh}");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of MIS: {misLetterGradCh}");
Console.WriteLine(outMesStr);

// overall GPA
outMesStr = String.Format($"Overall GPA: {overGPADbl:F2}");
Console.WriteLine();
Console.WriteLine(outMesStr);


Console.ReadLine();