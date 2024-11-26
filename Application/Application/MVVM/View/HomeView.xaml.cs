using Business.Services;
using Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        private readonly IMedicalCaseService _medicalCaseService;
        public HomeView()
        {
            InitializeComponent();

        }
        public HomeView(IMedicalCaseService medicalCaseService)
            : this()
        {
            _medicalCaseService = medicalCaseService;

            // Load data on initialization
            Loaded += MedicalCasesWindow_Loaded;
            _medicalCaseService = medicalCaseService;
        }
        private async void MedicalCasesWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var cases = await _medicalCaseService.GetAllAsync();
                var displayData = new List<MedicalCaseDisplayModel>();

                foreach (var medicalCase in cases)
                {
                    displayData.Add(new MedicalCaseDisplayModel
                    {
                        PatientName = $"{medicalCase.Patient?.PatientName} {medicalCase.Patient?.PatientSurname}",
                        DiagnosisName = medicalCase.Diagnose?.DiagnoseDescription ?? "Unknown"
                    });
                }

                MedicalCasesList.ItemsSource = displayData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public class MedicalCaseDisplayModel
        {
            public string PatientName { get; set; }
            public string DiagnosisName { get; set; }
        }

    }
}
