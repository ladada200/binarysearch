using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearch
{
    public partial class frmBinSearch : Form
    {
        public frmBinSearch()
        {
            InitializeComponent();
        }

        private void frmBinSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Predefine the values of the Numeric up-downs.
            int NVal = (int)nudNVal.Value; int XVal = (int)nudXVal.Value;
            //Now we'll discern the following:
            
            functionGet(NVal, XVal);

            /*
             * Set LOW to 1 and HIGH to N - 1;
             * IF LOW is greater than HIGH break;
             * Otherwise; set MID to LOW + HIGH divided by two.
             * if X (input) is greater than the mid change LOW to mid + 1;
             * However, if X (input) is less than the mid, change the HIGH to mid - 1;
             * 
             * By reducing the field size, we're able to find the near exact positioning.
             * 
             * m = mid;
             * L = LOW;
             * R = HIGH;
             * 
             * For sanity checks, evalute that loop must be broken if the LOWer end of the scale-
             * is not less than or equal to the HIGHer end.
             */
        }
        private void functionGet(int N, int X)
        {
            int LOW = 1;
            int HIGH = N -1;
            int mid = 0;

            //Start by clearing the list box.
            lstBoxTree.Items.Clear();

            //First output;
            lstBoxTree.Items.Add(LOW.ToString() + " " + (HIGH + 1).ToString());

            //Start by creating two lists; one for tight discovery in binary search;
            //The other for confirmation that number exists in a given array.

            List<int> nums = new List<int>();
            List<int> oNums = new List<int>();
            for (int i = LOW; i <= HIGH; i++)
            {
                nums.Add(i);
            }//End for

            for (int i = LOW; i <= HIGH + 1; i++)
            {
                oNums.Add(i);
            }//End for

            //Conditionally; if the input value of X (from user input) is higher than the ceiling (N - 1)
            //This evalutes to true; which simply means that the user is trying to search out of range.
            if (X > HIGH)
            {
                MessageBox.Show("Error, Ceiling too low");
            }  else
            {
                
                //I struggled with precision here, until I realised that less-than-equal-to was necessary.
                //It should be noted here that without the equals to the loop will end abruptly with-
                //A list of 11 integers if given an X value of 37 (this is because 37 would be the mid-point
                while (LOW <= HIGH) 
                {
                    //Exchange a variable MID to be the ceiling and the floor together; then divide by two to begin branching
                    mid = (HIGH + LOW) / 2;
                    if (mid < X)
                    {
                        LOW = mid + 1;
                    }
                    else
                    {
                        HIGH = mid - 1;
                    }
                    
                    //Clear the smaller array; we'll be able to compare array sizes much later if necessary.
                    nums.Clear();
                    //Re-establish array nums by adding integers to array (This is another sanity check for further comparison)
                    for (int i = LOW; i < HIGH; i++)
                    {
                        nums.Add(i);
                    }

                    //Output floor and ceiling to list-box for quick breakdown.
                    if (LOW == HIGH +1)
                    {
                        //Unless we're on the final string output
                        lstBoxTree.Items.Add(LOW.ToString());
                    } else
                    {
                        lstBoxTree.Items.Add(LOW.ToString() + " " + (HIGH + 1).ToString());
                    }
                    
                   
                }
                    //Output where the number can be expected to be found in the array oNums.
                    lstBoxTree.Items.Add("Found " + mid.ToString() + " At Pos, " + oNums[mid].ToString());
            }
        }
    }
}
