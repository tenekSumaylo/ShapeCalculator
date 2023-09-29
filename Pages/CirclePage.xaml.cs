namespace ShapeCalculator.Pages;

using ShapeCalculator.NewFolder;
using System.Text.RegularExpressions;

public partial class CirclePage : ContentPage
{
    public Circle CircleS {  get; set; }
	public CirclePage()
	{
		InitializeComponent();
		cboCircle.ItemsSource = metric();
        txtAreaCircle.Text = "0";
        txtPerimeterCircle.Text = "0";
        txtVolumeSphere.Text = "0";
        txtRadiusCircle.Text = "0";
        cboCircle.SelectedIndex = 0;
        CircleS = new Circle();
    }
    List<string> metric() => new List<string>() { "+-Select-+","Inches", "Meters", "Centimeters", "Kilometers" };

    bool isDigitString(string a)
    {
        if (Regex.IsMatch(a, "^-?\\d*(\\.\\d+)?$"))
            return true;
        return false;
    }

    private void btnCalculateCircle_Clicked(object sender, EventArgs e)
    {
        if ( !isDigitString( txtRadiusCircle.Text )  || string.IsNullOrEmpty( txtRadiusCircle.Text)) {
            _ = DisplayAlert("Error!!!", "Values must not be empty or contain non-numbers", "Close");
        }
        else if ( cboCircle.SelectedIndex == 0 )
        {
            _ = DisplayAlert("No metric inidicated!!!", "Please select a metric", "Close");
            return;
        }
        else
        {
            CircleS.Radius = Convert.ToDouble(txtRadiusCircle.Text);
            txtAreaCircle.Text = $"{CircleS.Area()}" + metricType();
            txtPerimeterCircle.Text = Convert.ToString( CircleS.Perimeter()) + metricType();
            txtVolumeSphere.Text = Convert.ToString( CircleS.Volume()) + metricType();
            return;
        }
        btnClearCircle_Clicked(sender, e);
    }

    string metricType() => cboCircle.SelectedIndex == 1 ? " in^2" : cboCircle.SelectedIndex == 2 ? " m^2" : cboCircle.SelectedIndex == 3 ? " cm^2" : "km^2";




    private void btnClearCircle_Clicked(object sender, EventArgs e)
    {
        txtRadiusCircle.Text = "0";
        txtAreaCircle.Text = "0";
        txtPerimeterCircle.Text = "0";
        txtVolumeSphere.Text = "0";
        cboCircle.SelectedIndex = 0;
    }
}