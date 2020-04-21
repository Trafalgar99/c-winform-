using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当程序加载时 先加载年
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            int year=DateTime.Now.Year;
            for(int i=2019;i>=1949;i--)
            {
                cboYear.Items.Add(i + "年");

            }
        }
        /// <summary>
        /// 当年份的选项发生改变时候 加载月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //首先清空月份选择项中的内容
            cboMonth.Items.Clear();
            for(int i=1;i<=12;i++)
            {
                cboMonth.Items.Add(i + "月");
            }
        }
        /// <summary>
        /// 当月份选项发生改变时 加载天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //首先清空天选择项中的内容
            cboDay.Items.Clear();
            //2007年 2007 【0】
            //获得当前选中的年份
            string strYear=((string)cboYear  .SelectedItem).Split(new char[] {'年'}, StringSplitOptions.RemoveEmptyEntries)[0];

            //获得当前选中的月份
            string strMonth = ((string)cboMonth.SelectedItem).Split(new char[] {'月'},StringSplitOptions.RemoveEmptyEntries)[0];


            int year = Convert.ToInt32(strYear);
            int month = Convert.ToInt32(strMonth);

            int day = 0; //存贮天数
            if(month==2)
            {
                //满足条件是闰年
                if((year%400==0)||(year%4==0&&year%100!=0))
                {
                    day = 29;
                }
                else
                {
                    day = 28;
                }
            }
            else//不是2月
            {
                switch(month)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day = 30;
                        break;
                    default:
                        day = 31;
                        break; 

                         
                }
            }
            
            //将天数加载到下拉框
            for(int i=1;i<=day;i++)
            {
                cboDay.Items.Add(i + "日");
            }


        }
    }
}
