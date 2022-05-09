
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;




namespace QueuingSystem
{
    public partial class Mainform : Form
    {
        

        int NoCust;
        int[] Customers;
        string[] interarrivaltime;
        double[] ProbabilityOfInterTime;
        string[] Servicetime;
        double[] ProbOfServiceTime;
        double TotTmCustWitInQ;
        double NoOfCustWhoWit;
        double TotTimOFIdlServ;
        double TotRnTimOfSim;
        double TotServTim;
        double SmOfAllTimBetAriv;
        double NoOfAriv;
        double TotTimCustSpndInSys;
        int prcs = 0;

        class PobDist
        {
            public string PDME(string[] arr, double[] freq)
            {
                double QP = 0;
                int sum = 0;
                int l = 0;
                //  string mm = freq.Max().ToString();
                string[] rer = new string[freq.Length];
                for(int q = 0; q < freq.Length; q++)
                {
                    rer[q] = freq[q].ToString();
                }
                int maxind = 0;
                for (int q = 0; q < freq.Length; q++)
                {
                    if (rer[maxind].Length < rer[q].Length)
                    {
                        maxind = q;
                    }
                }
                //string ff = rer;
                int aa = rer[maxind].Length-2;
                string bb = "1";
                for( int gg = 0; gg < aa; gg++)
                {
                   bb = bb + "0";
                }
                int rr = Convert.ToInt32(bb);
                int tt = (int)freq.Sum() * rr;
                string[] rda = new string[tt + 1];

                for (int m = 0; m < freq.Length; m++)
                {
                    sum = (int)(sum + freq[m] * rr);
                    QP = (QP + freq[m]* rr);


                    for (int i = l + 1; i <= sum; i++)
                    {
                        rda[i] = arr[m];
                        l = i;
                    }
                }
                Random rnd = new Random();
                int index = rnd.Next(1, tt);

                return rda[index];
            }

        }

        /* Before this class was used to get the probability selection 
        class GFG
        {


            // Utility function to find ceiling
            // of r in arr[l..h]
            static int findCeil(int[] arr, int r,
                                int l, int h)
            {
                int mid;
                while (l < h)
                {

                    // Same as mid = (l+h)/2
                    mid = l + ((h - l) >> 1);

                    if (r > arr[mid])
                        l = mid + 1;
                    else
                        h = mid;
                }
                return (arr[l] >= r) ? l : -1;
            }

            // The main function that returns a random number
            // from arr[] according to distribution array
            // defined by freq[]. n is size of arrays.
          public  static int myRand(int[] arr, int[] freq, int n)
            {

                // Create and fill prefix array
                int[] prefix = new int[n];
                int i;
                prefix[0] = freq[0];

                for (i = 1; i < n; ++i)
                    prefix[i] = prefix[i - 1] + freq[i];

                // prefix[n-1] is sum of all frequencies.
                // Generate a random number with
                // value from 1 to this sum
                Random rand = new Random();
                int r = ((int)(rand.Next() * (323567)) %
                                prefix[n - 1]) + 1;

                // Find index of ceiling of r in prefix array
                int indexc = findCeil(prefix, r, 0, n - 1);
                return arr[indexc];
            }
        }
        */
            public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
        
            txtInterarrivalTm.Text = "1, 2, 3, 4, 5, 6, 7, 8";
            txtProbaOfInterTime.Text = "0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125";
            txtSrvcTime.Text = "1, 2, 3, 4, 5, 6";
            txtProbOfSrvcTime.Text = "0.10,0.20,0.30,0.25,0.10,0.05";
            txtNoCust.Text = "20";
        }

        // this method is to select according to prob but it is not used


