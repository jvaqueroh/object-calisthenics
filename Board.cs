using System.Text;

public class Board{
    private string [,] data;

    public string BuildBoard(){
        var boardBuilder = new StringBuilder();
        for(int i=0; i<10; i++){
            for(int j=0; j<10; j++){
                boardBuilder.Append(data[i,j]);                
            }
            boardBuilder.Append("\n");
        }
        return boardBuilder.ToString();
    }
}