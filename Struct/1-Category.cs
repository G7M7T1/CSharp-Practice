public struct Category
{
    // private field
    private int _categoryID;
    private string _categoryName;
    
    // public field
    public int CategoryID
    {
        set
        {
            _categoryID = value;
        }

        get
        {
            return _categoryID;
        }
    }

    public string CategoryName
    {
        get
        {
            return _categoryName;
        }

        set
        {
            _categoryName = value;
        }
    }

    public int GetCategoryNameLength()
    {
        return _categoryName.Length;
    }
}