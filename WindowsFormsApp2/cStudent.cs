namespace WindowsFormsApp2
{
    public abstract class cStudent
    {
        public string Number { get; set; } 
        public string Kor { get; set; }
        public string Eng { get; set; }
        public string Math { get; set; }
        public string Sex { get; set; }
        public string Avg { get; set; }
    } 
    public class cBoy:cStudent
    {
        
        public cBoy()
        {
           this.Sex = "남자";
        }  
    }

    public class cGirl : cStudent
    { 
        public cGirl()
        {
            this.Sex = "여자";
        } 
    }
}
