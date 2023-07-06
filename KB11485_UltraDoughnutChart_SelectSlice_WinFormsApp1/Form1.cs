using Infragistics.Win.DataVisualization;

namespace KB11485_UltraDoughnutChart_SelectSlice_WinFormsApp1;

public partial class Form1 : Form
{
    private List<SampleDataItem> _sampleDataItems;
    public Form1()
    {
        InitializeComponent();

        this._sampleDataItems = new List<SampleDataItem>()
        {
            new (){Category = "Category 1", Value = 300},
            new (){Category = "Category 2", Value = 300},
            new (){Category = "Category 3", Value = 200},
            new (){Category = "Category 4", Value = 200},
            new (){Category = "Category 5", Value = 100},
        };
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        var ringSeries = new RingSeries()
        {
            DataSource = this._sampleDataItems,
            LabelMemberPath = "Category",
            ValueMemberPath = "Value",
            StartAngle = 270,
        };

        this.ultraDoughnutChart1.Series.Add(ringSeries);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var ringSeries = this.ultraDoughnutChart1.Series[0] as RingSeries;
        if (ringSeries == null) return;

        ringSeries.SelectedSlices.Clear();
        ringSeries.SelectedSlices.Add(0);
    }
}
