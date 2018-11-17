using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MailSender.Service;

namespace MailSender.ViewModel
{
	public class MainWindowViewModel : ViewModelBase
	{
		private readonly IDataAccessService _dataAccessService;
		private Emails _currentEmail = new Emails();

		private ObservableCollection<Emails> _emails = new ObservableCollection<Emails>();

		public MainWindowViewModel(IDataAccessService dataAccessService)
		{
			_dataAccessService = dataAccessService;
			ReadAllMailsCommand = new RelayCommand(GetEmails);
			SaveEmailCommand = new RelayCommand<Emails>(SaveEmails);
		}

		public ObservableCollection<Emails> Emails
		{
			get => _emails;
			set
			{
				if(!Set(ref _emails, value)) return;
				//if(Equals(_emails, value))return;
				//_emails = value;
				//RaisePropertyChanged(nameof(Emails));
			}
		}

		public RelayCommand ReadAllMailsCommand { get; }
		public RelayCommand<Emails> SaveEmailCommand { get; }

		public Emails CurrentEmail
		{
			get => _currentEmail;
			set => Set(ref _currentEmail, value);
		}

		private void GetEmails() => Emails = _dataAccessService.GetEmails();

		private void SaveEmails(Emails email)
		{
			email.Id = _dataAccessService.CreateEmail(email);
			if (email.Id == 0) return;
			Emails.Add(email);
		}
	}
}