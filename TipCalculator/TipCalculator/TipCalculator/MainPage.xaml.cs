using System;

using Xamarin.Forms;

namespace TipCalculator {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void btnCalculate_Clicked(object sender, EventArgs e) {

            var total = decimal.Parse(entCellTotal.Text);
            var tip = decimal.Parse(entCellPorcent.Text);
            var NumberOfPeople = decimal.Parse(entCellNumberOfPeople.Text);

            var TotalTip = ( total * tip)/100;

            TxtTip.Detail = TotalTip.ToString("C");
            TxtTotalBill.Detail = (TotalTip + total).ToString("C");
            TxtTotaTipPerPerson.Detail = (TotalTip / NumberOfPeople).ToString("C");
            TxtTotalPerson.Detail = ((total + TotalTip) / NumberOfPeople).ToString("C");
        }
    }
}
