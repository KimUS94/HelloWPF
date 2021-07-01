using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_calculator.Model
{
    public class MainModel
    {
        //데이터 처리
        private string dollar;
        private string won;

        /*
         * 
    View : 사용자의 눈에 보이는 인터페이스 (디자이너가 만듬)
    Model : 데이터 처리, 즉 데이터베이스와 통신
    ViewModel : View와는 Binding, Command로 연결하고, Model과는 데이터를 주고 받는 역할

         View Model 
View를 표현하기 위해 존재합니다. 즉 View를 위한 Model입니다.
그 외에는 View를 나타내기 위한 데이터 처리를 하는 역할
    
    1.View에 요청이 들어오면 Command를 통해 ViewModel로 보낸다.
    2.ViewModel은 Model에 데이터를 요청한다. 그리고 Model은 데이터를 응답한다.
    3.이를 받은 ViewModel은 필요한만큼 가공한다.
    4.View는 ViewModel과의 Data Binding을 통해 데이터를 자동으로 갱신한다.



        사용자의 입력값이 View를 통해 들어옵니다.
View에 입력값이 들어오면 ViewModel에 입력값을 전달합니다. 그 후 ViewModel은 Model에게 데이터 요청을 보냅니다.
Model은 ViewModel에게 요청받은 데이터를 Response하고 ViewModel은 그 값을 받은 후 가공처리하여 내부에 저장합니다.
View는 ViewModel과 Data Binding통해 화면상에 표출합니다



        
개발이야기/c#과 .Net, Core 이야기
C#으로 본 MVVM 패턴 정리 및 활용
by 평범한 개발자 센트빈 2019. 10. 3.

MVVM 패턴은 Model과 View Model, View로 이루어진 패턴입니다. 

 

Model은 개념을 나타내는 Entity 입니다. 데이터를 나타내는 기본 단위가 됩니다.

View는 유저가 보는 그래픽 컨트롤들의 집합입니다. WPF의 윈도우나 Web 페이지가 될 수 있습니다.

VIewModel은 View와 Model를 연결하는 요소입니다.  MVVM패턴에서 가장 중요한 역할을 하는 요소입니다.

ViewModel은 UI 로직, 커맨드, 이벤트, 모델에 대한 참조가 포함이 되어 있습니다. 

그리고 데이터바인딩을 통해 View에 표시된 데이터를 갱신하게 되는데, View가 가지고 있는 Observer가 뷰모델을 보고 있으면서 데이터가 변경되면 스스로 UI를 갱신하게 됩니다. UI를 갱신할 때, ViewModel은 INotifyPropertyChanged를 상속받으며, ProperryChanged 이벤트를 발생 시켜야합니다. 

 

SoC(Separation of Concerns) 즉, 관심사의 분리는 레이어로 구성된 어플리케이션을 만드는 컨셉을 가지고 있습니다. SoC는 레이어 별로 기능을 분리함으로써 위험을 줄이고 복잡한 설계를 좀 더 단순하게 만드는 방법을 제공합니다. 

이것을 소개하는 이유는 MVVM 패턴이 만들어진 이유이기 때문입니다. MVVM 패턴은 관심사를 분리 시켜 기능을 분산시키고, 집중되는 것을 막습니다. 이를 통해 위험도를 낮추고 설계를 편리하게 하는데 도움을 줍니다. 

 

MVVM을 사용하는 WPF에서 구현해야하는 인터페이스

1. INotifyPropertyChange : property 값이 변경될 때 통지시스템을 구현하며, 제대로 동작하는 바인딩엔진을 만들기 위해 ViewModel에서 구현이 필요하다.

2. ICommand : Xaml 컨트롤과 바인딩 되며, 액션과 이벤트를 실행할 수 있도록 해준다. 

3. Data Template : ViewModel이나 ViewModel의 상태를 어떻게 렌더링할지 정의한다. 특징으론 런타임에 렌더링되기 떄문에 동적으로 생성된다.
         */
    }
}
