using System.Linq;
using System.Windows.Input;

namespace SampleWeightUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double gramValue, poundValue;

        //▲ボタンで呼ばれるコマンド
        public ICommand PoundUnitToGramUnit { get; private set; }
        //▼ボタンで呼ばれるコマンド
        public ICommand GramUnitToPoundUnit { get; private set; }

        //上のConboBoxで選択されている値
        public Gramunit CurrentGramuUnit { get; set; }
        //下のConboBoxで選択されている値
        public PoundUnit CurrentPoundUnit { get; set; }

        public double GramValue {
            get { return gramValue; }
            set {
                gramValue = value;
                OnPropertyChanged(); //値が変更されたら通知
            }

        }

        public double PoundValue {
            get { return poundValue; }
            set {
                poundValue = value;
                OnPropertyChanged(); //値が変更されたら通知
            }

        }

        //コンストラクター
        public MainWindowViewModel() {
            CurrentGramuUnit = Gramunit.Units.First();

            CurrentPoundUnit = PoundUnit.Units.First();

            GramUnitToPoundUnit = new DelegateCommand(() =>
                            PoundValue = CurrentPoundUnit.FromGramUnit(CurrentGramuUnit, GramValue));

            PoundUnitToGramUnit = new DelegateCommand(() =>
                            GramValue = CurrentGramuUnit.FromoPoundUnit(CurrentPoundUnit, PoundValue));
        }
    }
}
