namespace Library1
{
    public class ArrayWorker
    {
        

        public int[] Invert(int[] array)
        {
            int[] answer = new int[array.Length];
            for (int i = array.Length-1; i >= 0; i--)
            {
                answer[(answer.Length-1)-i] = array[i];
            }
            return answer;
        }
    }
}
