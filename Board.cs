using System.Text;

public class Board{
    private string [,] data;

    public string BuildBoard(){
        var boardBuilder = new StringBuilder();
        CollectRows(boardBuilder);
        return boardBuilder.ToString();
    }

    private void CollectRows(StringBuilder boardBuilder){
        for (int i = 0; i < 10; i++){
            CollectSingleRow(boardBuilder, i);
        }
    }

    private void CollectSingleRow(StringBuilder boardBuilder, int row){
        for (int j = 0; j < 10; j++){
            boardBuilder.Append(data[row, j]);
        }
        boardBuilder.Append("\n");
    }
}