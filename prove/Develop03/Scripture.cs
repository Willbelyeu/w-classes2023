public class Scriptures
{// make a list from scripture.
    public List<string> scriptures = new List<string>();
    public Scriptures(){
        scriptures.Add("5 If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. 6 But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
    }
    public List<string> getScripture(){
        return scriptures;
    }
}