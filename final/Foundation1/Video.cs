using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;  
    public int _length; // Length in seconds

    public List<Comment> _comments= new List<Comment>();
  
    public void DisplayVideoDetails()  
    {
        Console.WriteLine($"{_title} ({_author}) {_length} seconds. ");
        Console.WriteLine($"Number of Comments : {GetNumberofComments()}"); 
        Console.WriteLine($"Comments: ");

        
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }  

        Console.WriteLine();
    }

    
    public int GetNumberofComments()
        {
            return _comments.Count;
        }
 
     

    

    

         
    
    

}