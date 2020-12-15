namespace exercise_130
{


  public class Book
  {

    private string name;
    private int publicationYear;

    public Book(string name, int publicationYear)
    {
      this.name = name;
      this.publicationYear = publicationYear;
    }


    // BEGIN SOLUTION
    public override bool Equals(object compared)
    {
        Book comparedBook = (Book)compared;
        if (this.name == comparedBook.name && this.publicationYear == comparedBook.publicationYear)
        {
            return true;
        }
        return false;
    }
    // END SOLUTION
  }


}