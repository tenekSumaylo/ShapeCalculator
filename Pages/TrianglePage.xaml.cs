using ShapeCalculator.NewFolder;
using System.Text.RegularExpressions;
namespace ShapeCalculator.Pages;
public partial class TrianglePage : ContentPage
{
    public Triangle TriS { get; set; }
	public TrianglePage()
	{
		InitializeComponent();
		cboAreaTriangle.ItemsSource = metric();
		cboPerimeterTriangle.ItemsSource = metric();
		cboVolumeTriangle.ItemsSource = metric();
        cboAreaTriangle.SelectedIndex = 0;
        cboPerimeterTriangle.SelectedIndex = 0;
        cboVolumeTriangle.SelectedIndex = 0;
        txtAreaTriangle.Text = "0";
        txtBaseTriangle.Text = "0";
        txtVolumeTriangle.Text = "0";
        txtFirstEdge.Text = "0";
        txtSecondEdge.Text = "0";
        txtThirdSide.Text = "0";
        txtRadiusTriangle.Text = "0";
        txtHeightTriangle.Text = "0";
        txtFirstSide.Text = "0";
        txtSecondSide.Text = "0";   
        txtSecondEdge.Text = "0";
        txtPerimeterTriangle.Text = "0";
        txtVolumeTriangle.Text = "0";


        TriS = new Triangle();
	}

    List<string> metric() => new List<string>() { "+-Select-+", "Inches", "Meters", "Centimeters", "Kilometers" };
    string metricType( int index ) => index == 1 ? " in^2" : index == 2 ? " m^2" : index == 3 ? " cm^2" : "km^2";


    bool isDigitString(string a)
    {
        if (Regex.IsMatch(a, "^-?\\d*(\\.\\d+)?$"))
            return true;
        return false;
    }

    private void btnCalculatePerimeter_Clicked(object sender, EventArgs e)
    {
        if (!isDigitString(txtFirstSide.Text) || !isDigitString(txtSecondSide.Text) || !isDigitString(txtThirdSide.Text) || string.IsNullOrEmpty(txtFirstSide.Text) || string.IsNullOrEmpty(txtSecondSide.Text) || string.IsNullOrEmpty(txtThirdSide.Text))
        {
            _ = DisplayAlert("Error!!!", "Values must not be empty or contain non-numbers", "Close");
        }
        else if (cboPerimeterTriangle.SelectedIndex == 0)
        {
            _ = DisplayAlert("No metric inidicated!!!", "Please select a metric", "Close");
            return;
        }
        else
        {
            TriS.Length = Convert.ToDouble(txtFirstSide.Text);
            TriS.Width = Convert.ToDouble(txtSecondSide.Text); 
            TriS.Height = Convert.ToDouble(txtThirdSide.Text);
            txtPerimeterTriangle.Text = Convert.ToString( TriS.Perimeter()) + metricType(cboPerimeterTriangle.SelectedIndex) ;
            return;
        }
        btnClearPerimeter_Clicked(sender, e); 
    }

    private void btnClearPerimeter_Clicked(object sender, EventArgs e)
    {
        txtFirstSide.Text = "0";
        txtSecondSide.Text = "0";
        txtThirdSide.Text = "0";
        txtPerimeterTriangle.Text = "0";
        cboPerimeterTriangle.SelectedIndex = 0;
    }

    private void btnVolumePerimeter_Clicked(object sender, EventArgs e)
    {
        if ( !isDigitString( txtBaseTriangle.Text ) || !isDigitString( txtRadiusTriangle.Text) || !isDigitString( txtHeightTriangle.Text ) || string.IsNullOrEmpty( txtHeightTriangle.Text ) || string.IsNullOrEmpty( txtRadiusTriangle.Text ) || string.IsNullOrEmpty( txtBaseTriangle.Text ) )
        {
            _ = DisplayAlert("Error!!!", "Values must not be empty or contain non-numbers", "Close");
        }
        else if ( cboVolumeTriangle.SelectedIndex == 0 )
        {
            _ = DisplayAlert("No metric inidicated!!!", "Please select a metric", "Close");
            return;
        }
        else
        {
            TriS.Radius = Convert.ToDouble(txtRadiusTriangle.Text);
            TriS.Height = Convert.ToDouble(txtHeightTriangle.Text);
            TriS.Width = Convert.ToDouble(txtBaseTriangle.Text);
            txtVolumeTriangle.Text = TriS.Volume() + metricType( cboVolumeTriangle.SelectedIndex );
            return;
        }
        btnVolumePerimeter_Clicked(sender, e);
    }

    private void btnClearVolume_Clicked(object sender, EventArgs e)
    {
        txtBaseTriangle.Text = "0";
        txtHeightTriangle.Text = "0";
        txtRadiusTriangle.Text = "0";
        txtVolumeTriangle.Text = "0";
        cboVolumeTriangle.SelectedIndex = 0;
    }

    private void btnClearAreaTriangle_Clicked(object sender, EventArgs e)
    {
        txtFirstEdge.Text = "0";
        txtSecondEdge.Text = "0";
        txtAreaTriangle.Text = "0";
        cboAreaTriangle.SelectedIndex = 0;
    }

    private void btnCalculateAreaTriangle_Clicked(object sender, EventArgs e)
    {
        if ( !isDigitString( txtFirstEdge.Text) || !isDigitString( txtSecondEdge.Text) || string.IsNullOrEmpty( txtFirstEdge.Text) || string.IsNullOrEmpty( txtSecondEdge.Text ) )
        {
            _ = DisplayAlert("Error!!!", "Values must not be empty or contain non-numbers", "Close");
        }        
        else if ( cboAreaTriangle.SelectedIndex == 0 )
        {
            _ = DisplayAlert("No metric inidicated!!!", "Please select a metric", "Close");
            return;
        }
        else
        {
            TriS.Edge1 = Convert.ToDouble( txtFirstEdge.Text );
            TriS.Edge2 = Convert.ToDouble( txtSecondEdge.Text );
            txtAreaTriangle.Text = Convert.ToString(TriS.Area()) + metricType(cboAreaTriangle.SelectedIndex);
            return;
        }
        btnClearAreaTriangle_Clicked(sender, e);
    }
}