using Business.Services.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace App.MVVM.View
{
    /// <summary>
    /// Interaction logic for AddMedicalCaseVies.xaml
    /// </summary>
    public partial class AddMedicalCaseView : UserControl
    {
        private readonly IMedicalCaseService _medicalCaseService;
        public AddMedicalCaseView(IMedicalCaseService medicalCaseService)
        {
            InitializeComponent();
            _medicalCaseService = medicalCaseService;
        }
        private async void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    int patientId = int.Parse(PatientIdTextBox.Text);
            //    int diagnoseId = int.Parse(DiagnoseIdTextBox.Text);

            //    // Call the service to save the entity
            //    await _medicalCaseService.AddAsync(patientId, diagnoseId);

            //    MessageBox.Show("Entity successfully added!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

        }
    }
}

