using System;
using System.Collections.Generic;
using System.Text;

namespace RayPI.Model
{
    /// <summary>
    /// 通用类
    /// </summary>
    public class MessageModel<T>
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public List<T> Data { get; set; }

    }
}
