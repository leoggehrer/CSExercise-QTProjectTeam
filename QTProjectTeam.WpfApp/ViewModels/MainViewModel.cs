//@CodeCopy
//MdStart
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QTProjectTeam.WpfApp.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        #region fields
        private ICommand? _cmdAddMember;
        private ICommand? _cmdEditMember;
        private ICommand? _cmdDeleteMember;

        private string _searchTextMember = string.Empty;
        private Logic.Models.App.Member? _selectedMember;
        private List<Logic.Models.App.Member> _members = new();
        #endregion fields

        #region properties
        public ICommand CommandAddMember
        {
            get
            {
                return RelayCommand.CreateCommand(ref _cmdAddMember, p =>
                {
                    AddMember();
                },
                p => true);
            }
        }
        public ICommand CommandEditMember
        {
            get
            {
                return RelayCommand.CreateCommand(ref _cmdEditMember, p =>
                {
                    EditMember(SelectedMember!.Id);
                },
                p => SelectedMember != null);
            }
        }
        public ICommand CommandDeleteMember
        {
            get
            {
                return RelayCommand.CreateCommand(ref _cmdDeleteMember, p =>
                {
                    var viewModel = new MemberViewModel();

                    viewModel.Window?.Close();
                    viewModel.Delete(SelectedMember!.Id);
                    OnPropertiesChanged();
                },
                p => SelectedMember != null);
            }
        }

        public string SearchTextMember
        {
            get => _searchTextMember ?? string.Empty;
            set
            {
                _searchTextMember = value;
                OnPropertyChanged(nameof(Members));
            }
        }
        public Logic.Models.App.Member? SelectedMember
        {
            get => _selectedMember;
            set
            {
                _selectedMember = value;
            }
        }
        public ObservableCollection<Logic.Models.App.Member> Members => new ObservableCollection<Logic.Models.App.Member>(_members);
        #endregion properties

        #region methods
        public MainViewModel()
        {
            OnPropertyChanged(nameof(Members));
        }
        private async Task LoadMembersAsync()
        {
            using var ctrl = new Logic.Controllers.App.MembersController();
            var entities = await ctrl.GetAllAsync().ConfigureAwait(false);
            var searchEntities = entities.Where(e => string.IsNullOrEmpty(_searchTextMember) || e.ToString()!.Contains(_searchTextMember, StringComparison.CurrentCultureIgnoreCase));
            var displayEntities = searchEntities.Select(e => Logic.Models.App.Member.Create(e));

            _members.Clear();
            _members.AddRange(displayEntities);
            base.OnPropertyChanged(nameof(Members));
        }
        protected override void OnPropertyChanged(string propertyName)
        {
            if (propertyName == nameof(Members))
            {
                Task.Run(() => LoadMembersAsync());
            }
            else
            {
                base.OnPropertyChanged(propertyName);
            }
        }
        protected virtual void OnPropertiesChanged()
        {
            OnPropertyChanged(nameof(Members));
        }
        private void AddMember()
        {
            var childWindow = new MemberWindow();

            childWindow.ShowDialog();
            OnPropertiesChanged();
        }
        private void EditMember(int id)
        {
            var childWindow = new MemberWindow();

            childWindow.ViewModel.Load(id);
            childWindow.ShowDialog();
            OnPropertiesChanged();
        }
        #endregion methods
    }
}
//MdEnd
