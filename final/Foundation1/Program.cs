class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "HairSpray";
        video1._author = "Jessica Mueller";
        video1._length = 190;
    
        Comment opinion1vid1 = new Comment();
        opinion1vid1._commenter = "Alice Joe";
        opinion1vid1._comment = "best way to apply hairspray!";
        video1._comments.Add(opinion1vid1);

        Comment opinion2vid1 = new Comment();
        opinion2vid1._commenter = "Mike Jones";
        opinion2vid1._comment = "Loved the mohawk style!";
        video1._comments.Add(opinion2vid1);

        Comment opinion3vid1 = new Comment();
        opinion3vid1._commenter = "Amanda Bynes";
        opinion3vid1._comment = "It was fun watching your video!";
        video1._comments.Add(opinion3vid1);

        Video video2 = new Video();
        video2._title = "Modeling Clay";
        video2._author = "Sam Walter";
        video2._length = 200;

        Comment opinion1vid2 = new Comment();
        opinion1vid2._commenter = "Sam Adams";
        opinion1vid2._comment = "This is a high end clay, models great!";
        video2._comments.Add(opinion1vid2);

        Comment opinion2vid2 = new Comment();
        opinion2vid2._commenter = "Holly Jacobs";
        opinion2vid2._comment = "Great tutorial!";
        video2._comments.Add(opinion2vid2);

        Comment opinion3vid2 = new Comment();
        opinion3vid2._commenter = "Alyssa Roberts";
        opinion3vid2._comment = "I love how this clay bakes so well!";
        video2._comments.Add(opinion3vid2);

        Comment opinion4vid2 = new Comment();
        opinion4vid2._commenter = "John Smith";
        opinion4vid2._comment = "Interesting techniques!";
        video2._comments.Add(opinion4vid2);

        Video video3 = new Video();
        video3._title = "Lamp Assemble";
        video3._author = "Amanda Higgens";
        video3._length = 210;
        
        Comment opinion1vid3 = new Comment();
        opinion1vid3._commenter = "Bob Riggins";
        opinion1vid3._comment = "This lamp was great and easy to assemble!";
        video3._comments.Add(opinion1vid3);

        Comment opinion2vid3 = new Comment();
        opinion2vid3._commenter = "Vanessa Hudgens";
        opinion2vid3._comment = "It's so bright I can use it on its own in my room.";
        video3._comments.Add(opinion2vid3);

        Comment opinion3vid3 = new Comment();
        opinion3vid3._commenter = "Danny Keeps";
        opinion3vid3._comment = "It's too bright, no way you can use it as a night light.";
        video3._comments.Add(opinion3vid3);

        Comment opinion4vid3 = new Comment();
        opinion4vid3._commenter = "Lucas Thompson";
        opinion4vid3._comment = "Nice instructional video!";
        video3._comments.Add(opinion4vid3);

        Comment opinion5vid3 = new Comment();
        opinion5vid3._commenter = "Emma Watson";
        opinion5vid3._comment = "Helpful tips, thank you!";
        video3._comments.Add(opinion5vid3);

        List<Video> myvideos = new List<Video>();
        myvideos.Add(video1);
        myvideos.Add(video2);
        myvideos.Add(video3);

        foreach (Video video in myvideos)
        {
            video.DisplayVideoDetails();
        }
    }
}