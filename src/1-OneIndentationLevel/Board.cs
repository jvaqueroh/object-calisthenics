using System.Text;

public class Board{
    private string [,] data = new string [5,5];

    public string BuildBoard(){
        var boardBuilder = new StringBuilder();
        CollectData(boardBuilder);
        return boardBuilder.ToString();
    }

    private void CollectData(StringBuilder boardBuilder){
        for (int i = 0; i < 10; i++){
            CollectRow(boardBuilder, i);
        }
    }

    private void CollectRow(StringBuilder boardBuilder, int row){
        for (int j = 0; j < 10; j++){
            boardBuilder.Append(data[row, j]);
        }
        boardBuilder.Append("\n");
    }
}