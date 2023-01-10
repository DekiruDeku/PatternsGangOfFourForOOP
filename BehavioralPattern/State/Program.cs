namespace State
{
    internal class Program
    {
        // Обьект меняет свое поведение в зависимоти от своего состояния
        
        // контекст, и сами конкретные
        // состояния могут знать друг о друге и инициировать
        // переходы от одного состояния к другому.
        
        // пример построен на работе светофора
        public static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight(new YellowState());
            trafficLight.NextState();
            trafficLight.NextState();
            
            trafficLight.PreviuosState();
            trafficLight.PreviuosState();
            trafficLight.PreviuosState();

        }
    }
}