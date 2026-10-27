using static XMUI.XMUI;

class Program : XMUI.AppForm
{
    public static void Main()
    {
        var p = new Program();

        p.StartRendering(0).GetAwaiter().GetResult();
    }

    public override void Setup(int globalListId)
    {
        base.Setup(globalListId);
    }
}
