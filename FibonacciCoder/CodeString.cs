using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCoder
{
    struct Symbol
    {
        public char Name { get; set; }
        public string Coding { get; set; }
    }
    class CodeString
    {
        private string string_to_code;
        public List<Symbol> Unique_symbol_list;
        List<int> FibonacciNumber;
        Symbol s;
        public CodeString(string String_to_code)
        {
            string_to_code = String_to_code;
            Unique_symbol_list = new List<Symbol>();
            FibonacciNumber = new List<int>();
        }
        public string GetCodedString()
        {
            GetUnicueSymbols();
            GetSymbolFrequency();
            FillFibonacciNumber();
            FormSymbolCode();
            return FormString();
        }
        private void GetUnicueSymbols()
        {
            for(int i = 0; i < string_to_code.Length; i++)
            {
                if(!IsExist(string_to_code[i]))
                {
                    Symbol s = new Symbol();
                    s.Name = string_to_code[i];
                    Unique_symbol_list.Add(s);
                }
            }
        }
        private bool IsExist(char ch)
        {
            for(int j = 0; j < Unique_symbol_list.Count; j++)
            {
                if(Unique_symbol_list[j].Name == ch)
                {
                    return true;
                }
            }
            return false;
        }
        private void GetSymbolFrequency()
        {
            int[] SymbolCounter = new int[Unique_symbol_list.Count];
            for (int i = 0; i < string_to_code.Length; i++)
            {
                for (int j = 0; j < Unique_symbol_list.Count; j++)
                {
                    if (Unique_symbol_list[j].Name == string_to_code[i])
                    {
                        SymbolCounter[j]++;
                    }
                }
            }
            for(int i = 0; i < SymbolCounter.Length - 1; i++)
            {
                for(int j = i + 1; j < SymbolCounter.Length; j++)
                if(SymbolCounter[i] < SymbolCounter[j])
                {
                    s = Unique_symbol_list[i];
                    Unique_symbol_list[i] = Unique_symbol_list[j];
                    Unique_symbol_list[j] = s;
                    int tmp = SymbolCounter[i];
                    SymbolCounter[i] = SymbolCounter[j];
                    SymbolCounter[j] = tmp;
                }
            }
        }
        private void FillFibonacciNumber()
        {
            FibonacciNumber.Add(1);
            if(Unique_symbol_list.Count == 1)
            {
                return;
            }
            FibonacciNumber.Add(2);
            for (int i = 1; FibonacciNumber[i] + FibonacciNumber[i - 1] <= Unique_symbol_list.Count; i++)
            {
                FibonacciNumber.Add(FibonacciNumber[i] + FibonacciNumber[i - 1]);
            }
        }
        private void FormSymbolCode()
        {
            s = Unique_symbol_list[0];
            string codestring = "0";
            s.Coding = codestring;
            Unique_symbol_list[0] = s;
            int j = 1;
            for (int i = 1; i < FibonacciNumber.Count - 1; i++)
            {
                int col = j + FibonacciNumber[i + 1] - FibonacciNumber[i];
                codestring += "0";
                for(; j < col; j++)
                {
                    s = Unique_symbol_list[j];
                    s.Coding = codestring;
                    Unique_symbol_list[j] = s;
                }
            }
            codestring += "0";
            for (;j < Unique_symbol_list.Count; j++)
            {
                s = Unique_symbol_list[j];
                s.Coding = codestring;
                Unique_symbol_list[j] = s;
            }
            int l;
            for (int i = 0; i < Unique_symbol_list.Count; i++)
            {
                int rating = i + 1;
                s = Unique_symbol_list[i];
                while (rating!=0)
                {
                    for (l = FibonacciNumber.Count - 1; l >= 0; l--)
                    {
                        if (rating >= FibonacciNumber[l])
                        {
                            break;
                        }
                    }
                    rating -= FibonacciNumber[l];
                    s.Coding = ReplaseSymbol(s.Coding, '1', l);
                }
                s.Coding += "1";
                Unique_symbol_list[i] = s;
            }
        }
        private string FormString()
        {
            string codedstring = "";
            for(int i = 0; i < string_to_code.Length; i++)
            {
                for(int j = 0; j < Unique_symbol_list.Count; j++)
                {
                    if(string_to_code[i] == Unique_symbol_list[j].Name)
                    {
                        codedstring += Unique_symbol_list[j].Coding;
                    }
                }
            }
            return codedstring;
        }
        private string ReplaseSymbol(string source, char ch, int position)
        {
            string finalstring = "";
            for(int i = 0; i < source.Length; i++)
            {
                if(i == position)
                {
                    finalstring += ch;
                }
                else
                {
                    finalstring += source[i];
                }
            }
            return finalstring;
        }
    }
}
