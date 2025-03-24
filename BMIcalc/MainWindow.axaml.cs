using Avalonia.Controls;
using System;
using System.Windows.Forms;

namespace BMIcalc
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
        }

        private void bmi_calc_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                decimal bmi_index = Math.Round(decimal.Parse(bmi_bodymass.Text) / (decimal.Parse(bmi_height.Text) * decimal.Parse(bmi_height.Text)), 2);
                bmi_result.Text = bmi_index.ToString();
                if (bmi_index < new decimal(18.5))
                {
                    bmi_interpret.Text = "体重过轻";
                }
                else if (bmi_index >= new decimal(18.5) && bmi_index <= 24)
                {
                    bmi_interpret.Text = "体重正常";
                }
                else if (bmi_index > 24 && bmi_index < 28)
                {
                    bmi_interpret.Text = "超重";
                }
                else
                {
                    bmi_interpret.Text = "肥胖";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}