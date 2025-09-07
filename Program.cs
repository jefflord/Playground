using WindowsInput;
using WindowsInput.Native;

namespace RestartDisplayDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sim = new InputSimulator();
            sim.Keyboard.ModifiedKeyStroke(new[] { VirtualKeyCode.LWIN, VirtualKeyCode.CONTROL, VirtualKeyCode.SHIFT }, VirtualKeyCode.VK_B);
        }
    }
}
