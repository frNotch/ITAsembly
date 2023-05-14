using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnCode_1._0
{
    public partial class JohnCode : Form
    {
        static int stackd = 1000;
        int AH = 0, AL = 0, BH = 0, BL = 0, CH = 0, CL = 0, DH = 0, DL = 0;
        int CS = 0, IP = 0, SS = 0, SP = 0, BP = 0, SI = 0, DI = 0, DS = 0, ES = 0;
        Int32[,] stack = new Int32[2, stackd];
        string[,] etichette = new string[2, 10];
        string confronto = "";
        int i = 0, s = 0;
        int PC = 0;
        Boolean SBS = false;
        private static bool check = false;
        public string NomeFile = "";
        public string TestoIniziale = "";

        private void JohnCode_Load(object sender, EventArgs e)
        {
            titolo("Nuovo file");
            StackUpdate();
            azzerastack();
        }
        public JohnCode()
        {
            InitializeComponent();
        }
       
        void salva()
        {

            {
                SalvaFile.ShowDialog();
                try
                {
                    if (SalvaFile.FileName != null)
                    {
                        System.IO.File.WriteAllText(SalvaFile.FileName, AreaTesto.Text);
                        NomeFile = SalvaFile.FileName;
                    }
                }
                catch { }
            }
        }
        void Controllo()
        {
            if (AH > 255)
            {
                AH = AH - 256;
            }
            if (AL > 255)
            {
                AL = AL - 256;
            }
            if (BH > 255)
            {
                BH = BH - 256;
            }
            if (BL > 255)
            {
                BL = BL - 256;
            }
            if (CH > 255)
            {
                CH = CH - 256;
            }
            if (CL > 255)
            {
                CL = CL - 256;
            }
            if (DH > 255)
            {
                DH = DH - 256;
            }
            if (DL > 255)
            {
                DL = DL - 256;
            }
            AHB.Text = (Convert.ToString(AH));
            ALB.Text = (Convert.ToString(AL));
            BHB.Text = (Convert.ToString(BH));
            BLB.Text = (Convert.ToString(BL));
            CHB.Text = (Convert.ToString(CH));
            CLB.Text = (Convert.ToString(CL));
            DHB.Text = (Convert.ToString(DH));
            DLB.Text = (Convert.ToString(DL));
        }
        private int var(String variabile)
        {
            if (variabile == "AH")
            {
                return AH;
            }
            else if (variabile == "AL")
            {
                return AL;
            }
            else if (variabile == "BH")
            {
                return BH;
            }
            else if (variabile == "BL")
            {
                return BL;
            }
            else if (variabile == "CH")
            {
                return CH;
            }
            else if (variabile == "CL")
            {
                return CL;
            }
            else if (variabile == "DH")
            {
                return DH;
            }
            else if (variabile == "DL")
            {
                return DL;
            }
            else
            {
                return 0;
            }
        }

        private void ControlloTesto()
        {
            if (AreaTesto.Text != TestoIniziale)
            {
                DialogResult risposta = MessageBox.Show("Vuoi salvare?", "Salva", MessageBoxButtons.YesNo);
                try
                {
                    if (risposta == DialogResult.Yes)
                    {
                        TestoIniziale = "";
                        salva();
                    }
                    if (risposta == DialogResult.No)
                    {
                        TestoIniziale = "";
                    }
                }
                catch { }
            }
        }
        private void titolo(string TitoloFile)
        {
            this.Text = "JohnCode - " + TitoloFile;
        }
        public void StackUpdate()
        {
            StackView.Clear();
            for (int r = 0; r < stackd; r++)
            {
                StackView.Items.Add("[" + stack[0, r].ToString("x4") + "] " + Convert.ToString(stack[1, r]));
            }
        }
        public void azzerastack()
        {
            for (int r = 0; r < stackd; r++)
            {
                stack[0, r] = Convert.ToInt32(r);
                stack[1, r] = 0;
            }
        }
        public void ipupdate()
        {
            IPB.Text = PC.ToString();
        }
    
        private void AreaTesto_TextChanged(object sender, EventArgs e)
        {
            {
                nrighe.Text = AreaTesto.Lines.Count().ToString();
            }
        }
        private void Nuovo_Click(object sender, EventArgs e)
        {
            {
                ControlloTesto();
                AreaTesto.Text = ("");
                NomeFile = "";
                titolo("Nuovo File");
            }

        }
        private void Esci_Click(object sender, EventArgs e)
        {
            {
                ControlloTesto();
                Application.Exit();
            }
        }
        private void Apri_Click(object sender, EventArgs e)
        {

            ControlloTesto();
            ApriFile.ShowDialog();

            if (ApriFile.FileName != null)
            {
                try
                {
                    AreaTesto.Text = System.IO.File.ReadAllText(ApriFile.FileName);
                    TestoIniziale = System.IO.File.ReadAllText(ApriFile.FileName);
                    NomeFile = ApriFile.FileName;
                    titolo(NomeFile);
                }
                catch { }


            }

        }
        private void Salva_Click(object sender, EventArgs e)
        {

            {

                if (NomeFile != "")
                {
                    try
                    {
                        if (SalvaFile.FileName != null)
                        {

                            System.IO.File.WriteAllText(NomeFile, AreaTesto.Text);
                        }
                    }
                    catch { }
                }
                else
                {
                    salva();
                }
            }
        }
        private void Salvaconnome_Click(object sender, EventArgs e)
        {
            salva();
        }

        private void Debug_Click(object sender, EventArgs e)
        { 
            i = 0;
            s = 0;
            int inizio = 0;
            int ultimok = 0;
            azzerastack();
        
            if(NomeFile != "")
            {
                try
                {
                    if (SalvaFile.FileName != null)
                    {
                        
                        System.IO.File.WriteAllText(NomeFile, AreaTesto.Text);
                    }
                }
                catch { }
            }
            else
            {
                salva();
            }
            string Program = AreaTesto.Text;
            char separatorerighe = Convert.ToChar("\n");
            char separatoreriga = Convert.ToChar(" ");
            char separatoreetichette = Convert.ToChar(":");
            string[] righe = Program.Split(separatorerighe);
            for (int k = 0; k < righe.Length; k++)
            {
                if (righe[k].Contains(":"))
                {
                    IP = +2;
                    string[] riga = righe[k].Split(separatoreriga);

                    etichette[0, i] = righe[k].Substring(0, righe[k].Length - 1);
                    etichette[1, i] = Convert.ToString(k);
                    //MessageBox.Show(etichette[0, i] + " " + etichette[1, i]);
                    i++;

                }
                if (righe[k].Contains("Inizio"))
                {
                    inizio = k;
                }
            }
            for (int k = inizio; k < righe.Length; k++)
            {
                string[] riga = righe[k].Split(separatoreriga);

                if (riga[0] == "Muovi" && riga[2] == "in")
                {
                    if (riga[1].Contains("[") && riga[1].Contains("]"))
                    {
                        int var1 = 0;
                        string parola = riga[1];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        for (int j = 0; j < stackd; j++)
                        {
                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                var1 = stack[1, j];
                            }
                        }
                        variabile(riga[3]) = var1;
                    }
                    else if (riga[3].Contains("[") && riga[3].Contains("]"))
                    {
                        int pos = 0;
                        int rip = 0;
                        string parola = riga[3];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        rip = variabile(riga[1]);
                        for (int j = 0; j < stackd; j++)
                        {

                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                stack[1, j] = rip;
                            }
                        }
                    }
                    else if (int.TryParse(riga[1], out i))
                    {
                        variabile(riga[3])= Convert.ToInt16(riga[1]);
                    }
                    else
                    {
                        int ValVar = var(riga[1]);

                        variabile(riga[3]) = ValVar;
                    }
                    PC = +3;
                    Controllo();
                }
                else if (riga[0] == "Aggiungi" && riga[2] == "a")
                {
                    if (riga[1].Contains("[") && riga[1].Contains("]"))
                    {
                        int var1 = 0;
                        string parola = riga[1];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        for (int j = 0; j < stackd; j++)
                        {
                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                var1 = stack[1, j];
                            }


                        }

                        variabile(riga[3]) = variabile(riga[3]) + var1;
                    }
                    else if (riga[3].Contains("[") && riga[3].Contains("]"))
                    {
                        int pos = 0;
                        int rip = 0;
                        string parola = riga[3];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        rip = variabile(riga[1]);
                        for (int j = 0; j < stackd; j++)
                        {

                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                stack[1, j] = stack[1, j] + rip;
                            }
                        }
                    }
                    else if (int.TryParse(riga[1], out i))
                    {
                        variabile(riga[3]) = variabile(riga[3]) + Convert.ToInt16(riga[1]);
                    }
                    else
                    {
                        int ValVar = var(riga[1]);
                        variabile(riga[3]) = variabile(riga[3]) + ValVar;
                    }
                    PC = +3;
                    Controllo();
                }
                else if (riga[0] == "Sottrai" && riga[2] == "a")
                {
                    if (riga[1].Contains("[") && riga[1].Contains("]"))
                    {
                        int var1 = 0;
                        string parola = riga[1];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        for (int j = 0; j < stackd; j++)
                        {
                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                var1 = stack[1, j];
                            }
                        }

                        variabile(riga[3]) = variabile(riga[3]) - var1;
                    }
                    else if (riga[3].Contains("[") && riga[3].Contains("]"))
                    {
                        int pos = 0;
                        int rip = 0;
                        string parola = riga[3];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        rip = variabile(riga[1]);
                        for (int j = 0; j < stackd; j++)
                        {

                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                stack[1, j] = stack[1, j] - rip;
                            }
                        }
                    }
                    bool risultato = int.TryParse(riga[1], out i);
                    if (risultato == true)
                    {
                        variabile(riga[3])= variabile(riga[3]) - Convert.ToInt16(riga[1]);
                    }
                    else
                    {
                        int ValVar = var(riga[1]);
                        variabile(riga[3]) = variabile(riga[3]) - ValVar;
                    }
                    PC = +3;
                    Controllo();
                }
                else if (riga[0] == "Salta" && riga[1] == "a")
                {
                    for (int z = 0; z < i; z++)
                    {
                        if (etichette[0, z] == riga[2])
                        {
                            k = Convert.ToInt16(etichette[1, z]);
                        }
                    }
                    PC = +2;
                }
                else if (riga[0] == "Confronto" && riga[1] == "tra" && riga[3] == "e")
                {
                    int reg1 = var(riga[2]);
                    int reg2 = var(riga[4]);

                    if (reg1 > reg2)
                    {
                        confronto = "reg1>reg2";
                    }
                    else if (reg1 == reg2)
                    {
                        confronto = "reg1==reg2";
                    }
                    else
                    {
                        confronto = "reg1<reg2";
                    }
                    PC = +3;
                }
                else if (riga[0] == "Salto" && riga[1] == "MDZ" && riga[2] == "a")
                {
                    if (confronto == "reg1>reg2")
                    {
                        for (int z = 0; z < i; z++)
                        {
                            if (etichette[0, z] == riga[2])
                            {
                                k = Convert.ToInt16(etichette[1, z]);
                            }
                        }
                    }
                    PC = +2;
                }
                else if (riga[0] == "Salto" && riga[1] == "UAZ" && riga[2] == "a")
                {
                    if (confronto == "reg1==reg2")
                    {
                        for (int z = 0; z < i; z++)
                        {

                            if (etichette[0, z] == riga[2])
                            {
                                k = Convert.ToInt16(etichette[1, z]);
                            }
                        }
                    }
                    PC = +2;
                }
                else if (riga[0] == "Salto" && riga[1] == "mDZ" && riga[2] == "a")
                {
                    if (confronto == "reg1<reg2")
                    {
                        for (int z = 0; z < i; z++)
                        {

                            if (etichette[0, z] == riga[2])
                            {
                                k = Convert.ToInt16(etichette[1, z]);
                            }
                        }
                    }
                    PC = +2;
                }
                else if (riga[0] == "Incrementa")
                {
                    variabile(riga[1])++;
                    PC = +2;
                    Controllo();
                }
                else if (riga[0] == "Decrementa")
                {
                    variabile(riga[1])--;
                    PC = +2;
                    Controllo();
                }
                else if (riga[0] == "Stacka")
                {
                    int n;
                    if (int.TryParse(riga[1], out n))
                        stack[1, s] = Convert.ToByte(riga[1]);
                    else
                    {
                        stack[1, s] = Convert.ToByte(variabile(riga[1]));
                    }
                    s++;
                    PC = +2;
                    StackUpdate();
                }
                else if (riga[0] == "Poppa")
                {
                    int varpop = stack[1, k - 2];
                    variabile(riga[1]) = varpop;
                    PC = +2;
                }
                else if (riga[0] == "Fine")
                {
                    PC = +1;
                    StackUpdate();
                    return;
                }
                else if (riga[0] == "Chiama")
                {
                    for (int z = 0; z < i; z++)
                    {
                        if (etichette[0, z] == riga[1])
                        {
                            ultimok = k;
                            k = Convert.ToInt32(etichette[1, z]);
                        }
                    }
                    PC = +2;
                }
                else if (riga[0] == "FineFunzione")
                {
                    k = ultimok;
                    PC = +1;
                }
                else if (riga[0] == "Inizio")
                {
                    PC = +1;
                }
                else
                {
                    MessageBox.Show("Errore alla riga " + k);
                    return;
                }
                ipupdate();
                check = false;
            }

        }

        public ref int variabile(string Var){
            
            if (Var == "AH"){
                return ref AH;
            }
            else if (Var == "AL")
            {
                return ref AL;
            }
            else if (Var == "BH")
            {
                return ref BH;
            }
            else if (Var == "BL")
            {
                return ref BL;
            }
            else if (Var == "CH")
            {
                return ref CH;
            }
            else if (Var == "CL")
            {
                return ref CL;
            }
            else if (Var == "DH")
            {
                return ref DH;
            }
            else if (Var == "DL")
            {
                return ref DL;
            }
            else
            {
                return ref AH;
            }
            
        }


    }
}
