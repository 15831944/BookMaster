using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RiziFrame.Utility.Db;
using zhiyueBook.Model;
using zhiyueBook.DAL;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;


namespace zhiyueBook.WinUI
{
    public partial class TjfxForm : Form
    {
        // 创建数据访问对象        
        private TjjyService srv = new TjjyService();

        string is_rq_start = System.DateTime.Now.Year.ToString() + "-01-01";
        string is_rq_end = DateTime.Now.ToString("yyyy-MM-dd"); 

        // 保存查询结果，作为缓存，后面修改和删除的时候都要使用。
        private List<Tjjyfx> queryList = null;

        public TjfxForm()
        {
            InitializeComponent();

            //设置日期           
            this.dtpStart.Text = is_rq_start;
            this.dtpEnd.Text = is_rq_end;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //OleDbHelper.SetConn(DbProvider.connectionString);
                 
            //this.queryList = srv.JyxxNyfx(this.dtpStart.Text, this.dtpEnd.Text);
            //this.dgvMain.DataSource = this.queryList;
            DrawTu();
            
        }

        private void DrawTu()
        {
            // 数据
            OleDbHelper.SetConn(new DbProvider().ConnectionString);

            this.queryList = srv.JyxxNyfx(this.dtpStart.Text, this.dtpEnd.Text);
            this.dgvMain.DataSource = this.queryList;

            chart1.DataSource = queryList;

            // 绘图设置            
            chart1.Series["Series1"].ChartType = SeriesChartType.Line;
            chart1.Series["Series2"].ChartType = SeriesChartType.Line;

            chart1.ChartAreas[0].AxisX.Title = "日期(年月)";
            chart1.ChartAreas[0].AxisY.Title = "借阅量";

            //chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Blue;
            //chart1.ChartAreas[0].AxisX.LineWidth = 2;

            //chart1.ChartAreas.Add("AlarmArea");
            //chart1.ChartAreas["AlarmArea"].CursorX.IsUserEnabled = true;
            //chart1.ChartAreas["AlarmArea"].CursorX.AutoScroll = true;
            //chart1.ChartAreas["AlarmArea"].AxisX.Title = "日期(年月)";
            //chart1.ChartAreas["AlarmArea"].AxisY.Title = "借阅量";
            //chart1.ChartAreas["AlarmArea"].AxisX.ScrollBar.Enabled = false;

            //chart1.ChartAreas["AlarmArea"].AxisX.Interval = 1;
            ////chart1.ChartAreas["AlarmArea"].AxisX.IntervalOffset = -1;
            //chart1.ChartAreas["AlarmArea"].AxisX.ScaleView.Zoomable = true;
            ////chart1.ChartAreas["AlarmArea"].AxisX.ScaleView.Position = 0;
            ////chart1.ChartAreas["AlarmArea"].AxisX.ScaleView.Size = 12;
            ////chart1.ChartAreas["AlarmArea"].AxisX.ScaleView.Scroll(ScrollType.Last);

            ////chartAlarmS.ChartAreas["AlarmArea"].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;   
            //chart1.ChartAreas["AlarmArea"].AxisX.IsMarginVisible = true;
            ////chart1.ChartAreas["AlarmArea"].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            //chart1.ChartAreas["AlarmArea"].AxisX.IsStartedFromZero = true;
            //chart1.ChartAreas["AlarmArea"].AxisY.MajorGrid.Enabled = false;
            //chart1.ChartAreas["AlarmArea"].AxisX.MajorGrid.Enabled = false;
                       
            chart1.Series["Series1"].LegendText = "借阅量";
            chart1.Series["Series1"].Color = Color.Blue;  //线条颜色
            chart1.Series["Series1"].BorderWidth = 2;     //线条粗细

            // 标记点设置-- Series1
            chart1.Series["Series1"].MarkerBorderColor = Color.Red;  //标记点边框颜色 
            chart1.Series["Series1"].MarkerBorderWidth = 3;  //标记点边框大小
            chart1.Series["Series1"].MarkerColor = Color.White; ;      //标记点中心颜色
            chart1.Series["Series1"].MarkerStyle = MarkerStyle.Circle; //标记点类型  
            chart1.Series["Series1"].MarkerSize = 8;  //标记点大小

            chart1.Series["Series1"].IsValueShownAsLabel = true;  // 在间隔点显示数据

            // 浮动显示
            chart1.Series["Series1"].ToolTip = "当前年份：#VAL\n最高分：#MAX\n最低分：#Min";
            //将文字移到外侧
            chart1.Series["Series1"]["PieLabelStyle"] = "Outside";
            //绘制黑色的连线
            chart1.Series["Series1"]["PieLineColor"] = "Black";
            //chart1.Series["Series1"].Points.DataBindXY(xData, yData);


            chart1.Series["Series2"].LegendText = "借阅人次";
            chart1.Series["Series2"].Color = Color.Brown;
            chart1.Series["Series2"].BorderWidth = 2;

            // 标记点设置-- Series2
            chart1.Series["Series2"].MarkerBorderColor = Color.BlueViolet;  //标记点边框颜色 
            chart1.Series["Series2"].MarkerBorderWidth = 3;  //标记点边框大小
            chart1.Series["Series2"].MarkerColor = Color.White; ;      //标记点中心颜色
            chart1.Series["Series2"].MarkerStyle = MarkerStyle.Circle; //标记点类型  
            chart1.Series["Series2"].MarkerSize = 8;  //标记点大小

            chart1.Series["Series2"].IsValueShownAsLabel = true;  // 在间隔点显示数据

            // 设置数据
            chart1.Series["Series1"].XValueMember = "Ny";
            chart1.Series["Series1"].YValueMembers = "Jysl";

            chart1.Series["Series2"].YValueMembers = "Jyrc";

            //设置坐标轴标题
            chart1.ChartAreas[0].AxisX.Interval = 1;  // 显示x轴上的所有标签
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            chart1.ChartAreas[0].AxisY.Interval = 100;  // 设置Y轴数值间隔




            //chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
            //chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;



            //设置坐标轴标题的字体
            //chart1.ChartAreas[0].AxisX.TitleFont = new Font("宋体", 12F);
            //chart1.ChartAreas[0].AxisY.TitleFont = new Font("宋体", 12F);
            //chart1.ChartAreas[0].AxisY2.TitleFont = new Font("宋体", 12F);

            //设置坐标轴栅格是否可见。。
            //chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;


            //for (int i = 0; i < this.dgvMain.Columns.Count - 2; i++)
            //{
            //    chart1.Series[i].XValueMember = this.dgvMain.Columns[1].HeaderText;
            //    chart1.Series[i].YValueMembers = this.dgvMain.Columns[i + 2].HeaderText;
            //    chart1.Series[i].XValueType = ChartValueType.DateTime;
            //    chart1.Series[i].ChartType = SeriesChartType.StackedColumn; //设置图表类型             
            //}

            //chart1.Series[0].XValueMember = "日期"; //绑定X轴的值
            //chart1.Series[0].YValueMembers = "设备1";

            //// 在chart中显示数据
            //int x = 0;
            //foreach (float v in values)
            //{
            //    series.Points.AddXY(x, v);
            //    x++;
            //}


            //var chart = chart1.ChartAreas[0];

            ////chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            ////chart.AxisX.LabelStyle.Format = "";
            ////chart.AxisY.LabelStyle.Format = "";
            ////chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            //// 设置显示范围
            //chart.AxisX.Minimum = 1;
            //chart.AxisX.Maximum = 12;
            //chart.AxisY.Minimum = 0;
            //chart.AxisY.Maximum = 50;
            //chart.AxisX.Interval = 1;
            //chart.AxisY.Interval = 5;

            ////chart1.Series.Add("line1");
        }

        private void btnHuitu_Click(object sender, EventArgs e)
        {
            
            

        }



    }
}
