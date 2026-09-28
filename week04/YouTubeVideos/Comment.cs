class Comment
{
   string _commenterName;
   string _text;


   public Comment(string commenterName, string text)
   {
    this._commenterName = commenterName;
    this._text = text;
   }


     public string GetCommenterName()
    {
        return _commenterName;
    }

     public string GetText()
    {
        return _text;
    }
}