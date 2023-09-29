using System.Text.RegularExpressions;


namespace ShapeCalculator.Pages;

using ShapeCalculator.NewFolder;
public partial class RectanglePage : ContentPage
{
    public Rectangle RecS { get; set; }
    public RectanglePage()
	{
		InitializeComponent();
		cboAreaRectangle.ItemsSource = metric();
		cboVolumeRec.ItemsSource = metric();
        txtAreaResult.Text = "0";
        txtPerimeterResult.Text = "0";
        txtVolumeResult.Text = "0";
        txtWidthRec.Text = "0";
        txtWidthRecArea.Text = "0";
        txtLengthRec.Text = "0";
        txtLengthRecArea.Text = "0";
        txtHeightRec.Text = "0";
        RecS = new Rectangle();
        cboAreaRectangle.SelectedIndex = 0;
        cboVolumeRec.SelectedIndex = 0;
    }
    List<string> metric() => new List<string>() { "+-Select-+", "Inches", "Meters", "Centimeters", "Kilometers" };
    string metricType(int index) => index == 1 ? " in^2" : index == 2 ? " m^2" : index == 3 ? " cm^2" : "km^2";

    bool isDigitString( string a )
	{
		if (Regex.IsMatch(a,"^-?\\d*(\\.\\d+)?$"))
			return true;
		return false;
	}

    private void btnCalculateAreaRec_Clicked(object sender, EventArgs e)
    {
        if ( !isDigitString( txtLengthRecArea.Text ) || !isDigitString( txtWidthRecArea.Text ) || string.IsNullOrEmpty( txtLengthRecArea.Text ) || string.IsNullOrEmpty( txtWidthRec.Text  )) {
            _ = DisplayAlert("Error!!!", "Values must not be empty or contain non-numbers", "Close");
        }
        else if ( cboAreaRectangle.SelectedIndex == 0 )
        {
            _ = DisplayAlert("No metric inidicated!!!", "Please select a metric", "Close");
            return;
        }
        else
        {
            RecS.Length = Convert.ToDouble( txtLengthRecArea.Text );
            RecS.Width = Convert.ToDouble(txtWidthRecArea.Text);
            txtAreaResult.Text = Convert.ToString( RecS.Area()  ) + metricType( cboAreaRectangle.SelectedIndex );
            txtPerimeterResult.Text = Convert.ToString(RecS.Perimeter()) + metricType( cboAreaRectangle.SelectedIndex);
            return;
        }
        btnClearAreaRec_Clicked(sender, e);
    }

    private void btnClearAreaRec_Clicked(object sender, EventArgs e)
    {
        txtAreaResult.Text = "0";
        txtPerimeterResult.Text = "0";
        txtLengthRecArea.Text = "0";
        txtWidthRecArea.Text ="0";
        cboAreaRectangle.SelectedIndex = 0;
    }

    private void btnClearVol_Clicked(object sender, EventArgs e)
    {
        txtLengthRec.Text = "0";
        txtWidthRec.Text = "0";
        txtHeightRec.Text = "0";
        cboVolumeRec.SelectedIndex = 0;
    }

    private void btnCalculateVol_Clicked(object sender, EventArgs e)
    {
        if ( !isDigitString( txtLengthRec.Text) || !isDigitString( txtWidthRec.Text ) || !isDigitString( txtHeightRec.Text) || string.IsNullOrEmpty( txtLengthRec.Text ) || string.IsNullOrEmpty( txtWidthRec.Text ) || string.IsNullOrEmpty( txtHeightRec.Text ) )
        {
            _ = DisplayAlert("Error!!!", "Values must not be empty or contain non-numbers", "Close");
        }
        else if ( cboVolumeRec.SelectedIndex == 0 )
        {
            _ = DisplayAlert("No metric inidicated!!!", "Please select a metric", "Close");
        }
        else
        {
            RecS.Length = Convert.ToDouble(txtLengthRec.Text);
            RecS.Width = Convert.ToDouble(txtWidthRec.Text);
            RecS.Height = Convert.ToDouble(txtHeightRec.Text);
            txtVolumeResult.Text = Convert.ToString(RecS.Volume()) + metricType(cboVolumeRec.SelectedIndex);
        }
    }
}