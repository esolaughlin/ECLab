namespace ECLab
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;
        public Author(string tempName, char tempGender, string tempEmail){
            name = tempName;
            gender = tempGender;
            email = tempEmail;
        }
        public string GetName(){
            return name;
        }
        public void SetName(string name){
            this.name = name;
        }
        public char GetGender(){
            return gender;
        }
        public void SetGender(char gender){
            this.gender = gender;
        }
        public string GetEmail(){
            return email;
        }
        public void SetEmail(string email){
            this.email = email;
        }
        public override string ToString(){
            return $"Name: {name} Email: {email} Gender: {gender}";
        }
    }
}