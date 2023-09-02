public enum SortingState {
    [Color("red")]
    Waiting,
    [Color("blue")]
    BeingSorted,
    [Color("yellow")]
    Pivot,
    [Color("yellow")]
    HigherValue,
    [Color("lightgreen")]
    InTemporaryGoodPlace,
    [Color("green")]
    InGoodPlace,
}