"# DSA" 
----1---04-2024-----

   public int LengthOfLastWord(string s) {
        int count =0;
        string str = s.TrimEnd(' ');

    for(int i =str.Length-1; i>0 ; i--)
    {
        if(str[i] == ' ')
    {
       break;
    }
    count++;
    }
    if(str.Length == 1)
    {
        return 1;
    }
    return count;

    }
