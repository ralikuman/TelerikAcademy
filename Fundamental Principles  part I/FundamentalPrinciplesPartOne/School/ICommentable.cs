using System;
using System.Collections.Generic;

namespace School
{
    public interface ICommentable
    {
        string[] Comments { get; }
        void AddComment(string comment);
    }
}
