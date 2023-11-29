using System;

class Program
{
    static void Main(string[] args)
    {
        //Need a list to hold Videos.
        //Copy everything from here to the next comment and alter them to make the other lists.
        string firstVideoTitle="Gary";
        string firstVideoAuthor="Gary";
        int firstVideoSeconds=62; 

        List<Video> videos=new List<Video>();
        List <Comment> firstVideoCommments=new List<Comment>();

        string firstVideoFirstCommentAuthor= "Arthur1";
        string firstVideoFirstComment= "that looked painful1.";
        Comment firstCommentFirstVideo=new Comment(firstVideoFirstCommentAuthor,firstVideoFirstComment);
        firstVideoCommments.Add(firstCommentFirstVideo);

        string firstVideoSecondCommentAuthor= "Luke2";
        string firstVideoSecondComment= "Is he alright?2";
        Comment firstCommentSecondVideo=new Comment(firstVideoSecondCommentAuthor,firstVideoSecondComment);
        firstVideoCommments.Add(firstCommentSecondVideo);

        string firstVideoThirdCommentAuthor= "Arthur3";
        string firstVideoThirdComment= "that looked painful.3";
        Comment firstVideoCommentThird=new Comment(firstVideoThirdCommentAuthor,firstVideoThirdComment);
        firstVideoCommments.Add(firstVideoCommentThird);

        string firstVideoFourthCommentAuthor= "Luke4";
        string firstVideoFourthComment= "Is he alright?4";
        Comment firstVideoCommentFourth=new Comment(firstVideoFourthCommentAuthor,firstVideoFourthComment);
        firstVideoCommments.Add(firstVideoCommentFourth);

        Video firstVideo=new Video(firstVideoTitle,firstVideoAuthor,firstVideoSeconds,firstVideoCommments);
        videos.Add(firstVideo);

        //firstVideoCommments.Add(firstVideoFirstCommentAuthor, firstVideoFirstComment);

        string secondVideoTitle="Gary1";
        string secondVideoAuthor="Gary1";
        int secondVideoSeconds=62; 

        List <Comment> secondVideoCommments=new List<Comment>();

        string secondVideoFirstCommentAuthor= "Arthur1";
        string secondVideoFirstComment= "that looked painful.";
        Comment secondCommentFirstVideo=new Comment(secondVideoFirstCommentAuthor,secondVideoFirstComment);
        secondVideoCommments.Add(secondCommentFirstVideo);

        string secondVideoSecondCommentAuthor= "Luke2";
        string secondVideoSecondComment= "Is he alright?";
        Comment secondCommentSecondVideo=new Comment(secondVideoSecondCommentAuthor,secondVideoSecondComment);
        secondVideoCommments.Add(secondCommentSecondVideo);

        string secondVideoThirdCommentAuthor= "Arthur3";
        string secondVideoThirdComment= "that looked painful.";
        Comment secondVideoCommentThird=new Comment(secondVideoThirdCommentAuthor,secondVideoThirdComment);
        secondVideoCommments.Add(secondVideoCommentThird);

        string secondVideoFourthCommentAuthor= "Luke4";
        string secondVideoFourthComment= "Is he alright?";
        Comment secondVideoCommentFourth=new Comment(secondVideoFourthCommentAuthor,secondVideoFourthComment);
        secondVideoCommments.Add(secondVideoCommentFourth);

        Video secondVideo=new Video(secondVideoTitle,secondVideoAuthor,secondVideoSeconds,secondVideoCommments);
        videos.Add(secondVideo);
// moving to the third video

        string thirdVideoTitle="Gary2";
        string thirdVideoAuthor="Gary2";
        int thirdVideoSeconds=62; 

        List <Comment> thirdVideoCommments=new List<Comment>();

        string thirdVideoFirstCommentAuthor= "Arthur1";
        string thirdVideoFirstComment= "that looked painful.";
        Comment thirdCommentFirstVideo=new Comment(thirdVideoFirstCommentAuthor,thirdVideoFirstComment);
        thirdVideoCommments.Add(thirdCommentFirstVideo);

        string thirdVideoSecondCommentAuthor= "Luke2";
        string thirdVideoSecondComment= "Is he alright?";
        Comment firstCommentthirdVideo=new Comment(thirdVideoSecondCommentAuthor,thirdVideoSecondComment);
        thirdVideoCommments.Add(firstCommentthirdVideo);

        string thirdVideoThirdCommentAuthor= "Arthur3";
        string thirdVideoThirdComment= "that looked painful.";
        Comment thirdVideoCommentThird=new Comment(thirdVideoThirdCommentAuthor,thirdVideoThirdComment);
        thirdVideoCommments.Add(thirdVideoCommentThird);

        string thirdVideoFourthCommentAuthor= "Luke4";
        string thirdVideoFourthComment= "Is he alright?";
        Comment thirdVideoCommentFourth=new Comment(thirdVideoFourthCommentAuthor,thirdVideoFourthComment);
        thirdVideoCommments.Add(thirdVideoCommentFourth);

        Video thirdVideo=new Video(thirdVideoTitle,thirdVideoAuthor,thirdVideoSeconds,thirdVideoCommments);
        videos.Add(thirdVideo);

        Console.WriteLine("Bird");
        foreach (var video in videos){
            int count=video.commentCount();
            Console.WriteLine($"{video._title} by {video._author}, {video._length} seconds long, {count} comments.");
            foreach (var comment in video._comments){
                Console.WriteLine(comment._author);
                Console.WriteLine(comment._comment);
            }
        }
    }
}