using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample
{
    /// <summary>
    /// đây có thể là một interface hoặc abstract class,
    /// chứa một abstract method execute(). 
    /// Request sẽ được đóng gói dưới dạng Command.
    /// Order sẽ đóng vai trò Command
    /// </summary>
    public interface IOrder
    {
        void Execute();
    }
}
