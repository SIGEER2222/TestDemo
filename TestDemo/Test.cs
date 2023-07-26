global using System;
global using System.Collections.Generic;
global using System.Threading.Tasks;
global using DevExpress.Mvvm.CodeGenerators;
using System.ComponentModel.DataAnnotations;
using System.Windows;

namespace ManuTalent.Mom.Opeartion.UserControl.ModelsGenerated;

[GenerateViewModel(ImplementINotifyPropertyChanging = true)]
public partial class Test
{
	[GenerateProperty]
	[StringLength(5, ErrorMessage = "111")]
	[Display(GroupName = "<Name|>", Name = "Last name")]
	string lastName;

	[GenerateProperty]
	[Display(GroupName = "<Name|>", Name = "First name", Order = 0)]
	string firstName;

	[GenerateProperty]
	[Display(GroupName = "{Tabs}/Contact", Order = 2), DataType(DataType.PhoneNumber)]
	string phone;

	[GenerateProperty]
	[Display(GroupName = "{Tabs}/Contact", Order = 4), DataType(DataType.EmailAddress)]
	string email;

	[GenerateProperty]
	[Display(GroupName = "{Tabs}/Contact/Address", ShortName = "")]
	string addressLine1;

	[GenerateProperty]
	[Display(GroupName = "{Tabs}/Contact/Address", ShortName = "")]
	string addressLine2;
	[GenerateProperty]
	[Display(GroupName = "Personal-", Name = "Birth date")]
	DateTime birthDate;

	[GenerateProperty]
	[Display(GroupName = "Personal-", Order = 3)]
	GenderEnum gender;

	[GenerateProperty]
	[Display(GroupName = "{Tabs}/Job", Order = 6)]
	string group;

	[GenerateProperty]
	[Display(GroupName = "{Tabs}/Job", Name = "Hire date")]
	DateTime hireDate;

	[GenerateProperty]
	[Display(GroupName = "{Tabs}/Job"), DataType(DataType.Currency)]
	decimal salary;

	[GenerateProperty]
	[Display(GroupName = "{Tabs}/Job", Order = 7)]
	string title;
	public enum GenderEnum { Male, Female }


	[GenerateCommand]
	async void OnHireDateChanged()
	{
		await Task.Delay(1000);
		Console.WriteLine(2222);
		throw new NotImplementedException();
    }


	[GenerateProperty]
	List<string> names;

	[GenerateCommand]
	[Display(AutoGenerateField = false)]
	public async Task Set()
	{
		var a = Group;
		MessageBox.Show("1");
	}

	[GenerateCommand]
	[Display(AutoGenerateField = false)]
	public async void Set2()
	{

		MessageBox.Show("1");
	}

	[GenerateCommand]
	[Display(AutoGenerateField = false)]
	public async Task<int> Set3(string a)
	{
		return 1;
	}
}

