using ShapeCalculator.NewFolder;
using System.Text.RegularExpressions;

namespace ShapeCalculator.Pages;

public partial class SquarePage : ContentPage
{
    public Square SquareS {  get; set; }

	public SquarePage()
	{
		InitializeComponent();
		cboSquare.ItemsSource = metric();
        txtAreaSquare.Text = "0";
        txtPerimeterSquare.Text = "0";
        txtVolumeCube.Text = "0";
        txtSide.Text = "0";
        SquareS = new Square();
        cboSquare.SelectedIndex = 0;
    }
    List<string> metric() => new List<string>() { "+-Select-+", "Inches", "Meters", "Centimeters", "Kilometers" };

    bool isDigitString(string a)
    {
        if (Regex.IsMatch(a, "^-?\\d*(\\.\\d+)?$"))
            return true;
        return false;
    }
    string metricType() => cboSquare.SelectedIndex == 1 ? " in^2" : cboSquare.SelectedIndex == 2 ? " m^2" : cboSquare.SelectedIndex == 3 ? " cm^2" : "km^2";

    private void btnCalculateSquare_Clicked(object sender, EventArgs e)
    {
        if ( !isDigitString( txtSide.Text )  || string.IsNullOrEmpty( txtSide.Text ) ) 
        {
            _ = DisplayAlert("Error!!!", "Values must not be empty or contain non-numbers", "Close");
        }
        else if ( cboSquare.SelectedIndex == 0 ) {
            _ = DisplayAlert("No metric inidicated!!!", "Please select a metric", "Close");
        }
        else
        {
            SquareS.Side = Convert.ToDouble( txtSide.Text );
            txtAreaSquare.Text = Convert.ToString(SquareS.Area()) + metricType();
            txtPerimeterSquare.Text = Convert.ToString(SquareS.Perimeter()) + metricType();
            txtVolumeCube.Text = Convert.ToString(SquareS.Volume()) + metricType();
            return;
        }
        btnClearSquare_Clicked(sender, e);
            
    }

    private void btnClearSquare_Clicked(object sender, EventArgs e)
    {
        txtAreaSquare.Text = "0";
        txtPerimeterSquare.Text = "0";
        txtVolumeCube.Text = "0";
        txtSide.Text = "0";
        cboSquare.SelectedIndex = 0;
    }
}