        private void txtNoCust_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNoCust_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtNoCust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int Num = 0;
                NoCust = Convert.ToInt32(txtNoCust.Text);
                int index = dataGridView1.Rows.Add(NoCust-1);
                Customers = new int[NoCust];
                for (int i = 0 ;i<NoCust; i++)
                {
                    Num++;
                    Customers[i] = i + 1;
                    dataGridView1.Rows[i].Cells[0].Value = Num;
                }
               

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (e.KeyCode == Keys.Enter)
            {
                interarrivaltime = txtInterarrivalTm.Text.Split(',').Select(Int32.Parse).ToArray();//Convert.ToInt32(txtInterarrivalTm.Text.Split((' ')));
           
            }*/
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {/*
            if (e.KeyCode == Keys.Enter)
            {
                ProbabilityOfInterTime  =txtProbaOfInterTime.Text.Split(',').Select(Int32.Parse).ToArray();//Convert.ToInt32(txtInterarrivalTm.Text.Split((' ')));
            }
            */
        }

        private void btnStartSim_Click(object sender, EventArgs e)
        {
            prcs = 1; 
            interarrivaltime = txtInterarrivalTm.Text.Split(',');
            ProbabilityOfInterTime = txtProbaOfInterTime.Text.Split(',').Select(Double.Parse).ToArray();
            Servicetime = txtSrvcTime.Text.Split(',');
            ProbOfServiceTime = txtProbOfSrvcTime.Text.Split(',').Select(Double.Parse).ToArray();
      
            if (ProbabilityOfInterTime.Sum()==1 && ProbOfServiceTime.Sum()==1)
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    dataGridView1.Rows.Clear();
                    // dataGridView1.Rows.Remove(dataGridView1.Rows(NoCust));
                }

                NoCust = Convert.ToInt32(txtNoCust.Text);
                dataGridView1.Rows.Add(NoCust - 1);
                string[] intarivtim = new string[NoCust];
                string[] servtim = new string[NoCust];

                /* these 4 line were moved to the top to serve another purpose
                interarrivaltime = txtInterarrivalTm.Text.Split(',');
                ProbabilityOfInterTime = txtProbaOfInterTime.Text.Split(',').Select(Double.Parse).ToArray();
                Servicetime = txtSrvcTime.Text.Split(',');
                ProbOfServiceTime = txtProbOfSrvcTime.Text.Split(',').Select(Double.Parse).ToArray();
                
                string[] arr = interarrivaltime;//{ 1, 2, 3, 4, 5, 6, 7, 8 };
                double[] freq = ProbabilityOfInterTime;// { 125, 125, 125, 125, 125, 125, 125, 125 };
                int n = arr.Length;
                */
            
                PobDist nn = new PobDist();
                for (int i = 0; i < NoCust; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    intarivtim[i] = nn.PDME(interarrivaltime, ProbabilityOfInterTime);
                    Thread.Sleep(8);
                    servtim [i] = nn.PDME(Servicetime, ProbOfServiceTime);
                    Thread.Sleep(8);

                }
                
                /*for (int j = 0; j < NoCust; j++)
                {
                    dataGridView1.Rows[j].Cells[1].Value = ff[j];
                }
                */
                dataGridView1.Rows[0].Cells[1].Value = "-";
             /*   string[] arr1 = Servicetime; //{ 1, 2, 3, 4, 5, 6, 7, 8 };
                double[] freq1 = ProbOfServiceTime;// { 125, 125, 125, 125, 125, 125, 125, 125 };
                                                */

                for (int k = 0; k < NoCust; k++)
                {
                    dataGridView1.Rows[k].Cells[1].Value = intarivtim[k];
                    dataGridView1.Rows[k].Cells[3].Value = servtim[k];// ff[k] = nn.PDME(arr1, freq1);
                }
                /*
                for (int l = 0; l < NoCust; l++)
                {
                    dataGridView1.Rows[l].Cells[3].Value = ff[l];
                } */


                dataGridView1.Rows[0].Cells[2].Value = 0;
                dataGridView1.Rows[0].Cells[4].Value = 0;
                dataGridView1.Rows[0].Cells[1].Value = "-";

