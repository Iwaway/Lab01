using System;
using Avalonia.Controls;

namespace Lab01.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void DatePicker_DateChanged(object sender, SelectionChangedEventArgs e)
    {
        if (!DateHandler.IsDateCorrect(datePicker.SelectedDate.Value.DateTime))
        {
            MessageBox.Show(this, "Error", "Date is incorrect!", MessageBox.MessageBoxButtons.YesNoCancel);
            return;
        }
        if (DateHandler.IsBirthday(datePicker.SelectedDate.Value.DateTime))
        {
            MessageBox.Show(this, "Hurray", "Happy birthday!", MessageBox.MessageBoxButtons.YesNoCancel);
        }
        textBlock1.Text = DateHandler.GetAge(datePicker.SelectedDate.Value.DateTime).ToString();
        textBlock2.Text = DateHandler.GetWesternZodiac(datePicker.SelectedDate.Value.DateTime);
        textBlock3.Text = DateHandler.GetChineseZodiac(datePicker.SelectedDate.Value.DateTime);
    }

    private void DatePicker_DateChanged(object? sender, DatePickerSelectedValueChangedEventArgs e)
    {
        if (!DateHandler.IsDateCorrect(datePicker.SelectedDate.Value.DateTime))
        {
            MessageBox.Show(this, "Error", "Date is incorrect!", MessageBox.MessageBoxButtons.YesNoCancel);
            return;
        }
        if (DateHandler.IsBirthday(datePicker.SelectedDate.Value.DateTime))
        {
            MessageBox.Show(this, "Hurray", "Happy birthday!", MessageBox.MessageBoxButtons.YesNoCancel);
        }
        textBlock1.Text = DateHandler.GetAge(datePicker.SelectedDate.Value.DateTime).ToString();
        textBlock2.Text = DateHandler.GetWesternZodiac(datePicker.SelectedDate.Value.DateTime);
        textBlock3.Text = DateHandler.GetChineseZodiac(datePicker.SelectedDate.Value.DateTime);
    }
}

