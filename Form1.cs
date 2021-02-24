using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace win1
{
    public partial class Form1 : Form
    {
        class Global
        {
            public static char[] AC = new char[16];
            public static char[] DR = new char[16];
            public static char[] IR = new char[16];
            public static char[] TR = new char[16];
            public static char[] AR = new char[12];
            public static char[] PC = new char[12];
            public static char[] INPR = new char[8];
            public static char[] OUTR = new char[8];
            public static char[] E = new char[1];
            public static char[] I = new char[1];
            public static char[] HEX = new char[4];
            public static char[] OPCode = new char[3];
            public static char[] OPdecode = new char[4];
            public static int SC;
            public static int FGI;
            public static int FGO;
            public static int IEN;
            public static int step_flag;
            public static int hlt_flag;
            public static int run_flag;
            public static int org_int;
            public static int counter;
            public static string line;
            public static Dictionary<string, string> LABEL = new Dictionary<string, string>();  //  label name                address hexadecimal
            public static Dictionary<string, string> VALUE = new Dictionary<string, string>();  //  label name                value hexadecimal
            public static Dictionary<string, string> ADDRESS = new Dictionary<string, string>();//  memory address hex        value hexadecimal
            public static String[] strlist;
            public static String[] strlist_2;
        }
        public Form1()
        {
            InitializeComponent();
            //AllocConsole();
            
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.clear, "Clear Code Box");
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.compile, "Compile!");
            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.pause, "Pause");
            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip4.SetToolTip(this.next, "Next Step");
            System.Windows.Forms.ToolTip ToolTip5 = new System.Windows.Forms.ToolTip();
            ToolTip5.SetToolTip(this.all, "Run All");
            System.Windows.Forms.ToolTip ToolTip6 = new System.Windows.Forms.ToolTip();
            ToolTip6.SetToolTip(this.save, "Save as");
            System.Windows.Forms.ToolTip ToolTip7 = new System.Windows.Forms.ToolTip();
            ToolTip7.SetToolTip(this.open, "Open");
            System.Windows.Forms.ToolTip ToolTip8 = new System.Windows.Forms.ToolTip();
            ToolTip8.SetToolTip(this.about, "About me");
            System.Windows.Forms.ToolTip ToolTip9 = new System.Windows.Forms.ToolTip();
            ToolTip9.SetToolTip(this.stop, "Stop");
        }


        public string Hex_to_bin(string hexvalue)
        {
            string binaryval = "";
            binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
            return binaryval;
        }
        public string Bin_to_hex(string str)
        {
            string hexval = "";
            hexval = Convert.ToUInt16(str, 2).ToString("X4");
            return hexval;
        }
        public string Dec_to_hex(string str)
        {
            if(str[0]!='-')
            {
                int decval = Convert.ToInt32(str);
                string hexval = (decval).ToString("X");
                return hexval;
            }
            else
            {
                short decval = Convert.ToInt16(str);
                Int16 d = decval;
                string s = Convert.ToString(d, 2);
                s = Bin_to_hex(s);
                return s;
            }
           
        }
        public string Hex_to_dec(string str)
        {
            int num;
            num = int.Parse(str, System.Globalization.NumberStyles.HexNumber);
            string decval = num.ToString();
            return decval;
        }


        string make_string(string s)
        {
            if (s.Length == 0)
                s = "000" + s;
            if (s.Length == 1)
                s = "00" + s;
            if (s.Length == 2)
                s = "0" + s;
            return s;
        }
        string make16(string a)
        {
            int l = a.Length;
            string s = "";
            for (int i = 0; i < 16 - l; i++)
                s += "0";
            a = s + a;
            return a;
        }
        string make4(string s)
        {
            if (s.Length == 0)
                s = "0000" + s;
            if (s.Length == 1)
                s = "000" + s;
            if (s.Length == 2)
                s = "00" + s;
            if (s.Length == 3)
                s = "0" + s;
            return s;
        }
        string make3(string s)
        {
            if (s.Length == 0)
                s = "000" + s;
            if (s.Length == 1)
                s = "00" + s;
            if (s.Length == 2)
                s = "0" + s;
            return s;
        }


        void show_registers()
        {
            string pcs = new string(Global.PC);
            pcs = make3(pcs);
            string acs = new string(Global.AC);
            acs = make4(acs);
            string irs = new string(Global.IR);
            irs = make4(irs);
            string opdecodes = new string(Global.OPdecode);
            string drs = new string(Global.DR);
            drs = make4(drs);
            string ars = new string(Global.AR);
            ars = make3(ars);
            string es = new string(Global.E);
            string iss = new string(Global.I);
            string inprs = new string(Global.INPR);
            string outrs = new string(Global.OUTR);
            string opcodes = new string(Global.OPCode);

            line.Text = String.Format(Global.line);
            pc.Text = String.Format(pcs);
            ac.Text = String.Format(acs);
            ir.Text = String.Format(irs);
            decode.Text = String.Format(opdecodes);
            dr.Text = String.Format(drs);
            ar.Text = String.Format(ars);
            e.Text = String.Format(es);
            i.Text = String.Format(iss);
            ien.Text = String.Format(Global.IEN.ToString());
            fgo.Text = String.Format(Global.FGO.ToString());
            fgi.Text = String.Format(Global.FGI.ToString());
            sc.Text = String.Format(Global.SC.ToString());
            outr.Text = String.Format(outrs);
            opcode.Text = String.Format(opcodes);
            inpr.Text = String.Format(inprs);
        }
        void prepare()
        {
            Global.E = "0".ToCharArray();
            String s = code.Text;
            String str = code.Text;

            String[] spearator = { " ", "\n" };
            Int32 count = 100000000;
            Global.strlist = str.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);//word by word

            String[] spearator_2 = { "\n" };
            Int32 count_2 = 100000000;
            //string org;
            //Global.org_int = 0;
            /*if (Global.strlist[0] == "ORG")
            {
                org = Global.strlist[1];
                Global.org_int = int.Parse(org, System.Globalization.NumberStyles.HexNumber);
            }*/
            Global.strlist_2 = str.Split(spearator_2, count_2, StringSplitOptions.RemoveEmptyEntries);//line by line

            //start
            Global.org_int = 0;
            Global.PC = "0".ToCharArray();
            Global.counter = 0;
        }
        void run_func()
        {
            string strstr;
            int w;
            w = Global.counter;
            while((w < Global.strlist_2.Length)&& Global.step_flag == 1)
            {
                if (Global.step_flag == 1)
                {
                    int inst = 0, name = 0, dirc = 0;
                    String[] spearator_3 = { " " };
                    Int32 count_3 = 100000000;
                    String[] ins = Global.strlist_2[w].Split(spearator_3, count_3, StringSplitOptions.RemoveEmptyEntries);//check
                    if (ins[0] == "ORG")
                    {
                        Global.org_int = Int32.Parse(Hex_to_dec(ins[1]));

                        //org_int = org_int - 1;
                        Global.PC = ins[1].ToCharArray();
                        Global.counter += 1;
                        Global.line = Global.strlist_2[w];
                        show_registers();
                    }
                    else if (Global.strlist_2[w].IndexOf(',') > -1)
                    {
                        inst = 1;
                        name = 2;
                    }
                    else if (Global.strlist_2[w].IndexOf(',') == -1)
                    {
                        inst = 0;
                        name = 1;
                    }
                    //register reference instructions
                    if (ins[inst] == "CLA")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        strstr = "0";
                        Global.OPCode = "111".ToCharArray();
                        strstr = make4(strstr);
                        Global.AC = strstr.ToCharArray();
                        Global.SC = 3;
                        Global.HEX = "7800".ToCharArray();
                        Global.I = "0".ToCharArray();
                        Global.OPdecode = "rB11".ToCharArray();
                        Global.AR = "800".ToCharArray();
                        Global.IR = "7800".ToCharArray();
                        show_registers();
                    }
                    else if (ins[inst] == "CLE")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        Global.OPCode = "111".ToCharArray();
                        strstr = "0";
                        Global.E = strstr.ToCharArray();
                        Global.SC = 3;
                        Global.HEX = "7400".ToCharArray();
                        Global.I = "0".ToCharArray();
                        Global.OPdecode = "rB10".ToCharArray();
                        Global.AR = "400".ToCharArray();
                        Global.IR = "7400".ToCharArray();
                        show_registers();
                    }
                    else if (ins[inst] == "CMA")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        string s2 = new string(Global.AC);
                        string SD = new string(Global.AC);
                        string bin = Hex_to_bin(SD);
                        int k;
                        bin = make16(bin);
                        char[] temp = bin.ToCharArray();
                        for (k = 0; k < bin.Length; k++)
                            if (bin[k] == '0')
                                temp[k] = '1';
                            else if (bin[k] == '1')
                                temp[k] = '0';
                        
                        string st = new string(temp);
                        string temp2 = Bin_to_hex(st);
                        temp2 = make4(temp2);
                        Global.AC = temp2.ToCharArray();
                        Global.SC = 3;
                        Global.HEX = "7200".ToCharArray();
                        Global.I = "0".ToCharArray();
                        Global.OPdecode = "rB9".ToCharArray();
                        Global.OPCode = "111".ToCharArray();
                        Global.AR = "200".ToCharArray();
                        Global.IR = "7200".ToCharArray();
                        show_registers();
                    }
                    else if (ins[inst] == "CME")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        string s2 = new string(Global.E);
                        int c = Int32.Parse(s2);
                        if (s2 == "0")
                            Global.E="1".ToCharArray();
                        if (s2 == "1")
                            Global.E = "0".ToCharArray();
                        Global.SC = 3;
                        Global.HEX = "7100".ToCharArray();
                        Global.I = "0".ToCharArray();
                        Global.OPdecode = "rB8".ToCharArray();
                        Global.OPCode = "111".ToCharArray();
                        Global.AR = "100".ToCharArray();
                        Global.IR = "7100".ToCharArray();
                        show_registers();
                    }
                    else if (ins[inst] == "CIR")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        string s = new string(Global.AC);
                        string bf = Hex_to_bin(s);
                        bf = make16(bf);
                        string eee = new string(Global.E);
                        bf = eee + bf;


                        int  ite;
                        char temporary;
                        char[] arr = bf.ToCharArray();
                        for (ite = 0; ite < 17 - 1; ite++)
                        {
                            temporary = arr[ite + 1];
                            arr[ite + 1] = arr[0];
                            arr[0] = temporary;
                        }
                        char[] chstr = new char[16];
                        for (int k = 1; k < 17; k++)
                            chstr[k - 1] = arr[k];
                        Global.E = arr[0].ToString().ToCharArray();


                        /*bf = Hex_to_dec(Bin_to_hex(bf));
                        int input = Int32.Parse(bf);
                        int result = input >> 1 | input << (16);
                        string da = result.ToString();
                        da = Hex_to_bin(Dec_to_hex(da));
                        Global.E = da[0].ToString().ToCharArray();
                        char[] chstr = new char[16];
                        for (int k = 1; k < 17; k++)
                            chstr[k - 1] = da[k];*/

                        string gk = new string(chstr);
                        Global.AC = Bin_to_hex(gk).ToCharArray();

                        Global.SC = 3;
                        Global.HEX = "7080".ToCharArray();
                        Global.I = "0".ToCharArray();
                        Global.OPdecode = "rB7".ToCharArray();
                        Global.OPCode = "111".ToCharArray();
                        Global.AR = "080".ToCharArray();
                        Global.IR = "7080".ToCharArray();
                        show_registers();
                    }
                    else if (ins[inst] == "CIL")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        string s = new string(Global.AC);
                        string bf = Hex_to_bin(s);
                        bf = make16(bf);
                        string eee = new string(Global.E);
                        bf = eee + bf;

                        int ite;
                        char temporary;
                        char[] arr = bf.ToCharArray();
                        for (int ii = 0; ii < 16; ii++)
                        {
                            for (ite = 0; ite < 17 - 1; ite++)
                            {
                                temporary = arr[ite + 1];
                                arr[ite + 1] = arr[0];
                                arr[0] = temporary;
                            }
                        }
                       
                        char[] chstr = new char[16];
                        for (int k = 1; k < 17; k++)
                            chstr[k - 1] = arr[k];
                        Global.E = arr[0].ToString().ToCharArray();


                        /*bf = Hex_to_dec(Bin_to_hex(bf));
                        int input = Int32.Parse(bf);
                        int result = input << 1 | input >> (16);
                        string da = result.ToString();
                        da = Hex_to_bin(Dec_to_hex(da));
                        Global.E = da[0].ToString().ToCharArray();
                        char[] chstr =new char[16];
                        for (int k = 1; k < 17; k++)
                            chstr[k-1] = da[k];*/

                        string gk = new string(chstr);
                        Global.AC = Bin_to_hex(gk).ToCharArray();

                        
                        Global.SC = 3;
                        Global.HEX = "7040".ToCharArray();
                        Global.I = "0".ToCharArray();
                        Global.OPdecode = "rB6".ToCharArray();
                        Global.OPCode = "111".ToCharArray();
                        Global.AR = "040".ToCharArray();
                        Global.IR = "7040".ToCharArray();
                        show_registers();
                    }
                    else if (ins[inst] == "INC")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        string tmp = new string(Global.AC);
                        if (tmp == "ffff"|| tmp == "FFFF")
                        {
                            Global.AC = "1".ToCharArray();
                            Global.E = "1".ToCharArray();
                        }
                        else
                        {
                            string s2 = new string(Global.AC);
                            string s3 = Hex_to_dec(s2);
                            int c = Int32.Parse(s3);
                            int d = c + 1;
                            string hex = Dec_to_hex(d.ToString());
                            Global.AC = hex.ToCharArray();
                        }
                        Global.SC = 3;
                        Global.HEX = "7020".ToCharArray();
                        Global.I = "0".ToCharArray();
                        Global.OPdecode = "rB5".ToCharArray();
                        Global.OPCode = "111".ToCharArray();
                        Global.AR = "020".ToCharArray();
                        Global.IR = "7020".ToCharArray();
                        show_registers();
                    }
                    else if (ins[inst] == "SPA")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        Global.HEX = "7010".ToCharArray();
                        Global.I = "0".ToCharArray();
                        Global.OPdecode = "rB4".ToCharArray();
                        Global.OPCode = "111".ToCharArray();
                        Global.AR = "010".ToCharArray();
                        Global.IR = "7010".ToCharArray();
                        string sq = new string(Global.AC);
                        sq = Hex_to_bin(sq);
                        sq = make16(sq);
                        if (sq[0]=='0')
                        {
                            string s2 = new string(Global.PC);
                            s2 = Hex_to_dec(s2);
                            int c = Int32.Parse(s2);
                            int d = c + 1;
                            s2 = d.ToString();
                            s2 = Dec_to_hex(s2);
                            Global.PC = s2.ToCharArray();
                            Global.counter += 1;

                        }
                        show_registers();
                    }
                    else if (ins[inst] == "SNA")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.SC = 3;
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        Global.HEX = "7008".ToCharArray();
                        Global.I = "0".ToCharArray();
                        Global.OPdecode = "rB3".ToCharArray();
                        Global.OPCode = "111".ToCharArray();
                        Global.AR = "008".ToCharArray();
                        Global.IR = "7008".ToCharArray();
                        string sq = new string(Global.AC);
                        sq = Hex_to_bin(sq);
                        sq = make16(sq);
                        if (sq[0] == '1')
                        {
                            string s2 = new string(Global.PC);
                            s2 = Hex_to_dec(s2);
                            int c = Int32.Parse(s2);
                            int d = c + 1;
                            s2 = d.ToString();
                            s2 = Dec_to_hex(s2);
                            Global.PC = s2.ToCharArray();
                            Global.counter += 1;
                        }

                        show_registers();
                    }
                    else if (ins[inst] == "SZA")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.SC = 3;
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        Global.HEX = "7004".ToCharArray();
                        Global.I = "0".ToCharArray();
                        Global.OPdecode = "rB2".ToCharArray();
                        Global.OPCode = "111".ToCharArray();
                        Global.AR = "004".ToCharArray();
                        Global.IR = "7004".ToCharArray();
                        string sq = new string(Global.AC);
                        sq = Hex_to_bin(sq);
                        sq = make16(sq);
                        if (sq == "0000000000000000")
                        {
                            string s2 = new string(Global.PC);
                            s2 = Hex_to_dec(s2);
                            int c = Int32.Parse(s2);
                            int d = c + 1;
                            s2 = d.ToString();
                            s2 = Dec_to_hex(s2);
                            Global.PC = s2.ToCharArray();
                            Global.counter += 1;
                        }
                        show_registers();
                    }
                    else if (ins[inst] == "SZE")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.SC = 3;
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        Global.HEX = "7002".ToCharArray();
                        Global.I = "0".ToCharArray();
                        Global.OPdecode = "rB1".ToCharArray();
                        Global.OPCode = "111".ToCharArray();
                        Global.AR = "002".ToCharArray();
                        Global.IR = "7002".ToCharArray();
                        if (Global.E[0] == '0')
                        {
                            string s2 = new string(Global.PC);
                            s2 = Hex_to_dec(s2);
                            int c = Int32.Parse(s2);
                            int d = c + 1;
                            s2 = d.ToString();
                            s2 = Dec_to_hex(s2);
                            Global.PC = s2.ToCharArray();
                            Global.counter += 1;
                        }
                        show_registers();
                    }
                    else if (ins[inst] == "HLT")
                    {
                        Global.hlt_flag = 1;
                        string strhlt = "";
                        line.Text = String.Format(strhlt);
                        pc.Text = String.Format(strhlt);
                        ac.Text = String.Format(strhlt);
                        ir.Text = String.Format(strhlt);
                        decode.Text = String.Format(strhlt);
                        dr.Text = String.Format(strhlt);
                        ar.Text = String.Format(strhlt);
                        e.Text = String.Format(strhlt);
                        i.Text = String.Format(strhlt);
                        ien.Text = String.Format(strhlt);
                        fgo.Text = String.Format(strhlt);
                        fgi.Text = String.Format(strhlt);
                        sc.Text = String.Format(strhlt);
                        outr.Text = String.Format(strhlt);
                        opcode.Text = String.Format(strhlt);
                        inpr.Text = String.Format(strhlt);

                        open.Enabled = true;
                        save.Enabled = true;
                        about.Enabled = true;
                        clear.Enabled = true;
                        compile.Enabled = true;
                        stop.Enabled = false;
                        next.Enabled = false;
                        all.Enabled = false;
                        pause.Enabled = false;

                        Global.AC = "".ToCharArray();
                        Global.DR = "".ToCharArray();
                        Global.IR = "".ToCharArray();
                        Global.TR = "".ToCharArray();
                        Global.AR = "".ToCharArray();
                        Global.PC = "".ToCharArray();
                        Global.E = "".ToCharArray();
                        Global.I = "".ToCharArray();
                        Global.HEX = "".ToCharArray();
                        Global.OPCode = "".ToCharArray();
                        Global.OPdecode = "".ToCharArray();
                        Global.INPR = "".ToCharArray();
                        Global.OUTR = "".ToCharArray();
                        Global.counter = 0;
                        Global.org_int = 0;
                        Global.line = "";
                        Global.SC = 0;
                        Global.FGI = 0;
                        Global.FGO = 0;
                        Global.IEN = 0;
                        Global.step_flag = 0;
                        Global.hlt_flag = 0;
                        Global.run_flag = 0;

                        Global.LABEL.Clear();
                        Global.VALUE.Clear();
                        Global.ADDRESS.Clear();

                        Array.Clear(Global.strlist, 0, Global.strlist.Length);
                        Array.Clear(Global.strlist_2, 0, Global.strlist_2.Length);


                        break;
                    }
                    //memory reference instructions
                    else if (ins[inst] == "AND")
                    {
                        Global.line = Global.strlist_2[w];
                        if ((ins.Length == 3 && ins[2] != "I") || (ins.Length == 2)) //directed
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 5;
                            Global.OPCode = "000".ToCharArray();
                            Global.OPdecode = "D0".ToCharArray();
                            string fs=make_string(Global.LABEL[ins[name]]);
                            string str1 = "0" + fs;
                            Global.HEX = str1.ToCharArray();
                            Global.AR = Global.LABEL[ins[name]].ToCharArray();
                            Global.DR = Global.VALUE[ins[name]].ToCharArray();
                            Global.IR = str1.ToCharArray();
                            Global.I = "0".ToCharArray();

                            char[] str_tmp = new char[16];
                            int k;
                            string ss1 = new string(Global.DR);
                            string ss2 = new string(Global.AC);

                            string str_dr = Hex_to_bin(ss1);
                            string str_ac = Hex_to_bin(ss2);
                            str_dr = make16(str_dr);
                            str_ac = make16(str_ac);
                            for(k=0;k<16;k++)
                            {
                                if (str_dr[k] == '0' || str_ac[k] == '0')
                                    str_tmp[k] = '0';
                                else if (str_dr[k] == '1' && str_ac[k] == '1')
                                    str_tmp[k] = '1';
                            }
                            string h = new string(str_tmp);
                            h = Bin_to_hex(h);
                            Global.AC = h.ToCharArray();
                        }
                        else if ((ins.Length == 4) || (ins.Length == 3 && ins[2] == "I")) //indirected
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 5;
                            Global.OPCode = "000".ToCharArray();
                            Global.OPdecode = "D0".ToCharArray();
                            string fs = make_string(Global.LABEL[ins[name]]);

                            string str1 = "8" + fs;
                            Global.HEX = str1.ToCharArray();
                            Global.AR = Global.VALUE[ins[name]].ToCharArray();
                            string xs = new string(Global.AR);
                            Global.DR = Global.ADDRESS[xs].ToCharArray();
                            Global.IR = str1.ToCharArray();
                            Global.I = "1".ToCharArray();

                            char[] str_tmp = new char[16];
                            int k;
                            string ss1 = new string(Global.DR);
                            string ss2 = new string(Global.AC);

                            string str_dr = Hex_to_bin(ss1);
                            string str_ac = Hex_to_bin(ss2);
                            str_dr = make16(str_dr);
                            str_ac = make16(str_ac);
                            for (k = 0; k < 16; k++)
                            {
                                if (str_dr[k] == '0' || str_ac[k] == '0')
                                    str_tmp[k] = '0';
                                else if (str_dr[k] == '1' && str_ac[k] == '1')
                                    str_tmp[k] = '1';
                            }
                            string h = new string(str_tmp);
                            h = Bin_to_hex(h);
                            Global.AC = h.ToCharArray();
                        }
                        show_registers();
                    }
                    else if (ins[inst] == "ADD")
                    {
                        Global.line = Global.strlist_2[w];
                        if ((ins.Length == 3 && ins[2]!="I") || (ins.Length == 2))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 5;
                            Global.OPCode = "001".ToCharArray();
                            Global.OPdecode = "D1".ToCharArray();
                            string str1 = "1" + Global.LABEL[ins[name]];
                            Global.HEX = str1.ToCharArray();
                            Global.AR = Global.LABEL[ins[name]].ToCharArray();
                            Global.DR = Global.VALUE[ins[name]].ToCharArray();
                            Global.IR = str1.ToCharArray();
                            Global.I = "0".ToCharArray();

                            string s2 = new string(Global.AC);
                            s2 = Hex_to_dec(s2);
                            int c = Int32.Parse(s2);
                            int ac = c;
                            string s3 = new string(Global.DR);
                            s3 = Hex_to_dec(s3);
                            int d = Int32.Parse(s3);
                            int dr = d;
                            
                            ac = ac + dr;
                            int e = 0;
                            if (ac > 65535)
                            {
                                e = 1;
                                ac -= 65535;
                                Global.E = e.ToString().ToCharArray();
                            }
                            Global.AC = Dec_to_hex(ac.ToString()).ToCharArray();
                            //Global.E = e.ToString().ToCharArray();
                        }
                        if ((ins.Length == 4) || (ins.Length==3 && ins[2]=="I"))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 5;
                            Global.OPCode = "001".ToCharArray();
                            Global.OPdecode = "D1".ToCharArray();
                            string str1 = "9" + Global.LABEL[ins[name]];
                            Global.HEX = str1.ToCharArray();
                            Global.AR = Global.VALUE[ins[name]].ToCharArray();
                            string fq = new string(Global.AR);
                            
                            Global.DR = Global.ADDRESS[fq].ToCharArray();
                            Global.IR = str1.ToCharArray();
                            Global.I = "1".ToCharArray();

                            string s2 = new string(Global.AC);
                            s2 = Hex_to_dec(s2);
                            int c = Int32.Parse(s2);
                            int ac = c;
                            string s3 = new string(Global.DR);
                            s3 = Hex_to_dec(s3);
                            int d = Int32.Parse(s3);
                            int dr = d;

                            ac = ac + dr;
                            int e = 0;
                            if (ac > 65535)
                            {
                                e = 1;
                                ac -= 65535;
                                Global.E = e.ToString().ToCharArray();
                            }
                            Global.AC = Dec_to_hex(ac.ToString()).ToCharArray();
                        }
                        show_registers();
                    }
                    else if (ins[inst] == "LDA")
                    {
                        Global.line = Global.strlist_2[w];
                        if ((ins.Length == 3 && ins[2] != "I") || (ins.Length == 2))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 5;
                            Global.OPCode = "010".ToCharArray();
                            Global.OPdecode = "D2".ToCharArray();
                            string fs = make_string(Global.LABEL[ins[name]]);

                            string str1 = "2" + fs;
                            Global.HEX = str1.ToCharArray();
                            Global.AR = Global.LABEL[ins[name]].ToCharArray();
                            Global.DR = Global.VALUE[ins[name]].ToCharArray();
                            Global.IR = str1.ToCharArray();
                            Global.I = "0".ToCharArray();
                            Global.AC = Global.DR;
                        }
                        if ((ins.Length == 4) || (ins.Length == 3 && ins[2] == "I"))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 5;
                            Global.OPCode = "010".ToCharArray();
                            Global.OPdecode = "D2".ToCharArray();
                            string fs = make_string(Global.LABEL[ins[name]]);

                            string str1 = "A" + fs;
                            Global.HEX = str1.ToCharArray();
                            Global.AR = Global.VALUE[ins[name]].ToCharArray();
                            string fq = new string(Global.AR);
                            Global.DR = Global.ADDRESS[fq].ToCharArray();
                            Global.IR = str1.ToCharArray();
                            Global.I = "1".ToCharArray();
                            Global.AC = Global.DR;
                        }
                        show_registers();
                    }
                    else if (ins[inst] == "STA")
                    {
                        Global.line = Global.strlist_2[w];
                        if ((ins.Length == 3 && ins[2] != "I") || (ins.Length == 2))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 4;
                            Global.OPCode = "011".ToCharArray();
                            Global.OPdecode = "D3".ToCharArray();
                            string fs = make_string(Global.LABEL[ins[name]]);

                            string str1 = "B" + fs;
                            Global.HEX = str1.ToCharArray();
                            Global.IR = str1.ToCharArray();
                            Global.AR = Global.LABEL[ins[name]].ToCharArray();
                            string acc = new string(Global.AC);
                            Global.VALUE[ins[name]] = acc;//////
                            Global.I = "0".ToCharArray();
                        }
                        else if ((ins.Length == 4) || (ins.Length == 3 && ins[2] == "I"))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 4;
                            Global.OPCode = "011".ToCharArray();
                            Global.OPdecode = "D3".ToCharArray();
                            string fs = make_string(Global.LABEL[ins[name]]);

                            string str1 = "C" + fs;
                            Global.HEX = str1.ToCharArray();
                            Global.IR = str1.ToCharArray();
                            Global.AR = Global.VALUE[ins[name]].ToCharArray();
                            string fq = new string(Global.AR);
                            string h = new string(Global.AC);
                            Global.ADDRESS[fq] = h;
                            Global.I = "1".ToCharArray();
                            string myKey = Global.LABEL.FirstOrDefault(x => x.Value == fq).Key;
                            Global.VALUE[myKey] = h;
                        }
                        show_registers();
                    }
                    else if (ins[inst] == "BUN")
                    {
                        Global.line = Global.strlist_2[w];
                        if ((ins.Length == 3 && ins[2] != "I") || (ins.Length == 2))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();

                            Global.counter = Global.counter + 1;

                            Global.SC = 4;
                            Global.OPCode = "100".ToCharArray();
                            Global.OPdecode = "D4".ToCharArray();
                            string fs = make_string(Global.LABEL[ins[name]]);

                            string str1 = "4" + fs;
                            Global.HEX = str1.ToCharArray();
                            Global.AR = Global.LABEL[ins[name]].ToCharArray();
                            //Global.DR = Global.VALUE[ins[name]].ToCharArray();
                            Global.IR = str1.ToCharArray();
                            Global.I = "0".ToCharArray();
                            if (Global.org_int > 0)
                            {
                                string sss = new string(Global.AR);
                                sss = Hex_to_dec(sss);
                                int c = Int32.Parse(sss);

                                w = c - Global.org_int + 1;
                                Global.counter = w;
                                Global.PC = (Global.AR);
                            }
                            else
                            {
                                string sss = new string(Global.AR);
                                sss = Hex_to_dec(sss);
                                int c = Int32.Parse(sss);
                                w = c;
                                Global.counter = w;
                                Global.PC = Global.AR;
                            }
                        }
                        else if ((ins.Length == 4) || (ins.Length == 3 && ins[2] == "I"))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 4;
                            Global.OPCode = "100".ToCharArray();
                            Global.OPdecode = "D4".ToCharArray();
                            string fs = make_string(Global.LABEL[ins[name]]);

                            string str1 = "C" + fs;
                            Global.HEX = str1.ToCharArray();
                            Global.AR = Global.VALUE[ins[name]].ToCharArray();
                            //Global.DR = Global.ADDRESS[Global.AR.ToString()].ToCharArray();
                            Global.IR = str1.ToCharArray();
                            Global.I = "1".ToCharArray();
                            if (Global.org_int > 0)
                            {
                                string sss = new string(Global.AR);
                                sss = Hex_to_dec(sss);
                                int c = Int32.Parse(sss);

                                w = c - Global.org_int + 1;
                                Global.counter = w;
                                int zx = c + 1;//Global.org_int;
                                sss = Dec_to_hex(sss);
                                Global.PC = sss.ToCharArray();
                            }
                            else
                            {
                                string sss = new string(Global.AR);
                                sss = Hex_to_dec(sss);
                                int c = Int32.Parse(sss);

                                //w = c - Global.org_int + 1;
                                w = c;
                                Global.counter = w;
                                Global.PC = (Global.AR);
                            }
                        }
                        show_registers();
                    }
                    else if (ins[inst] == "BSA")
                    {
                        Global.line = Global.strlist_2[w];
                        if ((ins.Length == 3 && ins[2] != "I") || (ins.Length == 2))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 4;
                            Global.OPCode = "101".ToCharArray();
                            Global.OPdecode = "D5".ToCharArray();
                            string fs = make_string(Global.LABEL[ins[name]]);

                            string str1 = "5" + fs;
                            Global.HEX = str1.ToCharArray();
                            Global.IR = str1.ToCharArray();

                            Global.AR = Global.LABEL[ins[name]].ToCharArray();

                            string s2 = new string(Global.AR);
                            s2 = Hex_to_dec(s2);
                            int c = Int32.Parse(s2);

                            int ar = c + 1;
                            Global.AR = ar.ToString().ToCharArray();
                            string s33 = new string(Global.PC);

                            Global.VALUE[ins[name]] = s33;
                            Global.PC = Global.AR;
                            if (Global.org_int > 0)
                            {
                                w = ar - Global.org_int + 1;
                                Global.counter = w;
                            }
                            else
                            {
                                w = ar;
                                Global.counter = w;
                            }
                            Global.DR = Global.VALUE[ins[name]].ToCharArray();
                            Global.I = "0".ToCharArray();
                        }
                        else if ((ins.Length == 4) || (ins.Length == 3 && ins[2] == "I"))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 4;
                            Global.OPCode = "101".ToCharArray();
                            Global.OPdecode = "D5".ToCharArray();
                            string fs = make_string(Global.LABEL[ins[name]]);

                            string str1 = "5" + fs;
                            Global.HEX = str1.ToCharArray();
                            Global.IR = str1.ToCharArray();

                            Global.AR = Global.LABEL[ins[name]].ToCharArray();

                            string s2 = new string(Global.AR);
                            s2 = Hex_to_dec(s2);
                            int c = Int32.Parse(s2);

                            int ar = c + 1;
                            Global.AR = ar.ToString().ToCharArray();
                            string s33 = new string(Global.PC);

                            Global.VALUE[ins[name]] = s33;
                            Global.PC = Global.AR;
                            if (Global.org_int > 0)
                            {
                                w = ar - Global.org_int + 1;
                                Global.counter = w;
                            }
                            else
                            {
                                w = ar;
                                Global.counter = w;
                            }
                            Global.DR = Global.VALUE[ins[name]].ToCharArray();
                            Global.I = "0".ToCharArray();
                        }
                        show_registers();
                    }
                    else if (ins[inst] == "ISZ")
                    {
                        Global.line = Global.strlist_2[w];
                        if ((ins.Length == 3 && ins[2] != "I") || (ins.Length == 2))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 4;
                            Global.OPCode = "110".ToCharArray();
                            Global.OPdecode = "D6".ToCharArray();
                            string fs = make_string(Global.LABEL[ins[name]]);

                            string str1 = "6" + fs;
                            Global.IR = str1.ToCharArray();
                            Global.HEX = str1.ToCharArray();
                            Global.AR = Global.LABEL[ins[name]].ToCharArray();
                            Global.DR = Global.VALUE[ins[name]].ToCharArray();

                            string s2 = new string(Global.DR);
                            s2 = Hex_to_dec(s2);
                            int c = Int32.Parse(s2);

                            int dr = c;
                            dr += 1;
                            string s4 = dr.ToString();
                            s4 = Dec_to_hex(s4);
                            if (s4 == "10000")
                                s4 = "0000";
                            Global.DR = s4.ToCharArray();
                            Global.VALUE[ins[name]] = s4.ToString();
                            Global.ADDRESS[Global.LABEL[ins[name]]]= s4.ToString();
                            if (dr == 65536)
                            {
                                string s3 = new string(Global.PC);
                                s3 = Hex_to_dec(s3);
                                int bbb = Int32.Parse(s3);

                                int aa = bbb + 1;
                                s3 = aa.ToString();
                                s3 = Dec_to_hex(s3);
                                Global.PC = s3.ToCharArray();
                                w++;
                                w++;
                                Global.counter = w;
                            }
                            Global.I = "0".ToCharArray();
                        }
                        if ((ins.Length == 4) || (ins.Length == 3 && ins[2] == "I"))
                        {
                            string s1 = new string(Global.PC);
                            s1 = Hex_to_dec(s1);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            s1 = a.ToString();
                            s1 = Dec_to_hex(s1);
                            Global.PC = s1.ToCharArray();
                            Global.counter = Global.counter + 1;
                            Global.SC = 4;
                            Global.OPCode = "110".ToCharArray();
                            Global.OPdecode = "D6".ToCharArray();
                            string fs = make_string(Global.LABEL[ins[name]]);

                            string str1 = "E" + fs;
                            Global.IR = str1.ToCharArray();
                            Global.HEX = str1.ToCharArray();
                            Global.AR = Global.VALUE[ins[name]].ToCharArray();
                            string ssss = new string(Global.AR);
                            Global.DR = Global.ADDRESS[ssss].ToCharArray();

                            string ss = new string(Global.DR);
                            ss = Hex_to_dec(ss);
                            int c = Int32.Parse(ss);

                            int dr = c;
                            dr += 1;
                            ss = dr.ToString();
                            ss = Dec_to_hex(ss);
                            if (ss == "10000")
                                ss = "0000";
                            Global.DR = ss.ToCharArray();
                            //Global.VALUE[Global.AR.ToString()] = ss;
                            string sar = new string(Global.AR);
                            Global.ADDRESS[sar] = ss;
                            if (dr == 65536)
                            {
                                string s3= new string(Global.PC);
                                s3 = Hex_to_dec(s3);
                                int d = Int32.Parse(s3);

                                int aa = d + 1;
                                s3 = aa.ToString();
                                s3 = Dec_to_hex(s3);
                                Global.PC = s3.ToCharArray();
                                w++;
                                w++;
                                Global.counter = w;
                            }
                            Global.I = "1".ToCharArray();
                        }
                        show_registers();
                    }
                    //IO reference instruction
                    else if (ins[inst] == "INP")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        Global.OPCode = "111".ToCharArray();
                        Global.SC = 3;
                        Global.HEX = "F800".ToCharArray();
                        Global.I = "1".ToCharArray();
                        Global.OPdecode = "pB11".ToCharArray();
                        Global.AR = "800".ToCharArray();
                        Global.IR = "F800".ToCharArray();
                        for (int q = 0; q < 8; q++)
                        {
                            Global.AC[q] = Global.INPR[q];
                        }
                        Global.FGI = 0;
                        show_registers();
                    }
                    else if (ins[inst] == "OUT")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        Global.OPCode = "111".ToCharArray();
                        Global.SC = 3;
                        Global.HEX = "F400".ToCharArray();
                        Global.I = "1".ToCharArray();
                        Global.OPdecode = "pB10".ToCharArray();
                        Global.AR = "400".ToCharArray();
                        Global.IR = "F400".ToCharArray();
                        for (int q = 0; q < 8; q++)
                        {
                            Global.OUTR[q] = Global.AC[q];
                        }
                        Global.FGO = 0;
                        show_registers();
                    }
                    else if (ins[inst] == "SKI")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        Global.OPCode = "111".ToCharArray();
                        Global.SC = 3;
                        Global.HEX = "F200".ToCharArray();
                        Global.I = "1".ToCharArray();
                        Global.OPdecode = "pB9".ToCharArray();
                        Global.AR = "200".ToCharArray();
                        Global.IR = "F200".ToCharArray();
                        if (Global.FGI == 1)
                        {
                            w++;
                            string ss = new string(Global.PC);
                            int c = Int32.Parse(ss);
                            int aa = c + 1;
                            Global.PC = aa.ToString().ToCharArray();
                            Global.counter = w;
                        }
                        show_registers();
                    }
                    else if (ins[inst] == "SKO")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        Global.OPCode = "111".ToCharArray();
                        Global.SC = 3;
                        Global.HEX = "F100".ToCharArray();
                        Global.I = "1".ToCharArray();
                        Global.OPdecode = "pB8".ToCharArray();
                        Global.AR = "100".ToCharArray();
                        Global.IR = "F100".ToCharArray();
                        if (Global.FGO == 1)
                        {
                            w++;
                            string s2 = new string(Global.PC);
                            int c = Int32.Parse(s2);
                            int aa = c + 1;
                            Global.PC = aa.ToString().ToCharArray();
                            Global.counter=w;
                        }
                        show_registers();
                    }
                    else if (ins[inst] == "ION")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        Global.OPCode = "111".ToCharArray();
                        Global.SC = 3;
                        Global.HEX = "F080".ToCharArray();
                        Global.I = "1".ToCharArray();
                        Global.OPdecode = "pB7".ToCharArray();
                        Global.AR = "80".ToCharArray();
                        Global.IR = "F080".ToCharArray();
                        Global.IEN = 1;
                        show_registers();
                    }
                    else if (ins[inst] == "IOF")
                    {
                        Global.line = Global.strlist_2[w];
                        string s1 = new string(Global.PC);
                        s1 = Hex_to_dec(s1);
                        int b = Int32.Parse(s1);
                        int a = b + 1;
                        s1 = a.ToString();
                        s1 = Dec_to_hex(s1);
                        Global.PC = s1.ToCharArray();
                        Global.counter = Global.counter + 1;
                        Global.OPCode = "111".ToCharArray();
                        Global.SC = 3;
                        Global.HEX = "F040".ToCharArray();
                        Global.I = "1".ToCharArray();
                        Global.OPdecode = "pB6".ToCharArray();
                        Global.AR = "40".ToCharArray();
                        Global.IR = "F040".ToCharArray();
                        Global.IEN = 0;
                        show_registers();
                    }
                    else if(Global.hlt_flag==0)
                    {
                        Global.line = Global.strlist_2[w];
                        String[] spearator_4 = { " ", "," };
                        Int32 count_4 = 100000000;
                        String[] lbl = Global.strlist_2[w].Split(spearator_4, count_4, StringSplitOptions.RemoveEmptyEntries);//check
                        if (Global.LABEL.ContainsKey(lbl[0]))
                        {
                            string s1 = new string(Global.PC);
                            int b = Int32.Parse(s1);
                            int a = b + 1;
                            Global.PC = a.ToString().ToCharArray();
                            Global.counter += 1;
                            show_registers();
                        }
                        else
                        {
                            MessageBox.Show("Invalid instruction!", "Warning!");
                            System.Environment.Exit(0);
                        }
                    }
                   
                    Global.step_flag = 0;

                }
            }
        }
        void run_all()
        {
            while (Global.hlt_flag == 0 && Global.run_flag == 1)
            {
                Thread.Sleep(2000);
                Global.step_flag = 1;
                run_func();
                Application.DoEvents();
            }
        }

        public void SaveMyFile()
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files (*.rtf)|*.rtf";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                code.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        public void LoadMyFile()
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                code.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void Open_Click(object sender, EventArgs e)
        {
            open.Enabled = true;
            save.Enabled = true;
            about.Enabled = true;
            clear.Enabled = true;
            compile.Enabled = true;
            stop.Enabled = false;
            next.Enabled = false;
            all.Enabled = false;
            pause.Enabled = false;
            LoadMyFile();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveMyFile();
        }
        private void About_Click(object sender, EventArgs e)
        {
            string message = "Farzaneh Koohestani"+"\n"+"Studens at Isfahan University of Thechnology"+"\n"+"Department of Electrical and Computer Engineering";
            string title = "About me";
            MessageBox.Show(message, title);
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            open.Enabled = true;
            save.Enabled = true;
            about.Enabled = true;
            clear.Enabled = true;
            compile.Enabled = true;
            stop.Enabled = false;
            next.Enabled = false;
            all.Enabled = false;
            pause.Enabled = false;

            code.Text = "";

        }
        private void Compile_Click(object sender, EventArgs e)
        {
            open.Enabled = false;
            save.Enabled = true;
            about.Enabled = true;
            clear.Enabled = false;
            compile.Enabled = false;
            stop.Enabled = true;
            next.Enabled = true;
            all.Enabled = true;
            pause.Enabled = false;

            String s = code.Text;
            String str = code.Text;

            if(s=="")
            {
                MessageBox.Show("First enter the desired code...", "Warning!");
                System.Environment.Exit(0);
            }

            String[] spearator = { " ", "\n" };
            Int32 count = 100000000;
            String[] strlist = str.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);//word by word

            String[] spearator_2 = { "\n" };
            Int32 count_2 = 100000000;
            string org;
            int org_int = 0;
            if (strlist[0] == "ORG")
            {
                org = strlist[1];
                org_int = int.Parse(org, System.Globalization.NumberStyles.HexNumber);
            }
            String[] strlist_2 = str.Split(spearator_2, count_2, StringSplitOptions.RemoveEmptyEntries);//line by line
            int flag = 0,emp=0;
            //prepare dictionarys
            for (int i = 0; i < strlist_2.Length; i++)
            {
                String[] spearator_g = { " " };
                Int32 count_g = 100000000;
                String[] strlist_g = strlist_2[i].Split(spearator_g, count_g, StringSplitOptions.RemoveEmptyEntries);

                if (strlist_g[0] == "ORG")
                {
                    if (flag == 0)
                        flag = 1;
                    else
                        emp=i;
                    org = strlist_g[1];
                    org_int = int.Parse(org, System.Globalization.NumberStyles.HexNumber);
                }
                if (strlist_2[i].IndexOf(',') > -1)
                {
                    String[] spearator_l = { "," };
                    int count_l = 100000000;
                    String[] strlist_l = strlist_2[i].Split(spearator_l, count_l, StringSplitOptions.RemoveEmptyEntries);
                    if (org_int > 0)
                        Global.LABEL.Add(strlist_l[0], (org_int + i - 1).ToString("X")); //label name , label address
                    else
                        Global.LABEL.Add(strlist_l[0], (i).ToString("X")); //label name , label address

                    if (strlist_g.Length > 2)
                    {
                        string hexval = "0";
                        if (strlist_g[1] == "HEX")
                        {
                            hexval = strlist_g[2];
                            Global.VALUE.Add(strlist_l[0], hexval);  //label name , decimal value
                        }
                        if (strlist_g[1] == "DEC")
                        {
                            hexval = Dec_to_hex(strlist_g[2]);
                            Global.VALUE.Add(strlist_l[0], hexval);  //label name , decimal value
                        }
                        if (org_int > 0)
                            Global.ADDRESS.Add((org_int + i - 1).ToString("X"), hexval);   //address   value
                        else
                            Global.ADDRESS.Add((i).ToString("X"), hexval);   //address   value
                    }

                }
                if (strlist_g[0] == "DEC")
                {
                    string hexadecimal = Dec_to_hex(strlist_g[1]);
                    if (org_int > 0 && flag==0)
                        Global.ADDRESS.Add((org_int + i - 1).ToString("X"), hexadecimal);   //address   value
                    else if (org_int == 0 && flag == 0)
                        Global.ADDRESS.Add((i).ToString("X"), hexadecimal);   //address   value
                    else if (org_int > 0 && flag == 1)
                        Global.ADDRESS.Add((org_int + i - 1-emp).ToString("X"), hexadecimal);   //address   value
                    
                }
                if (strlist_g[0] == "HEX")
                {
                    if (org_int > 0)
                        Global.ADDRESS.Add((org_int + i - 1).ToString("X"), strlist_g[1]);   //address   value
                    else
                        Global.ADDRESS.Add((i).ToString("X"), strlist_g[1]);
                }
            }


            Global.hlt_flag = 0;
            Global.run_flag = 0;
            prepare();
            Global.step_flag = 1;
            run_func();
        }
        private void Stop_Click(object sender, EventArgs eee)
        {
            open.Enabled = true;
            save.Enabled = true;
            about.Enabled = true;
            clear.Enabled = true;
            compile.Enabled = true;
            stop.Enabled = false;
            next.Enabled = false;
            all.Enabled = false;
            pause.Enabled = false;

            string strhlt = "";
            line.Text = String.Format(strhlt);
            pc.Text = String.Format(strhlt);
            ac.Text = String.Format(strhlt);
            ir.Text = String.Format(strhlt);
            decode.Text = String.Format(strhlt);
            dr.Text = String.Format(strhlt);
            ar.Text = String.Format(strhlt);
            e.Text = String.Format(strhlt);
            i.Text = String.Format(strhlt);
            ien.Text = String.Format(strhlt);
            fgo.Text = String.Format(strhlt);
            fgi.Text = String.Format(strhlt);
            sc.Text = String.Format(strhlt);
            outr.Text = String.Format(strhlt);
            opcode.Text = String.Format(strhlt);
            inpr.Text = String.Format(strhlt);

            Global.AC = "".ToCharArray();
            Global.DR = "".ToCharArray();
            Global.IR = "".ToCharArray();
            Global.TR = "".ToCharArray();
            Global.AR = "".ToCharArray();
            Global.PC = "".ToCharArray();
            Global.E = "".ToCharArray();
            Global.I= "".ToCharArray();
            Global.HEX= "".ToCharArray();
            Global.OPCode= "".ToCharArray();
            Global.OPdecode= "".ToCharArray();
            Global.INPR= "".ToCharArray();
            Global.OUTR= "".ToCharArray();
            Global.counter = 0;
            Global.org_int = 0;
            Global.line = "";
            Global.SC = 0;
            Global.FGI = 0;
            Global.FGO = 0;
            Global.IEN = 0;
            Global.step_flag = 0;
            Global.hlt_flag = 0;
            Global.run_flag = 0;

            Global.LABEL.Clear();
            Global.VALUE.Clear();
            Global.ADDRESS.Clear();

            Array.Clear(Global.strlist, 0, Global.strlist.Length);
            Array.Clear(Global.strlist_2, 0, Global.strlist_2.Length);
            

        }
        private void Next_Click(object sender, EventArgs e)
        {
            open.Enabled = false;
            save.Enabled = true;
            about.Enabled = true;
            clear.Enabled = false;
            compile.Enabled = false;
            stop.Enabled = true;
            next.Enabled = true;
            all.Enabled = true;
            pause.Enabled = false;

            Global.step_flag = 1;
            run_func();
        }
        private void All_Click(object sender, EventArgs e)
        {
            open.Enabled = false;
            save.Enabled = true;
            about.Enabled = true;
            clear.Enabled = true;
            compile.Enabled = false;
            stop.Enabled = true;
            next.Enabled = false;
            all.Enabled = false;
            pause.Enabled = true;

            Global.run_flag = 1;
            run_all();
            
        }
        private void Pause_Click(object sender, EventArgs e)
        {
            open.Enabled = false;
            save.Enabled = true;
            about.Enabled = true;
            clear.Enabled = false;
            compile.Enabled = false;
            stop.Enabled = true;
            next.Enabled = true;
            all.Enabled = true;
            pause.Enabled = false;

            Global.run_flag = 0;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}