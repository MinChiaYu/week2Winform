using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2Winform
{
    public partial class Form1 : Form
    {
        double FirstNumber, SecondNumber;
        string Operate;
        double Result;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "正常收費", "打八折", "滿300送100" });
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 簡單工廠模式
            // CashSuper csuper = CashFactory.CreateCashAccept(textBox3.Text);//正常收費
            //Result = csuper.acceptCash(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));//價錢/數量
            //listBox1.Items.Add("單價:" + textBox1.Text + ",數量:" + textBox2.Text + " 折扣狀態:" + textBox3.Text + " 合計:" + Result.ToString());
            //SumPrice.Text = Result.ToString();
            #endregion
            if (textBox1.Text == "" || textBox2.Text == "" || Result != 0)
            {
                MessageBox.Show("輸入框錯誤");
            }
            else
            {
                #region 策略模式與簡單工廠模式結合
                //CashContext csuper = new CashContext(textBox3.Text);//正常收費
                CashContext csuper = new CashContext(comboBox1.SelectedItem.ToString());//正常收費
                Result = csuper.GetResult(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));//價錢/數量
                listBox1.Items.Add("單價:" + textBox1.Text + ",數量:" + textBox2.Text + " 折扣狀態:" + comboBox1.SelectedItem.ToString() + " 合計:" + Result.ToString());
                SumPrice.Text = Result.ToString();
                #endregion
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            //textBox3.Text = null;
            listBox1.Items.Clear();//.Add(null);
            SumPrice.Text = null;
        }

        #region 簡單工廠模式
        //class CashFactory//簡單工廠模式
        //{
        //    public static CashSuper CreateCashAccept(string type)
        //    {
        //        CashSuper cs = null;
        //        switch (type)
        //        {
        //            case "正常收費":
        //                cs = new CashNormal();
        //                break;
        //            case "打八折":
        //                CashRebate cashRebate = new CashRebate("0.8");
        //                cs = cashRebate;
        //                break;
        //            case "滿300送100":
        //                CashReturn cashReturn = new CashReturn("300", "100");
        //                cs = cashReturn;
        //                break;
        //        }
        //        return cs;
        //    }
        //}
        //abstract class CashSuper//現金收費抽象類別--欄位名稱為money:收到的原價
        //{
        //    public abstract double acceptCash(double money);
        //}
        //class CashNormal : CashSuper//正常收費子類別 繼承現金收費抽象類別
        //{
        //    public override double acceptCash(double money)//override:覆蓋修飾詞(搭配 基底類別方法 加入virtual ; 衍生類別方法加入override )。
        //    {
        //        return money;
        //    }
        //}
        //class CashRebate : CashSuper//打折收費子類別 繼承現金收費抽象類別
        //{
        //    private double moneyRebate = 1d;
        //    public CashRebate(string moneyRebate)
        //    {
        //        this.moneyRebate = double.Parse(moneyRebate);//打折收費初始時 需要輸入折扣率 
        //    }
        //    public override double acceptCash(double money)
        //    {
        //        return money * moneyRebate;
        //    }
        //}
        //class CashReturn : CashSuper//紅利收費子類別 繼承現金收費抽象類別//滿500送100
        //{
        //    private double moneyCondition = 0.0d;
        //    private double moneyReturn = 0.0d;
        //    public CashReturn(string moneyCondition, string moneyReturn)
        //    {
        //        this.moneyCondition = double.Parse(moneyCondition);//紅利收費初始化時 需要先輸入紅利條件
        //        this.moneyReturn = double.Parse(moneyReturn);//紅利收費初始化時 需要先輸入紅利值
        //    }
        //    public override double acceptCash(double money)
        //    {
        //        double result = money;
        //        if (money >= moneyCondition)
        //            result = money - (Math.Floor(money / moneyCondition)) * moneyReturn;
        //        return result;
        //    }
        //}
        #endregion


        #region  策略模式與簡單工廠模式結合
        abstract class CashSuper//現金收費抽象類別--欄位名稱為money:收到的原價
        {
            public abstract double acceptCash(double money);
        }
        class CashContext
        {
            CashSuper cash = null;
            public CashContext(string tpye)
            {
                switch (tpye)
                {
                    case "正常收費":
                        CashNormal csN = new CashNormal();
                        cash = csN;//csN指向到cash
                        break;
                    case "打八折":
                        CashRebate csR = new CashRebate("0.8");
                        cash = csR;//csR指向到cash
                        break;
                    case "滿300送100":
                        CashReturn cashReturn = new CashReturn("300", "100");
                        cash = cashReturn;
                        break;
                }
            }
            public double GetResult(double money)
            {
                return cash.acceptCash(money);
            }
        }
        class CashNormal : CashSuper//正常收費子類別 繼承現金收費抽象類別
        {
            public override double acceptCash(double money)//override:覆蓋修飾詞(搭配 基底類別方法 加入virtual ; 衍生類別方法加入override )。
            {
                return money;
            }
        }
        class CashRebate : CashSuper//打折收費子類別 繼承現金收費抽象類別
        {
            private double moneyRebate = 1d;
            public CashRebate(string moneyRebate)
            {
                this.moneyRebate = double.Parse(moneyRebate);//打折收費初始時 需要輸入折扣率 
            }
            public override double acceptCash(double money)
            {
                return money * moneyRebate;
            }
        }

        private void SumPrice_Click(object sender, EventArgs e)
        {

        }

        private void SumNumber_Click(object sender, EventArgs e)
        {

        }

        class CashReturn : CashSuper//紅利收費子類別 繼承現金收費抽象類別//滿500送100
        {
            private double moneyCondition = 0.0d;
            private double moneyReturn = 0.0d;
            public CashReturn(string moneyCondition, string moneyReturn)
            {
                this.moneyCondition = double.Parse(moneyCondition);//紅利收費初始化時 需要先輸入紅利條件
                this.moneyReturn = double.Parse(moneyReturn);//紅利收費初始化時 需要先輸入紅利值
            }
            public override double acceptCash(double money)
            {
                double result = money;
                if (money >= moneyCondition)
                    result = money - (Math.Floor(money / moneyCondition)) * moneyReturn;
                return result;
            }
        }
        #endregion


    }
}
