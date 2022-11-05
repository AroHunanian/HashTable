using Hash_Table;
string a = "11001001110100111101010100011100";
string b = "01101011000100111001110101011010";
string SumBin = string.Empty;
long sumDec = 0;
StringToBinary.SumBin(a, b,out SumBin,out sumDec);

Console.WriteLine(SumBin);
Console.WriteLine(sumDec); 

