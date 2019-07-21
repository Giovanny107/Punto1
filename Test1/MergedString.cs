namespace Test1
{
    public class MergedString
    {
        public string MergedText(string text1, string text2)
        {
            string mixed = string.Empty;

            for(var i = 0; i < text1.Length; i++)
            {
                mixed += text1[i].ToString();
                if(i < text2.Length)
                {
                    mixed += text2[i].ToString();
                    if(i == text1.Length - 1)
                    {
                        i++;
                        while(i < text2.Length)
                        {
                            mixed += text2[i].ToString();
                            i++;
                        }
                    }
                }
            }

            return mixed;
        }
    }
}
