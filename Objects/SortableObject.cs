public class SortableObject {
    public int Number {get; set; }
    public SortingState State {get; set; }

    public SortableObject(int number) {
        Number = number;
        State = SortingState.Waiting;
    }
}