using SchoolManeager.Screens;

namespace SchoolManeager.Base;

public static class Navigation<CONTROLLER> where CONTROLLER : BaseController
{
   static Stack<BaseScreen<CONTROLLER>> stack = new Stack<BaseScreen<CONTROLLER>>();

    public static void Add(BaseScreen<CONTROLLER> baseScreen)
    {
        stack.Push(baseScreen);
    }

    public static void Back()
    {
         stack.Pop();
         if (stack.FirstOrDefault() != null)
         {
             
         }
    }
}