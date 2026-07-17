namespace SchoolManeager.Base ;

public abstract class BaseScreen<CONTROLLER> where CONTROLLER : BaseController
{
    protected BaseScreen()
    {
            controller = (CONTROLLER)Activator.CreateInstance(typeof(CONTROLLER), new object[] { });
    }

    protected CONTROLLER controller;
    public abstract void InitUi(CONTROLLER controller);

    protected virtual void GetOpeator()
    {
        Console.WriteLine("");
    }
    public void Show(bool isRplace = false)
    {
        if (!isRplace)
        {
            Navigation<CONTROLLER>.Add(this);
        }
        RenderUI();
    }

    public void RenderUI()
    {
        Console.Clear();
        
        if (this is ITopBar)
        {
            Console.WriteLine($"\t\t\t\t {(this as ITopBar).GetTitleTopBar()}");
            Console.WriteLine("------------------------------------------------");
        }
        InitUi(controller);
    }

    public string GetInput(string measege)
    {
        Console.WriteLine("\t" + measege + "\t");
        return Console.ReadLine();
    }
}