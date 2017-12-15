using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesRobots
{
    public class NonValidCoordoonneeException : Exception
    {
        public NonValidCoordoonneeException() : base() { }
        public NonValidCoordoonneeException(string message) : base(message) { }
        public NonValidCoordoonneeException(string message, Exception inner) : base(message, inner) { }

        public Robot Robot { get => this.Data["Robot"] as Robot; set => this.Data["Robot"] = value; }
    }
}
