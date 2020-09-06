using System;

namespace W6_ClassNotes
{
    public class AbstractClassTest
    {
        public abstract class AbstractSquare
        {
            public AbstractSquare(bool top, bool left, bool bottom, bool right, bool hasMinotuar,
                bool hasTheseus, bool isExit)
            {
            }


            public abstract bool HasMinotaur { get; }
            public abstract bool HasTheseus { get; }
            public abstract bool IsExit { get; }
        }

        private class AbstractSquareImpl : AbstractSquare
        {
            public AbstractSquareImpl(bool top, bool left, bool bottom, bool right, bool hasMinotuar, bool hasTheseus,
                bool isExit, bool hasMinotaur) : base(top, left, bottom, right, hasMinotuar, hasTheseus, isExit)
            {
                HasTheseus = hasTheseus;
                IsExit = isExit;
                HasMinotaur = hasMinotaur;
            }

            public override bool HasMinotaur { get; }
            public override bool HasTheseus { get; }
            public override bool IsExit { get; }
        }
    }
}