using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 程序加载时将下拉框的第一项显示到下拉框列表中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //让下拉框列表中默认被选中的项的索引为0
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            


            //获得用户在文本框输入的内容
            string strNumOne=txtNumOne.Text.Trim();
            string strNumTwo = txtNumTwo.Text.Trim();
            //将他们转化成double类型
            double d1 = double.Parse(strNumOne);
            double d2 = Convert.ToDouble(strNumTwo);

            //创建计算类的实例
            Calculator cal = new Calculator();
            //将两个数字赋值给这个对象的两个属性
            cal.NumOne = d1;
            cal.NumTwo = d2;

            //获得用户在下拉框中选中的操作符
            string oper = comboBox1.SelectedItem.ToString();
            switch(oper)
            {
                case "+":txtResult.Text = cal.Add().ToString();
                    break;
                case "-":txtResult.Text = cal.Sub().ToString();
                    break;
                case "*":txtResult.Text = cal.Mul().ToString();
                    break;
                case "/":txtResult.Text = cal.Div().ToString();
                    break;
                default:MessageBox.Show("请选择正确的操作符");
                    break;
            }


            //MessageBox.Show(comboBox1.SelectedItem.ToString());

        }
    }
}
