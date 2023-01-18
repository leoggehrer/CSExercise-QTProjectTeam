using QTProjectTeam.Logic.Contracts;
using System.Collections.Generic;
using QTProjectTeam.Logic.Models.App;
using System.Windows.Input;

namespace QTProjectTeam.WpfApp.ViewModels
{
    public class MemberViewModel : EntityViewModel<Member>
    {
        #region fields
        private ICommand? _saveCommand = null;
        private ICommand? _closeCommand = null;

        private List<Member> _members = new List<Member>();
        #endregion fields

        #region properties
        public string Name
        {
            get { return Entity.Name; }
            set
            {
                Entity.Name = value;
                OnPropertiesChanged();
            }
        }
        public string Responsibilities
        {
            get { return Entity.Responsibilities; }
            set
            {
                Entity.Responsibilities = value;
                OnPropertiesChanged();
            }
        }
        public ICommand SaveCommand
        {
            get
            {
                return RelayCommand.CreateCommand(ref _saveCommand, (p) => Save());
            }
        }
        public ICommand CloseCommand
        {
            get
            {
                return RelayCommand.CreateCommand(ref _closeCommand, (p) => Close());
            }
        }

        #endregion properties

        #region Constructor
        public MemberViewModel()
        {
        }
        #endregion Constructor

        public override IDataAccess<Member> CreateController()
        {
            return new Logic.Controllers.App.MembersController();
        }
        protected override void OnPropertiesChanged()
        {
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Responsibilities));
            base.OnPropertiesChanged();
        }
        public void Close()
        {
            Window?.Close();
        }

    }
}