                // Validation part ( when you remove the comment it fills the table just like that in the notes and gets the calculations
                /*
                 dataGridView1.Rows[1].Cells[1].Value = 8;
                dataGridView1.Rows[2].Cells[1].Value = 6;
                dataGridView1.Rows[3].Cells[1].Value = 1;
                dataGridView1.Rows[4].Cells[1].Value = 8;
                dataGridView1.Rows[5].Cells[1].Value = 3;
                dataGridView1.Rows[6].Cells[1].Value = 8;
                dataGridView1.Rows[7].Cells[1].Value = 7;
                dataGridView1.Rows[8].Cells[1].Value = 2;
                dataGridView1.Rows[9].Cells[1].Value = 3;
                dataGridView1.Rows[10].Cells[1].Value = 1;
                dataGridView1.Rows[11].Cells[1].Value = 1;
                dataGridView1.Rows[12].Cells[1].Value = 5;
                dataGridView1.Rows[13].Cells[1].Value = 6;
                dataGridView1.Rows[14].Cells[1].Value = 3;
                dataGridView1.Rows[15].Cells[1].Value = 8;
                dataGridView1.Rows[16].Cells[1].Value = 1;
                dataGridView1.Rows[17].Cells[1].Value = 2;
                dataGridView1.Rows[18].Cells[1].Value = 4;
                dataGridView1.Rows[19].Cells[1].Value = 5;


                dataGridView1.Rows[0].Cells[3].Value = 4;
                dataGridView1.Rows[1].Cells[3].Value = 1;
                dataGridView1.Rows[2].Cells[3].Value = 4;
                dataGridView1.Rows[3].Cells[3].Value = 3;
                dataGridView1.Rows[4].Cells[3].Value = 2;
                dataGridView1.Rows[5].Cells[3].Value = 4;
                dataGridView1.Rows[6].Cells[3].Value = 5;
                dataGridView1.Rows[7].Cells[3].Value = 4;
                dataGridView1.Rows[8].Cells[3].Value = 5;
                dataGridView1.Rows[9].Cells[3].Value = 3;
                dataGridView1.Rows[10].Cells[3].Value = 3;
                dataGridView1.Rows[11].Cells[3].Value = 5;
                dataGridView1.Rows[12].Cells[3].Value = 4;
                dataGridView1.Rows[13].Cells[3].Value = 1;
                dataGridView1.Rows[14].Cells[3].Value = 5;
                dataGridView1.Rows[15].Cells[3].Value = 4;
                dataGridView1.Rows[16].Cells[3].Value = 3;
                dataGridView1.Rows[17].Cells[3].Value = 3;
                dataGridView1.Rows[18].Cells[3].Value = 2;
                dataGridView1.Rows[19].Cells[3].Value = 3;
                */
            }
            else
            {
                MessageBox.Show("Wrong probability!!");
            }
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Enter)
            {
                Servicetime =txtSrvcTime.Text.Split(',').Select(Int32.Parse).ToArray();//Convert.ToInt32(txtInterarrivalTm.Text.Split((' ')));
            }*/
        }

        private void txtProbOfSrvcTime_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Enter)
            {
                ProbOfServiceTime = txtProbOfSrvcTime.Text.Split(',').Select(Int32.Parse).ToArray();//Convert.ToInt32(txtInterarrivalTm.Text.Split((' ')));
            }
            */
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (prcs == 1 ) {
                prcs = 2;
                dataGridView1.Rows[0].Cells[5].Value = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value) + Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value);
                for (int i = 1; i < NoCust; i++)
                {
                    dataGridView1.Rows[i].Cells[2].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) + Convert.ToInt32(dataGridView1.Rows[i - 1].Cells[2].Value);
                }
                for (int j = 0; j < NoCust; j++)
                {
                    if (j > 0)
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[j - 1].Cells[5].Value) < Convert.ToInt32(dataGridView1.Rows[j].Cells[2].Value))
                        {
                            dataGridView1.Rows[j].Cells[4].Value = dataGridView1.Rows[j].Cells[2].Value;
                        }
                        else
                        {
                            dataGridView1.Rows[j].Cells[4].Value = dataGridView1.Rows[j - 1].Cells[5].Value;
                        }
                        dataGridView1.Rows[j].Cells[5].Value = Convert.ToInt32(dataGridView1.Rows[j].Cells[3].Value) + Convert.ToInt32(dataGridView1.Rows[j].Cells[4].Value);

                    }
                    dataGridView1.Rows[j].Cells[6].Value = Convert.ToInt32(dataGridView1.Rows[j].Cells[4].Value) - Convert.ToInt32(dataGridView1.Rows[j].Cells[2].Value);
                    dataGridView1.Rows[j].Cells[7].Value = Convert.ToInt32(dataGridView1.Rows[j].Cells[5].Value) - Convert.ToInt32(dataGridView1.Rows[j].Cells[2].Value);
                }
                dataGridView1.Rows[0].Cells[8].Value = 0;
                for (int i = 1; i < NoCust; i++)
                {
                    dataGridView1.Rows[i].Cells[8].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) - Convert.ToInt32(dataGridView1.Rows[i - 1].Cells[5].Value);
                }
            }
            else
            {
                MessageBox.Show("Press the button 'Start Probability fill' first.");
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (prcs == 2)
            {
                TotRnTimOfSim = Convert.ToDouble(dataGridView1.Rows[NoCust - 1].Cells[5].Value);
                NoOfAriv = NoCust - 1;
                for (int i = 0; i < NoCust; i++)
                {
                    TotTmCustWitInQ += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    TotTimOFIdlServ += Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
                    TotServTim += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    if (i > 0)
                        SmOfAllTimBetAriv += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                    TotTimCustSpndInSys += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);

                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value) > 0)
                    {
                        NoOfCustWhoWit++;
                    }
                }
                lbldom1.Text = TotTmCustWitInQ.ToString();
                lblNom1.Text = NoCust.ToString();
                lblRes1.Text = (TotTmCustWitInQ / NoCust).ToString();
                lbldom2.Text = NoOfCustWhoWit.ToString();
                lblNom2.Text = NoCust.ToString();
                lblRes2.Text = (NoOfCustWhoWit / NoCust).ToString();
                lblDom3.Text = TotTimOFIdlServ.ToString();
                lblNom3.Text = TotRnTimOfSim.ToString();
                lblRes3.Text = (TotTimOFIdlServ / TotRnTimOfSim).ToString();
                lblDom4.Text = TotServTim.ToString();
                lblNom4.Text = NoCust.ToString();
                lblRes4.Text = (TotServTim / NoCust).ToString();
                lblDom5.Text = SmOfAllTimBetAriv.ToString();
                lblNom5.Text = (NoCust - 1).ToString();
                lblRes5.Text = (SmOfAllTimBetAriv / (NoCust - 1)).ToString();
                lblDom6.Text = TotTmCustWitInQ.ToString();
                lblNom6.Text = NoOfCustWhoWit.ToString();
                lblRes6.Text = (TotTmCustWitInQ / NoOfCustWhoWit).ToString();
                lblDom7.Text = TotTimCustSpndInSys.ToString();
                lblNom7.Text = NoCust.ToString();
                lblRes7.Text = (TotTimCustSpndInSys / NoCust).ToString();

                TotTmCustWitInQ = 0;
                NoOfCustWhoWit = 0;
                TotTimOFIdlServ = 0;
                TotServTim = 0;
                SmOfAllTimBetAriv = 0;
                TotTmCustWitInQ = 0;
                TotTimCustSpndInSys = 0;
            }
            else
            {
                MessageBox.Show("Press the button 'Start Simulation' first.");
            }
        }

        private void btnExpExcel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }



    }
}
