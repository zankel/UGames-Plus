namespace UgamesPlus.Data.VO
{
    public class ComentarioVO 
    {
        public long Id { get; set; }

        public string Descritivo { get; set; }         
        
        public long Id_Usuario { get; set; }     
        
        public long Id_Post { get; set; }    
    }
}