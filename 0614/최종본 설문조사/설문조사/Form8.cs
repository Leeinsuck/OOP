using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 설문조사
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        


        private void 돌아가기_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;

        }

        
        
            private void button1_Click(object sender, EventArgs e)
        {
            dataSet1.대면비대면테이블.Clear();
            dataSet1.대면비대면테이블.Rows.Add("대면",5);
            dataSet1.대면비대면테이블.Rows.Add("비대면",7);

            SeriesCollection series = new SeriesCollection();
            foreach (var obj in dataSet1.대면비대면테이블) series.Add(new PieSeries()
            {
                Title = obj.선택.ToString(),
                Values = new ChartValues<int>
                { obj.학생수 }                           
            });
            pieChart1.Series = series;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataSet1.대면비대면테이블.Clear();
            dataSet1.대면비대면테이블.Rows.Add("학교에서 해야한다고 하기 때문에", 3);
            dataSet1.대면비대면테이블.Rows.Add("대면이 공부하기 더 좋기 때문에", 2);
            dataSet1.대면비대면테이블.Rows.Add("기타사유", 1);

            SeriesCollection series = new SeriesCollection();
            foreach (var obj in dataSet1.대면비대면테이블) series.Add(new PieSeries()
            {
                Title = obj.선택.ToString(),
                Values = new ChartValues<int>
                { obj.학생수 }              
            });
            pieChart1.Series = series;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataSet1.대면비대면테이블.Clear();
            dataSet1.대면비대면테이블.Rows.Add("학교 가기 싫기 때문에", 2);
            dataSet1.대면비대면테이블.Rows.Add("비대면이 공부하기 더 좋기 때문에", 4);
            dataSet1.대면비대면테이블.Rows.Add("기타사유", 3);

            SeriesCollection series = new SeriesCollection();
            foreach (var obj in dataSet1.대면비대면테이블) series.Add(new PieSeries()
            {
                Title = obj.선택.ToString(),
                Values = new ChartValues<int>
                { obj.학생수 }              
            });
            pieChart1.Series = series;
        }
    }
}
