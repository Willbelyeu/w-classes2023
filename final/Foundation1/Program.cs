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
        string firstVideoFirstComment= "    that looked painful.";
        Comment firstCommentFirstVideo=new Comment(firstVideoFirstCommentAuthor,firstVideoFirstComment);
        firstVideoCommments.Add(firstCommentFirstVideo);

        string firstVideoSecondCommentAuthor= "Luke2";
        string firstVideoSecondComment= "   Is he alright?";
        Comment firstCommentSecondVideo=new Comment(firstVideoSecondCommentAuthor,firstVideoSecondComment);
        firstVideoCommments.Add(firstCommentSecondVideo);

        string firstVideoThirdCommentAuthor= "Arthur3";
        string firstVideoThirdComment= "    Is he bleeding?";
        Comment firstVideoCommentThird=new Comment(firstVideoThirdCommentAuthor,firstVideoThirdComment);
        firstVideoCommments.Add(firstVideoCommentThird);

        string firstVideoFourthCommentAuthor= "Luke4";
        string firstVideoFourthComment= "   Why did he do this again?";
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
        string secondVideoFirstComment= "   that looked painful.";
        Comment secondCommentFirstVideo=new Comment(secondVideoFirstCommentAuthor,secondVideoFirstComment);
        secondVideoCommments.Add(secondCommentFirstVideo);

        string secondVideoSecondCommentAuthor= "Luke2";
        string secondVideoSecondComment= "  Is he alright?";
        Comment secondCommentSecondVideo=new Comment(secondVideoSecondCommentAuthor,secondVideoSecondComment);
        secondVideoCommments.Add(secondCommentSecondVideo);

        string secondVideoThirdCommentAuthor= "Arthur3";
        string secondVideoThirdComment= "   why do people keep doing this?";
        Comment secondVideoCommentThird=new Comment(secondVideoThirdCommentAuthor,secondVideoThirdComment);
        secondVideoCommments.Add(secondVideoCommentThird);

        string secondVideoFourthCommentAuthor= "Luke4";
        string secondVideoFourthComment= "  He should see a doctor.";
        Comment secondVideoCommentFourth=new Comment(secondVideoFourthCommentAuthor,secondVideoFourthComment);
        secondVideoCommments.Add(secondVideoCommentFourth);

        Video secondVideo=new Video(secondVideoTitle,secondVideoAuthor,secondVideoSeconds,secondVideoCommments);
        videos.Add(secondVideo);
// moving to the third video

        string thirdVideoTitle="Dancing With the Stars";
        string thirdVideoAuthor="Gary2";
        int thirdVideoSeconds=32; 

        List <Comment> thirdVideoCommments=new List<Comment>();

        string thirdVideoFirstCommentAuthor= "Arthur1";
        string thirdVideoFirstComment= "    Stars can't dance.";
        Comment thirdCommentFirstVideo=new Comment(thirdVideoFirstCommentAuthor,thirdVideoFirstComment);
        thirdVideoCommments.Add(thirdCommentFirstVideo);

        string thirdVideoSecondCommentAuthor= "Luke2";
        string thirdVideoSecondComment= "   @Arthur1 he meant movie stars.";
        Comment firstCommentthirdVideo=new Comment(thirdVideoSecondCommentAuthor,thirdVideoSecondComment);
        thirdVideoCommments.Add(firstCommentthirdVideo);

        string thirdVideoThirdCommentAuthor= "Arthur1";
        string thirdVideoThirdComment= "    I stand by my words.";
        Comment thirdVideoCommentThird=new Comment(thirdVideoThirdCommentAuthor,thirdVideoThirdComment);
        thirdVideoCommments.Add(thirdVideoCommentThird);

        string thirdVideoFourthCommentAuthor= "Luke4";
        string thirdVideoFourthComment= "   Neither of you watched the video, did you?";
        Comment thirdVideoCommentFourth=new Comment(thirdVideoFourthCommentAuthor,thirdVideoFourthComment);
        thirdVideoCommments.Add(thirdVideoCommentFourth);

        Video thirdVideo=new Video(thirdVideoTitle,thirdVideoAuthor,thirdVideoSeconds,thirdVideoCommments);
        videos.Add(thirdVideo);

        foreach (var video in videos){
            int count=video.commentCount();
            Console.WriteLine("");
            Console.WriteLine($"    {video.GetTitle()} by {video.GetAuthor()}, {video.GetLength()} seconds long, {count} comments.");
            foreach (var comment in video.GetList()){

                Console.WriteLine(comment.GetAuthor());
                Console.WriteLine(comment.GetComment());
            }
        }
    }
}